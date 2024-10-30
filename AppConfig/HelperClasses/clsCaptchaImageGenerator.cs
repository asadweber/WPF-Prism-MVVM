using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;

namespace AppConfig.HelperClasses
{
    public static class clsCaptchaImageGenerator
    {


        /// <summary>
        /// SymmetricKey generate
        /// </summary>
        /// <method name="SymmetricKey" type="byte[]"></method>
        private static byte[] SymmetricKey
        {
            get
            {
                return Encoding.UTF8.GetBytes("1B2c3D4e5F6g7H81");
            }
        }
        /// <summary>
        /// Encrypt String
        /// </summary>
        /// <method name="EncryptString" type="byte[]"></method>
        /// <param name="data" type="string"></param>
        /// <returns> byte[]</returns>
        /// <remarks>Encrypt String</remarks>
        public static byte[] EncryptString(string data)
        {
            byte[] ClearData = Encoding.UTF8.GetBytes(data);
            SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create();
            Algorithm.Key = SymmetricKey;

            MemoryStream Target = new MemoryStream();
            Algorithm.GenerateIV();
            Target.Write(Algorithm.IV, 0, Algorithm.IV.Length);
            CryptoStream cs = new CryptoStream(Target, Algorithm.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(ClearData, 0, ClearData.Length);
            cs.FlushFinalBlock();
            return Target.ToArray();
        }
        /// <summary>
        /// Decrypt String
        /// </summary>
        /// <method name="DecryptString" type="string"></method>
        /// <param name="data" type="byte[]"></param>
        /// <returns> string</returns>
        /// <remarks>Decrypt String</remarks>
        public static string DecryptString(byte[] data)
        {
            SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create();
            Algorithm.Key = SymmetricKey;
            MemoryStream Target = new MemoryStream();
            int ReadPos = 0;
            byte[] IV = new byte[Algorithm.IV.Length];
            Array.Copy(data, IV, IV.Length);
            Algorithm.IV = IV;
            ReadPos += Algorithm.IV.Length;
            CryptoStream cs = new CryptoStream(Target,
            Algorithm.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(data, ReadPos, data.Length - ReadPos);
            cs.FlushFinalBlock();
            return Encoding.UTF8.GetString(Target.ToArray());
        }
    }
    /// <summary>
    /// Captcha generator
    /// </summary>
    public class clsCaptchaGenerator
    {
        public clsCaptchaGenerator()
        {

        }

        public string GetCapchaImage(string str, int imageHeight, int imageWidth, int fontSize, int distortion)
        {
            string strimage = string.Empty;

            try
            {
                MemoryStream ms = new MemoryStream();
                ms = ImageFactory.GenerateImage(str, imageHeight, imageWidth, fontSize, distortion);
                byte[] byteImage = ms.ToArray();
                strimage = Convert.ToBase64String(byteImage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strimage;
        }



        string[] ValidFonts = { "Segoe Script", "Century", "Eccentric Std", "Freestyle Script", "Viner Hand ITC" };
        public clsCaptchaGenerator(char c)
        {
            Random rnd = new Random();
            font = new Font(ValidFonts[rnd.Next(ValidFonts.Count() - 1)], 15 + 5, GraphicsUnit.Pixel);
            letter = c;
        }
        public Font font
        {
            get;
            private set;
        }
        /// <summary>
        /// get letter size
        /// </summary>
        /// <method name="LetterSize" type="Size"></method>
        public Size LetterSize
        {
            get
            {
                var Bmp = new Bitmap(1, 1);
                var Grph = Graphics.FromImage(Bmp);
                return Grph.MeasureString(letter.ToString(), font).ToSize();
            }
        }
        public char letter
        {
            get;
            private set;
        }
        public int space
        {
            get;
            set;
        }

    }

}
