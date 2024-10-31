using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_imagegallary : _Common
    {
         private static IResourceProvider resourceProvider_gen_imagegallary = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_imagegallary.xml"));//DbResourceProvider(); //  
         
         
        public static string imagegallaryList
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallaryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallaryCreate
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallaryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallaryUpdate
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallaryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallaryDetails
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallaryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string imagegallarycategoryid
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallarycategoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallarycategoryidRequired
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagegallarycategoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imagepath
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imagetype
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imageextension
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imageextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imagename
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("imagename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string headingtextar
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("headingtextar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string headingtext
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("headingtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bodytextar
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("bodytextar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bodytext
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("bodytext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isslider
        {
            get
            {
                return resourceProvider_gen_imagegallary.GetResource("isslider", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
