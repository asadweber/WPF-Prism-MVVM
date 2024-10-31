using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_TrainingCentreResponse : UseCaseResponseMessage
    {
        public gen_trainingcentreEntity _gen_TrainingCentre { get; }

        public IEnumerable<gen_trainingcentreEntity> _gen_TrainingCentreList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_TrainingCentreResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_TrainingCentreResponse(IEnumerable<gen_trainingcentreEntity> gen_TrainingCentreList, bool success = false, string message = null) : base(success, message)
        {
            _gen_TrainingCentreList = gen_TrainingCentreList;
        }
        
        public Gen_TrainingCentreResponse(gen_trainingcentreEntity gen_TrainingCentre, bool success = false, string message = null) : base(success, message)
        {
            _gen_TrainingCentre = gen_TrainingCentre;
        }

        public Gen_TrainingCentreResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
