using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_notificationtemplet : _Common
    {
         private static IResourceProvider resourceProvider_cnf_notificationtemplet = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_notificationtemplet.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationtempletList
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("notificationtempletList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtempletCreate
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("notificationtempletCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtempletUpdate
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("notificationtempletUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtempletDetails
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("notificationtempletDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string templettypeid
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templettypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtemplateid
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("notificationtemplateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string templettypeidRequired
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templettypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string templateshortname
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templateshortname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string templateshortnameRequired
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templateshortnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string templatemsg
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templatemsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string templatemsgRequired
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("templatemsgRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tempaltesubject
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("tempaltesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tempaltesubjectRequired
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("tempaltesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_notificationtemplet.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}