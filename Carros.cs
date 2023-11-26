using Estapar.Model;
using Microsoft.AspNetCore.Mvc;


namespace Estapar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Carros : ControllerBase
    {
        // GET: api/<Carros>
        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            List<Carro>carros = new List<Carro>();

            carros.Add(new Carro()
            {
                Garagem = "",
                CarroPlaca = "",
                CarroMarca = "",
                CarroModelo = "",
                DataHoraEntrada = "",
                DataHoraSaida = "",
                FormaPagamento = "",
                PrecoTotal = "",

            });

            return carros;
            
        }

       

        // POST api/<Estapar>
        [HttpPost]
        public void Post([FromBody] Carro carro)
        {


        }

       


    }
}
