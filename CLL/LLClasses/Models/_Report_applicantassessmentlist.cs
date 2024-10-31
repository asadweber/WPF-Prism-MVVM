using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _Report_applicantassessmentlist : _Common
    {
        private static IResourceProvider resourceProvider_report_applicantlist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Report_applicantassessmentlist.xml"));//DbResourceProvider(); //  

        public static string fromdate
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string todate
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
