using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AppConfig.HelperClasses
{
    public static class StringHelper
    {
        private static System.Globalization.CultureInfo CurrentCulture
        {
            [DebuggerStepThrough()]
            get
            {
                return System.Globalization.CultureInfo.CurrentCulture;
            }
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string value)
        {
            if ((value == null) || (value.Trim().Length == 0))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim();
            }
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="byte"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(byte value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        byte value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="short"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(short value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="short"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        short value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="int"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(int value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        /// <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        int value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="long"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(long value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="long"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        long value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" type="float"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(float value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="float"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        float value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="value" ytype="double"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(double value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="double"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        double value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        ///  <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        decimal value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        /// <method name="Convert" type="string"></method>
        /// <param name="value" type="decimal"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(decimal value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        /// <method name="Convert" type="string"></method>
        /// <param name="value" type="DateTime"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(DateTime value)
        {
            return value.ToString(CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        /// <method name="Convert" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="value" type="DateTime"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(string format,
        DateTime value)
        {
            return value.ToString(format, CurrentCulture);
        }
        /// <summary>
        /// Convert
        /// </summary>
        /// <method name="Convert" type="string"></method>
        /// <param name="value" type="object"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Convert(object value)
        {
            if ((value == null) || (value == DBNull.Value))
            {
                return string.Empty;
            }
            else
            {
                return value.ToString().Trim();
            }
        }
        /// <summary>
        /// Format
        /// </summary>
        /// <method name="Format" type="string"></method>
        /// <param name="format" type="string"></param>
        /// <param name="arg" type="params object[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Format(string format, params object[] arg)
        {
            return string.Format(CurrentCulture, format, arg);
        }
        /// <summary>
        /// ToArray
        /// </summary>
        /// <method name="ToArray" type="string[]"></method>
        /// <param name="collection" type="StringCollection"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string[] ToArray(System.Collections.Specialized.StringCollection collection)
        {
            if ((collection == null) || (collection.Count == 0))
            {
                return null;
            }

            string[] values = new string[collection.Count];

            collection.CopyTo(values, 0);

            return values;
        }
        /// <summary>
        /// ToLower
        /// </summary>
        /// <method name="ToLower" type="string"></method>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string ToLower(string value)
        {
            if (IsBlank(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim().ToLower(CurrentCulture);
            }
        }
        /// <summary>
        /// ToUpper
        /// </summary>
        /// <method name="ToUpper" type="string"></method>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string ToUpper(string value)
        {
            if (IsBlank(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim().ToUpper(CurrentCulture);
            }
        }
        /// <summary>
        /// IsBlank
        /// </summary>
        /// <method name="IsBlank" type="bool"></method>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsBlank(string value)
        {
            //return ((value == null) || (value.Trim().Length == 0));
            return string.IsNullOrEmpty(value);
        }
        /// <summary>
        /// IsBlank
        /// </summary>
        /// <method name="IsBlank" type="bool"></method>
        /// <param name="value" string="bool"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsBlank(StringBuilder value)
        {
            //return ((value == null) || (value.Trim().Length == 0));
            return string.IsNullOrEmpty(value.ToString());
        }
        /// <summary>
        /// IsEqual
        /// </summary>
        /// <method name="IsEqual" type="bool"></method>
        /// <param name="leftHandSide" type="string"></param>
        /// <param name="rightHandSide" type="string"></param>
        /// <param name="ignoreCase" type="bool"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsEqual(string leftHandSide,
        string rightHandSide,
        bool ignoreCase)
        {
            return (Compare(leftHandSide, rightHandSide, ignoreCase) == 0);
        }
        /// <summary>
        /// IsEqual
        /// </summary>
        /// <method name="IsEqual" type="bool"></method>
        /// <param name="leftHandSide" type="string"></param>
        /// <param name="rightHandSide" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsEqual(string leftHandSide,
        string rightHandSide)
        {
            return IsEqual(leftHandSide, rightHandSide, true);
        }
        /// <summary>
        /// Compare
        /// </summary>
        /// <method name="Compare" type="int"></method>
        /// <param name="leftHandSide" type="string"></param>
        /// <param name="rightHandSide" type="string"></param>
        /// <param name="ignoreCase" type="bool"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static int Compare(string leftHandSide,
        string rightHandSide,
        bool ignoreCase)
        {
            return string.Compare(leftHandSide, rightHandSide, ignoreCase, CurrentCulture);
        }
        /// <summary>
        /// Compare
        /// </summary>
        /// <method name="Compare" type="int"></method>
        /// <param name="leftHandSide" type="string"></param>
        /// <param name="rightHandSide" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static int Compare(string leftHandSide,
        string rightHandSide)
        {
            return Compare(leftHandSide, rightHandSide, true);
        }
        /// <summary>
        /// Hash
        /// </summary>
        /// <method name="Hash" type="int"></method>
        /// <param name="plain" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Hash(string plain)
        {
            if (IsBlank(plain)) return string.Empty;

            using (KeyedHashAlgorithm csp = HMACSHA1.Create())
            {
                csp.Key = Key;
                byte[] data = System.Text.Encoding.Default.GetBytes(plain);
                byte[] hash = csp.ComputeHash(data);

                return System.Convert.ToBase64String(hash);
            }
        }
        /// <summary>
        /// Encrypt
        /// </summary>
        /// <method name="Encrypt" type="string"></method>
        /// <param name="plain" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Encrypt(string plain)
        {
            if (IsBlank(plain)) return string.Empty;

            using (SymmetricAlgorithm crypto = CreateAlgorithm())
            {
                return System.Convert.ToBase64String(Read(crypto.CreateEncryptor(), Encoding.Default.GetBytes(plain)));
            }
        }
        /// <summary>
        /// Decrypt
        /// </summary>
        /// <method name="Decrypt" type="string"></method>
        /// <param name="cipher" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Decrypt(string cipher)
        {
            if (IsBlank(cipher)) return string.Empty;

            using (SymmetricAlgorithm crypto = CreateAlgorithm())
            {
                return Encoding.Default.GetString(Read(crypto.CreateDecryptor(), System.Convert.FromBase64String(cipher)));
            }
        }

        /// <summary>
        /// Decrypt
        /// </summary>
        /// <method name="Decrypt" type="SymmetricAlgorithm"></method>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static SymmetricAlgorithm Decrypt()
        {
            SymmetricAlgorithm crypto = new RijndaelManaged();

            crypto.Key = Key;
            crypto.IV = new byte[crypto.IV.Length];

            return crypto;
        }

        [DebuggerStepThrough()]
        private static SymmetricAlgorithm CreateAlgorithm()
        {
            SymmetricAlgorithm crypto = new RijndaelManaged();

            crypto.Key = Key;
            crypto.IV = new byte[crypto.IV.Length];

            return crypto;
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <method name="Read" type="byte[]"></method>
        /// <param name="transformer" type="ICryptoTransform"></param>
        /// <param name="data" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static byte[] Read(ICryptoTransform transformer,
        byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transformer, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }
        /// <summary>
        /// ReplaceUnWantedCharacter
        /// </summary>
        /// <method name="ReplaceUnWantedCharacter" type="string"></method>
        /// <param name="input" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static string ReplaceUnWantedCharacter(string input)
        {
            //input = input.Replace('(', ',');
            //input = input.Replace(')', ',');
            //input = input.Replace(", ", ",");
            //input = input.Replace(" ,", ",");
            //input = input.Replace(' ', ',');
            input = input.Replace("++", "--");
            input = input.Replace('+', ',');
            input = input.Replace("--", "++");
            input = input.Replace('&', ',');
            input = input.Replace('[', ',');
            input = input.Replace(']', ',');

            return input;
        }
        /// <summary>
        /// BuildKeyWordArray
        /// </summary>
        ///  <method name="BuildKeyWordArray" type="byte[]"></method>
        /// <param name="searchString" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string[] BuildKeyWordArray(string searchString)
        {
            string correctedString = ReplaceUnWantedCharacter(searchString);
            string[] keyWordArray = correctedString.Split(',');
            return keyWordArray;
        }
        /// <summary>
        /// IsNullOrEmpty
        /// </summary>
        /// <method name="IsNullOrEmpty" type="bool"></method>
        /// <param name="value" type="this StringBuilder"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsNullOrEmpty(this StringBuilder value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static readonly byte[] Key = new byte[] { 4, 93, 171, 3, 85, 23, 41, 34, 216, 14, 78, 156, 78, 3, 103, 154, 9, 150, 65, 54, 226, 95, 68, 79, 159, 36, 246, 57, 177, 107, 116, 8 };
        /// <summary>
        /// IsStringMatch
        /// </summary>
        /// <method name="IsStringMatch" type="bool"></method>
        /// <param name="StringToSearch" type="string"></param>
        /// <param name="StringInSearch" type="string"></param>
        /// <returns></returns>
        public static bool IsStringMatch(string StringToSearch, string StringInSearch)
        {
            StringToSearch = RemoveWhiteSpaces(StringToSearch);
            StringToSearch = StringToSearch.ToLower();
            StringInSearch = RemoveWhiteSpaces(StringInSearch);
            StringInSearch = StringInSearch.ToLower();
            if (StringToSearch.Length > StringInSearch.Length)
            {
                string strTemp = StringToSearch;
                StringToSearch = StringInSearch;
                StringInSearch = strTemp;
            }
            int prevIndex = -1;
            int count = 1;
            int lastCount = 0;
            for (int i = 0; i < StringToSearch.Length; i++)
            {
                char chr = StringToSearch[i];
                int index = StringInSearch.IndexOf(chr, i);
                if (index > -1 && prevIndex == -1)
                {
                    prevIndex = index;
                    count++;
                }
                else
                {
                    if (prevIndex + 1 == index)
                    {
                        prevIndex = index;
                        count++;
                        //lastCount = count;
                    }
                    else
                    {
                        prevIndex = -1;
                        count = 0;
                    }
                }
                if (count > lastCount)
                {
                    lastCount = count;
                }
            }

            //2/3 of job title
            int length = StringToSearch.Length / 3;
            if (lastCount > length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// RemoveWhiteSpaces
        /// </summary>
        /// <method name="RemoveWhiteSpaces" type="string"></method>
        /// <param name="strSource" type="string"></param>
        /// <returns></returns>
        public static string RemoveWhiteSpaces(string strSource)
        {
            Regex r = new Regex(@"\s");
            string strDestination = r.Replace(strSource, "");
            return strDestination;
        }

        /// <summary>
        /// Separate
        /// </summary>
        /// <method name="Separate" type="string[]"></method>
        /// <param name="separator" type="char"></param>
        /// <param name="value" type="string"></param>
        /// <returns></returns>
        public static string[] Separate(char separator, string value)
        {
            return value.Split(new char[] { separator });
        }
        /// <summary>
        /// Concate
        /// </summary>
        /// <method name="Concate" type="string"></method>
        /// <param name="p" type="string"></param>
        /// <param name="instituteName" type="string"></param>
        /// <param name="p_3" type="string"></param>
        /// <param name="countryName" type="string"></param>
        /// <returns></returns>
        public static string Concate(string p, string instituteName, string p_3, string countryName)
        {
            throw new NotImplementedException();
        }
    }
}
