using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestGetController : ControllerBase
    {
        /// <summary>
        /// ApiGetValuesGetWParam
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("apigetvaluesgetwparam")]
       // [CacheOutputAttributeOver(
       //    ClientTimeSpan = 0,
       //    ServerTimeSpan = 3600,
       //    MustRevalidate = true,
       //    ExcludeQueryStringFromCacheKey = false
       //)]
        public async Task<IActionResult> ApiGetValuesGetWParam()
        {
            System.Threading.Thread.Sleep(4000);
            return Ok(new
            {
                helloUser = "Hello World - From GET Without PARAM"
            });
        }
    }
}
