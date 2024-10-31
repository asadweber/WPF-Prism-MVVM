using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CompaniesResponse : UseCaseResponseMessage
    {
        public gen_companiesEntity _gen_Companies { get; }

        public IEnumerable<gen_companiesEntity> _gen_CompaniesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CompaniesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CompaniesResponse(IEnumerable<gen_companiesEntity> gen_CompaniesList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CompaniesList = gen_CompaniesList;
        }
        
        public Gen_CompaniesResponse(gen_companiesEntity gen_Companies, bool success = false, string message = null) : base(success, message)
        {
            _gen_Companies = gen_Companies;
        }

        public Gen_CompaniesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
