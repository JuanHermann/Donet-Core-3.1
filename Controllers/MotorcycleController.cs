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
    [Route("motorcycles")]
    public class MotorcycleController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Motorcycle>>> Get([FromServices] DataContext context)
        {
            var motorcycles = await context.Motorcycles.Include(x => x.BrandId).ToListAsync();

            return motorcycles;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Motorcycle>> Post([FromServices] DataContext context, [FromBody] Motorcycle model)
        {
            if (ModelState.IsValid)
            {
                context.Motorcycles.Add(model);
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