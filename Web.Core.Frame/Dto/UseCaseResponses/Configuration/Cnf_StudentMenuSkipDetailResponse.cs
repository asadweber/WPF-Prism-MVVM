using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_StudentMenuSkipDetailResponse : UseCaseResponseMessage
    {
        public cnf_studentmenuskipdetailEntity _cnf_StudentMenuSkipDetail { get; }

        public IEnumerable<cnf_studentmenuskipdetailEntity> _cnf_StudentMenuSkipDetailList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_StudentMenuSkipDetailResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_StudentMenuSkipDetailResponse(IEnumerable<cnf_studentmenuskipdetailEntity> cnf_StudentMenuSkipDetailList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_StudentMenuSkipDetailList = cnf_StudentMenuSkipDetailList;
        }

        public Cnf_StudentMenuSkipDetailResponse(cnf_studentmenuskipdetailEntity cnf_StudentMenuSkipDetail, bool success = false, string message = null) : base(success, message)
        {
            _cnf_StudentMenuSkipDetail = cnf_StudentMenuSkipDetail;
        }

        public Cnf_StudentMenuSkipDetailResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
