using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class CaoVanTrungController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}