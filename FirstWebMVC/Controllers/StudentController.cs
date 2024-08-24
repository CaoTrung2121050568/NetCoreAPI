using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}