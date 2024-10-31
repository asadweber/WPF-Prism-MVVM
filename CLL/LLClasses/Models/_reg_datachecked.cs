using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_datachecked : _Common
    {
         private static IResourceProvider resourceProvider_reg_datachecked = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_datachecked.xml"));//DbResourceProvider(); //  
         
         
        public static string datacheckedList
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("datacheckedList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string datacheckedCreate
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("datacheckedCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string datacheckedUpdate
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("datacheckedUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string datacheckedDetails
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("datacheckedDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoviewid
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("basicinfoviewid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicanttableid
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("applicanttableid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttableidRequired
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("applicanttableidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewedbyid
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("reviewedbyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vieweddate
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("vieweddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ischecked
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("ischecked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_datachecked.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
