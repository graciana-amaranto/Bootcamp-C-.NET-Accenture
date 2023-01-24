using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiPubs.Models;

namespace WebApiPubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly PubsContext context;
        public PublisherController(PubsContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Publisher>> Get()
        {
            return context.Publishers.ToList();
        }

        [HttpGet("{pub_id}")]
        public ActionResult<Publisher> GetById(string pub_id)
        {
            Publisher publisher = (from p in context.Publishers
                                   where p.PubId == pub_id
                                   select p).SingleOrDefault();
            return publisher;
        }

        [HttpPost]
        public ActionResult<Publisher> Post(Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Publishers.Add(publisher);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{pub_id}")]
        public ActionResult<Publisher> Put(string pub_id, [FromBody] Publisher publisher)
        {
            if (pub_id != publisher.PubId)
            {
                return BadRequest();
            }
            context.Entry(publisher).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{pub_id}")]
        public ActionResult<Publisher> Delete(string pub_id)
        {
            var publisherOriginal = (from p in context.Publishers
                                   where p.PubId == pub_id
                                   select p).SingleOrDefault();

            if (publisherOriginal == null)
            {
                return NotFound();
            }
            context.Publishers.Remove(publisherOriginal);
            context.SaveChanges();
            return publisherOriginal;

        }
    }
}
