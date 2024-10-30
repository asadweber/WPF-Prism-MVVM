using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class RegisterUserExportImportResponse : UseCaseResponseMessage 
    {

        //public string Id { get; }
        public Error Errors { get; }

        public BDO.Core.DataAccessObjects.ExtendedEntities.AjaxResponse _ajaxresponse { get; }

        public string Response { get; }


		public List<kns_batchEntity> Batch { get; }

		public RegisterUserExportImportResponse( bool success=false, string message=null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public RegisterUserExportImportResponse(BDO.Core.DataAccessObjects.ExtendedEntities.AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }

        public RegisterUserExportImportResponse(string exportresponse, bool success = false, string message = null) : base(success, message)
        {
            Response = exportresponse;
            
        }

		public RegisterUserExportImportResponse(List<kns_batchEntity> batch, bool success = false, string message = null) : base(success, message)
		{
			Batch = batch;
		}


	}
}
