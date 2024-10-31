using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_notificationfile : _Common
    {
         private static IResourceProvider resourceProvider_tran_notificationfile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_notificationfile.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationfileList
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("notificationfileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfileCreate
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("notificationfileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfileUpdate
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("notificationfileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfileDetails
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("notificationfileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string fileguid
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileguid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileguidRequired
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileguidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicationid
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("applicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationidRequired
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("applicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string physicalfilename
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("physicalfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userfilename
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("userfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileextension
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filesize
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("filesize", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagesubject
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebody
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagebody", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagesubjectar
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagesubjectar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebodyar
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagebodyar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebodyemail
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagebodyemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebodyemailar
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("messagebodyemailar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendsms
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("sendsms", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendsmsRequired
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("sendsmsRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string senddigitalidnotification
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("senddigitalidnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddigitalidnotificationRequired
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("senddigitalidnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendemail
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("sendemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendemailRequired
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("sendemailRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileid
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileuploaddate
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileuploaddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileuploadresult
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("fileuploadresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string notificationtypeselectionwarning
        {
            get
            {
                return resourceProvider_tran_notificationfile.GetResource("notificationtypeselectionwarning", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
