using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_volunteersyclearance : _Common
    {
         private static IResourceProvider resourceProvider_tran_volunteersyclearance = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_volunteersyclearance.xml"));//DbResourceProvider(); //  
         
        public static string volunteersyclearanceList
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("volunteersyclearanceList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteersyclearanceCreate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("volunteersyclearanceCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteersyclearanceUpdate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("volunteersyclearanceUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteersyclearanceDetails
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("volunteersyclearanceDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syclearanceresult
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("syclearanceresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewfromdate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("reviewfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewtodate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("reviewtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syforwardedfromdate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("syforwardedfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syforwardedtodate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("syforwardedtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syforwardeddate
        {
            get
            {
                return resourceProvider_tran_volunteersyclearance.GetResource("syforwardeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
