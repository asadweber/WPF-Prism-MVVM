using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_previousexperiance : _Common
    {
         private static IResourceProvider resourceProvider_reg_previousexperiance = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_previousexperiance.xml"));//DbResourceProvider(); //  
         
         
        public static string previousexperianceList
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("previousexperianceList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string previousexperianceCreate
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("previousexperianceCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string previousexperianceUpdate
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("previousexperianceUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string previousexperianceDetails
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("previousexperianceDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companytypeid
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("companytypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeidRequired
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("companytypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyid
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyname
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("companyname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companynameRequired
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("companynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string designation
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("designation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string designationRequired
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("designationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromdate
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromdateRequired
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("fromdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string todate
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_previousexperiance.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
