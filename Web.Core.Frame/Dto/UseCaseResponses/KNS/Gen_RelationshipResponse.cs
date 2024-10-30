using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_RelationshipResponse : UseCaseResponseMessage
    {
        public gen_relationshipEntity _gen_Relationship { get; }

        public IEnumerable<gen_relationshipEntity> _gen_RelationshipList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_RelationshipResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_RelationshipResponse(IEnumerable<gen_relationshipEntity> gen_RelationshipList, bool success = false, string message = null) : base(success, message)
        {
            _gen_RelationshipList = gen_RelationshipList;
        }
        
        public Gen_RelationshipResponse(gen_relationshipEntity gen_Relationship, bool success = false, string message = null) : base(success, message)
        {
            _gen_Relationship = gen_Relationship;
        }

        public Gen_RelationshipResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
