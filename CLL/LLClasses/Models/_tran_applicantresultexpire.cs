using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicantresultexpire : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicantresultexpire = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicantresultexpire.xml"));//DbResourceProvider(); //  
         
         
        public static string applicantresultexpireList
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("applicantresultexpireList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantresultexpireCreate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("applicantresultexpireCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantresultexpireUpdate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("applicantresultexpireUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantresultexpireDetails
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("applicantresultexpireDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string resulttypeid
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resulttypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resulttypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resulttypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resultdate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expiredate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("expiredate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expiredateRequired
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("expiredateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resultexpirefromdate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resultexpirefromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resultexpiretodate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resultexpiretodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resultexpirydate
        {
            get
            {
                return resourceProvider_tran_applicantresultexpire.GetResource("resultexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
