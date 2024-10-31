using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _stp_organizationentity : _Common
    {
         private static IResourceProvider resourceProvider_stp_organizationentity = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_stp_organizationentity.xml"));//DbResourceProvider(); //  
         
         
        public static string organizationentityList
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityCreate
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityUpdate
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityDetails
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string organizationkey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationkeyRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentkey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("parentkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entirytypekey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entirytypekey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entirytypekeyRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entirytypekeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylevel
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitylevelRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylevelRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string seqfirstindex
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("seqfirstindex", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string seqfullindex
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("seqfullindex", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitycpde
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitycpde", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitytname
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitytname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitytnameRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitytnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
