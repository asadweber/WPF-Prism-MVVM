
using BDO.DataAccessObjects.ExtendedEntities;
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface IDigitalNotificationSender
    { 
        /// <summary>
        /// SendEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<string> SendDigitalNotificationAsync(EmailEntity emailobject);
    }
}
