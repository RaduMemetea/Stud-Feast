using DataModels.Models;
using DataModels.Translates;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        protected readonly IApiClient _apiClient;

        public IndexModel(ILogger<IndexModel> logger, IApiClient apiClient)
        {
            _logger = logger;
            _apiClient = apiClient;

        }

        public List<DayOfWeek> Zile { get; set; } = new List<DayOfWeek>();
        public DayOfWeek CurrentDay { get; set; }

        public List<OrarResponse> Orar { get; set; }

        public async Task OnGetAsync(DayOfWeek day = 0)
        {
            CurrentDay = day;
            var orar = await _apiClient.GetOrarAsync();
       
            Orar = orar.Where(x => x.Ora.DayOfWeek == day).OrderBy(x=>x.Ora.Hour).ToList();
            Zile = orar.Select(x => x.Ora.DayOfWeek).Distinct().ToList();
           
        }
    }
}
