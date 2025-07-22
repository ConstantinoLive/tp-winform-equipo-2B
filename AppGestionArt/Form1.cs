using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominios;
using Conexion;

namespace AppGestionArt
{
    public partial class Form1 : Form
    {
        private List<Imagenes> listaImagenesActual;
        private int indiceImagenActual;
        private int idArticuloActual;

        public Form1()
        {
            InitializeComponent();
            indiceImagenActual = 0;
            listaImagenesActual = new List<Imagenes>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Cargar();

        }

        private void Cargar()
        {
            
            ArticuloDatos datos = new ArticuloDatos();
            List<Articulo> lista = datos.listar();
            dgvArticulos.DataSource = datos.listar();
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            CargarImagen(lista[0].UrlImagen);

            lblCantidad.Text = $"{lista.Count}";

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pcbArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pcbArticulos.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //CargarImagen(ArticuloSeleccionado.UrlImagen);
            idArticuloActual = ArticuloSeleccionado.IdProductos;
            
            CargarImagenesArticulo(idArticuloActual);
            
            MostrarImagenActual();
        }

        private void CargarImagenesArticulo(int idArticulo)
        {
            ImagenesDatos imgDatos = new ImagenesDatos();
            listaImagenesActual = imgDatos.listarImagenes()
                .Where(img => img.IdArticulo == idArticulo).ToList();

            indiceImagenActual = 0;
      
            if (listaImagenesActual.Count <= 1)
            {
                BtnLeft.Enabled = false;
                BtnRight.Enabled = false;
            }
            else
            {
                BtnLeft.Enabled = true;
                BtnRight.Enabled = true;
            }
        }

        private void MostrarImagenActual()
        {
            if (listaImagenesActual.Count == 0)
            {
                pcbArticulos.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
                return;
            }

            try
            {
                pcbArticulos.Load(listaImagenesActual[indiceImagenActual].ImagenUrl);
            }
            catch (Exception)
            {
                pcbArticulos.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            FrmSerch frmSerch = new FrmSerch(); 
            frmSerch.ShowDialog();  
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();   
            frmAdd.ShowDialog();
            Cargar();
        }

        private void btntrash_Click(object sender, EventArgs e)
        {
            CnxnTbArticulo articulosDatos = new CnxnTbArticulo();
            CnxnTbImagenes imagenesDatos = new CnxnTbImagenes();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            try
            {
                DialogResult respuesta = MessageBox.Show($"¿De verdad desea eliminar el artículo  '{seleccionado.Nombre}'?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articulosDatos.eliminarFisico(seleccionado.IdProductos);
                    imagenesDatos.eliminarFisico(seleccionado.IdProductos);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            FrmModify frmModify = new FrmModify();  
            frmModify.ShowDialog();
            Cargar();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (listaImagenesActual.Count <= 1) return;

            indiceImagenActual--;
            if (indiceImagenActual < 0)
                indiceImagenActual = listaImagenesActual.Count - 1;

            MostrarImagenActual();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (listaImagenesActual.Count <= 1) return;

            indiceImagenActual++;
            if (indiceImagenActual >= listaImagenesActual.Count)
                indiceImagenActual = 0;

            MostrarImagenActual();
        }
    }
}
