using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_faqcategory : _Common
    {
         private static IResourceProvider resourceProvider_gen_faqcategory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_faqcategory.xml"));//DbResourceProvider(); //  
         
         
        public static string faqcategoryList
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string faqcategoryCreate
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string faqcategoryUpdate
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string faqcategoryDetails
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string faqcategory
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategory", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string faqcategoryRequired
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string faqcategoryen
        {
            get
            {
                return resourceProvider_gen_faqcategory.GetResource("faqcategoryen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
