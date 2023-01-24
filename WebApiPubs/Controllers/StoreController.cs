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
    public class StoreController : ControllerBase
    {
        private readonly PubsContext context;

        public StoreController(PubsContext context) 
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Store>> Get()
        {
            return context.Stores.ToList();
        }
        //get api/store/1
        [HttpGet("{id}")]
        public ActionResult<Store> GetById(string id)
        {
            Store store = (from s in context.Stores
                               where s.StorId == id
                               select s).SingleOrDefault();
            return store;
        }
        //get api/store/name/a
        [HttpGet("name/{name}")]
        public ActionResult<Store> GetByName(string name)
        {
            Store store = (from s in context.Stores
                           where s.StorName == name
                           select s).SingleOrDefault();
            return store;
        }
        //get api/store/zip/12
        [HttpGet("zip/{zip}")]
        public ActionResult<IEnumerable<Store>> GetByZip(string zip)
        {
            List<Store> stores = (from s in context.Stores
                                  where s.Zip == zip
                                  select s).ToList();
            if (stores.Count == 0)
            {
                return NotFound();
            }
            return stores;
        }

        [HttpGet("{city}/{state}")]
        public ActionResult<IEnumerable<Store>> GetByCityState(string city, string state)
        {
            List<Store> stores = (from s in context.Stores
                                  where s.City == city && s.State == state
                                  select s).ToList();
            if (stores.Count == 0)
            {
                return NotFound();
            }
            return stores;
        }

        [HttpPost]
        public ActionResult<Store> Post(Store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Stores.Add(store);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Store> Put(string id, [FromBody] Store store)
        {
            if (id != store.StorId)
            {
                return BadRequest();
            }
            context.Entry(store).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Store> Delete(string id)
        {
            var storeOriginal = (from s in context.Stores
                                   where s.StorId == id
                                   select s).SingleOrDefault();

            if (storeOriginal == null)
            {
                return NotFound();
            }
            context.Stores.Remove(storeOriginal);
            context.SaveChanges();
            return storeOriginal;
        }
    }
}
