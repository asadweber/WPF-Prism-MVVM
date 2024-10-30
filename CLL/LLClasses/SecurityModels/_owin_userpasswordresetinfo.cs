using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userpasswordresetinfo : _Common
    {
         private static IResourceProvider resourceProvider_owin_userpasswordresetinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userpasswordresetinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string userpasswordresetinfoList
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("userpasswordresetinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userpasswordresetinfoCreate
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("userpasswordresetinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userpasswordresetinfoUpdate
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("userpasswordresetinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userpasswordresetinfoDetails
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("userpasswordresetinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string sessionid
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("sessionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sessionidRequired
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("sessionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sessiontoken
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("sessiontoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sessiontokenRequired
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("sessiontokenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string username
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("username", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactiveRequired
        {
            get
            {
                return resourceProvider_owin_userpasswordresetinfo.GetResource("isactiveRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
