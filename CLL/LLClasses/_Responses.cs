using CLL.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CLL.LLClasses
{
    public class _Responses
    {
        private static IResourceProvider resourceProviderrsponse = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Responses.xml"));//DbResourceProvider(); //  

        public static string _resforgetPasswordReply
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resforgetPasswordReply", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resinvalidCredential
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resinvalidCredential", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resloginSuccess
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resloginSuccess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resgeneralErrorInformation
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resgeneralErrorInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resmodelStateInvalidInformation
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resmodelStateInvalidInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resbadRequest
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resbadRequest", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resinvalidUser
        {
            get
            {
                return resourceProviderrsponse.GetResource("_resinvalidUser", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
