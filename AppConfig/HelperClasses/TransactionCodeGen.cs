using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace AppConfig.HelperClasses
{
    public class transactioncodeGen : IDisposable
    {
        #region IDisposable Members

        private bool isDisposed = false;
        private static Mutex mutex = new Mutex();
        ~transactioncodeGen()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Code to dispose the managed resources of the class
            }
            // Code to dispose the un-managed resources of the class

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public transactioncodeGen()
        {
        }
        #endregion

        private RNGCryptoServiceProvider _global = new RNGCryptoServiceProvider();
        private Random _local;
        private string TransactionID;
        private DateTime dot = new DateTime();

        private object DTciks = DateTime.Now.Ticks;

        private string AlphaNumericString = "23456789ACDEFGHJKLMNPQRSTUVWXYZ";
        private string AlphaString = "ACDEFGHJKLMNPQRSTUVWXYZ";
        private string NumberString = "0123456789";

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
        /// <summary>
        /// GetUserCode
        /// </summary>
        /// <method name="GetUserCode" type="string"></method>
        /// <param name="ParentCode" type="string"></param>
        /// <param name="UserType" type="string"></param>
        /// <param name="ChildCounter" type="int"></param>
        /// <returns></returns>
        public string GetUserCode(string ParentCode, string UserType, int ChildCounter)
        {
            string UserCode = string.Empty;
            if (ChildCounter == 0)
            {
                ChildCounter = 1;
            }
            else
                ChildCounter = ChildCounter + 1;

            UserCode = ParentCode + "-" + UserType + ChildCounter.ToString();
            return UserCode;
        }

        // SMS TRANID
        /// <summary>
        /// GetRandomAlphaNumericStringForCoupon
        /// </summary>
        /// <method name="GetRandomAlphaNumericStringForCoupon" type="string"></method>
        /// <param name="dotFor" type="DateTime"></param>
        /// <returns></returns>
        public string GetRandomAlphaNumericStringForCoupon(DateTime dotFor)
        {
            int maxSize = 8;
            char[] chars = new char[62];
            var random = new Random();
            string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder(maxSize);
            lock (_object)
            {
                a = new string(
                    Enumerable.Repeat(a, 10)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());

                chars = a.ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);


                DateTime dt = dotFor;
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length - 1)]);
                }

                string trnID = TransactionID;
                TransactionID = trnID = new string(((dt.Ticks / 6) % 100000000).ToString().ToCharArray());
            }

            return result.ToString() + TransactionID;
        }
        /// <summary>
        /// GetRandomNumericStringForBillCode
        /// </summary>
        /// <method name="GetRandomNumericStringForBillCode" type="long"></method>
        /// <param name="dotFor" type="long"></param>
        /// <returns></returns>
        public long GetRandomNumericStringForBillCode(DateTime dotFor)
        {
            int length = 2;


            if (length <= 0)
            {
                length = 1;
            }
            char[] code = new char[length];
            int iCtr = 0;
            int iLen = AlphaNumericString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = AlphaNumericString[randVar.Next(0, iLen)];
                    foreach (char ch in code)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    code[i] = '\x0001';
                }
                else
                {
                    code[i] = chRandom;
                }
            }
            string TransactionID = String.Format("{0:d8}", (dotFor.Ticks / 10) % 1000000000000);
            return long.Parse(TransactionID);
        }

        [ThreadStatic]
        readonly object _object2 = new object();
        public string GetTicks(string transactionTypeCode, DateTime dotFor)
        {
            lock (_object2)
            {
                DateTime dt = dotFor;
                string trnID = TransactionID;
                TransactionID = trnID = new string((dt.Ticks).ToString().ToCharArray());
            }

            return transactionTypeCode + "." + TransactionID;// +inst.Next().ToString(); // (12 + 2 + 2 = 16) Digits 
        }
        [ThreadStatic]
        readonly object _object = new object();
        public string GetRandomAlphaNumericStringForTransactionActivity(string transactionTypeCode, DateTime dotFor)
        {
            int maxSize = 3;
            char[] chars = new char[62];
            string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder(2);
            lock (_object)
            {
                var random = new Random();
                a = new string(
                    Enumerable.Repeat(a, 10)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());

                chars = a.ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);

                DateTime dt = dotFor;
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length - 1)]);
                }

                string trnID = TransactionID;

                TransactionID = trnID = new string(((dt.Ticks / 6) % 100000000).ToString().ToCharArray());
            }

            return transactionTypeCode + result.ToString() + TransactionID;// +inst.Next().ToString(); // (12 + 2 + 2 = 16) Digits 
        }
        /// <summary>
        /// Get Generated Code
        /// </summary>
        /// <returns></returns>
        public string GetCodeS()
        {
            int length = 2;

            if (length <= 0)
            {
                length = 1;
            }
            char[] code = new char[length];
            int iCtr = 0;
            int iLen = AlphaNumericString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = AlphaNumericString[randVar.Next(0, iLen)];
                    foreach (char ch in code)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    code[i] = '\x0001';
                }
                else
                {
                    code[i] = chRandom;
                }
            }

            return new string(code);
        }
        /// <summary>
        /// Get Random AlphaNumeric String
        /// </summary>
        /// <method name="GetRandomAlphaNumericString" type="string"></method>
        /// <param name="length" type="int"></param>
        /// <returns></returns>
        public string GetRandomAlphaNumericString(int length)
        {
            DateTime dot = DateTime.Now;
            string TransactionID = String.Format("{0:d9}", (dot.Ticks / 10) % 1000000000);

            if (length <= 0)
            {
                length = 1;
            }
            char[] code = new char[length];
            int iCtr = 0;
            int iLen = AlphaNumericString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = AlphaNumericString[randVar.Next(0, iLen)];
                    foreach (char ch in code)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    code[i] = '\x0001';
                }
                else
                {
                    code[i] = chRandom;
                }
            }
            return new string(code);
        }
        /// <summary>
        /// Get Random Numeric string
        /// </summary>
        /// <method name="GetRandomNumeric" type="string"></method>
        /// <param name="length" type="int"></param>
        /// <returns></returns>
        public string GetRandomNumeric(int length)
        {
            DateTime dot = DateTime.Now;
            string TransactionID = String.Format("{0:d9}", (dot.Ticks / 10) % 1000000000);

            if (length <= 0)
            {
                length = 1;
            }
            char[] code = new char[length];
            int iCtr = 0;
            int iLen = NumberString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = NumberString[randVar.Next(0, iLen)];
                    foreach (char ch in code)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    code[i] = '\x0001';
                }
                else
                {
                    code[i] = chRandom;
                }
            }
            return new string(code);
        }
        /// <summary>
        /// Get Random AlphaString
        /// </summary>
        /// <method name="GetRandomAlphaString" type="string"></method>
        /// <param name="length" type="int"></param>
        /// <returns></returns>
        public string GetRandomAlphaString(int length)
        {
            if (length <= 0)
            {
                length = 1;
            }
            char[] code = new char[length];
            int iCtr = 0;
            int iLen = AlphaString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = AlphaString[randVar.Next(0, iLen)];
                    foreach (char ch in code)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    code[i] = '\x0001';
                }
                else
                {
                    code[i] = chRandom;
                }
            }
            return new string(code);
        }
        /// <summary>
        /// Get Random NumericString Code
        /// </summary>
        /// <method name="GetRandomNumericStringCode" type="string"></method>
        /// <param name="length" type="int"></param>
        /// <returns></returns>
        public string GetRandomNumericStringCode(int length)
        {
            char[] ns = new char[length];
            int iCtr = 0;
            int iLen = NumberString.Length;
            bool bGenerate = true;
            char chRandom = '\0';
            Random randVar = new Random(Environment.TickCount);
            for (int i = 0; i < length; i++)
            {
                iCtr = 0;
                bGenerate = true;
                while ((iCtr < iLen) && bGenerate)
                {
                    bGenerate = false;
                    chRandom = NumberString[randVar.Next(0, iLen)];
                    foreach (char ch in ns)
                    {
                        if (ch == chRandom)
                        {
                            bGenerate = true;
                            break;
                        }
                    }
                    iCtr++;
                }
                if ((iCtr >= iLen) && bGenerate)
                {
                    ns[i] = '\x0001';
                }
                else
                {
                    ns[i] = chRandom;
                }
            }
            return new string(ns);
        }
        /// <summary>
        /// Check If palindrome
        /// </summary>
        /// <method name="CheckIfpalindrome" type="bool"></method>
        /// <param name="myString" type="string"></param>
        /// <returns></returns>
        public bool CheckIfpalindrome(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

        /// <summary>
        /// Get Random NumericString PIN
        /// </summary>
        /// <method name="GetRandomNumericStringPIN" type="string"></method>
        /// <param name="length" type="int"></param>
        /// <returns></returns>
        public string GetRandomNumericStringPIN(int length)
        {
            Random rnd = new Random();
            int MPIN = rnd.Next(1000, 9999);
            if (CheckIfpalindrome(MPIN.ToString()))
                GetRandomNumericStringPIN(length);
            return MPIN.ToString();
        }

        /// <summary>
        /// DatetimeToGuid
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public Guid DatetimeToGuid(DateTime dt)
        {

            var bytes = BitConverter.GetBytes(dt.Ticks);

            Array.Resize(ref bytes, 16);

            return new Guid(bytes);
        }

        /// <summary>
        /// GuiDToDateTime
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public DateTime GuiDToDateTime(Guid guid)
        {
            var bytes = guid.ToByteArray();

            Array.Resize(ref bytes, 8);

            return new DateTime(BitConverter.ToInt64(bytes));
        }
    }
}
