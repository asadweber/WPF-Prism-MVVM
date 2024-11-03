using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDO.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Core.Frame.Dto.UseCaseResponses;
using WebApi.Extensions;
namespace WebApi.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    /// </summary>

    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]

    public class DepartmentController : ControllerBase
    {
       /// <summary>
        /// GetAllPagedGen_Faq
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllDepartment")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Department))]
        public async Task<ActionResult> GetAllDepartment()
        {
            return Ok(new Department());
        }             
    }
}
