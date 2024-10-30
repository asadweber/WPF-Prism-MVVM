using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AppConfig.EncryptionHandler
{
    ///////////////////////////////////////////////////////////////////////////////
    // Author : Prince
    // Date : 06-Nov-2010
    // Copyright (C) 2010 NextIT. All rights reserved.
    // USA Standards : http://www.itl.nist.gov/fipspubs/fip180-1.htm


    /// <summary>
    /// This class uses a symmetric key algorithm (Rijndael/AES) to encrypt and 
    /// decrypt data. As long as encryption and decryption routines use the same
    /// parameters to generate the keys, the keys are guaranteed to be the same.
    /// The class uses static functions with duplicate code to make it easier to
    /// demonstrate encryption and decryption logic. In a real-life application, 
    /// this may not be the most efficient way of handling encryption, so - as
    /// soon as you feel comfortable with it - you may want to redesign this class.
    /// </summary>
    public class PCryptography
    {
        /// <summary>
        /// Encrypts specified plaintext using Rijndael symmetric key algorithm
        /// and returns a base64-encoded result.
        /// </summary>
        /// <param name="plainText">
        /// Plaintext value to be encrypted.
        /// </param>
        /// <param name="key">
        /// key from which a pseudo-random password will be derived. The
        /// derived password will be used to generate the encryption key.
        /// key can be any string. In this example we assume that this
        /// key is an ASCII string.
        /// </param>
        /// <param name="saltValue">
        /// Salt value used along with key to generate password. Salt can
        /// be any string. In this example we assume that salt is an ASCII string.
        /// </param>
        /// <param name="hashAlgorithm">
        /// Hash algorithm used to generate password. Allowed values are: "MD5" and
        /// "SHA1". SHA1 hashes are a bit slower, but more secure than MD5 hashes.
        /// </param>
        /// <param name="passwordIterations">
        /// Number of iterations used to generate password. One or two iterations
        /// should be enough.
        /// </param>
        /// <param name="initVector">
        /// Initialization vector (or IV). This value is required to encrypt the
        /// first block of plaintext data. For RijndaelManaged class IV must be 
        /// exactly 16 ASCII characters long.
        /// </param>
        /// <param name="keySize">
        /// Size of encryption key in bits. Allowed values are: 128, 192, and 256. 
        /// Longer keys are more secure than shorter keys.
        /// </param>
        /// <returns>
        /// Encrypted value formatted as a base64-encoded string.
        /// </returns>
        /// 
        public string KeyValue
        {
            get
            {
                return keyValue;
            }
            set
            {
                keyValue = value;
            }
        }

        public string SaltValue
        {
            // Salt value
            get
            {
                return saltValue;
            }
            set
            {
                saltValue = value;
            }
        }
        private string saltValue;               // can be any string
        private string keyValue;                // can be any string
        private string hashAlgorithm;           // can be MD5,SHA1,SHA256,SHA384,SHA512
        private int passwordIterations;         // can be any number
        private string initVector;              // must be 16 bytes
        private int keySize;                   // can be 192 or 128


        private void Default()
        {
            //saltValue = ConfigurationManager.AppSettings["Saltvalue"].ToString();                    // can be any string
            //keyValue = ConfigurationManager.AppSettings["keyValue"].ToString();                      // can be any string
            //hashAlgorithm = ConfigurationManager.AppSettings["hashAlgorithm"].ToString();              // can be MD5,SHA1,SHA256,SHA384,SHA512
            //passwordIterations = int.Parse(ConfigurationManager.AppSettings["passwordIterations"].ToString());             // can be any number
            //initVector = ConfigurationManager.AppSettings["initVector"].ToString();    // must be 16 bytes
            //keySize = int.Parse(ConfigurationManager.AppSettings["keySize"].ToString());                       // can be 192 or 128
        }

        public enum KeySize : int
        {
            bit_256,
            bit_192,
            bit_128
        }
        public enum HashAlgorithm : int
        {
            // Supported algorithms
            SHA1,
            SHA256,
            SHA384,
            SHA512,
            MD5
        }

        public PCryptography()
        {
            Default();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="SaltValue"></param>
        /// <param name="KeyValue"></param>
        /// <param name="PasswordIterations"></param>
        /// <param name="InitVector"></param>
        /// <param name="KeySize"></param>
        public PCryptography(HashAlgorithm serviceProvider, string SaltValue, string KeyValue, int PasswordIterations, string InitVector, KeySize KeySize)
        {
            Default();
            // Select hash algorithm
            switch (serviceProvider)
            {
                case HashAlgorithm.MD5:
                    hashAlgorithm = HashAlgorithm.MD5.ToString();
                    break;
                case HashAlgorithm.SHA1:
                    hashAlgorithm = HashAlgorithm.SHA1.ToString();
                    break;
                case HashAlgorithm.SHA256:
                    hashAlgorithm = HashAlgorithm.SHA256.ToString();
                    break;
                case HashAlgorithm.SHA384:
                    hashAlgorithm = HashAlgorithm.SHA384.ToString();
                    break;
                case HashAlgorithm.SHA512:
                    hashAlgorithm = HashAlgorithm.SHA512.ToString();
                    break;
            }
            this.saltValue = SaltValue;
            this.keyValue = KeyValue;
            this.passwordIterations = PasswordIterations;
            this.initVector = InitVector;
            this.keySize = int.Parse(KeySize.ToString().Substring(4, 3));
        }
        public string Encrypt(string PlainText)
        {
            try
            {


                // Convert strings into byte arrays.
                // Let us assume that strings only contain ASCII codes.
                // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
                // encoding.
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(this.initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(this.saltValue);

                // Convert our plaintext into a byte array.
                // Let us assume that plaintext contains UTF8-encoded characters.
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(PlainText);

                // First, we must create a password, from which the key will be derived.
                // This password will be generated from the specified key and 
                // salt value. The password will be created using the specified hash 
                // algorithm. Password creation can be done in several iterations.
                PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                                this.keyValue,
                                                                saltValueBytes,
                                                                this.hashAlgorithm,
                                                                this.passwordIterations);

                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(this.keySize / 8);

                // Create uninitialized Rijndael encryption object.
                RijndaelManaged symmetricKey = new RijndaelManaged();

                // It is reasonable to set encryption mode to Cipher Block Chaining
                // (CBC). Use default options for other symmetric key parameters.
                symmetricKey.Mode = CipherMode.CBC;

                // Generate encryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                                 keyBytes,
                                                                 initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                MemoryStream memoryStream = new MemoryStream();

                // Define cryptographic stream (always use Write mode for encryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                             encryptor,
                                                             CryptoStreamMode.Write);
                // Start encrypting.
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                // Finish encrypting.
                cryptoStream.FlushFinalBlock();

                // Convert our encrypted data from a memory stream into a byte array.
                byte[] EncryptedTextBytes = memoryStream.ToArray();

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert encrypted data into a base64-encoded string.
                string EncryptedText = Convert.ToBase64String(EncryptedTextBytes);

                // Return encrypted string.
                return EncryptedText;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Decrypts specified EncryptedText using Rijndael symmetric key algorithm.
        /// </summary>
        /// <param name="EncryptedText">
        /// Base64-formatted EncryptedText value.
        /// </param>
        /// <param name="keyValue">
        /// key from which a pseudo-random password will be derived. The
        /// derived password will be used to generate the encryption key.
        /// key can be any string. In this example we assume that this
        /// key is an ASCII string.
        /// </param>
        /// <param name="saltValue">
        /// Salt value used along with key to generate password. Salt can
        /// be any string. In this example we assume that salt is an ASCII string.
        /// </param>
        /// <param name="hashAlgorithm">
        /// Hash algorithm used to generate password. Allowed values are: "MD5" and
        /// "SHA1". SHA1 hashes are a bit slower, but more secure than MD5 hashes.
        /// </param>
        /// <param name="passwordIterations">
        /// Number of iterations used to generate password. One or two iterations
        /// should be enough.
        /// </param>
        /// <param name="initVector">
        /// Initialization vector (or IV). This value is required to encrypt the
        /// first block of plaintext data. For RijndaelManaged class IV must be
        /// exactly 16 ASCII characters long.
        /// </param>
        /// <param name="keySize">
        /// Size of encryption key in bits. Allowed values are: 128, 192, and 256.
        /// Longer keys are more secure than shorter keys.
        /// </param>
        /// <returns>
        /// Decrypted string value.
        /// </returns>
        /// <remarks>
        /// Most of the logic in this function is similar to the Encrypt
        /// logic. In order for decryption to work, all parameters of this function
        /// - except EncryptedText value - must match the corresponding parameters of
        /// the Encrypt function which was called to generate the
        /// EncryptedText.
        /// </remarks>
        public string Decrypt(string EncryptedText)
        {
            try
            {


                // Convert strings defining encryption key characteristics into byte
                // arrays. Let us assume that strings only contain ASCII codes.
                // If strings include Unicode characters, use Unicode, UTF7, or UTF8
                // encoding.
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(this.initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(this.saltValue);

                // Convert our EncryptedText into a byte array.
                byte[] EncryptedTextBytes = Convert.FromBase64String(EncryptedText);

                // First, we must create a password, from which the key will be 
                // derived. This password will be generated from the specified 
                // key and salt value. The password will be created using
                // the specified hash algorithm. Password creation can be done in
                // several iterations.
                PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                                this.keyValue,
                                                                saltValueBytes,
                                                                this.hashAlgorithm,
                                                                this.passwordIterations);

                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(this.keySize / 8);

                // Create uninitialized Rijndael encryption object.
                RijndaelManaged symmetricKey = new RijndaelManaged();

                // It is reasonable to set encryption mode to Cipher Block Chaining
                // (CBC). Use default options for other symmetric key parameters.
                symmetricKey.Mode = CipherMode.CBC;

                // Generate decryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                                 keyBytes,
                                                                 initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                MemoryStream memoryStream = new MemoryStream(EncryptedTextBytes);

                // Define cryptographic stream (always use Read mode for encryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                              decryptor,
                                                              CryptoStreamMode.Read);

                // Since at this point we don't know what the size of decrypted data
                // will be, allocate the buffer long enough to hold EncryptedText;
                // plaintext is never longer than EncryptedText.
                byte[] plainTextBytes = new byte[EncryptedTextBytes.Length];

                // Start decrypting.
                int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                           0,
                                                           plainTextBytes.Length);

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert decrypted data into a string. 
                // Let us assume that the original plaintext string was UTF8-encoded.
                string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                           0,
                                                           decryptedByteCount);

                // Return decrypted string.   
                return plainText;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
