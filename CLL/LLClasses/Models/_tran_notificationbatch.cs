using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_notificationbatch : _Common
    {
         private static IResourceProvider resourceProvider_tran_notificationbatch = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_notificationbatch.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationbatchList
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("notificationbatchList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchCreate
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("notificationbatchCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchUpdate
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("notificationbatchUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchDetails
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("notificationbatchDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchid
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string typeid
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("typeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string phaseid
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("phaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string numberofapplicant
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("numberofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string numberofapplicantRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("numberofapplicantRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string scheduledfor
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("scheduledfor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string scheduledforRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("scheduledforRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string interviewdate
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("interviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendsms
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("sendsms", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendsmsRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("sendsmsRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddigitalidnotification
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("senddigitalidnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddigitalidnotificationRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("senddigitalidnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendemail
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("sendemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendemailRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("sendemailRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatus
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string maxageplaceholder
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("maxageplaceholder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string minageplaceholder
        {
            get
            {
                return resourceProvider_tran_notificationbatch.GetResource("minageplaceholder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}