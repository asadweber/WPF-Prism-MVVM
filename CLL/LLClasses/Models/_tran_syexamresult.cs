using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_syexamresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_syexamresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_syexamresult.xml"));//DbResourceProvider(); //  
         
         
        public static string syexamresultList
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamresultCreate
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamresultUpdate
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamresultDetails
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string syexamresult
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string syexamcomment
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string syexamresultdate
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("syexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_syexamresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
