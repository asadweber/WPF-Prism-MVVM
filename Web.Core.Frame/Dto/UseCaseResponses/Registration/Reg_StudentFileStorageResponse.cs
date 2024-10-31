using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_StudentFileStorageResponse : UseCaseResponseMessage
    {
        public reg_studentfilestorageEntity _reg_StudentFileStorage { get; }

        public IEnumerable<reg_studentfilestorageEntity> _reg_StudentFileStorageList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_StudentFileStorageResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_StudentFileStorageResponse(IEnumerable<reg_studentfilestorageEntity> reg_StudentFileStorageList, bool success = false, string message = null) : base(success, message)
        {
            _reg_StudentFileStorageList = reg_StudentFileStorageList;
        }

        public Reg_StudentFileStorageResponse(reg_studentfilestorageEntity reg_StudentFileStorage, bool success = false, string message = null) : base(success, message)
        {
            _reg_StudentFileStorage = reg_StudentFileStorage;
        }

        public Reg_StudentFileStorageResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
