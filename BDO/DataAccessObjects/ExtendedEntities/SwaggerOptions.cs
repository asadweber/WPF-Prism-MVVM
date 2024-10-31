using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    public class SwaggerOptions
    {
        public string JsonRoute { get; set; }

        public string Description { get; set; }

        public string UiEndpoint { get; set; }
    }
}
