using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using BDO.CustomAnnotation;
using System.Collections.Generic;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_notificationfileEntity : BaseEntity
    {
        #region Properties

        protected IFormFile? _file;

        [DataMember]
        [AllowedExtensions(new string[] { ".xls", ".xlsx" })]
        public IFormFile? file
        {
            get { return _file; }
            set { _file = value; }
        }


        #endregion

        #region Constructor

        #endregion
        
    }
}