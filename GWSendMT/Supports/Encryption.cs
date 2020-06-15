using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GWSendMT.Supports
{
    public class Encryption
    {
        //While an app specific salt is not the best practice for
        //password based encryption, it's probably safe enough as long as
        //it is truly uncommon. Also too much work to alter this answer otherwise.
        private static byte[] _salt = { 10, 100, 120, 210, 255 };

        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }

        public static string Md5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }

        public static string ShaHash(SHA1 shahash1, string input)
        {
            byte[] data = shahash1.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(data);
        }

        public static byte[] GenerateAESKey(ECPublicKeyParameters bobPublicKey,
                                AsymmetricKeyParameter alicePrivateKey)
        {
            IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
            aKeyAgree.Init(alicePrivateKey);
            BigInteger sharedSecret = aKeyAgree.CalculateAgreement(bobPublicKey);
            byte[] sharedSecretBytes = sharedSecret.ToByteArray();

            IDigest digest = new Sha256Digest();
            byte[] symmetricKey = new byte[digest.GetDigestSize()];
            digest.BlockUpdate(sharedSecretBytes, 0, sharedSecretBytes.Length);
            digest.DoFinal(symmetricKey, 0);

            return symmetricKey;
        }

        public static byte[] CreateSharedSecret(byte[] privateKey, byte[] publicKey)
        {
            // this returns shared secret, not private key
            // initialize algorithm with private key of one party
            //using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(CngKey.Import(privateKey, CngKeyBlobFormat.EccPrivateBlob)))
            using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(CngKey.Import(privateKey, CngKeyBlobFormat.Pkcs8PrivateBlob)))
            {
                cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                cng.HashAlgorithm = CngAlgorithm.Sha512;  // CngAlgorithm.Sha256; // CngAlgorithm.Sha512;
                // use public key of another party
                return cng.DeriveKeyMaterial(CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob));
            }
        }

        public static string EncryptText(byte[] key, string secretMessage,  byte[] iv) //out byte[] iv
        {
            string encryptedMessage;
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                //iv = aes.IV;
                aes.IV = iv;

                // Encrypt the message
                using (MemoryStream ciphertext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(secretMessage);
                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
                    cs.Close();
                    encryptedMessage = Encoding.UTF8.GetString(ciphertext.ToArray());
                }
            }

            return encryptedMessage;
        }

        public string DecryptText(byte[] bobKey, byte[] encryptedMessage, byte[] iv)
        {
            string decryptedMessage;
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = bobKey;
                aes.IV = iv;
                // Decrypt the message
                using (MemoryStream plaintext = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedMessage, 0, encryptedMessage.Length);
                        cs.Close();
                        decryptedMessage = Encoding.UTF8.GetString(plaintext.ToArray());
                        Console.WriteLine(decryptedMessage);
                    }
                }
            }

            return decryptedMessage;
        }


        public static (byte[] publicKey, byte[] privateKey) CreateKeyPair()
        {
            using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(
                // need to do this to be able to export private key
                CngKey.Create(
                    CngAlgorithm.ECDiffieHellmanP256,
                    null,
                    new CngKeyCreationParameters
                    { ExportPolicy = CngExportPolicies.AllowPlaintextExport })))
            {
                cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                cng.HashAlgorithm = CngAlgorithm.Sha512;
                // export both private and public keys and return
                var pr = cng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
                var pub = cng.PublicKey.ToByteArray();
                return (pub, pr);
            }
        }

        public static AsymmetricCipherKeyPair GenerateKeyPair(ECDomainParameters ecDomain)
        {
            ECKeyPairGenerator g = (ECKeyPairGenerator)GeneratorUtilities.GetKeyPairGenerator("ECDH");
            g.Init(new ECKeyGenerationParameters(ecDomain, new SecureRandom()));

            AsymmetricCipherKeyPair aliceKeyPair = g.GenerateKeyPair();
            return aliceKeyPair;
        }

        public static string ViettelEncryption(string inputText, string viettelPublicKey, string customerPrivateKey) {
            string encryptedSMSText = "";

            try
            {
                //string privateKeyConek = @"MIGEAgEAMBAGByqGSM49AgEGBSuBBAAKBG0wawIBAQQg1OGD/UuZ3FO9u6e60TmOJne47RWWYGqH7FIzRvxxhruhRANCAAQKJjarvVgOWJz6eg5ncv5WucbRBR2/qJqXpe5Yo9a9NQ7gzOgRBvejgj2q2NFNo9lgZgeFXl4fuoqOiLCGawaO";
                //string publicKeyViettel = @"MFYwEAYHKoZIzj0CAQYFK4EEAAoDQgAEe9YVVfiuEbTC8MLFcmettM9z6i1bh49kM97NZJ0yLCZcDQtWhuQ230W/nackSySWO8tErAzDWiMdvEACaHevaA==";

                //PublicKey Viettel
                var base64PubKeyStr = viettelPublicKey; // "MFYwEAYHKoZIzj0CAQYFK4EEAAoDQgAEe9YVVfiuEbTC8MLFcmettM9z6i1bh49kM97NZJ0yLCZcDQtWhuQ230W/nackSySWO8tErAzDWiMdvEACaHevaA==";
                var publicKeyBytes = Convert.FromBase64String(base64PubKeyStr);
                ECPublicKeyParameters otherPartyPublicKey = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
                Console.WriteLine(otherPartyPublicKey.ToString());

                //PrivateKey 
                var base64PrivateKeyStr = customerPrivateKey; // "MIGEAgEAMBAGByqGSM49AgEGBSuBBAAKBG0wawIBAQQgnFkCkg26s2pwWa1oV0cYFUUqU0sCDeYP2wRpUQcu74WhRANCAASDBA7GheF0EFqZY8xhQSXhYog6pEEtOBIo64eFBT2JZsPZysxk5i+PQXfVhkvib/tTLag6MuNiL451+u9qPbg5";
                var privateKeyBytes = Convert.FromBase64String(base64PrivateKeyStr);
                ECPrivateKeyParameters privateKey = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
                Console.WriteLine(privateKey.ToString());

                //Make share key
                IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
                aKeyAgree.Init(privateKey);
                BigInteger sharedSecret = aKeyAgree.CalculateAgreement(otherPartyPublicKey);
                byte[] sharedSecretBytes = sharedSecret.ToByteArrayUnsigned();
                var keyparam = ParameterUtilities.CreateKeyParameter("AES", sharedSecretBytes);

                var plainText = inputText; // "Hello! This is an banksms message!";
                byte[] plainTextByte = Encoding.UTF8.GetBytes(plainText);
                var bankSmsIv = "Banksms@Viettel!";
                byte[] iv = Encoding.UTF8.GetBytes(bankSmsIv);

                var parametersWithIV = new ParametersWithIV(keyparam, iv);
                Console.WriteLine(Encoding.ASCII.GetString(parametersWithIV.GetIV()));
                Console.WriteLine(parametersWithIV.ToString());

                var cipher = CipherUtilities.GetCipher("AES/CBC/PKCS5Padding");
                cipher.Init(true, parametersWithIV);
                byte[] output = cipher.DoFinal(plainTextByte);

                Console.WriteLine(string.Concat(output.Select(b => b.ToString("X2"))));
                encryptedSMSText = string.Concat(output.Select(b => b.ToString("X2")));  // Nội dung sau khi được mã hóa
            } catch (Exception ex)
            {
                Console.WriteLine("Exception ex = " + ex.Message);
            }
            

            return encryptedSMSText;
        }

        public static string TestDecrypt()
        {
            var privateKey = "pX/BvdXXUdpC79mW/jWi10Z6PJb5SBY2+aqkR/qYOjqgakKsqZFKnl0kz10Ve+BP";
            var token = "BDiRKNnPiPUb5oala31nkmCaXMB0iyWy3Q93p6fN7vPxEQSUlFVsInkJzPBBqmW1FUIY1KBA3BQb3W3Qv4akZ8kblqbmvupE/EJzPKbROZFBNvxpvVOHHgO2qadmHAjHSmnxUuxrpKxopWnOgyhzUx+mBUTao0pcEgqZFw0Y/qZIJPf1KusCMlz5TAhpjsw=";

            // #####
            // ##### Step 1
            // #####
            var decodedToken = Convert.FromBase64String(token);
            var decodedEphemeralPublicKey = decodedToken.Take(97).ToArray();
            var encodedEphemeralPublicKeyCheck = Convert.ToBase64String(decodedEphemeralPublicKey);

            if (encodedEphemeralPublicKeyCheck != "BDiRKNnPiPUb5oala31nkmCaXMB0iyWy3Q93p6fN7vPxEQSUlFVsInkJzPBBqmW1FUIY1KBA3BQb3W3Qv4akZ8kblqbmvupE/EJzPKbROZFBNvxpvVOHHgO2qadmHAjHSg==")
                throw new Exception("Public key check failed");

            X9ECParameters curveParams = ECNamedCurveTable.GetByName("secp384r1");
            Org.BouncyCastle.Math.EC.ECPoint decodePoint = curveParams.Curve.DecodePoint(decodedEphemeralPublicKey);
            ECDomainParameters domainParams = new ECDomainParameters(curveParams.Curve, curveParams.G, curveParams.N, curveParams.H, curveParams.GetSeed());
            ECPublicKeyParameters ecPublicKeyParameters = new ECPublicKeyParameters(decodePoint, domainParams);

            var x = ecPublicKeyParameters.Q.AffineXCoord.ToBigInteger();
            var y = ecPublicKeyParameters.Q.AffineYCoord.ToBigInteger();

            if (!x.Equals(new BigInteger("8706462696031173094919866327685737145866436939551712382591956952075131891462487598200779332295613073905587629438229")))
                throw new Exception("X coord check failed");

            if (!y.Equals(new BigInteger("10173258529327482491525749925661342501140613951412040971418641469645769857676705559747557238888921287857458976966474")))
                throw new Exception("Y coord check failed");

            Console.WriteLine("Step 1 complete");

            // #####
            // ##### Step 2
            // #####
            var privateKeyBytes = Convert.FromBase64String(privateKey);
            var ecPrivateKeyParameters = new ECPrivateKeyParameters("ECDHC", new BigInteger(1, privateKeyBytes), domainParams);
            var privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(ecPrivateKeyParameters);
            var ecPrivateKey = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyInfo);

            IBasicAgreement agree = AgreementUtilities.GetBasicAgreement("ECDHC");
            agree.Init(ecPrivateKey);
            BigInteger sharedKey = agree.CalculateAgreement(ecPublicKeyParameters);
            var sharedKeyBytes = sharedKey.ToByteArrayUnsigned();
            var sharedKeyBase64 = Convert.ToBase64String(sharedKeyBytes);

            if (sharedKeyBase64 != "2lvSJsBO2keUHRfvPG6C1RMUmGpuDbdgNrZ9YD7RYnvAcfgq/fjeYr1p0hWABeif")
                throw new Exception("Shared key check failed");

            Console.WriteLine("Step 2 complete");

            // #####
            // ##### Step 3
            // #####
            var kdf2Bytes = Kdf2(sharedKeyBytes, decodedEphemeralPublicKey);
            var kdf2Base64 = Convert.ToBase64String(kdf2Bytes);

            if (kdf2Base64 != "mAzkYatDlz4SzrCyM23NhgL/+mE3eGgfUz9h1CFPhZOtXequzN3Q8w+B5GE2eU5g")
                throw new Exception("Kdf2 failed");

            Console.WriteLine("Step 3 complete");

            // #####
            // ##### Step 4
            // #####
            var decryptionKeyBytes = kdf2Bytes.Take(32).ToArray();
            var decryptionIvBytes = kdf2Bytes.Skip(32).ToArray();

            var decryptionKeyBase64 = Convert.ToBase64String(decryptionKeyBytes);
            var decryptionIvBase64 = Convert.ToBase64String(decryptionIvBytes);

            if (decryptionKeyBase64 != "mAzkYatDlz4SzrCyM23NhgL/+mE3eGgfUz9h1CFPhZM=")
                throw new Exception("Decryption key check failed");

            if (decryptionIvBase64 != "rV3qrszd0PMPgeRhNnlOYA==")
                throw new Exception("Decryption iv check failed");

            var encryptedDataBytes = decodedToken.Skip(97).Take(decodedToken.Length - 113).ToArray();
            var tagBytes = decodedToken.Skip(decodedToken.Length - 16).ToArray();

            var encryptedDataBase64 = Convert.ToBase64String(encryptedDataBytes);
            var tagBase64 = Convert.ToBase64String(tagBytes);

            if (encryptedDataBase64 != "afFS7GukrGilac6DKHNTH6YFRNqjSlwSCpkXDRj+")
                throw new Exception("Encrypted data check failed");

            if (tagBase64 != "pkgk9/Uq6wIyXPlMCGmOzA==")
                throw new Exception("Tag check failed");

            KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("AES", decryptionKeyBytes);
            ParametersWithIV parameters = new ParametersWithIV(keyParam, decryptionIvBytes);
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/GCM/NoPadding");
            cipher.Init(false, parameters);
            var resultBytes = cipher.DoFinal(encryptedDataBytes.Concat(tagBytes).ToArray());
            var resultBase64 = Convert.ToBase64String(resultBytes);
            var resultString = Strings.FromByteArray(resultBytes);

            if (resultString != "xXTi32iZwrQ6O8Sy6r1isKwF6Ff1Py")
                throw new Exception("Decryption failed");

            Console.WriteLine("Step 4 complete");
            Console.WriteLine(resultString);

            Console.WriteLine();
            Console.WriteLine("Done... press any key to finish");
            Console.ReadLine();

            return resultString;
        }

        static byte[] Kdf2(byte[] sharedKeyBytes, byte[] ephemeralKeyBytes)
        {
            var gen = new Kdf2BytesGenerator(new Sha256Digest());
            gen.Init(new KdfParameters(sharedKeyBytes, ephemeralKeyBytes));

            byte[] encryptionKeyBytes = new byte[48];
            gen.GenerateBytes(encryptionKeyBytes, 0, encryptionKeyBytes.Length);
            return encryptionKeyBytes;
        }

    }
}
