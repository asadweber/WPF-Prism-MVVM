using BDO.Core.DataAccessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_FinalExamNotificationRequest : IUseCaseRequest<Tran_FinalExamNotificationResponse>
    {
        public tran_finalexamnotificationEntity Objtran_finalexamnotification { get; }

        public Tran_FinalExamNotificationRequest(tran_finalexamnotificationEntity objtran_finalexamnotification)
        {
            Objtran_finalexamnotification = objtran_finalexamnotification;
        }
    }
}
