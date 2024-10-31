using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_news : _Common
    {
         private static IResourceProvider resourceProvider_gen_news = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_news.xml"));//DbResourceProvider(); //  
         
         
        public static string newsList
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newsCreate
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newsUpdate
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newsDetails
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string newscategoryid
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newscategoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newscategoryidRequired
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newscategoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newsheadlinear
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsheadlinear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newsheadlinearRequired
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsheadlinearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newsheadline
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsheadline", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newsdetailar
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsdetailar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newsdetailarRequired
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsdetailarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newsdetail
        {
            get
            {
                return resourceProvider_gen_news.GetResource("newsdetail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ispublished
        {
            get
            {
                return resourceProvider_gen_news.GetResource("ispublished", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string publisheddate
        {
            get
            {
                return resourceProvider_gen_news.GetResource("publisheddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string publishedby
        {
            get
            {
                return resourceProvider_gen_news.GetResource("publishedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreviewed
        {
            get
            {
                return resourceProvider_gen_news.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string revieweddate
        {
            get
            {
                return resourceProvider_gen_news.GetResource("revieweddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewedby
        {
            get
            {
                return resourceProvider_gen_news.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string showinticker
        {
            get
            {
                return resourceProvider_gen_news.GetResource("showinticker", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string showinscroller
        {
            get
            {
                return resourceProvider_gen_news.GetResource("showinscroller", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string showasmodal
        {
            get
            {
                return resourceProvider_gen_news.GetResource("showasmodal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
