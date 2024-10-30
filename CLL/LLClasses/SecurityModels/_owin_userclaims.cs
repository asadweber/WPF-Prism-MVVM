using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userclaims : _Common
    {
         private static IResourceProvider resourceProvider_owin_userclaims = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userclaims.xml"));//DbResourceProvider(); //  
         
         
        public static string userclaimsList
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("userclaimsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userclaimsCreate
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("userclaimsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userclaimsUpdate
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("userclaimsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userclaimsDetails
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("userclaimsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string claimtype
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("claimtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string claimvalue
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("claimvalue", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userclaims.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
