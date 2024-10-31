using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CompanyTypeResponse : UseCaseResponseMessage
    {
        public gen_companytypeEntity _gen_CompanyType { get; }

        public IEnumerable<gen_companytypeEntity> _gen_CompanyTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CompanyTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CompanyTypeResponse(IEnumerable<gen_companytypeEntity> gen_CompanyTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CompanyTypeList = gen_CompanyTypeList;
        }
        
        public Gen_CompanyTypeResponse(gen_companytypeEntity gen_CompanyType, bool success = false, string message = null) : base(success, message)
        {
            _gen_CompanyType = gen_CompanyType;
        }

        public Gen_CompanyTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
