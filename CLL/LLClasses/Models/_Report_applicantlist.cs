using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _Report_applicantlist : _Common
    {
        private static IResourceProvider resourceProvider_report_applicantlist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Report_applicantlist.xml"));//DbResourceProvider(); //  

        public static string phase
        {
            get
            {
                return resourceProvider_report_applicantlist.GetResource("phase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
    }
}
