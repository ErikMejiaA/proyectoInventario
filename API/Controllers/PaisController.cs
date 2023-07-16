using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class PaisController : BaseApiController
{
   private readonly IUnitOFWorkInterface _UnitOfWork;

   public PaisController(IUnitOFWorkInterface UnitOfWork)
   {
      _UnitOfWork = UnitOfWork;
   }

   //Metodo Get para lsiatr todo los paises de la base de datos
   [HttpGet]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<ActionResult<IEnumerable<Pais>>> Get()
   {
      var paises = await _UnitOfWork.Paises.GetAllAsync();
      return Ok(paises);
   }

   //Metodo Get para solo traer un unico registro de la base de datos
   [HttpGet("{id}")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<IActionResult> Get(string id)
   {
      var pais = await _UnitOfWork.Paises.GetByIdAsync(id);
      return Ok(pais);
   }

   //Metodo POST para enviar datos a la entideda de la Db
   [HttpPost]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<ActionResult<IEnumerable<Pais>>> Post(Pais pais)
   {

      this._UnitOfWork.Paises.Add(pais);
      await _UnitOfWork.SaveAsync();
      if (pais == null) {
         return BadRequest();
      }
      return CreatedAtAction(nameof(Post), new {id = pais.codPais}, pais);
   }

}
