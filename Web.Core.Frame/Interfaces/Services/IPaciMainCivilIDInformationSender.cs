
using BDO.DataAccessObjects.ExtendedEntities;
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface IPaciMainCivilIDInformationSender
    {
        /// <summary>
        /// GetPACICivilIDInformationAsync
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<PACIMainShortProfileResponseEntity> GetPACICivilIDInformationAsync(EmailEntity emailobject);

    }
}
