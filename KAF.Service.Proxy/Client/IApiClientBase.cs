using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.Service.Proxy.Client
{
    public interface IApiClientBase
    {
        string BaseUrl { get; set; }
        void SetBearerToken(string token);
    }
}
