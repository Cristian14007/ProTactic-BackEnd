using BackEnd.Models;
using BackEnd.Business;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanController : ControllerBase
{
    private readonly IPlanService _PlanService;
    public PlanController(IPlanService PlanService)
    {
        _PlanService = PlanService;
    }

    [HttpGet]
public ActionResult<List<PlanGetDTO>> GetAll() =>
    _PlanService.GetAll();

    [HttpGet]
    [Route("{id}")]
public ActionResult<PlanGetDTO> Get(int id)
{
    var Plan = _PlanService.Get(id);

    if(Plan == null)
        return NotFound();

    return Plan;
}

    [HttpPost]
public IActionResult Create(PlanCreateDTO PlanCreateDTO)
{            
     if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _PlanService.Add(PlanCreateDTO);
        return Ok();
}

[HttpPut("{id}")]
public IActionResult Update(int id, [FromBody] PlanUpdateDTO PlanUpdateDTO)
{
    if (!ModelState.IsValid)  {return BadRequest(ModelState); } 

        try
        {
            _PlanService.Update(id, PlanUpdateDTO);
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
    var Plan = _PlanService.Get(id);
   
    if (Plan is null)
        return NotFound();
       
    _PlanService.Delete(id);
   
    return NoContent();
}
}