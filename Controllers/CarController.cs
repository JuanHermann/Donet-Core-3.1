using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestDotnet.Data;
using RestDotnet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace RestDotnet.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Car>>> Get([FromServices] DataContext context)
        {
            var cars = await context.Cars.ToListAsync();

            return cars;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Car>> Post([FromServices] DataContext context, [FromBody] Car model)
        {
            if (ModelState.IsValid)
            {
                context.Cars.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }




    }
}