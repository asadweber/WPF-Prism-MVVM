using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _owin_forminfo : _Common
    {
         private static IResourceProvider resourceProvider_owin_forminfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_forminfo.xml"));//DbResourceProvider(); //  
         
         
        public static string forminfoList
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("forminfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string forminfoCreate
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("forminfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string forminfoUpdate
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("forminfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string forminfoDetails
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("forminfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string formname
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("formname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formnameRequired
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("formnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentid
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string levelid
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("levelid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string menulevel
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("menulevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formnamear
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("formnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hasdirectchild
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("hasdirectchild", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string icon
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("icon", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string classicon
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("classicon", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sequence
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("sequence", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string url
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("url", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isview
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("isview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isdynamic
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("isdynamic", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issuperadmin
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("issuperadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isvisibleinmenu
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("isvisibleinmenu", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string organizationkey
        {
            get
            {
                return resourceProvider_owin_forminfo.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
