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
            AccesoDatos IngresarDatos = new AccesoDatos();
            CnxnTbImagenes CargarImagen = new CnxnTbImagenes();

            try
            {
                IngresarDatos.Consulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) VALUES ('" + nuevo.CodArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', @IdMarca ,@IdCategoria ," + nuevo.Precio + ")");
                IngresarDatos.SetearParametros("@IdMarca", nuevo.Marca.id);
                IngresarDatos.SetearParametros("@IdCategoria", nuevo.Categoria.Id);
                IngresarDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                IngresarDatos.CerrarConexion();
            }

        }

        public void eliminarFisico(int idArticulo)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                accesoDatos.SetearParametros("@Id", idArticulo);
                //accesoDatos.SetearParametro("@Id", idArticulo);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Articulo existente)
        {

        }
    }
}
