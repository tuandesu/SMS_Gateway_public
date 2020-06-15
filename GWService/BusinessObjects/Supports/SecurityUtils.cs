using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace BusinessObjects.Supports
{
    public static class SecurityUtils
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string EncryptInputWithAES(string input)
        {
            Aes aes = Aes.Create();
            var key = aes.Key;
            var tmp = AESEncrypt(key, input);
            return string.Format("value={0}&key={1}", tmp, BitConverter.ToString(key).Replace("-", string.Empty));
        }

        public static string EncryptInputWithPublicDS(string input)
        {
            var keyPath = AppConfig.CERTIFICATE_PATH_PUBLICKEYDS;
            return RSAEncrypt(Encoding.UTF8.GetBytes(input), GetPublicKey(keyPath), false);
        }

        public static string SignatureWithPrivateCP(string input)
        {
            var keyPath = AppConfig.CERTIFICATE_PATH_PRIVATEKEYDS;
            return RSASignature(input, GetPrivateKey(keyPath));
        }

        public static string AESEncrypt(byte[] key, string input)
        {
            using (var aes = new AesManaged())
            {
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(input);
                        cs.Write(data, 0, data.Length);
                    }

                    byte[] encrypted = ms.ToArray();
                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        public static string RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (var RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return Convert.ToBase64String(encryptedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static RSAParameters GetPublicKey(string keyPath)
        {
            using (TextReader privateKeyTextReader = new StringReader(File.ReadAllText(keyPath)))
            {
                PemReader pr = new PemReader(privateKeyTextReader);
                AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
                return DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);
            }
        }

        public static string RSASignature(string input, RSAParameters RSAKeyInfo)
        {
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                var encryptedData = RSA.SignData(Encoding.UTF8.GetBytes(input),
                    CryptoConfig.MapNameToOID("SHA256"));
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static RSAParameters GetPrivateKey(string keyPath)
        {
            using (TextReader privateKeyTextReader = new StringReader(File.ReadAllText(keyPath)))
            {
                PemReader pr = new PemReader(privateKeyTextReader);
                AsymmetricCipherKeyPair keyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
                return DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair.Private);
            }
        }

        public static string Encryption_VNPT(string input)
        {
            int dwKeySize = 1024;
            string pathRoot = AppConfig.PRIVATE_KEY;

            StreamReader streamReader = new StreamReader(pathRoot, true);
            string xmlString = streamReader.ReadToEnd();
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider =
                                          new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            //rsaCryptoServiceProvider.PublicOnly = false;
            int keySize = dwKeySize / 8;
            //byte[] bytes = Encoding.UTF32.GetBytes(inputString);
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            ///
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            // Get our data as bytes
            byte[] plainBytes = Encoding.UTF8.GetBytes(input);
            // Create our hash
            byte[] hashedBytes = sha256.ComputeHash(plainBytes);
            // Because each new RSA instance is created with new random keys, we actually need to load the XML key data
            // into our RSA object in real world use. This private key value should come from reading the contents of a file
            // So that we are using the same key every time, rather than the private member variable created above.
            // Sign (encrypt) our hash
            byte[] signedHash = rsaCryptoServiceProvider.SignHash(hashedBytes, CryptoConfig.MapNameToOID("SHA256"));
            // Return the hashed data as a string that we can easily store in a text or xml file.

            var AuthenKey = Convert.ToBase64String(signedHash);

            return AuthenKey;
        }
    }
}
