using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class TipoPersonaController : BaseApiController
{
     //definimos el constructor de la clase
     private readonly IUnitOFWorkInterface _UnitOfWork;
     
     public TipoPersonaController(IUnitOFWorkInterface UnitOfWork)
     {
          _UnitOfWork = UnitOfWork;
     }

     //Metodo GET para obtener todos los registros de la entidad 
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<IEnumerable<TipoPersona>>> Get()
     {
          var TiposPersonas = await _UnitOfWork.TiposPersonas.GetAllAsync();
          return Ok(TiposPersonas);
     }

     //Metodo GET para obtener un unico registro 
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<IActionResult> Get(int id)
     {
          var tipoPersona = await _UnitOfWork.TiposPersonas.GetByIdAsync(id);
          return Ok(tipoPersona);
     }

     //Metodo POST para enviar datos a la entideda de la Db
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<IEnumerable<TipoPersona>>> Post(TipoPersona tipoPersona)
     {

          this._UnitOfWork.TiposPersonas.Add(tipoPersona);
          await _UnitOfWork.SaveAsync();
          if (tipoPersona == null) {
               return BadRequest();
          }
          return CreatedAtAction(nameof(Post), new {id = tipoPersona.Id}, tipoPersona);
     }

     //Metodo PUT permite editar un registro de la entidad 
     [HttpPut("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<TipoPersona>> Put(int id, [FromBody]TipoPersona tipoPersona)
     {
          if (tipoPersona  == null) {
               return NotFound();
          }
          _UnitOfWork.TiposPersonas.Update(tipoPersona);
          await _UnitOfWork.SaveAsync();
          return tipoPersona;
     }

     //Metodo DELETE permite eliminar un registro de la entidad 
     [HttpDelete("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     public async Task<ActionResult> Delete(int id)
     {
          var tipoPersona = await _UnitOfWork.TiposPersonas.GetByIdAsync(id);
          if (tipoPersona == null)
          {
          return NotFound();
          }
          _UnitOfWork.TiposPersonas.Remove(tipoPersona);
          await _UnitOfWork.SaveAsync();
          return NoContent();
     }
        
}
