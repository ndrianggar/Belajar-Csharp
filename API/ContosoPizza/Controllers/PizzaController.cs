using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;



namespace ContosoPizza.Controllers

[ApiController]
[Route("[controller]")]
public class PizzaCntroller : ControllerBase
{
    public PizzaController()

    { }
[HttpGet]
public ActionResult<List<Pizza>> GettAll() {
    PizzaService.GetAll()
}