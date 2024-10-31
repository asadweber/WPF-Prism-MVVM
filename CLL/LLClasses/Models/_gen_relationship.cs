using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_relationship : _Common
    {
         private static IResourceProvider resourceProvider_gen_relationship = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_relationship.xml"));//DbResourceProvider(); //  
         
         
        public static string relationshipList
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipCreate
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipUpdate
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipDetails
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string relationshipname
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipnameRequired
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
