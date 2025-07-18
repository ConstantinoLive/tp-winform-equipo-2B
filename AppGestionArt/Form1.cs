﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
            catch (Exception ex)
            {
                pcbArticulos.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(ArticuloSeleccionado.UrlImagen);
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
        }

        private void btntrash_Click(object sender, EventArgs e)
        {
            CnxnTbArticulo articulosDatos = new CnxnTbArticulo();
            CnxnTbImagenes imagenesDatos = new CnxnTbImagenes();
            Articulo seleccionado = new Articulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
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
        }
    }
}
