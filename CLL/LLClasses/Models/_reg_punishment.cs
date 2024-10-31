using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_punishment : _Common
    {
         private static IResourceProvider resourceProvider_reg_punishment = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_punishment.xml"));//DbResourceProvider(); //  
         
         
        public static string punishmentList
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentCreate
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentUpdate
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentDetails
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmentreason
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentreason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentreasonRequired
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentreasonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmentdetails
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentdetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentdetailsRequired
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentdetailsRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmentdate
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentdateRequired
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmentdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmenttodate
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("punishmenttodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_punishment.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
