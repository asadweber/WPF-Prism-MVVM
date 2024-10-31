using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;

namespace Web.Core.Frame.Interfaces.Services
{
    public partial interface IHttpClientHR
    {
        Task<knsCertificatesResponseEntity> GetKNSProfileCertificateByCivilID(GetStatusByCivilIDEntity objEntity);

        Task<knsCertificatesResponseEntity> GetKNSProfessionalCertificateByCivilID(GetStatusByCivilIDEntity objEntity);

        Task<knsCertificatesResponseEntity> GetKNSEmploymentCertificateByCivilID(GetStatusByCivilIDEntity objEntity);

        Task<salaryCertificatesResponseEntity> GetSalaryCertificateByCivilIDAndMilitaryID(GetStatusByCivilIDEntity objEntity);


        Task<string> SendPACINotification(EmailEntity objEntity);

        Task<Payload> GetPACICivilIDInformation(EmailEntity objEntity);


        Task<PACIMainShortProfileResponseEntity> GetPACIMAinCivilIDInformation(EmailEntity objEntity);


    }

}
