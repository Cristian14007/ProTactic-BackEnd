using BackEnd.Models;
using BackEnd.Business;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class UsageController : ControllerBase
{
    private readonly IUsageService _UsageService;
    public UsageController(IUsageService UsageService)
    {
        _UsageService = UsageService;
    }

    [HttpGet]
public ActionResult<List<UsageGetDTO>> GetAll() =>
    _UsageService.GetAll();

    [HttpGet]
    [Route("{id}")]
public ActionResult<UsageGetDTO> Get(int id)
{
    var Usage = _UsageService.Get(id);

    if(Usage == null)
        return NotFound();

    return Usage;
}

    [HttpPost]
public IActionResult Create(UsageCreateDTO UsageCreateDTO)
{            
     if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _UsageService.Add(UsageCreateDTO);
        return Ok();
}

[HttpPut("{id}")]
public IActionResult Update(int id, [FromBody] UsageUpdateDTO UsageUpdateDTO)
{
    if (!ModelState.IsValid)  {return BadRequest(ModelState); } 

        try
        {
            _UsageService.Update(id, UsageUpdateDTO);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
           return NotFound();
        }
}

    [HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var Usage = _UsageService.Get(id);
   
    if (Usage is null)
        return NotFound();
       
    _UsageService.Delete(id);
   
    return NoContent();
}
}