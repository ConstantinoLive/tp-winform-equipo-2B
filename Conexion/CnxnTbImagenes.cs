﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace Conexion
{
    public class CnxnTbImagenes
    {
        public List<Imagenes> listarImagenes()
        {
            List<Imagenes> lista = new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("select ImagenUrl from IMAGENES");
                datos.EjecutarConsulta();

                while (datos.Reader.Read())
                {
                    Imagenes aux = new Imagenes();

                    aux.IdArticulo = (int)datos.Reader["IdArticulo"];
                    aux.id = (int)datos.Reader["IdImagen"];
                    aux.ImagenUrl = (string)datos.Reader["ImagenUrl"];
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

        public void eliminarFisico(int idArticulo)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                accesoDatos.SetearParametros("@IdArticulo", idArticulo);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
 
        }

        /*Modulo agregar*/

        public void ingresarUrl(string nuevo, int id)
        {
            AccesoDatos IngresarDatos = new AccesoDatos();

            try
            {
                IngresarDatos.Consulta("INSERT INTO IMAGENES (IdArticulo,ImagenUrl) VALUES (@IdArticulos,@ImagenUrl)");
                IngresarDatos.SetearParametros("@IdArticulos", id);
                IngresarDatos.SetearParametros("@ImagenUrl", nuevo);
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
        /*Modulo modificar*/

        public void ModificarImagen(int id, string nuevo)
        {
            AccesoDatos ModificarDatos = new AccesoDatos();

            try
            {
                ModificarDatos.Consulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl WHERE Id = @IdImagen");
                ModificarDatos.SetearParametros("@IdImagen", id);
                ModificarDatos.SetearParametros("@ImagenUrl", nuevo);
                ModificarDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ModificarDatos.CerrarConexion();
            }
        }

        public void eliminarPorURL(string url)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.Consulta("DELETE FROM IMAGENES WHERE ImagenUrl = @URL");
                accesoDatos.SetearParametros("@URL", url);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
