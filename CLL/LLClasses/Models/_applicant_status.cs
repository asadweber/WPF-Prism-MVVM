using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _applicant_status : _Common
    {
        private static IResourceProvider resourceProvider_applicant_status = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_applicant_status.xml"));//DbResourceProvider(); //  

        public static string RegistrationInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("RegistrationInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string NotificationInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("NotificationInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string AuditInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("AuditInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SecurityInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("SecurityInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string UnitClearanceInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("UnitClearanceInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string MedExamInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("MedExamInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string PsychoExamInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("PsychoExamInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FinalExamInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("FinalExamInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string TrgJoinInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("TrgJoinInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SpecialRegistrationInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("SpecialRegistrationInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ApplyAnotherBatchInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("ApplyAnotherBatchInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationsendby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("notificationsendby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationsenddt
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("notificationsenddt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string interviewdt
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("interviewdt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("auditedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string currentphase
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("currentphase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string currentstatus
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("currentstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexaminedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("syexaminedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("unitclearanceby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexaminedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("medexaminedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexaminedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("psychoexaminedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamexaminedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("finalexamexaminedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trgjoinstatus
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("trgjoinstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trgjoinedby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("trgjoinedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string specialregistrationby
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("specialregistrationby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string specialregistrationdt
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("specialregistrationdt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applyanotherbatchdt
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("applyanotherbatchdt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationdt
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("registrationdt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volsyclearanceapprovalinfo
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("volsyclearanceapprovalinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunitclearanceapprovalinfo
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("volunitclearanceapprovalinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volmedclearanceapprovalinfo
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("volmedclearanceapprovalinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SyExamNotificationInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("SyExamNotificationInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string MedExamNotificationInfoHr
        {
            get
            {
                return resourceProvider_applicant_status.GetResource("MedExamNotificationInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
