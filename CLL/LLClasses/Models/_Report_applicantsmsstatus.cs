using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _Report_applicantsmsstatus : _Common
    {
        private static IResourceProvider resourceProvider_report_applicantlist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Report_applicantsmsstatus.xml"));//DbResourceProvider(); //  

        public static string civilid
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smssentdate
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("smssentdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string interviewdate
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("interviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatus
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
