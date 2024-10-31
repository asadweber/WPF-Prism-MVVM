using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_volunteerunitclearance : _Common
    {
         private static IResourceProvider resourceProvider_tran_volunteerunitclearance = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_volunteerunitclearance.xml"));//DbResourceProvider(); //  
         
         
        public static string volunteerunitclearanceList
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("volunteerunitclearanceList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteerunitclearanceCreate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("volunteerunitclearanceCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteerunitclearanceUpdate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("volunteerunitclearanceUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteerunitclearanceDetails
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("volunteerunitclearanceDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string unitclearanceresult
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("unitclearanceresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultRequired
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("unitclearanceresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syclearancefromdate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("syclearancefromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syclearancetodate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("syclearancetodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syclearancedate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("syclearancedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitforwardedfromdate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("unitforwardedfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitforwardedtodate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("unitforwardedtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitforwardeddate
        {
            get
            {
                return resourceProvider_tran_volunteerunitclearance.GetResource("unitforwardeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
