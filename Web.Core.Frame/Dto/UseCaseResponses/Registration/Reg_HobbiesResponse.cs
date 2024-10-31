using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_HobbiesResponse : UseCaseResponseMessage
    {
        public reg_hobbiesEntity _reg_Hobbies { get; }

        public IEnumerable<reg_hobbiesEntity> _reg_HobbiesList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_HobbiesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_HobbiesResponse(IEnumerable<reg_hobbiesEntity> reg_HobbiesList, bool success = false, string message = null) : base(success, message)
        {
            _reg_HobbiesList = reg_HobbiesList;
        }

        public Reg_HobbiesResponse(reg_hobbiesEntity reg_Hobbies, bool success = false, string message = null) : base(success, message)
        {
            _reg_Hobbies = reg_Hobbies;
        }

        public Reg_HobbiesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
