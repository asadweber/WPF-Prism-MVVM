using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userrole : _Common
    {
         private static IResourceProvider resourceProvider_owin_userrole = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userrole.xml"));//DbResourceProvider(); //  
         
         
        public static string userroleList
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("userroleList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleCreate
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("userroleCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleUpdate
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("userroleUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleDetails
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("userroleDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string roleid
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isenable
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("isenable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isenableRequired
        {
            get
            {
                return resourceProvider_owin_userrole.GetResource("isenableRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
