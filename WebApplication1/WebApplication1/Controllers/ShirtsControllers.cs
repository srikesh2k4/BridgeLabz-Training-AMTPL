using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ShirtsController : ControllerBase
{
    [HttpGet]
    public string GetShirts()
    {
        return "Getting shirts";
    }

    [HttpGet("{id}")]
    public string GetShirtById(int id,[FromQuery] string color,[FromHeader(Name = "col")] string col)
    {
        return $"This is id of shirt {id} {color} {col}";
    }

    [HttpPost]
    public IActionResult CreateShirt([FromBody]Shirts shirts)
    {
        return Ok(shirts);
    }

    [HttpPut("{id}")]
    public string UpdateShirt(int id)
    {
        return $"Update shirt{id}";
    }

    [HttpDelete("{id}")]
    public string DeleteShirt(int id)
    {
        return $"Delete shirt{id}";
    }
}

// [ApiController]
// public class ShirtsControllers:ControllerBase
// {
//     [HttpGet]
//     [Route("/shirt")]
//     public string GetShirts()
//     {
//         return "Getting shirts";
//     }
//
//     [HttpGet]
//     [Route("/shirt/{id}")]
//     public string GetShirtById(int id)
//     {
//         return $"This is id of shirt {id}";
//     }
//
//     [HttpPost]
//     [Route("/shirt/")]
//     public string CreateShirt()
//     {
//         return "Shirt is created";
//     }
//
//     [HttpPut]
//     [Route("/shirt/{id}")]
//     public string UpdateShirt(int id)
//     {
//         return $"Update shirt{id}";
//     }
//     
//     [HttpDelete]
//     [Route("/shirt/{id}")]
//     public string DeleteShirt(int id)
//     {
//         return $"Delete shirt{id}";
//     }
