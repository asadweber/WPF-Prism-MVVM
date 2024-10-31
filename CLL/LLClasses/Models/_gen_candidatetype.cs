using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_candidatetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_candidatetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_candidatetype.xml"));//DbResourceProvider(); //  
         
         
        public static string candidatetypeList
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeCreate
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeUpdate
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeDetails
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string candidatetypename
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypenameRequired
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("candidatetypenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_candidatetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
      
    }
}
