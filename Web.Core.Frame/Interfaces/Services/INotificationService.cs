 
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface INotificationService
    {
        /// <summary>
        /// SendDigitalIDNotifcationAsync
        /// </summary>
        /// <param name="civilid"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="subjectAR"></param>
        /// <param name="messageAR"></param>
        /// <returns></returns>
        //Task SendDigitalIDNotifcationAsync(string civilid, string subject, string message, string subjectAR, string messageAR);
		Task<string> SendBulkDigitalIDNotifcationAsync(byte[] fileByteContent, string file_guid);
    }
}
