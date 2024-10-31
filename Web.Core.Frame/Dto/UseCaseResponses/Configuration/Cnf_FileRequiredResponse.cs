using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_FileRequiredResponse : UseCaseResponseMessage
    {
        public cnf_filerequiredEntity _cnf_FileRequired { get; }

        public IEnumerable<cnf_filerequiredEntity> _cnf_FileRequiredList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_FileRequiredResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_FileRequiredResponse(IEnumerable<cnf_filerequiredEntity> cnf_FileRequiredList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_FileRequiredList = cnf_FileRequiredList;
        }

        public Cnf_FileRequiredResponse(cnf_filerequiredEntity cnf_FileRequired, bool success = false, string message = null) : base(success, message)
        {
            _cnf_FileRequired = cnf_FileRequired;
        }

        public Cnf_FileRequiredResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
