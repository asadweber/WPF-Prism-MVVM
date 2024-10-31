using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Stp_OrganizationEntityResponse : UseCaseResponseMessage
    {
        public stp_organizationentityEntity _stp_OrganizationEntity { get; }

        public IEnumerable<stp_organizationentityEntity> _stp_OrganizationEntityList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Stp_OrganizationEntityResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Stp_OrganizationEntityResponse(IEnumerable<stp_organizationentityEntity> stp_OrganizationEntityList, bool success = false, string message = null) : base(success, message)
        {
            _stp_OrganizationEntityList = stp_OrganizationEntityList;
        }
        
        public Stp_OrganizationEntityResponse(stp_organizationentityEntity stp_OrganizationEntity, bool success = false, string message = null) : base(success, message)
        {
            _stp_OrganizationEntity = stp_OrganizationEntity;
        }

        public Stp_OrganizationEntityResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
