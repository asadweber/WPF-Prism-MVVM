using BDO.Core.DataAccessObjects.Models;
using System.Runtime.Serialization;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests
{
   
    public class RegisterUserExportImportRequest : IUseCaseRequest<RegisterUserExportImportResponse>
    {

       [DataMember] 
        public long BatchId { get; set; }


		[DataMember]
        public string ImportJson { get; set; }

    }
}
