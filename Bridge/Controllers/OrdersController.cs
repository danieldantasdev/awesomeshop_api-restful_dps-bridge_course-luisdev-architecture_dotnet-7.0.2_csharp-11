using Bridge.Application.Configurations;
using Bridge.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bridge.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(
        OrderInputModel model
    )
    {
        return Ok(BusinessHours.GetInstance());
    }
}