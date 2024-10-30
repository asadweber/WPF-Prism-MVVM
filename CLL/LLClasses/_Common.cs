using CLL.Abstract;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace CLL.LLClasses
{
    public class _Common
    {
        private static IResourceProvider resourceProvidercommon = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Common.xml"));//DbResourceProvider(); //  
        public static string _btnSave
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSave", CultureInfo.CurrentUICulture.Name) as string;
            }
        }
        public static string LanguageToggle
        {
            get
            {
                return resourceProvidercommon.GetResource("_languageToggle", CultureInfo.CurrentUICulture.Name) as string;
            }
        }

    }
}
