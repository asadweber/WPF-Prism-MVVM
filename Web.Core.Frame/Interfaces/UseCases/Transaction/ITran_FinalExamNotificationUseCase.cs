using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;


namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_FinalExamNotificationUseCase : IUseCaseRequestHandler<Tran_FinalExamNotificationRequest, Tran_FinalExamNotificationResponse>
    {
        Task<bool> Save(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);

        Task<bool> Update(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);

        Task<bool> Delete(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);


        Task<bool> GetSingle(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);

        Task<bool> GetAll(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);


        Task<bool> GetAllPaged(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);

        Task<bool> GetListView(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort);



    }
}
