using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class RegionController : BaseApiController
{
    //definimos el constructor de la clase 
    private readonly IUnitOFWorkInterface _UnitOfWork;
    
    public RegionController(IUnitOFWorkInterface UnitOfWork)
    {
       _UnitOfWork = UnitOfWork;
    }

    //metodo GET para obtener todos los registros
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Region>>> Get()
    {
        var regions = await _UnitOfWork.Regiones.GetAllAsync();
        return Ok(regions);
    }

    //Metodo GET para obtener un uniuco registro 
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var region = await _UnitOfWork.Regiones.GetByIdAsync(id);
        return Ok(region);
    }
        
    //Metodo POST para enviar datos a la entideda de la Db
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Region>>> Post(Region region)
    {

        this._UnitOfWork.Regiones.Add(region);
        await _UnitOfWork.SaveAsync();
        if (region == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = region.codRegion}, region);
    }
}