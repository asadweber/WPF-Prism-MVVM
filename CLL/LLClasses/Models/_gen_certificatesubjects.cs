using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_certificatesubjects : _Common
    {
         private static IResourceProvider resourceProvider_gen_certificatesubjects = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_certificatesubjects.xml"));//DbResourceProvider(); //  
         
         
        public static string certificatesubjectsList
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatesubjectsCreate
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatesubjectsUpdate
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatesubjectsDetails
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string certificateid
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateidRequired
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificatesubjectname
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatesubjectnameRequired
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("certificatesubjectnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string years
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("years", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orclcertid
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("orclcertid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oraclecertificatelevel
        {
            get
            {
                return resourceProvider_gen_certificatesubjects.GetResource("oraclecertificatelevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
