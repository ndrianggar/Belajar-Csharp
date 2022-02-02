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
    public class BookController : ControllerBase
    {

        [HttpPost]
        public void Post([FromBody] Book item)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            db.Add(item);
            db.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book itemNew)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item = db.Books.SingleOrDefault(p => p.ISBN.Equals(id));
            item.CategoryID = itemNew.CategoryID;
            item.Title = itemNew.Title;
            item.Photo = itemNew.Photo;
            item.PublishDate = itemNew.PublishDate;
            item.Price = itemNew.Price;
            item.Quantity = itemNew.Quantity;
            db.Update(item);
            db.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BookStoreDataContext db = new BookStoreDataContext();
            var item = db.Books.Find(id);
            db.Books.Remove(item);
            db.SaveChanges();
        }
    }
}
