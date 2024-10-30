using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Core.Frame.Interfaces.Services
{
     public interface IStringCompression
    {
        string Zip(string uncompressedString);
        string UnZip(string CompressedString);
    }
}
