
using BDO.DataAccessObjects.ExtendedEntities;
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface IPaciCivilIDInformationSender
    {
        /// <summary>
        /// GetPACICivilIDInformationAsync
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Payload> GetPACICivilIDInformationAsync(EmailEntity emailobject);
    }
}
