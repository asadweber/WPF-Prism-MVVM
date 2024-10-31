using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_unitclearanceresult : _Common
    {
        private static IResourceProvider resourceProvider_tran_unitclearanceresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_unitclearanceresult.xml"));//DbResourceProvider(); //  


        public static string unitclearanceresultList
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultCreate
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultUpdate
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultDetails
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationid
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresult
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultRequired
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancecomment
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancecomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultdate
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultdateRequired
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearanceresultdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancemarks
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancemarkfrom
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarkfrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancemarkto
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarkto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string unitclearancemarkplaceholder
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarkplaceholder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string unitclearancemarkfromplaceholder
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarkfromplaceholder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string unitclearancemarktoplaceholder
        {
            get
            {
                return resourceProvider_tran_unitclearanceresult.GetResource("unitclearancemarktoplaceholder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
