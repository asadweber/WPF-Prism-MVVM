using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.DataAccessObjects.VCRegistration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public class VCRegistrationRequest : IUseCaseRequest<VCRegistrationResponse>
    {

        public long? BasicId { get; set; }
        public string CivilId { get; set; }

        public string? mobileno { get; set; }
        public string? email { get; set; }

        public long? phaseid { get; set; }
        public long? statusid { get; set; }
        public long? candidatetypeid { get; set; }

        public string batchidstring { get; set; }
        public string candidatetypeidstring { get; set; }

        public string professionidstring { get; set; }
        public string basicinfoidstring { get; set; }
        public string nationalityid { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }


        public DateTime? smsSendDate { get; set; }
        public DateTime? interViewDate { get; set; }
        

        public PreRegistrationValidationParameters validationParameter { get; set; }

        public cnf_smsactivationcodeEntity smsactivationcode { get; set; }

        public RegistrationViewModel registrationViewModel { get; set; }
        public Reg_ApplicantDataCheckedEntity reg_applicantdatacheckedEntity { get; set; }

        public owin_userEntity CreateUser { get; set; }

        public long? batchid { get; set; }
        public bool? notificationstatus { get; set; }
        public long? clearancetypeid { get; set; }
        public long? clearancestatus { get; set; }
        public long? certificatelevelid { get; set; }
        public long? certificateID { get; set; }
        public long? certificateSubjectID { get; set; }

        public VCRegistrationRequest()
        {
        }
    }
}
