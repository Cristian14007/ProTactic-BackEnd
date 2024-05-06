using BackEnd.Models;
using BackEnd.Business;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    private readonly IExerciseService _exerciseService;
    public ExerciseController(IExerciseService exerciseService)
    {
        _exerciseService = exerciseService;
    }

    [HttpGet]
public ActionResult<List<ExerciseGetDTO>> GetAll() =>
    _exerciseService.GetAll();

    [HttpGet]
    [Route("{id}")]
public ActionResult<ExerciseGetDTO> Get(int id)
{
    var exercise = _exerciseService.Get(id);

    if(exercise == null)
        return NotFound();

    return exercise;
}

    [HttpPost]
public IActionResult Create(ExerciseCreateDTO exerciseCreateDTO)
{            
     if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _exerciseService.Add(exerciseCreateDTO);
        return Ok();
}

[HttpPut("{id}")]
public IActionResult Update(int id, [FromBody] ExerciseUpdateDTO exerciseUpdateDTO)
{
    if (!ModelState.IsValid)  {return BadRequest(ModelState); } 

        try
        {
            _exerciseService.Update(id, exerciseUpdateDTO);
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
    var exercise = _exerciseService.Get(id);
   
    if (exercise is null)
        return NotFound();
       
    _exerciseService.Delete(id);
   
    return NoContent();
}
}