using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }

    //Get: /HellowWorld/Welcome/
    public String Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}
