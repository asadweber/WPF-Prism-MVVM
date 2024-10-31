﻿using System.Threading.Tasks;
using Web;
using Web.Core;
using Web.Core.Frame;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_StudentFileStorageUseCase : IUseCaseRequestHandler<Reg_StudentFileStorageRequest, Reg_StudentFileStorageResponse>
    {
        Task<bool> Save(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);

        Task<bool> Update(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);

        Task<bool> Delete(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);


        Task<bool> GetSingle(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);

        Task<bool> GetAll(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);


        Task<bool> GetAllPaged(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);

        Task<bool> GetListView(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort);



    }
}
