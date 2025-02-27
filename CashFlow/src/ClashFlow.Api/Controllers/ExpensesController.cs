using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ClashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestExpenseJson request)    
    {
        return Created();
    }
}