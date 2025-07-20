using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace Conexion
{
    public class CnxnTbCategorias
    {
        public List<Categoria> listarCategorias()
        {
                List<Categoria> lista = new List<Categoria>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.Consulta("select Descripcion from CARAGORIAS");
                    datos.EjecutarConsulta();

                    while (datos.Reader.Read())
                    {
                        Categoria aux = new Categoria();

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

        public void eliminarFisico(int idCategoria)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("DELETE FROM CATEGORIAS WHERE Id = @IdCategoria");
                accesoDatos.SetearParametros("@IdCategoria", idCategoria);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void agregarCategoria(string nuevaCategoria)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)");
                accesoDatos.SetearParametros("@Descripcion", nuevaCategoria);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarCategoria(int idCategoria, string nuevaCategoria)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @IdCategoria");
                accesoDatos.SetearParametros("@Descripcion", nuevaCategoria);
                accesoDatos.SetearParametros("@IdCategoria", idCategoria);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
