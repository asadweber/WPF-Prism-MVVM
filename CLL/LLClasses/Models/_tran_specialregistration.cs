using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_specialregistration : _Common
    {
         private static IResourceProvider resourceProvider_tran_specialregistration = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_specialregistration.xml"));//DbResourceProvider(); //  
         
         
        public static string specialregistrationList
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("specialregistrationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string specialregistrationCreate
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("specialregistrationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string specialregistrationUpdate
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("specialregistrationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string specialregistrationDetails
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("specialregistrationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string civilid
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string candidatetypeid
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("candidatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeidRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("candidatetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string emailaddress
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("emailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailaddressRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("emailaddressRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilenumber
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("mobilenumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenumberRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("mobilenumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtype
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("notificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendbysms
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbysms", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendbysmsRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbysmsRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendbydigitalid
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbydigitalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendbydigitalidRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbydigitalidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendbyemail
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbyemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendbyemailRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("sendbyemailRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string paciresponse
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("paciresponse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string paciresponseRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("paciresponseRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string validuntil
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("validuntil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string validuntilRequired
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("validuntilRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_specialregistration.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
