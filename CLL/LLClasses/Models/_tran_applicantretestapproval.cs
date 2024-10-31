using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicantretestapproval : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicantretestapproval = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicantretestapproval.xml"));//DbResourceProvider(); //  
         
         
        public static string applicantretestapprovalList
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("applicantretestapprovalList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantretestapprovalCreate
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("applicantretestapprovalCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantretestapprovalUpdate
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("applicantretestapprovalUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantretestapprovalDetails
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("applicantretestapprovalDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string resulttypeid
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("resulttypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string resulttypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("resulttypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string clearanceby
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("clearanceby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string clearancebyRequired
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("clearancebyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string clearancedate
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("clearancedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string clearancedateRequired
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("clearancedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicantretestapproval.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
