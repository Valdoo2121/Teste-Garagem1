using Estapar.Model;
using Microsoft.AspNetCore.Mvc;


namespace Estapar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class garagens    : ControllerBase
    {
        // GET: api/<Garagens>
        [HttpGet]
        public IEnumerable<Garagens> Get()
        {
            List<Garagens>garagens = new List<Garagens>();

            garagens.Add(new Garagens()
            {
               Codigo = "",
               Nome = " ",
               Preco_1aHora =  "",
               Preco_HorasExtra =  "",
               Preco_Mensalista = ""

            });


            return garagens;

           

        }

        // GET api/<Estapar>/5
      

        // POST api/<Estapar>
        [HttpPost]
        public void Post([FromBody] garagens garagens)
        {

        }

       
       


    }
}
