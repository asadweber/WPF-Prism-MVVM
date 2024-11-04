using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.Service.Proxy
{
    public interface IExceptionHandler
    {
        void Handle(Exception exception);
    }
}
