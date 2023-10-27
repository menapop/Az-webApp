using Az_webApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Az_webApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _applicationDbContext;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _configuration = configuration;
            _applicationDbContext = applicationDbContext;
        }

       

        public void OnGet()
        {
            ViewData["Greeting"] = _configuration["Greeting"];
            ViewData["Persons"] = _applicationDbContext.Persons.Select(p=>p.FirstName).FirstOrDefault();

             
        }
    }
}