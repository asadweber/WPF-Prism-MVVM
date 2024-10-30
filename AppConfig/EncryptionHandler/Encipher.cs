using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AppConfig.EncryptionHandler
{
    /// <summary>
    /// Provide encryption and decryption function 
    /// </summary>
    public static class Encipher
    {
        /// <summary>
        /// Generate RSA key pair
        /// </summary>
        /// <param name="publicKey">Receive public key</param>
        /// <param name="privateKey">Receive private key</param>
        public static (string, string) GenerateRSAKeyPair()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);
            return (publicKey, privateKey);
        }

        /// <summary>
        /// Encrypt a file
        /// </summary>
        /// <param name="plainText">Full path of the file to be encrypted</param>
        /// <param name="encryptedFilePath">Full path of the encrypted file</param>
        /// <param name="manifestFilePath">Full path of the generated manifest file</param>
        /// <param name="product">Product name</param>
        /// <param name="productVersion">Product version</param>
        /// <param name="rsaKey">RSA key used to encrypt the one-time symmetrical key</param>
        /// <param name="rsaKeyId">RSA key id for backend index</param>
        /// <returns>Encryption information including symmetrical keys for data encryption and signature, just for debug purpose</returns>
        public static (string, string) EncryptPlainText(string plainText,
            string rsaKey)
        {
            byte[] signatureKey = GenerateRandom(64);
            byte[] encryptionKey = GenerateRandom(16);
            byte[] encryptionIV = GenerateRandom(16);

            string encryptedbyte = EncryptPlainText(plainText, encryptionKey, encryptionIV);

            byte[] signature = CalculateSignature(signatureKey);

            string manifest = CreateManifest(signature, signatureKey, encryptionKey, encryptionIV, rsaKey);

            return (encryptedbyte, manifest);

        }
        public static (byte[], string) EncryptByte(byte[] inputStream,
            string rsaKey)
        {
            byte[] signatureKey = GenerateRandom(64);
            byte[] encryptionKey = GenerateRandom(16);
            byte[] encryptionIV = GenerateRandom(16);

            byte[] encryptedbyte = EncryptByte(inputStream, encryptionKey, encryptionIV);

            byte[] signature = CalculateSignature(signatureKey);

            string manifest = CreateManifest(signature, signatureKey, encryptionKey, encryptionIV, rsaKey);

            return (encryptedbyte, manifest);

        }



        /// <summary>
        /// Generate random byte array
        /// </summary>
        /// <param name="length">array length</param>
        /// <returns>Random byte array</returns>
        private static byte[] GenerateRandom(int length)
        {
            byte[] bytes = new byte[length];
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(bytes);
            }

            return bytes;
        }

        /// <summary>
        /// Encrypt a file with AES
        /// </summary>
        /// <param name="plainFilePath">Full path of the file to be encrypted</param>
        /// <param name="encryptedFilePath">Full path of the encrypted file</param>
        /// <param name="key">AES key</param>
        /// <param name="iv">AES IV</param>
        private static string EncryptPlainText(string plainbyte,
            byte[] key,
            byte[] iv)
        {
            byte[] encrypted = null;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainbyte);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        private static byte[] EncryptByte(byte[] inputStream,
            byte[] key,
            byte[] iv)
        {
            byte[] encrypted = null;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(inputStream, 0, inputStream.Length);
                        cs.Close();
                    }
                    encrypted = ms.ToArray();
                }
            }

            return encrypted;
        }

        /// <summary>
        /// Encrypt a file with AES
        /// </summary>
        /// <param name="plainFilePath">Full path of the encrypted file</param>
        /// <param name="encryptedFilePath">Full path of the file to be decrypted</param>
        /// <param name="key">AES key</param>
        /// <param name="iv">AES IV</param>
        public static string DecryptPlainText(string plaindata, string manifest, string rsaKey)
        {
            byte[] cipher = Convert.FromBase64String(plaindata);

            XDocument doc = XDocument.Parse(manifest);
            XElement aesKeyElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/Key");
            byte[] aesKey = Encipher.RSADescryptBytes(Convert.FromBase64String(aesKeyElement.Value), rsaKey);
            XElement aesIvElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/IV");
            byte[] aesIv = Encipher.RSADescryptBytes(Convert.FromBase64String(aesIvElement.Value), rsaKey);

            string DecryptData = null;

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = aesKey;
                aes.IV = aesIv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(cipher))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            DecryptData = sr.ReadToEnd();
                        }
                    }
                }



            }
            return DecryptData;
        }

        public static byte[] DecryptByte(byte[] cipherbyte, string manifest, string rsaKey)
        {

            XDocument doc = XDocument.Parse(manifest);
            XElement aesKeyElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/Key");
            byte[] aesKey = Encipher.RSADescryptBytes(Convert.FromBase64String(aesKeyElement.Value), rsaKey);
            XElement aesIvElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/IV");
            byte[] aesIv = Encipher.RSADescryptBytes(Convert.FromBase64String(aesIvElement.Value), rsaKey);


            byte[] DecryptData = new byte[cipherbyte.Length];

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = aesKey;
                aes.IV = aesIv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(cipherbyte, 0, DecryptData.Length);
                        cs.Close();
                    }
                    DecryptData = ms.ToArray();
                }



            }
            return DecryptData;
        }

        /// <summary>
        /// Calculate file signature
        /// </summary>
        /// <param name="filePath">Full path of the file for calculating signature</param>
        /// <param name="key">key for calculating signature</param>
        /// <returns>Signature array</returns>
        private static byte[] CalculateSignature(byte[] key)
        {
            byte[] sig = null;
            using (HMACSHA256 sha = new HMACSHA256(key))
            {
                using (MemoryStream f = new MemoryStream())
                {
                    sig = sha.ComputeHash(f);
                }
            }

            return sig;
        }

        /// <summary>
        /// Create manifest file of a encrypted package, used for backend parsing
        /// </summary>
        /// <param name="signature">Data signature</param>
        /// <param name="signatureKey">Data signature key</param>
        /// <param name="encryptionKey">AES encryption key</param>
        /// <param name="encryptionIv">AES encryption IV</param>
        /// <param name="product">Product name</param>
        /// <param name="productVersion">Product version</param>
        /// <param name="rsaKey">RSA key</param>
        /// <param name="rsaKeyID">RSA key ID</param>
        /// <param name="manifestFilePath">Output manifest file path</param>
        private static string CreateManifest(byte[] signature,
            byte[] signatureKey,
            byte[] encryptionKey,
            byte[] encryptionIv,
            string rsaKey
            )
        {
            string template = "<DataInfo>" +
                "<Encrypted>True</Encrypted>" +
                "<KeyEncryption algorithm='RSA2048'>" +
                "</KeyEncryption>" +
                "<DataEncryption algorithm='AES128'>" +
                "<AESEncryptedKeyValue>" +
                "<Key/>" +
                "<IV/>" +
                "</AESEncryptedKeyValue>" +
                "</DataEncryption>" +
                "<DataSignature algorithm='HMACSHA256'>" +
                "<Value />" +
                "<EncryptedKey />" +
                "</DataSignature>" +
                "</DataInfo>";

            XDocument doc = XDocument.Parse(template);
            doc.Descendants("DataEncryption").Single().Descendants("AESEncryptedKeyValue").Single().Descendants("Key").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(encryptionKey, rsaKey));
            doc.Descendants("DataEncryption").Single().Descendants("AESEncryptedKeyValue").Single().Descendants("IV").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(encryptionIv, rsaKey));
            doc.Descendants("DataSignature").Single().Descendants("Value").Single().Value = System.Convert.ToBase64String(signature);
            doc.Descendants("DataSignature").Single().Descendants("EncryptedKey").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(signatureKey, rsaKey));
            return doc.ToString();
        }

        /// <summary>
        /// Encrypt byte array with RSA
        /// </summary>
        /// <param name="datas">byte array to be encrypted</param>
        /// <param name="keyXml">RSA key</param>
        /// <returns>Encrypted array</returns>
        public static byte[] RSAEncryptBytes(byte[] datas, string keyXml)
        {
            byte[] encrypted = null;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(keyXml);
                encrypted = rsa.Encrypt(datas, true);
            }

            return encrypted;
        }

        /// <summary>
        /// Decrypt byte array with RSA
        /// </summary>
        /// <param name="datas">byte array to be decrypted</param>
        /// <param name="keyXml">RSA key</param>
        /// <returns>Decrypted array</returns>
        public static byte[] RSADescryptBytes(byte[] datas, string keyXml)
        {
            byte[] decrypted = null;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(keyXml);
                decrypted = rsa.Decrypt(datas, true);
            }

            return decrypted;
        }
    }
}
