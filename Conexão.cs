namespace Estapar.Controllers.Dao
{
    public class Conexão
    {

        String Conexao = @"Data Source=VALDO\SQLEXPRESS;Initial Catalog=CARROS;Integrated Security=True";

        public List<Carros> GetCarros() 
        {
            List<Carros> Carros = new List<Carros>();
            return Carros;

        }

    }
}
