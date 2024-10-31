using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_certificatetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_certificatetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_certificatetype.xml"));//DbResourceProvider(); //  
         
         
        public static string certificatetypeList
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatetypeCreate
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatetypeUpdate
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatetypeDetails
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string certificatetype
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatetypeRequired
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatetypeeng
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("certificatetypeeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_certificatetype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
