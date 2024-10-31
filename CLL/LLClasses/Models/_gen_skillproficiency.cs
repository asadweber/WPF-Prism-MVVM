using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_skillproficiency : _Common
    {
         private static IResourceProvider resourceProvider_gen_skillproficiency = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_skillproficiency.xml"));//DbResourceProvider(); //  
         
         
        public static string skillproficiencyList
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillproficiencyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string skillproficiencyCreate
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillproficiencyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string skillproficiencyUpdate
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillproficiencyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string skillproficiencyDetails
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillproficiencyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string skillname
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string skillnameRequired
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string skillvalue
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillvalue", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string skillvalueRequired
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("skillvalueRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_skillproficiency.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
