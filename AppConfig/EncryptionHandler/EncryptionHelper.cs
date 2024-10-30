using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace AppConfig.EncryptionHandler
{
    public class EncryptionHelper
    {
        public string GeneratePassword(int length) //length of salt    
        {
            const string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var randNum = new Random();
            var chars = new char[length];
            var allowedCharCount = allowedChars.Length;
            for (var i = 0; i <= length - 1; i++)
            {
                chars[i] = allowedChars[Convert.ToInt32((allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }

        public HashWithSaltResult EncodePassword(string pass, string salt)
        {
            transactioncodeGen objTranCodeGen = new transactioncodeGen();            
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = System.Security.Cryptography.SHA512.Create();
            byte[] inArray = algorithm.ComputeHash(dst);
            HashWithSaltResult objCAllBack = new HashWithSaltResult(EncodePasswordMd5(Convert.ToBase64String(inArray)), salt);
            return objCAllBack;
        }

        public string EncodePasswordMd5(string pass) //Encrypt using MD5    
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)    
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(originalBytes);
            //Convert encoded bytes back to a 'readable' string    
            return BitConverter.ToString(encodedBytes);
        }

        public string base64Encode(string sData) // Encode    
        {
            try
            {
                byte[] encData_byte = new byte[sData.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        public string base64Decode(string sData) //Decode    
        {
            try
            {
                var encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecodeByte = Convert.FromBase64String(sData);
                int charCount = utf8Decode.GetCharCount(todecodeByte, 0, todecodeByte.Length);
                char[] decodedChar = new char[charCount];
                utf8Decode.GetChars(todecodeByte, 0, todecodeByte.Length, decodedChar, 0);
                string result = new String(decodedChar);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Decode" + ex.Message);
            }
        }

        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }

        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[keyLength];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            return randomBytes;
        }
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            byte[] saltBytes = GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }


        /// <summary>
        /// Encrypt File into Byte Array
        /// </summary>
        /// <method name="EncryptFileByteArray" type="byte[]"></method>
        /// <param name="uploadedFile" type="byte[]"></param>
        /// <returns></returns>
        public byte[] EncryptFileByteArray(byte[] uploadedFile)
        {
            string EncryptionKey = "KAFRONTY18031980";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var memoryStream = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(memoryStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(uploadedFile, 0, uploadedFile.Length);
                        cs.FlushFinalBlock();
                        return memoryStream.ToArray();
                    }
                }
            }
        }
        /// <summary>
        /// Decrypt File to ByteArray 
        /// </summary>
        /// <method name="DecryptFileByteArray" type="byte[]"></method>
        /// <param name="uploadedFile" type="byte"></param>
        /// <returns></returns>
        public byte[] DecryptFileByteArray(byte[] uploadedFile)
        {
            string EncryptionKey = "KAFRONTY18031980";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(uploadedFile, 0, uploadedFile.Length);
                        cryptoStream.FlushFinalBlock();
                        return memoryStream.ToArray();
                    }
                }
            }
        }
        /// <summary>
        /// EncSMSText
        /// </summary>
        /// <method name="Encrypt" type="string"></method>
        /// <param name="text" type="string"></param>
        /// <param name="key" type="string"></param>
        /// <returns></returns>
        public string Encrypt(string toEncrypt, bool useHashing, string key)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            // Get the key from config file

            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        

        /// <summary>
        /// Convert Hex ToS tring
        /// </summary>
        /// <method name="ConvertHexToString" type="string"></method>
        /// <param name="HexValue" type="string"></param>
        /// <returns></returns>
        public string ConvertHexToString(string HexValue)
        {
            string StrValue = "";
            while (HexValue.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
                HexValue = HexValue.Substring(2, HexValue.Length - 2);
            }
            return StrValue;
        }

        /// <summary>
        /// DecSMSText
        /// </summary>
        /// <method name="DecSMSText" type="string"></method>
        /// <param name="text" type="string"></param>
        /// <param name="key" type="string"></param>
        /// <returns></returns>
        public string Decrypt(string cipherString, bool useHashing, string key)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock
                    (toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        /// <summary>
        /// AtionType to perform type of operation encryption or decryption
        /// </summary>
        public enum AtionType : int
        {
            // Supported algorithms
            Enc,
            Dec
        }

        public string decryptSimple(string password)
        {
            try
            {
                System.Text.Decoder utf8decode = new UTF8Encoding().GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(password);
                char[] decoded_char = new char[utf8decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)];
                utf8decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                return new string(decoded_char);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string encryptSimple(string password)
        {
            try
            {
                byte[] testdata = new byte[password.Length];
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// GetEncryptedDecryptedValues takes plain key, plain salt, venctor is hardcoded
        /// </summary>
        /// <param name="textStr"> Plain text or encrypted text</param>
        /// <param name="EnctextSaltStr">plain salt as string value</param>
        /// <param name="EnctextKeyStr">plain key as string value</param>
        /// <param name="algo">Type of algo enumurator</param>
        /// <param name="bitSize">Size of encrypted bit</param>
        /// <param name="actionType">Type of Action Encryption or Decryption</param>
        /// <returns> string arrary of length 3, 0 the plain key, 1 the plain salt, 2 the encrypted or decrypted value</returns>
        public string[] GetEncryptedDecryptedValues(string textStr,
            string EnctextSaltStr,
            string EnctextKeyStr,
            PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize,
            EncryptionHelper.AtionType actionType)
        {
            try
            {
                string[] strEncryptionValues = new string[3];
                strEncryptionValues[0] = EnctextKeyStr.ToString();
                strEncryptionValues[1] = EnctextSaltStr.ToString();

                PCryptography ED = new PCryptography(algo, EnctextSaltStr, EnctextKeyStr, 4, "@1X2c3D4e5F6x7H8", bitSize);
                ED.KeyValue = EnctextKeyStr;
                ED.SaltValue = EnctextSaltStr;

                switch (actionType)
                {
                    case AtionType.Enc:
                        strEncryptionValues[2] = ED.Encrypt(textStr);
                        break;
                    case AtionType.Dec:
                        strEncryptionValues[2] = ED.Decrypt(textStr);
                        break;
                }
                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// GetEncryptedDecryptedValuesComplex takes encrypted key, encrypted salt, venctor is hardcoded
        /// </summary>
        /// <param name="textStr"> Plain text or encrypted text</param>
        /// <param name="EnctextSaltStr">encrypted salt as string value</param>
        /// <param name="EnctextKeyStr">encrypted key as string value</param>
        /// <param name="algo">Type of algo enumurator</param>
        /// <param   name="bitSize">Size of encrypted bit</param>
        /// <param name="actionType">Type of Action Encryption or Decryption</param>
        /// <returns> string arrary of length 3, 0 the decrypted key, 1 the decrypted salt, 2 the encrypted or decrypted value</returns>
        public string[] GetEncryptedDecryptedValuesComplex(string textStr,
            string EnctextSaltStr,
            string EnctextKeyStr,
            PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize,
            EncryptionHelper.AtionType actionType)
        {
            try
            {
                string[] strEncryptionValues = new string[3];
                strEncryptionValues[0] = EnctextKeyStr.ToString();
                strEncryptionValues[1] = EnctextSaltStr.ToString();

                PCryptography ED = new PCryptography(algo, EnctextSaltStr, EnctextKeyStr, 4, "@1X2c3D4e5F6x7H8", bitSize);
                ED.KeyValue = decryptSimple(EnctextKeyStr).ToString();
                ED.SaltValue = decryptSimple(EnctextSaltStr).ToString();

                switch (actionType)
                {
                    case AtionType.Enc:
                        strEncryptionValues[2] = ED.Encrypt(textStr);
                        break;
                    case AtionType.Dec:
                        strEncryptionValues[2] = ED.Decrypt(textStr);
                        break;
                }
                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// GetEncryptedDecryptedValuesDynamicVentorComplex takes encrypted key, encrypted salt, encrypted vector
        /// </summary>
        /// <param name="textStr"> Plain text or encrypted text</param>
        /// <param name="EnctextSaltStr">Encrypted salt as string value</param>
        /// <param name="EnctextKeyStr">Encrypted key as string value</param>
        /// <param name="EnctextVectorStr">Encrypted vector as string value</param>
        /// <param name="algo">Type of algo enumurator</param>
        /// <param name="bitSize">Size of encrypted bit</param>
        /// <param name="actionType">Type of Action Encryption or Decryption</param>
        /// <returns> string arrary of length 4, 0 the decrypted key, 1 the decrypted salt, 2 the decrypted vector, and 3 the encrypted or decrypted value</returns>
        public string[] GetEncryptedDecryptedValuesDynamicVentorComplex(string textStr,
            string EnctextSaltStr,
            string EnctextKeyStr,
            string EnctextVectorStr,
            PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize,
            EncryptionHelper.AtionType actionType)
        {
            try
            {
                string[] strEncryptionValues = new string[4];
                strEncryptionValues[0] = decryptSimple(EnctextKeyStr).ToString();
                strEncryptionValues[1] = decryptSimple(EnctextSaltStr).ToString();
                strEncryptionValues[2] = decryptSimple(EnctextVectorStr).ToString();
                PCryptography ED = new PCryptography(algo, strEncryptionValues[1].ToString(), strEncryptionValues[0].ToString(), 2, strEncryptionValues[2].ToString(), bitSize);
                ED.KeyValue = strEncryptionValues[0].ToString();
                ED.SaltValue = strEncryptionValues[1].ToString();

                switch (actionType)
                {
                    case AtionType.Enc:
                        strEncryptionValues[3] = ED.Encrypt(textStr);
                        break;
                    case AtionType.Dec:
                        strEncryptionValues[3] = ED.Decrypt(textStr);
                        break;
                }
                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// GetEncryptedDecryptedValuesDynamicVentor GetEncryptedDecryptedValuesDynamicVentorComplex takes plain key, plain salt, plain vector
        /// </summary>
        /// <param name="textStr"> Plain text or encrypted text</param>
        /// <param name="EnctextSaltStr">Encrypted salt as string value</param>
        /// <param name="EnctextKeyStr">Encrypted key as string value</param>
        /// <param name="EnctextVectorStr">Encrypted vector as string value</param>
        /// <param name="algo">Type of algo enumurator</param>
        /// <param name="bitSize">Size of encrypted bit</param>
        /// <param name="actionType">Type of Action Encryption or Decryption</param>
        /// <returns> string arrary of length 4, 0 the key, 1 the salt, 2 the vector, and 3 the encrypted or decrypted value</returns>
        public string[] GetEncryptedDecryptedValuesDynamicVector(string textStr,
            string EnctextSaltStr,
            string EnctextKeyStr,
            string EnctextVectorStr,
            PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize,
            EncryptionHelper.AtionType actionType)
        {
            try
            {

                string[] strEncryptionValues = new string[4];
                strEncryptionValues[0] = EnctextKeyStr;
                strEncryptionValues[1] = EnctextSaltStr;
                strEncryptionValues[2] = EnctextVectorStr;
                PCryptography ED = new PCryptography(algo, strEncryptionValues[1].ToString(), strEncryptionValues[0].ToString(), 2, strEncryptionValues[2].ToString(), bitSize);
                ED.KeyValue = strEncryptionValues[0].ToString();
                ED.SaltValue = strEncryptionValues[1].ToString();

                switch (actionType)
                {
                    case AtionType.Enc:
                        strEncryptionValues[3] = ED.Encrypt(textStr);
                        break;
                    case AtionType.Dec:
                        strEncryptionValues[3] = ED.Decrypt(textStr);
                        break;
                }
                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Encrypted Values Dynamic
        /// </summary>
        /// <method name="GetEncryptedValuesDynamic" type="GetEncryptedValuesDynamic"></method>
        /// <param name="textStr" type="string"></param>
        /// <param name="algo" type="PCryptography.HashAlgorithm"></param>
        /// <param name="bitSize" type="PCryptography.KeySize"></param>
        /// <returns></returns>
        public string[] GetEncryptedValuesDynamic(string textStr,
           PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize)
        {
            AppConfig.HelperClasses.transactioncodeGen objTranCodeGen = new HelperClasses.transactioncodeGen();
            try
            {
                string EnctextKeyStr = string.Empty;
                string EnctextVectorStr = string.Empty;
                string EnctextSaltStr = string.Empty;

                EnctextKeyStr = objTranCodeGen.GetRandomAlphaNumericStringForTransactionActivity("KAF", DateTime.Now);
                EnctextVectorStr = objTranCodeGen.GetRandomAlphaNumericString(16);
                EnctextSaltStr = objTranCodeGen.GetRandomAlphaNumericStringForTransactionActivity("KAF", DateTime.Now.AddMilliseconds(1));

                string[] strEncryptionValues = new string[4];
                strEncryptionValues[0] = EnctextKeyStr;
                strEncryptionValues[1] = EnctextSaltStr;
                strEncryptionValues[2] = EnctextVectorStr;
                PCryptography ED = new PCryptography(algo, strEncryptionValues[1].ToString(),
                    strEncryptionValues[0].ToString(), 2, strEncryptionValues[2].ToString(), bitSize);
                ED.KeyValue = strEncryptionValues[0].ToString();
                ED.SaltValue = strEncryptionValues[1].ToString();


                strEncryptionValues[3] = ED.Encrypt(textStr);

                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objTranCodeGen.Dispose();
            }
        }
        /// <summary>
        /// Get Decrypted Values Dynamic Vector Auto
        /// </summary>
        /// <method name="GetDecryptedValuesDynamicVectorAuto" type="string[]"></method>
        /// <param name="textStr" type="string"></param>
        /// <param name="EnctextSaltStr" type="string"></param>
        /// <param name="EnctextKeyStr" type="string"></param>
        /// <param name="EnctextVectorStr" type="string"></param>
        /// <param name="algo" type="PCryptography.HashAlgorithm"></param>
        /// <param name="bitSize" type="PCryptography.KeySize"></param>
        /// <returns></returns>
        public string[] GetDecryptedValuesDynamicVectorAuto(string textStr,
         string EnctextSaltStr, string EnctextKeyStr, string EnctextVectorStr,
         PCryptography.HashAlgorithm algo, PCryptography.KeySize bitSize)
        {
            try
            {

                string[] strEncryptionValues = new string[4];
                strEncryptionValues[0] = EnctextKeyStr;
                strEncryptionValues[1] = EnctextSaltStr;
                strEncryptionValues[2] = EnctextVectorStr;
                PCryptography ED = new PCryptography(algo, strEncryptionValues[1].ToString(),
                    strEncryptionValues[0].ToString(), 2, strEncryptionValues[2].ToString(), bitSize);
                ED.KeyValue = strEncryptionValues[0].ToString();
                ED.SaltValue = strEncryptionValues[1].ToString();


                strEncryptionValues[3] = ED.Decrypt(textStr);

                return strEncryptionValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        /// <summary>
        /// StringToGUID
        /// </summary>
        /// <method name="StringToGUID" type="Guid"></method>
        /// <param name="value" type=""string></param>
        /// <returns></returns>
        public Guid StringToGUID(string value)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            return new Guid(data);
        }
    }
}
