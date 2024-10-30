using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Web.Core.Frame.Serialization
{
    public sealed class JsonSerializer
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new JsonContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore
		};

        public static string SerializeObject(object o)
        {
            string SerializeObject=string.Empty;

			try
            {
				SerializeObject = JsonConvert.SerializeObject(o, Formatting.Indented, Settings);
			}
            catch (System.Exception ex)
            {

                throw ex;
            }
            return SerializeObject;

		}

        public sealed class JsonContractResolver : CamelCasePropertyNamesContractResolver
        {
        }
    }
}
