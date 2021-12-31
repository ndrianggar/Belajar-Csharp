using Microsoft.AspNetCore.Mvc;
using PizzaDoang.Models;
using PizzaDoang.Services;
using System.Collections.Generic;

namespace PizzaDoang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();


        [HttpPost]
        public IActionResult Post(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Post), new { id = pizza.Id }, pizza);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
                return BadRequest();

            var existingPizza = PizzaService.Get(id);
            if( existingPizza is null)
            return NotFound("not exist");

            PizzaService.Update(pizza);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza is null)
                return NotFound();

            PizzaService.Delete(id);

            return NoContent();
        }

    }









}
