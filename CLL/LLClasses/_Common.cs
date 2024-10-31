using CLL.Abstract;
using System;
using System.Globalization;
using System.IO;

namespace CLL.LLClasses
{
    public class _Common
    {
        private static IResourceProvider resourceProvidercommon = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_CommonHtml_resource.xml"));//DbResourceProvider(); //  
        public static string CheckCivilIdDialog
        {
            get
            {
                return resourceProvidercommon.GetResource("CheckCivilIdDialog", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string CheckCivilIdMessage
        {
            get
            {
                return resourceProvidercommon.GetResource("CheckCivilIdMessage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string createddate
        {
            get
            {
                return resourceProvidercommon.GetResource("createddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string reviewed
        {
            get
            {
                return resourceProvidercommon.GetResource("reviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string published
        {
            get
            {
                return resourceProvidercommon.GetResource("published", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string archieved
        {
            get
            {
                return resourceProvidercommon.GetResource("archieved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string searchText
        {
            get
            {
                return resourceProvidercommon.GetResource("searchText", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string searchContent
        {
            get
            {
                return resourceProvidercommon.GetResource("searchContent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string dateTo
        {
            get
            {
                return resourceProvidercommon.GetResource("dateTo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string dateFrom
        {
            get
            {
                return resourceProvidercommon.GetResource("dateFrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string date
        {
            get
            {
                return resourceProvidercommon.GetResource("date", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string dateFor
        {
            get
            {
                return resourceProvidercommon.GetResource("dateFor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string userType
        {
            get
            {
                return resourceProvidercommon.GetResource("userType", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _listAction
        {
            get
            {
                return resourceProvidercommon.GetResource("_listAction", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string isreviewed
        {
            get
            {
                return resourceProvidercommon.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedby
        {
            get
            {
                return resourceProvidercommon.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedbyusername
        {
            get
            {
                return resourceProvidercommon.GetResource("reviewedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedcomment
        {
            get
            {
                return resourceProvidercommon.GetResource("reviewedcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string bypublishdatetop10
        {
            get
            {
                return resourceProvidercommon.GetResource("bypublishdatetop10", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string revieweddate
        {
            get
            {
                return resourceProvidercommon.GetResource("revieweddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ispublished
        {
            get
            {
                return resourceProvidercommon.GetResource("ispublished", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string publishedby
        {
            get
            {
                return resourceProvidercommon.GetResource("publishedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string publishedbyusername
        {
            get
            {
                return resourceProvidercommon.GetResource("publishedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string publishedcomment
        {
            get
            {
                return resourceProvidercommon.GetResource("publishedcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string publisheddate
        {
            get
            {
                return resourceProvidercommon.GetResource("publisheddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isarchived
        {
            get
            {
                return resourceProvidercommon.GetResource("isarchived", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string archivedate
        {
            get
            {
                return resourceProvidercommon.GetResource("archivedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string archivedby
        {
            get
            {
                return resourceProvidercommon.GetResource("archivedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string archivedbyusername
        {
            get
            {
                return resourceProvidercommon.GetResource("archivedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string archivedcomment
        {
            get
            {
                return resourceProvidercommon.GetResource("archivedcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string btnpublish
        {
            get
            {
                return resourceProvidercommon.GetResource("btnpublish", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string btnreview
        {
            get
            {
                return resourceProvidercommon.GetResource("btnreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string btnarchive
        {
            get
            {
                return resourceProvidercommon.GetResource("btnarchive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string comment
        {
            get
            {
                return resourceProvidercommon.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string by
        {
            get
            {
                return resourceProvidercommon.GetResource("by", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string add
        {
            get
            {
                return resourceProvidercommon.GetResource("add", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string pleaseselect
        {
            get
            {
                return resourceProvidercommon.GetResource("pleaseselect", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string yes
        {
            get
            {
                return resourceProvidercommon.GetResource("yes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string no
        {
            get
            {
                return resourceProvidercommon.GetResource("no", CultureInfo.CurrentUICulture.Name) as String;
            }
        }



        public static string createdby
        {
            get
            {
                return resourceProvidercommon.GetResource("createdby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updatedby
        {
            get
            {
                return resourceProvidercommon.GetResource("updatedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string searchprofilesummary
        {
            get
            {
                return resourceProvidercommon.GetResource("searchprofilesummary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string updateddate
        {
            get
            {
                return resourceProvidercommon.GetResource("updateddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string archiveddate
        {
            get
            {
                return resourceProvidercommon.GetResource("archiveddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newspublishdate
        {
            get
            {
                return resourceProvidercommon.GetResource("newspublishdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string eventdate
        {
            get
            {
                return resourceProvidercommon.GetResource("eventdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string publicationdate
        {
            get
            {
                return resourceProvidercommon.GetResource("publicationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _content
        {
            get
            {
                return resourceProvidercommon.GetResource("_content", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _yearFrom
        {
            get
            {
                return resourceProvidercommon.GetResource("_yearFrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _yearTo
        {
            get
            {
                return resourceProvidercommon.GetResource("_yearTo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _ascending
        {
            get
            {
                return resourceProvidercommon.GetResource("_ascending", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _descending
        {
            get
            {
                return resourceProvidercommon.GetResource("_descending", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _overview
        {
            get
            {
                return resourceProvidercommon.GetResource("_overview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _category
        {
            get
            {
                return resourceProvidercommon.GetResource("_category", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _title
        {
            get
            {
                return resourceProvidercommon.GetResource("_title", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _titleAdminPanel
        {
            get
            {
                return resourceProvidercommon.GetResource("_titleAdminPanel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _homePageTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_homePageTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _welcometext
        {
            get
            {
                return resourceProvidercommon.GetResource("_welcometext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _welcomePara
        {
            get
            {
                return resourceProvidercommon.GetResource("_welcomePara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _visiontext
        {
            get
            {
                return resourceProvidercommon.GetResource("_visiontext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _visionPara
        {
            get
            {
                return resourceProvidercommon.GetResource("_visionPara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _telephone
        {
            get
            {
                return resourceProvidercommon.GetResource("_telephone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _fax
        {
            get
            {
                return resourceProvidercommon.GetResource("_fax", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _contactUs
        {
            get
            {
                return resourceProvidercommon.GetResource("_contactUs", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _ourFacilities
        {
            get
            {
                return resourceProvidercommon.GetResource("_ourFacilities", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _ourEvents
        {
            get
            {
                return resourceProvidercommon.GetResource("_ourEvents", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _headerText
        {
            get
            {
                return resourceProvidercommon.GetResource("_headerText", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _firstName
        {
            get
            {
                return resourceProvidercommon.GetResource("_firstName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _fullname
        {
            get
            {
                return resourceProvidercommon.GetResource("_fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _fullnameRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _middleName
        {
            get
            {
                return resourceProvidercommon.GetResource("_middleName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _lastName
        {
            get
            {
                return resourceProvidercommon.GetResource("_lastName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _mobileNo
        {
            get
            {
                return resourceProvidercommon.GetResource("_mobileNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _email
        {
            get
            {
                return resourceProvidercommon.GetResource("_email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _emailRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_emailRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _subject
        {
            get
            {
                return resourceProvidercommon.GetResource("_subject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _subjectRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_subjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _message
        {
            get
            {
                return resourceProvidercommon.GetResource("_message", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _messageRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_messageRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _moreOption
        {
            get
            {
                return resourceProvidercommon.GetResource("_moreOption", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _viewMore
        {
            get
            {
                return resourceProvidercommon.GetResource("_viewMore", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string _uploadfiles
        {
            get
            {
                return resourceProvidercommon.GetResource("_uploadfiles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _btnDelete
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnOK
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnOK", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _chooseFile
        {
            get
            {
                return resourceProvidercommon.GetResource("_chooseFile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _print
        {
            get
            {
                return resourceProvidercommon.GetResource("_print", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
