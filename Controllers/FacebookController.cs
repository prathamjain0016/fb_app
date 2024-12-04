using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FacebookApplication.Service;


namespace FacebookApplication.Controllers
{
    public class FacebookController : Controller
    {
        private readonly FacebookService _facebookService;
        public FacebookController(FacebookService facebookService)
        {
            _facebookService = facebookService;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _facebookService.GetFacebookPostsAsync();
            ViewData["Posts"] = posts;
            return View();
        }

    }
}
