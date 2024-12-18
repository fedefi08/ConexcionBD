using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionaBdpyme.Models
{
    internal class Articulos
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        private string connectionString
            = "server=MSI\\SQLEXPRESS; initial catalog=BDPYME;" + 
            "User=sa;Password=it2990";

        public List<Articulos> Get()
        {
            List<Articulos> articulos = new List<Articulos>();

            string query = "SELECT IdArticulo, Nombre as NombreArticulo FROM Articulos";

            using (SqlConnection coneccion = new SqlConnection(connectionString) )
            {
                SqlCommand comando = new SqlCommand(query, coneccion);

                coneccion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string idarticulo = reader.GetString(0);
                    string Nombre = reader.GetString(1);
                    
                    Articulos artiWhile = new Articulos();
                    artiWhile.IdArticulo = Convert.ToInt32(idarticulo);
                    artiWhile.Nombre = Nombre;
                    articulos.Add(artiWhile);
                }

                reader.Close();
                coneccion.Close();
            }

                return articulos;
        }


    }
}
