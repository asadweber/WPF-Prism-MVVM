using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_relativesworkinginmod : _Common
    {
         private static IResourceProvider resourceProvider_reg_relativesworkinginmod = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_relativesworkinginmod.xml"));//DbResourceProvider(); //  
         
         
        public static string relativesworkinginmodList
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativesworkinginmodList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relativesworkinginmodCreate
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativesworkinginmodCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relativesworkinginmodUpdate
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativesworkinginmodUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relativesworkinginmodDetails
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativesworkinginmodDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imergencycontactid
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("imergencycontactid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imergencycontactidRequired
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("imergencycontactidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relativemilorempno
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativemilorempno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relativeentitykey
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativeentitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relativeworkdesignation
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativeworkdesignation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relativeworkdesignationRequired
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativeworkdesignationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relativecivilid
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativecivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relativemobile1
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("relativemobile1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_relativesworkinginmod.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
