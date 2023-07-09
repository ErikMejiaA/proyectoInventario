using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class PaisController : BaseApiController
{
    private readonly proyectoInventarioContext _context;
    
    public PaisController(proyectoInventarioContext context)
    {
       _context = context;
    }

    //Metodo Get para lsiatr todo los paises de la base de datos
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
         var paises = await _context.Paises.ToListAsync();
         return Ok(paises);
    }

    //Metodo Get para solo traer un unico registro de la base de datos
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
         var pais = await _context.Paises.FindAsync(id);
         return Ok(pais);
    }


}
