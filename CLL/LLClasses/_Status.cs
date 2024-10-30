using CLL.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CLL.LLClasses
{
    public class _Status
    {
        private static IResourceProvider resourceProviderstatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_Status.xml"));//DbResourceProvider(); //  


        public static string _statusFailed
        {
            get
            {
                return resourceProviderstatus.GetResource("_statusFailed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _statusSuccess
        {
            get
            {
                return resourceProviderstatus.GetResource("_statusSuccess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _titleInvalidData
        {
            get
            {
                return resourceProviderstatus.GetResource("_titleInvalidData", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _titleGenericError
        {
            get
            {
                return resourceProviderstatus.GetResource("_titleGenericError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _titleInformation
        {
            get
            {
                return resourceProviderstatus.GetResource("_titleInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _titleUnAuthorizedUser
        {
            get
            {
                return resourceProviderstatus.GetResource("_titleUnAuthorizedUser", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
