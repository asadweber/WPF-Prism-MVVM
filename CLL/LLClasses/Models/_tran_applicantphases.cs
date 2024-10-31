using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicantphases : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicantphases = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicantphases.xml"));//DbResourceProvider(); //  
         
         
        public static string applicantphasesList
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("applicantphasesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphasesCreate
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("applicantphasesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphasesUpdate
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("applicantphasesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphasesDetails
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("applicantphasesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string phaseid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("phaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phaseidRequired
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("phaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string submittedby
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("submittedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string submitteddate
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("submitteddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicantphases.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
