using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _applicant_review : _Common
    {
        private static IResourceProvider resourceProvider_applicant_review = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_applicant_review.xml"));//DbResourceProvider(); //  

        public static string interviewfromdate
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("interviewfromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string interviewtodate
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("interviewtodate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string interviewdate
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("interviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string email
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttablename
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("applicanttablename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicanttabledescription
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("applicanttabledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedbyusername
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("reviewedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantinformation
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("applicantinformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantreviewedconfirmation
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("applicantreviewedconfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantreviewercomment
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("applicantreviewercomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string birthcountryname
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("birthcountryname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroup
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("bloodgroup", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionname
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("religionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsSendDate
        {
            get
            {
                return resourceProvider_applicant_review.GetResource("smsSendDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
