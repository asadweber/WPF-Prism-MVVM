using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicantbatchchange : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicantbatchchange = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicantbatchchange.xml"));//DbResourceProvider(); //  
         
         
        public static string applicantbatchchangeList
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("applicantbatchchangeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantbatchchangeCreate
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("applicantbatchchangeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantbatchchangeUpdate
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("applicantbatchchangeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantbatchchangeDetails
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("applicantbatchchangeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joindate
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("joindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string volunteerno
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("volunteerno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupno
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("groupno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicantbatchchange.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
