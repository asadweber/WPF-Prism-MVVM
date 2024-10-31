using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_finalexamresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_finalexamresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_finalexamresult.xml"));//DbResourceProvider(); //  
         
         
        public static string finalexamresultList
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultCreate
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultUpdate
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultDetails
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string finalexamresult
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultRequired
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string finalexamcomment
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string finalexamresultdate
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultdateRequired
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresultfromdate
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresultfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresulttodate
        {
            get
            {
                return resourceProvider_tran_finalexamresult.GetResource("finalexamresulttodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
