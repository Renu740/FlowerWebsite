using FlowersWebsite.Models;
using FlowersWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersWebsite.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        public FlowersController(JsonFileFlowersService flowersService)
        {
            FlowersService = flowersService;
        }

        public JsonFileFlowersService FlowersService { get; }

        public IEnumerable<Flowers> Get()
        {
            return FlowersService.GetFlowers();
        }

        [Route("(Rate)")]
        [HttpGet]
        public ActionResult Get(string FlowerID,int Rating)
        {
            FlowersService.AddFlowerRating(FlowerID, Rating);
            return Ok();
        }
    }
}
