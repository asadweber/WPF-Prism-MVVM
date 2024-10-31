using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_notificationconfig : _Common
    {
         private static IResourceProvider resourceProvider_cnf_notificationconfig = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_notificationconfig.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationconfigList
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("notificationconfigList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigCreate
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("notificationconfigCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigUpdate
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("notificationconfigUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigDetails
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("notificationconfigDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string phaseid
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("phaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phaseidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("phaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusid
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_notificationconfig.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
