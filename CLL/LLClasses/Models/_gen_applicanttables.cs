using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_applicanttables : _Common
    {
         private static IResourceProvider resourceProvider_gen_applicanttables = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_applicanttables.xml"));//DbResourceProvider(); //  
         
         
        public static string applicanttablesList
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttablesCreate
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttablesUpdate
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttablesDetails
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string applicanttablename
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttablenameRequired
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("applicanttablenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tabledescription
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("tabledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string dataorder
        {
            get
            {
                return resourceProvider_gen_applicanttables.GetResource("dataorder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
