using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Cnf_FileConfigNameResponse : UseCaseResponseMessage
    {
        public cnf_fileconfignameEntity _cnf_FileConfigName { get; }

        public IEnumerable<cnf_fileconfignameEntity> _cnf_FileConfigNameList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Cnf_FileConfigNameResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_FileConfigNameResponse(IEnumerable<cnf_fileconfignameEntity> cnf_FileConfigNameList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_FileConfigNameList = cnf_FileConfigNameList;
        }
        
        public Cnf_FileConfigNameResponse(cnf_fileconfignameEntity cnf_FileConfigName, bool success = false, string message = null) : base(success, message)
        {
            _cnf_FileConfigName = cnf_FileConfigName;
        }

        public Cnf_FileConfigNameResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
