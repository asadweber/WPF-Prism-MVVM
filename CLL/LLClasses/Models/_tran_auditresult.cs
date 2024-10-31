using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_auditresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_auditresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_auditresult.xml"));//DbResourceProvider(); //  
         
         
        public static string auditresultList
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditresultCreate
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditresultUpdate
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditresultDetails
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string auditresult
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditresultRequired
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string auditcomment
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string auditdate
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditdateRequired
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("auditdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_auditresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
