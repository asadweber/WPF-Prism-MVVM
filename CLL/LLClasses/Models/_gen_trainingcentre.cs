using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_trainingcentre : _Common
    {
         private static IResourceProvider resourceProvider_gen_trainingcentre = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_trainingcentre.xml"));//DbResourceProvider(); //  
         
         
        public static string trainingcentreList
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentreList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingcentreCreate
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentreCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingcentreUpdate
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentreUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingcentreDetails
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentreDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string trainingcentrename
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentrename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingcentrenameRequired
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentrenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string trainingcentrenameeng
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("trainingcentrenameeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string migrationinfo
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("migrationinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string migrationtable
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("migrationtable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string migrationtext
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("migrationtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
		public static string GEN_TRAININGCENTREY_LIST
		{
			get
			{
				return resourceProvider_gen_trainingcentre.GetResource("GEN_TRAININGCENTREY_LIST", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

        public static string ADD_GEN_TRAININGCENTRE
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("ADD_GEN_TRAININGCENTRE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string EDIT_GEN_TRAININGCENTRE
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("EDIT_GEN_TRAININGCENTRE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string DELETE_GEN_TRAININGCENTRE
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("DELETE_GEN_TRAININGCENTRE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string GEN_TRAININGCENTRE
        {
            get
            {
                return resourceProvider_gen_trainingcentre.GetResource("GEN_TRAININGCENTRE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
