using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_MedicalResponse : UseCaseResponseMessage
    {
        public kns_medicalEntity _kns_Medical { get; }

        public IEnumerable<kns_medicalEntity> _kns_MedicalList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_MedicalResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_MedicalResponse(IEnumerable<kns_medicalEntity> kns_MedicalList, bool success = false, string message = null) : base(success, message)
        {
            _kns_MedicalList = kns_MedicalList;
        }
        
        public Kns_MedicalResponse(kns_medicalEntity kns_Medical, bool success = false, string message = null) : base(success, message)
        {
            _kns_Medical = kns_Medical;
        }

        public Kns_MedicalResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
