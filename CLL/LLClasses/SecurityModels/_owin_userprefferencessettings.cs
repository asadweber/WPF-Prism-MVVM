using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userprefferencessettings : _Common
    {
         private static IResourceProvider resourceProvider_owin_userprefferencessettings = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userprefferencessettings.xml"));//DbResourceProvider(); //  
         
         
        public static string userprefferencessettingsList
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("userprefferencessettingsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userprefferencessettingsCreate
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("userprefferencessettingsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userprefferencessettingsUpdate
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("userprefferencessettingsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userprefferencessettingsDetails
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("userprefferencessettingsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string appformid
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("appformid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string appformidRequired
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("appformidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prepagesize
        {
            get
            {
                return resourceProvider_owin_userprefferencessettings.GetResource("prepagesize", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
