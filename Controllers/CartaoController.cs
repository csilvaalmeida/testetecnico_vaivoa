using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using creditcardapi.Models;

namespace creditcardapi.Controllers
{
    [ApiController]
    [Route("v1/cartao")]
    public class CartaoController : ControllerBase {
        

        [HttpPost]
        [Route("")]
        public async Task <ActionResult<int>> Post([FromServices] AppDbContext context, [FromBody] Cliente body)
        {       
            if (ModelState.IsValid) {
                
                Cliente clientExists = (Cliente) await context.Cliente
                                                        .Where(c => c.email.Equals(body.email))
                                                        .SingleOrDefaultAsync();

                // clientExists;
                if (clientExists == null) {
                    context.Cliente.Add(body);
                    await context.SaveChangesAsync();
                }
                Cliente cliente = clientExists == null ? body : clientExists;

                Random rnd = new Random();
                int creditCardNumber = rnd.Next(10000000, 99999999);
                Cartao cartao = new Cartao() { cliente = cliente, numero = creditCardNumber };
                context.Cartao.Add(cartao);
                await context.SaveChangesAsync();

                return creditCardNumber;
                
            } else {
                return BadRequest(ModelState);
            }           
        
        }        
    }
}