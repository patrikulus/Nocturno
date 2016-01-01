using Microsoft.AspNet.Mvc;

[Area("Admin")]
public class HomeController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        return View();
    }
}