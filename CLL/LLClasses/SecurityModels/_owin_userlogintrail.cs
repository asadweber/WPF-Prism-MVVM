using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userlogintrail : _Common
    {
         private static IResourceProvider resourceProvider_owin_userlogintrail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userlogintrail.xml"));//DbResourceProvider(); //  
         
         
        public static string userlogintrailList
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("userlogintrailList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userlogintrailCreate
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("userlogintrailCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userlogintrailUpdate
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("userlogintrailUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userlogintrailDetails
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("userlogintrailDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string loginfrom
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("loginfrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logindate
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("logindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logoutdate
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("logoutdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string machineip
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("machineip", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string loginstatus
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("loginstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string loginstatusbit
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("loginstatusbit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sessionid
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("sessionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usertoken
        {
            get
            {
                return resourceProvider_owin_userlogintrail.GetResource("usertoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
