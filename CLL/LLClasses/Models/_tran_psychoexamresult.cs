using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_psychoexamresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_psychoexamresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_psychoexamresult.xml"));//DbResourceProvider(); //  
         
         
        public static string psychoexamresultList
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresultCreate
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresultUpdate
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresultDetails
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string psychoexamresult
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresultRequired
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string psychoexamcomment
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string psychoexamresultdate
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresultdateRequired
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("psychoexamresultdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_psychoexamresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
