using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _applicant_notification : _Common
    {
        private static IResourceProvider resourceProvider_applicant_notification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_applicant_notification.xml"));//DbResourceProvider(); //  

        public static string nationalityid
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationality
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("nationality", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateid
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("certificateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilid
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobno
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("mobno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string email
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationfromdate
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("registrationfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationtodate
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("registrationtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string submittedfromdate
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("submittedfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string submittedtodate
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("submittedtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maxage
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("maxage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string minage
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("minage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maxnoofapplicant
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("maxnoofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string fullname
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofapplicant
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("noofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serial
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("serial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationdate
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("notificationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationdateRequired
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("notificationdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtime
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("notificationtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtimeRequired
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("notificationtimeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtype
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("notificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotification
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("smsnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotification
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("pacinotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotification
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("emailnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofnotification
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("noofnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchno
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("batchno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string totalnoofapplicant
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("totalnoofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string showingnoofapplicant
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("showingnoofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string selectednoofapplicant
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("selectednoofapplicant", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
