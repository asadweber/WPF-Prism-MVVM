using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_LoginResponse : UseCaseResponseMessage
    {
        public tran_loginEntity _tran_Login { get; }

        public IEnumerable<tran_loginEntity> _tran_LoginList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_LoginResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_LoginResponse(IEnumerable<tran_loginEntity> tran_LoginList, bool success = false, string message = null) : base(success, message)
        {
            _tran_LoginList = tran_LoginList;
        }
        
        public Tran_LoginResponse(tran_loginEntity tran_Login, bool success = false, string message = null) : base(success, message)
        {
            _tran_Login = tran_Login;
        }

        public Tran_LoginResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
