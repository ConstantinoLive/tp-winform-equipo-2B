using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominios;

namespace Conexion
{
    public class CnxnTbArticulo
    {
        public List<Articulo> listarCodArt()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("select Codigo from ARTICULOS");
                datos.EjecutarConsulta();

                while(datos.Reader.Read())
                {
                    Articulo aux = new Articulo();

                    aux.CodArticulo=(string)datos.Reader["Codigo"];
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

        public List<Articulo> listarNombreArt()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("select nombre from ARTICULOS");
                datos.EjecutarConsulta();

                while (datos.Reader.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Nombre = (string)datos.Reader["Nombre"];
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

        public void buscar(Articulo existente)
        {

        }

        public void ingresar(Articulo nuevo)
        {

        }

        public void eliminar(Articulo existente)
        {

        }

        public void modificar(Articulo existente)
        {

        }
    }
}
