using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _Report_volunteerresult : _Common
    {
        private static IResourceProvider resourceProvider_report_volunteerresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Report_volunteerresult.xml"));//DbResourceProvider(); //  

        public static string reportparam
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("reportparam", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromdate
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string todate
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditedfromdate
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("auditedfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditedtodate
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("auditedtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string natselect
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("natselect", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string result
        {
            get
            {
                return resourceProvider_report_volunteerresult.GetResource("result", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
