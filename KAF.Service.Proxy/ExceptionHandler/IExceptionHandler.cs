using KAF.Service.Proxy.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Common.ExceptionHandler
{
    public interface IExceptionHandler
    {
        void Handle(Exception exception);
        void Handle(ApiException exception);


    }
}
