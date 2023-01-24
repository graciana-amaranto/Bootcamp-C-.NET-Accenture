using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAPILibros.Data;
using WebAPILibros.Models;

namespace WebAPILibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly DBLibrosContext context;

        public LibroController( DBLibrosContext context )
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Libro>> Get()
        {
            return context.Libros.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Libro> GetById(int id)
        {
            Libro libro = (from l in context.Libros
                               where l.Id == id
                               select l).SingleOrDefault();
            return libro;
        }

        [HttpPost]

        public ActionResult<Libro> Post(Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Libros.Add(libro);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Libro> Put(int id, [FromBody] Libro libro)
        {
            if (id != libro.Id)
            {
                return BadRequest();
            }
            context.Entry(libro).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Libro> Delete(int id)
        {
            var libroOriginal = (from l in context.Libros
                                   where l.Id == id
                                   select l).SingleOrDefault();

            if (libroOriginal == null)
            {
                return NotFound();
            }
            context.Libros.Remove(libroOriginal);
            context.SaveChanges();
            return libroOriginal;

        }
    }
}
