using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ApiTest.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : Controller
{

    [HttpGet]


    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}