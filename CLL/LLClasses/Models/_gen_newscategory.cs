using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_newscategory : _Common
    {
         private static IResourceProvider resourceProvider_gen_newscategory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_newscategory.xml"));//DbResourceProvider(); //  
         
         
        public static string newscategoryList
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newscategoryCreate
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newscategoryUpdate
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newscategoryDetails
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string newscategoryar
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newscategoryarRequired
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategoryarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newscategory
        {
            get
            {
                return resourceProvider_gen_newscategory.GetResource("newscategory", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
