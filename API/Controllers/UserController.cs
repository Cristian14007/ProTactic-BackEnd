using BackEnd.Models;
using BackEnd.Business;
using Microsoft.AspNetCore.Mvc;


namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public ActionResult<List<UserGetDTO>> GetAll() =>
    _userService.GetAll();


    // PILLAR SOLO 1 USER
    [HttpGet]
    [Route("{id}")]
    public ActionResult<UserGetDTO> Get(int id)
    {
        var user = _userService.Get(id);

        if (user == null)
        {
            return NotFound();
        }
        else
        {
            return user;
        }
    }

    // PILLAR TODAS LAS BUTACAS DE 1 FUNCION


    [HttpPost]
    public IActionResult Create([FromBody] UserCreateDTO userCreateDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _userService.Add(userCreateDTO);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UserUpdateDTO userUpdateDTO)
    {
        if (!ModelState.IsValid) { return BadRequest(ModelState); }

        try
        {
            _userService.Update(id, userUpdateDTO);
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
        var obra = _userService.Get(id);

        if (obra is null)
            return NotFound();

        _userService.Delete(id);

        return NoContent();
    }
}