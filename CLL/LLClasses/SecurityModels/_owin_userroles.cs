using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userroles : _Common
    {
         private static IResourceProvider resourceProvider_owin_userroles = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userroles.xml"));//DbResourceProvider(); //  
         
         
        public static string userrolesList
        {
            get
            {
                return resourceProvider_owin_userroles.GetResource("userrolesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userrolesCreate
        {
            get
            {
                return resourceProvider_owin_userroles.GetResource("userrolesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userrolesUpdate
        {
            get
            {
                return resourceProvider_owin_userroles.GetResource("userrolesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userrolesDetails
        {
            get
            {
                return resourceProvider_owin_userroles.GetResource("userrolesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
        
      
    }
}
