using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class KnsTransPunishmentResponse : UseCaseResponseMessage
    {
        public knstranspunishmentEntity _knstranspunishment_ { get; }

        public IEnumerable<knstranspunishmentEntity> _knstranspunishment_List { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public KnsTransPunishmentResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public KnsTransPunishmentResponse(IEnumerable<knstranspunishmentEntity> knstranspunishment_List, bool success = false, string message = null) : base(success, message)
        {
            _knstranspunishment_List = knstranspunishment_List;
        }
        
        public KnsTransPunishmentResponse(knstranspunishmentEntity knstranspunishment_, bool success = false, string message = null) : base(success, message)
        {
            _knstranspunishment_ = knstranspunishment_;
        }

        public KnsTransPunishmentResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
