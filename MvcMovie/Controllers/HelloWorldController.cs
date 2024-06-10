using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    //Get: /HellowWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
