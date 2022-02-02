using CoreBookStoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var items = db.Authors.ToList();
            return items;
        }
        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item =
           db.Authors.SingleOrDefault(p => p.AuthorID.Equals(id));
            return item;
        }
        [HttpPost]
        public void Post([FromBody] Author item)
        {
            BookStoreDataContext db = new BookStoreDataContext();

            db.Add(item);
            db.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author itemNew)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item =
           db.Authors.SingleOrDefault(p => p.AuthorID.Equals(id));
            item.Name = itemNew.Name;
            db.Update(item);
            db.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item = db.Authors.Find(id);
            db.Authors.Remove(item);
            db.SaveChanges();
        }

    }
}
