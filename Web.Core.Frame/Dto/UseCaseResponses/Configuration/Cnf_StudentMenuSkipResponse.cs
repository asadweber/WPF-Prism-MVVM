using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_StudentMenuSkipResponse : UseCaseResponseMessage
    {
        public cnf_studentmenuskipEntity _cnf_StudentMenuSkip { get; }

        public IEnumerable<cnf_studentmenuskipEntity> _cnf_StudentMenuSkipList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_StudentMenuSkipResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_StudentMenuSkipResponse(IEnumerable<cnf_studentmenuskipEntity> cnf_StudentMenuSkipList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_StudentMenuSkipList = cnf_StudentMenuSkipList;
        }

        public Cnf_StudentMenuSkipResponse(cnf_studentmenuskipEntity cnf_StudentMenuSkip, bool success = false, string message = null) : base(success, message)
        {
            _cnf_StudentMenuSkip = cnf_StudentMenuSkip;
        }

        public Cnf_StudentMenuSkipResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
