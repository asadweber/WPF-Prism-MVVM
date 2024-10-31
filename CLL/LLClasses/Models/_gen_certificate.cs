using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_certificate : _Common
    {
         private static IResourceProvider resourceProvider_gen_certificate = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_certificate.xml"));//DbResourceProvider(); //  
         
         
        public static string certificateList
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificateList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateCreate
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificateCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateUpdate
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificateUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateDetails
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificateDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string certificatename
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificatename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatenameRequired
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificatenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string educationlevel
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("educationlevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationlevelRequired
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("educationlevelRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatelevelid
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificatelevelid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatetypeid
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("certificatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ispercentage
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("ispercentage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_certificate.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
