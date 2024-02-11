using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;


namespace ApiChatBot.Controllers;

[ApiController]
[Route("[controller]")]

public class ApiController : ControllerBase
{
    public ApiController()
    {        
    }

    [HttpGet]
    public ActionResult<string> get()
    {
        return "hello word";
    }
}