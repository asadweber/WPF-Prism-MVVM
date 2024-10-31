using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_studentfilestorage : _Common
    {
         private static IResourceProvider resourceProvider_reg_studentfilestorage = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_studentfilestorage.xml"));//DbResourceProvider(); //  
         
         
        public static string studentfilestorageList
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("studentfilestorageList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentfilestorageCreate
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("studentfilestorageCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentfilestorageUpdate
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("studentfilestorageUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentfilestorageDetails
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("studentfilestorageDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileconfignameid
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("fileconfignameid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameidRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("fileconfignameidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string foldercontentid
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("foldercontentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string datatablename
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("datatablename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string datatablenameRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("datatablenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pkcolumnname
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("pkcolumnname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pkcolumnnameRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("pkcolumnnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pkcolumnid
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("pkcolumnid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pkcolumnidRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("pkcolumnidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userfilename
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("userfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetitle
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filetitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userfilenameRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("userfilenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filepathRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filepathRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filenameRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("filetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensionRequired
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("extensionRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileimage
        {
            get
            {
                return resourceProvider_reg_studentfilestorage.GetResource("fileimage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
