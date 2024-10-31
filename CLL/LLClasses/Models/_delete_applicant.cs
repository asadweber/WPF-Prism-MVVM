using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _delete_applicant : _Common
    {
        private static IResourceProvider resourceProvider_applicant_notification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_delete_applicant.xml"));//DbResourceProvider(); //  

        public static string civilid
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchno
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("batchno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetype
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("candidatetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantname
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("applicantname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobileno
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("mobileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationality
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("nationality", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityclass
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("nationalityclass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionname
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("professionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phase
        {
            get
            {
                return resourceProvider_applicant_notification.GetResource("phase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
