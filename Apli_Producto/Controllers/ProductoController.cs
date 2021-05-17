
using Apli_Producto.Context;
using Apli_Producto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apli_Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProductoController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return context.Producto.ToList();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(string id)
        {
            var producto = context.Producto.FirstOrDefault(p => p.Codigo == id);
            return producto;
        }

        // POST api/<ProductoController>
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            try
            {
            context.Producto.Add(producto);
            context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
           
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Producto producto)
        {
            if (producto.Codigo == id)
            {
                context.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var producto = context.Producto.FirstOrDefault(predicate => predicate.Codigo == id);
            if (producto!=null)
            {
                context.Producto.Remove(producto);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(); 
            }
        }
    }
}
