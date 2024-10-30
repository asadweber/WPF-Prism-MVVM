using BDO.Core.DataAccessObjects.SecurityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class MenuWiseForm
    {
        public long? appformid { get; set; }
        public string formname { get; set; }
        public IEnumerable<FormWiseAction> formList { get; set; }
    }
    public class FormWiseAction
    {

        // public long? menuid { get; set; }
        public long? appformid { get; set; }
        public string formname { get; set; }
        public IEnumerable<FormAction> formActionList { get; set; }
    }

    public class FormAction
    {
        public long? rolepremissionid { get; set; }
        public long? formactionid { get; set; }
        public string actionname { get; set; }
        public bool? isview { get; set; }
        public string action { get; set; }
    }
    public class RoleWithPermission
    {
        public owin_roleEntity RoleEntity { get; set; }
        public IEnumerable<owin_rolepermissionEntity> RolePermissionList { get; set; }
    }
}
