using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_phases : _Common
    {
         private static IResourceProvider resourceProvider_gen_phases = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_phases.xml"));//DbResourceProvider(); //  
         
         
        public static string phasesList
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phasesCreate
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phasesUpdate
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phasesDetails
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string phasename
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string phasenameRequired
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentid
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string phasedescription
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("phasedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_phases.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
