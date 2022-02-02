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
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var items = db.Categories.ToList();
            return items;
        }
        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item =
           db.Categories.SingleOrDefault(p => p.CategoryID.Equals(id));
            return item;
        }
        [HttpPost]
        public void Post([FromBody] Category item)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            db.Add(item);
            db.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category itemNew)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item =
           db.Categories.SingleOrDefault(p => p.CategoryID.Equals(id));
            item.Name = itemNew.Name;
            db.Update(item);
            db.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item = db.Categories.Find(id);
            db.Categories.Remove(item);
            db.SaveChanges();
        }
    }

}

