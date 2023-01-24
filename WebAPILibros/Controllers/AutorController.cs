using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebAPILibros.Data;
using WebAPILibros.Models;

namespace WebAPILibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase

    //Inyeccion de dependencia

    {   //propiedad
        private readonly DBLibrosContext context;

        //constructor
        public AutorController(DBLibrosContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Autor> GetById(int id)
        {
            Autor autor = (from a in context.Autores
                           where a.IdAutor == id
                           select a).SingleOrDefault();
            return autor;
        }

        [HttpPost]
        public ActionResult<Autor> Post(Autor autor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Autores.Add(autor);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Autor> Put(int id, [FromBody] Autor autor)
        {
            if (id != autor.IdAutor)
            {
                return BadRequest();
            }
            context.Entry(autor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            var autorOriginal = (from a in context.Autores
                                 where a.IdAutor == id
                                 select a).SingleOrDefault();

            if (autorOriginal == null)
            {
                return NotFound();
            }
            context.Autores.Remove(autorOriginal);
            context.SaveChanges();
            return autorOriginal;

        }
    }

}
