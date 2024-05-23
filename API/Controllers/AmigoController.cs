using BackEnd.Models;
using BackEnd.Business;
using Microsoft.AspNetCore.Mvc;


namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class AmigoController : ControllerBase
{
    private readonly IAmigoService _amigoService;
    public AmigoController(IAmigoService amigoService)
    {
        _amigoService = amigoService;
    }

    [HttpGet]
    public ActionResult<List<AmigoGetDTO>> GetAll() =>
    _amigoService.GetAll();


    // PILLAR SOLO 1 USER
    [HttpGet]
    [Route("{id}")]
    public ActionResult<AmigoGetDTO> Get(int id)
    {
        var amigo = _amigoService.Get(id);

        if (amigo == null)
        {
            return NotFound();
        }
        else
        {
            return amigo;
        }
    }

    // PILLAR TODAS LAS BUTACAS DE 1 FUNCION


    [HttpPost]
    public IActionResult Create([FromBody] AmigoCreateDTO amigoCreateDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _amigoService.Add(amigoCreateDTO);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] AmigoUpdateDTO amigoUpdateDTO)
    {
        if (!ModelState.IsValid) { return BadRequest(ModelState); }

        try
        {
            _amigoService.Update(id, amigoUpdateDTO);
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
        var obra = _amigoService.Get(id);

        if (obra is null)
            return NotFound();

        _amigoService.Delete(id);

        return NoContent();
    }
}