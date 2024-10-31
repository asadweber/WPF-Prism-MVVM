using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Stp_OrganizationResponse : UseCaseResponseMessage
    {
        public stp_organizationEntity _stp_Organization { get; }

        public IEnumerable<stp_organizationEntity> _stp_OrganizationList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Stp_OrganizationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Stp_OrganizationResponse(IEnumerable<stp_organizationEntity> stp_OrganizationList, bool success = false, string message = null) : base(success, message)
        {
            _stp_OrganizationList = stp_OrganizationList;
        }
        
        public Stp_OrganizationResponse(stp_organizationEntity stp_Organization, bool success = false, string message = null) : base(success, message)
        {
            _stp_Organization = stp_Organization;
        }

        public Stp_OrganizationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
