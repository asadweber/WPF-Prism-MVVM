using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_medexamresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_medexamresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_medexamresult.xml"));//DbResourceProvider(); //  
         
         
        public static string medexamresultList
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultCreate
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultUpdate
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultDetails
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medexamresult
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultRequired
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medexamcomment
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medexamresultdate
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultdateRequired
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medexamresultdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medresultfromdate
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medresultfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medresulttodate
        {
            get
            {
                return resourceProvider_tran_medexamresult.GetResource("medresulttodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
