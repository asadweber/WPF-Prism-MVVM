using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_educationinfo : _Common
    {
         private static IResourceProvider resourceProvider_reg_educationinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_educationinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string educationinfoList
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("educationinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationinfoCreate
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("educationinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationinfoUpdate
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("educationinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationinfoDetails
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("educationinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchcandcertificateid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("batchcandcertificateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandcertificateidRequired
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("batchcandcertificateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatelevelid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("certificatelevelid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatelevelidRequired
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("certificatelevelidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificateid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("certificateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateidRequired
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("certificateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatesubjectid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("certificatesubjectid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string educationshiftid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("educationshiftid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string edugradeid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("edugradeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string edumajorid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("edumajorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string instituteid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("instituteid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passyear
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("passyear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ispercentage
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("ispercentage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string points
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("points", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string grade
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("grade", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string institutename
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("institutename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isstudying
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("isstudying", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newinstituteid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("newinstituteid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string semestername
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("semestername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string CertificateLevel
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("CertificateLevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string CertificateName
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("CertificateName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CertificateSubjectName
        {
            get
            {
                return resourceProvider_reg_educationinfo.GetResource("CertificateSubjectName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }



    }
}
