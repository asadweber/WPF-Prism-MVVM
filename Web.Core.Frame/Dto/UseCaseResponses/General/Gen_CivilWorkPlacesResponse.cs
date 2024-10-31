using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CivilWorkPlacesResponse : UseCaseResponseMessage
    {
        public gen_civilworkplacesEntity _gen_CivilWorkPlaces { get; }

        public IEnumerable<gen_civilworkplacesEntity> _gen_CivilWorkPlacesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CivilWorkPlacesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CivilWorkPlacesResponse(IEnumerable<gen_civilworkplacesEntity> gen_CivilWorkPlacesList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CivilWorkPlacesList = gen_CivilWorkPlacesList;
        }
        
        public Gen_CivilWorkPlacesResponse(gen_civilworkplacesEntity gen_CivilWorkPlaces, bool success = false, string message = null) : base(success, message)
        {
            _gen_CivilWorkPlaces = gen_CivilWorkPlaces;
        }

        public Gen_CivilWorkPlacesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
