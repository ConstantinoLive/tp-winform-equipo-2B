using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;



namespace AppGestionArt
{
    internal class ArticuloDatos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca,C.Descripcion Categoria,Precio, I.ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where M.Id=A.IdMarca and C.Id=A.IdCategoria and I.Id = A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdProductos = lector["Id"] != DBNull.Value ? Convert.ToInt32(lector["Id"]) : 0;
                    aux.CodArticulo = lector["Codigo"] != DBNull.Value ? lector["Codigo"].ToString() : string.Empty;
                    aux.Nombre = lector["Nombre"] != DBNull.Value ? lector["Nombre"].ToString() : string.Empty;
                    aux.Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : string.Empty;
                    aux.Marca=new Marca();
                    aux.Marca.marca = lector["Marca"] != DBNull.Value ? lector["Marca"].ToString() : string.Empty;
                    aux.Categoria= new Categoria();
                    aux.Categoria.categoria = lector["Categoria"] != DBNull.Value ? lector["Categoria"].ToString() : string.Empty;
                    aux.Precio = lector["Precio"] != DBNull.Value ? Convert.ToDouble(lector["Precio"]) : 0.0;
                    aux.UrlImagen = lector["ImagenUrl"] != DBNull.Value ? lector["ImagenUrl"].ToString() : string.Empty;
                     
                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la base de datos");
                throw;
              
            }

        }
    }
}
