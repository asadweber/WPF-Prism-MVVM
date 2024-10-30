using System.Threading.Tasks;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKNS_ApiMigrateDataInfoUseCase
    {
        Task<bool> GetPAAETDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort,bool isServiceMap=true, bool IsList = false);
        Task<bool> GetPUCDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMOHEDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort,bool isServiceMap=true, bool IsList = false);
        Task<bool> GetKuwaitUniDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap=true, bool IsList = false);
        Task<bool> GetDisabledDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetDepartedDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetKFSDDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetCivilServiceCommissionDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetKPCDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMinistryOfEduDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
		Task<bool> GetMOIDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMOINewServiceDataByDateRange(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);



        Task<bool> GetPAAETDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetPUCDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMOHEDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetKuwaitUniDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetDisabledDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetDepartedDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetKFSDDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetCivilServiceCommissionDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetKPCDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMinistryOfEduDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetMOIDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);

        Task<bool> GetManpowerDataByCivilID(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetPIFSSDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);
        Task<bool> GetPACIDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort, bool isServiceMap = true, bool IsList = false);


        Task<bool> GetAllPagedExt(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);
        Task<bool> GetListViewMapping(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> GAPgbatchApiDataForProcess(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> GetProcessStatistics(KNS_ApiMigrateDataInfoRequest message, IProcessStatisticsRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> GetDisabledDataByCivilId(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);




    }
}
