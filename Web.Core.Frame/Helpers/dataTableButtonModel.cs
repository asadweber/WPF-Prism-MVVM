using AppConfig.EncryptionHandler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization.Json;
using System.Text;
using static AppConfig.HelperClasses.applicationEnamNConstants;

namespace AppConfig.HelperClasses
{
    public class dataTableButtonModel
    {
        protected basicCRUDButtons _btnid;
        protected string _btnname;
        protected string _btnmethodname;
        protected string _btnicon;
        protected string _btnclass;
        private bool _isCheckPermission = true;
        private string _jsMethodName;

        public bool isCheckPermission { get => _isCheckPermission; set => _isCheckPermission = value; }

        public string JsMethodName { get => _jsMethodName; set => _jsMethodName = value; }

        public dataTableButtonModel(basicCRUDButtons? actions, string btnname = null, string btnmethodname = null, string btnicon = null)
        {
            if (actions != null)
            {
                if (actions != basicCRUDButtons.CUSTOM)
                {
                    _btnid = actions.Value;
                    OnChnaged();
                }
                else
                {
                    _btnname = btnname;
                    _btnicon = "<i class='" + _btnicon + "'></i>";
                    _btnid = actions.Value;
                    _btnclass = "btn btn-primary btn-md m-1";
                    _btnmethodname = btnmethodname;
                }
            }
        }
        public basicCRUDButtons btnid
        {
            get { return _btnid; }
            set { _btnid = value; }
        }
        private void OnChnaged()
        {
            var rm = new ResourceManager(typeof(CLL.Localization.SharedResource));
            _btnname = string.IsNullOrEmpty(_btnname) == true ? rm.GetString(((basicCRUDButtons)_btnid).ToString(), CultureInfo.CurrentUICulture) : _btnname;
            string[] arr = ((basicCRUDButtons)_btnid).ToString().Split('_');
            _btnmethodname = arr.Length > 0 ? (string.IsNullOrEmpty(_btnmethodname) == true ? "{controllername}/" + arr[0] + "{controllername}" : _btnmethodname) : _btnmethodname;
            switch (_btnid)
            {
                case basicCRUDButtons.New_GET: _btnicon = "<i class='fas fa-plus-square'></i>"; _btnclass = "btn btn-primary btn-md m-1"; break;
                case basicCRUDButtons.Edit_GET: _btnicon = "<i class='fas fa-edit'></i>"; _btnclass = "btn btn-secondary btn-md m-1"; break;
                case basicCRUDButtons.Delete_GET: _btnicon = "<i class='fas fa-trash-alt'></i>"; _btnclass = "btn btn-danger btn-md m-1"; break;
                case basicCRUDButtons.GetSingle_GET: _btnicon = "<i class='fas fa-eye'></i>"; _btnclass = "btn btn-info btn-md m-1"; break;
                case basicCRUDButtons.Search_GET: _btnicon = "<i class='fas fa-search'></i>"; _btnclass = "btn btn-info btn-md m-1"; break;
                case basicCRUDButtons.New_POST: _btnicon = "<i class='fas fa-save'></i>"; _btnclass = "btn btn-primary btn-md m-1"; break;
                case basicCRUDButtons.Process_GET: _btnicon = "<i class='fas fa-cogs'></i>"; _btnclass = "btn btn-primary btn-md m-1"; break;
                case basicCRUDButtons.Submit_POST: _btnicon = "<i class='fas fa-sign-in-alt'></i>"; _btnclass = "btn btn-primary btn-md m-1"; break;
                default: _btnicon = "<i class='" + _btnicon + "'></i>"; _btnclass = "btn btn-primary btn-md mr-1"; break;
            }
        }

        public string btnname
        {
            get { return _btnname; }
        }
        public string btnmethodname
        {
            get { return _btnmethodname; }
        }
        public string btnicon
        {
            get { return _btnicon; }
        }
        public string btnclass
        {
            get { return _btnclass; }
        }
    }
}
