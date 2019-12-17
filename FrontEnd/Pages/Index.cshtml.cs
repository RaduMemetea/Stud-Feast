using DataModels.Models;
using DataModels.Translates;
using FrontEnd.Areas.Identity.Data;
using FrontEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        protected readonly IApiClient _apiClient;
        private readonly UserManager<User> _userManager;
        public string usermail { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IApiClient apiClient, UserManager<User> userManager)
        {
            _logger = logger;
            _apiClient = apiClient;
            _userManager = userManager;
        }

        public List<DayOfWeek> Zile { get; set; } = new List<DayOfWeek>();
        public DayOfWeek CurrentDay { get; set; }

        public List<OrarResponse> Orar { get; set; }

        public async Task OnGetAsync(DayOfWeek day = 0)
        {
            CurrentDay = day;
            var user = _userManager.GetUserAsync(User).Result.Email;
            if (user ==null)
                return;
            var usr = _apiClient.GetStudentByMailAsync(user);
            if (usr.IsFaulted)
                return;
            List<OrarResponse> orar = new List<OrarResponse>();
            try
            {
                orar = await _apiClient.GetOrarByStudentAsync(usr.Result.Id);
            }
            catch (Exception e) { };

            Zile = orar.Select(x => x.Ora.DayOfWeek).Distinct().OrderBy(x => x).ToList();
            Orar = orar.Where(x => x.Ora.DayOfWeek == day).OrderBy(x=>x.Ora.Hour).ToList();
            
           
        }
    }
}
