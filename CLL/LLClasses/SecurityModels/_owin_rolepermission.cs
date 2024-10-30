using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_rolepermission : _Common
    {
         private static IResourceProvider resourceProvider_owin_rolepermission = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_rolepermission.xml"));//DbResourceProvider(); //  
         
         
        public static string rolepermissionList
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("rolepermissionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rolepermissionCreate
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("rolepermissionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rolepermissionUpdate
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("rolepermissionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rolepermissionDetails
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("rolepermissionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string roleid
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formactionid
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("formactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionidRequired
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("formactionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string status
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("status", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusRequired
        {
            get
            {
                return resourceProvider_owin_rolepermission.GetResource("statusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
