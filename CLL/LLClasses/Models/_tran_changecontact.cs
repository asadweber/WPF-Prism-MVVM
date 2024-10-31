using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_changecontact : _Common
    {
        private static IResourceProvider resourceProvider__tran_changecontact = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_changecontact.xml"));//DbResourceProvider(); //  

        public static string civilid
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchno
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("batchno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetype
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("candidatetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantname
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("applicantname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobileno
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("mobileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string email
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationality
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("nationality", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityclass
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("nationalityclass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionname
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("professionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phase
        {
            get
            {
                return resourceProvider__tran_changecontact.GetResource("phase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
