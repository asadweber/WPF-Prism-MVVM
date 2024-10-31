using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces.Services
{
    public partial interface IFileUploadClient
    {
        bool FolderCheckFTP(string fileUploadDir);
        string UploadFileFTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension);
        
        string DeleteFileFTP(string fileUploadDir, string FileNamePrefix, string fileExtension);
        string DeleteFileFTP(string fileUrl);


    }
}
