﻿using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_LoginUseCase : IUseCaseRequestHandler<Tran_LoginRequest, Tran_LoginResponse>
    {
        Task<bool> Save(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);

        Task<bool> Update(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);

        Task<bool> Delete(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);


        Task<bool> GetSingle(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);

        Task<bool> GetAll(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);


        Task<bool> GetAllPaged(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);

        Task<bool> GetListView(Tran_LoginRequest message, ICRUDRequestHandler<Tran_LoginResponse> outputPort);



    }
}
