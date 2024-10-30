using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegFamilyInfoRequest : IUseCaseRequest<Kns_Tran_RegFamilyInfoResponse>
    {
        public kns_tran_regfamilyinfoEntity Objkns_tran_regfamilyinfo { get; }
        
        public Kns_Tran_RegFamilyInfoRequest(kns_tran_regfamilyinfoEntity objkns_tran_regfamilyinfo)
        {
            Objkns_tran_regfamilyinfo = objkns_tran_regfamilyinfo;
        }


        public List<kns_tran_regfamilyinfoEntity> Objkns_tran_regfamilyinfoList { get; }

        public Kns_Tran_RegFamilyInfoRequest(List<kns_tran_regfamilyinfoEntity> objkns_tran_regfamilyinfoList)
        {
            Objkns_tran_regfamilyinfoList = objkns_tran_regfamilyinfoList;
        }
    }
}
