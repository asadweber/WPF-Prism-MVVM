using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_imagegallarycategory : _Common
    {
         private static IResourceProvider resourceProvider_gen_imagegallarycategory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_imagegallarycategory.xml"));//DbResourceProvider(); //  
         
         
        public static string imagegallarycategoryList
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallarycategoryCreate
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallarycategoryUpdate
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallarycategoryDetails
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string imagegallarycategory
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategory", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagegallarycategoryRequired
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("imagegallarycategoryRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptions
        {
            get
            {
                return resourceProvider_gen_imagegallarycategory.GetResource("descriptions", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
