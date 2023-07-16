using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class EstadoController : BaseApiController
{
     //creamos el constructor de la clase
     private readonly IUnitOFWorkInterface _UnitOfWork;
     
     public EstadoController(IUnitOFWorkInterface UnitOfWork)
     {
          _UnitOfWork = UnitOfWork;
     }

     //metodo Get para obtener todo los registros de la entidad Estado de la Db
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<IEnumerable<Estado>>> Get()
     {
          var estados = await _UnitOfWork.Estados.GetAllAsync();
          return Ok(estados);
     }

     //metodo GET para obtener un Unico Registro de la entidad EStado de la Db
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<IActionResult> Get(string id)
     {
          var estado = await _UnitOfWork.Estados.GetByIdAsycn(id);
          return Ok(estado);
     }

     //Metodo POST para enviar registros a la base de datos
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<IEnumerable<Estado>>> Post(Estado estado)
     {
          this._UnitOfWork.Estados.Add(estado);
          await _UnitOfWork.SaveAsync();
          if (estado == null) {
               return BadRequest();
          }
          return CreatedAtAction(nameof(Post), new {id = estado.codEstado}, estado);
     }
        
}