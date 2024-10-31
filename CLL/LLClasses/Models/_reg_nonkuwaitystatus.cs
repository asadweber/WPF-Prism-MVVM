using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_nonkuwaitystatus : _Common
    {
         private static IResourceProvider resourceProvider_reg_nonkuwaitystatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_nonkuwaitystatus.xml"));//DbResourceProvider(); //  
         
         
        public static string nonkuwaitystatusList
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusCreate
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusUpdate
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusDetails
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string nonkuwaitystatusid
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusidRequired
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("nonkuwaitystatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilid
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyid
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("familyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyidRequired
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("familyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_nonkuwaitystatus.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
