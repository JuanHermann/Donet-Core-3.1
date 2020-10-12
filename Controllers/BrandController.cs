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
    [Route("brands")]
    public class BrandController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Brand>>> Get([FromServices] DataContext context)
        {
            var brands = await context.Brands.ToListAsync();

            return brands;
        }



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Brand>> Post([FromServices] DataContext context, [FromBody] Brand model)
        {
            if (ModelState.IsValid)
            {
                context.Brands.Add(model);
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