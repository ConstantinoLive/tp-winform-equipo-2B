using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace Conexion
{
    public class CnxnTbMarcas
    {
        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("select Descripcion from MARCAS");
                datos.EjecutarConsulta();

                while (datos.Reader.Read())
                {
                    Marca aux = new Marca();

                    aux.marca = (string)datos.Reader["Descripcion"];
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
