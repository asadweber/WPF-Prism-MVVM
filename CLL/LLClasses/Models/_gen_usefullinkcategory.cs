using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_usefullinkcategory : _Common
    {
         private static IResourceProvider resourceProvider_gen_usefullinkcategory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_usefullinkcategory.xml"));//DbResourceProvider(); //  
         
         
        public static string usefullinkcategoryList
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryCreate
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryUpdate
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryDetails
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string usefullinkcategory
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategory", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryRequired
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkcategoryar
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryarRequired
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategoryarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkcategorydescription
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategorydescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkcategorydescriptionar
        {
            get
            {
                return resourceProvider_gen_usefullinkcategory.GetResource("usefullinkcategorydescriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
