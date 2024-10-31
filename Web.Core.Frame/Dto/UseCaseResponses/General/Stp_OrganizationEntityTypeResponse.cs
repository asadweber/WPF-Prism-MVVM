using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Stp_OrganizationEntityTypeResponse : UseCaseResponseMessage
    {
        public stp_organizationentitytypeEntity _stp_OrganizationEntityType { get; }

        public IEnumerable<stp_organizationentitytypeEntity> _stp_OrganizationEntityTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Stp_OrganizationEntityTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Stp_OrganizationEntityTypeResponse(IEnumerable<stp_organizationentitytypeEntity> stp_OrganizationEntityTypeList, bool success = false, string message = null) : base(success, message)
        {
            _stp_OrganizationEntityTypeList = stp_OrganizationEntityTypeList;
        }
        
        public Stp_OrganizationEntityTypeResponse(stp_organizationentitytypeEntity stp_OrganizationEntityType, bool success = false, string message = null) : base(success, message)
        {
            _stp_OrganizationEntityType = stp_OrganizationEntityType;
        }

        public Stp_OrganizationEntityTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
