using KAF.Model.Lang.Abstract;
using System.Globalization;
using System.IO;

namespace KAF.Model.Lang.LLClasses
{
    public static class _Common
    {
        private static IResourceProvider resourceProvidercommon = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Common.xml"));//DbResourceProvider(); //  
        public static string _btnSave
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSave", CultureInfo.CurrentUICulture.Name) as string;
            }
        }

    }
}
