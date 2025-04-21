using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace Conexion
{
    public class CategoriaDatos
    {
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("select Id, Descripcion from CATEGORIAS");
                datos.EjecutarConsulta();

                while (datos.Reader.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Reader["Id"];
                    aux.categoria = (string)datos.Reader["Descripcion"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
