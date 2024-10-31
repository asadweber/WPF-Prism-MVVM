using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_ExportProfileResponse : UseCaseResponseMessage
    {
        public tran_exportprofileEntity _tran_ExportProfile { get; }

        public IEnumerable<tran_exportprofileEntity> _tran_ExportProfileList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_ExportProfileResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_ExportProfileResponse(IEnumerable<tran_exportprofileEntity> tran_ExportProfileList, bool success = false, string message = null) : base(success, message)
        {
            _tran_ExportProfileList = tran_ExportProfileList;
        }

        public Tran_ExportProfileResponse(tran_exportprofileEntity tran_ExportProfile, bool success = false, string message = null) : base(success, message)
        {
            _tran_ExportProfile = tran_ExportProfile;
        }

        public Tran_ExportProfileResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
