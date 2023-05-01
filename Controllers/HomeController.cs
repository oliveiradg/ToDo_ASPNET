using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
[ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    [Route("/")]
    public String Get()
    {
      return "Hello World!";
    }
  }
}