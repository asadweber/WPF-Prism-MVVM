using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_emergencycontactinfo : _Common
    {
         private static IResourceProvider resourceProvider_reg_emergencycontactinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_emergencycontactinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string emergencycontactinfoList
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("emergencycontactinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactinfoCreate
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("emergencycontactinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactinfoUpdate
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("emergencycontactinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactinfoDetails
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("emergencycontactinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyid
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("familyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name1Required
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name2Required
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name3
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name4
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name5
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("name5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobile1
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("mobile1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobile2
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("mobile2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephone1
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("telephone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephone2
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("telephone2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobile1Required
        {
            get
            {
                return resourceProvider_reg_emergencycontactinfo.GetResource("mobile1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        

    }
}
