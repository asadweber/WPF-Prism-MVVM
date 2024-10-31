using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_notificationconfigdetl : _Common
    {
         private static IResourceProvider resourceProvider_cnf_notificationconfigdetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_notificationconfigdetl.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationconfigdetlList
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigdetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigdetlCreate
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigdetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigdetlUpdate
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigdetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigdetlDetails
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigdetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string notificationconfigid
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationconfigidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationconfigidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phaseid
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("phaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phaseidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("phaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusid
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeid
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationtypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationtypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationtemplateid
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationtemplateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtemplateidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("notificationtemplateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string templateshortname
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("templateshortname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_cnf_notificationconfigdetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
      
    }
}