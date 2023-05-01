using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;

namespace Todo.Controllers
{
[ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    [Route("/")]
    public List<TodoModel> Get(
       [FromServices] AppDbContext context

        )
    {
      return context.Todos.ToList();
    }
  }
}