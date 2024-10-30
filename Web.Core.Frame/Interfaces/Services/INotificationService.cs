
using BDO.Core.DataAccessObjects.Models;
using CLL.LLClasses.Models;
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
        Task<bool> SendDigitalIDNotifcationAsync(string civilid, string subject, string message, string subjectAR, string messageAR);
		

        Task<bool> SendBulkDigitalIDNotifcationAsync(byte[] fileByteContent, string file_guid, bool? sendsms, bool? senddigitalidnotification, bool? sendemail,bool? SendSahelNotification,bool? SendWhatsAppNotification);

        Task<bool> SendDigitalIDNotifcationStatusChangeAsync(kns_tran_registrationprofileEntity profile);


        Task<string> SentNotification(PaciNotification obj, bool allowSendNotification);

    }
}



public class PaciNotification
{
    private string applicationid1 = "C4077E81-CD92-42E9-8811-B93A6578A4C7";

    public long notificationrequestid { get; set; }

    public string applicationid { get => applicationid1; set => applicationid1 = value; }
    public string recipientcivilid { get; set; }
    public string recipientmobile { get; set; }
    public string recipientemail { get; set; }

    public string msgsubject { get; set; }
    public string msgsubjectar { get; set; }

    public string msg { get; set; }
    public string msgar { get; set; }

    public string messagebodyemail { get; set; }
    public string messagebodyemailar { get; set; }

    public bool sendsms { get; set; }
    public bool senddigitalidnotification { get; set; }
    public bool sendemail { get; set; }
}