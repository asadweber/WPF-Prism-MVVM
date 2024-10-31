using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_certificatelevel : _Common
    {
        private static IResourceProvider resourceProvider_gen_certificatelevel = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_certificatelevel.xml"));//DbResourceProvider(); //  


        public static string certificatelevelList
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevelList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatelevelCreate
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevelCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatelevelUpdate
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevelUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatelevelDetails
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevelDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string certificatelevel
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificatelevelRequired
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificatelevelRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string certificateleveleng
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("certificateleveleng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationtypeid
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("educationtypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string displayorder
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("displayorder", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_certificatelevel.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
