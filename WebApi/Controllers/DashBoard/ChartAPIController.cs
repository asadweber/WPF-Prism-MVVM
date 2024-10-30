using AutoMapper.Configuration;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ApiModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    //[Route("/[controller]")]
    //[ApiController]
    //public class ChartAPIController : ControllerBase
    //{
       
    //    private readonly ILogger<PACINotificationAPIController> _logger;

    //    /// <summary>
    //    /// _configuration
    //    /// </summary>
    //    public IConfiguration _configuration { get; }

       
    //    public ChartAPIController(
           
    //        ILoggerFactory loggerFactory)
    //    {
           
    //        _logger = loggerFactory.CreateLogger<PACINotificationAPIController>();

    //    }


    //    // GET api/protected/home
    //    [HttpPost]
    //    public ActionResult GetBarPieChartData()
    //    {
    //        BarPieChartEntity root = new BarPieChartEntity();
    //        root.labels = new List<string> { "Inbox", "Outbox", "Draft" };

    //        Dataset obj = new Dataset();
    //        obj.label = "Email Statistics";
    //        obj.data = new List<int> { 11, 22, 33 };

    //        obj.backgroundColor = new List<string> { "rgba(255, 99, 132, 0.2)", "rgba(54, 162, 235, 0.2)", "rgba(255, 206, 86, 0.2)" };
    //        obj.borderColor = new List<string> { "rgba(255,99,132,1)", "rgba(54, 162, 235, 1)", "rgba(255, 206, 86, 1)" };
    //        obj.borderWidth = 1;

    //        root.datasets = new List<Dataset>();
    //        root.datasets.Add(obj);

    //        return Ok( root);
    //    }
    //}
   
}
