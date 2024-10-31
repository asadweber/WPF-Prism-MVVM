using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_volunteermedclearance : _Common
    {
         private static IResourceProvider resourceProvider_tran_volunteermedclearance = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_volunteermedclearance.xml"));//DbResourceProvider(); //  
         
         
        public static string volunteermedclearanceList
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("volunteermedclearanceList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteermedclearanceCreate
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("volunteermedclearanceCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteermedclearanceUpdate
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("volunteermedclearanceUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteermedclearanceDetails
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("volunteermedclearanceDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medclearanceresult
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("medclearanceresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medclearanceresultRequired
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("medclearanceresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendtomedical
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("sendtomedical", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string showdocument
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("showdocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string showprofilereport
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("showprofilereport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medforwardedfromdate
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("medforwardedfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medforwardedtodate
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("medforwardedtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medforwardeddate
        {
            get
            {
                return resourceProvider_tran_volunteermedclearance.GetResource("medforwardeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
