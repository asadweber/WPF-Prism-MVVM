using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _stp_organization : _Common
    {
         private static IResourceProvider resourceProvider_stp_organization = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_stp_organization.xml"));//DbResourceProvider(); //  
         
         
        public static string organizationList
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationCreate
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationUpdate
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationDetails
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string organizationname
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationnameRequired
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("organizationnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string addresslineone
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("addresslineone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string addresslinetwo
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("addresslinetwo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string phone
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("phone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string website
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("website", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string domain
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("domain", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fax
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("fax", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismailenable
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("ismailenable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smtphost
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("smtphost", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mailport
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("mailport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smtpusername
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("smtpusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smtppassword
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("smtppassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mailssl
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("mailssl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromemailaddress
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("fromemailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string maildisplayname
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("maildisplayname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isftpenable
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("isftpenable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ftpaddress
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("ftpaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ftpport
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("ftpport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ftpusername
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("ftpusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ftppassword
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("ftppassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isssl
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("isssl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logoimg
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("logoimg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string webheader
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("webheader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string folderpath
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("folderpath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_stp_organization.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
