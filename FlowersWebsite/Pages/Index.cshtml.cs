using FlowersWebsite.Models;
using FlowersWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileFlowersService FlowersService;
        public IEnumerable<Flowers> Flowers { get; private set; }

        public IndexModel(ILogger<IndexModel> logger , JsonFileFlowersService flowersService)
        {
            _logger = logger;
            FlowersService = flowersService;
        }

        public void OnGet()
        {
            Flowers = FlowersService.GetFlowers();
        }
    }
}
