using Conexion;
using Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionArt
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            MarcaDatos ArtMarca = new MarcaDatos();
            CategoriaDatos ArtCategoria = new CategoriaDatos();

            try
            {
                cbMarca.DataSource = ArtMarca.listarMarca();
                cbCategoria.DataSource = ArtCategoria.listarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CargarImagen(string imagen)
        {
            try
            {
                pcbAgregarArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbAgregarArt.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Articulo AgregarArticulo = new Articulo();
            ArticuloDatos articulos = new ArticuloDatos();
            CnxnTbArticulo AgregarArticuloBD = new CnxnTbArticulo();
            CnxnTbImagenes AgregarImagen = new CnxnTbImagenes();
            try
            {
                AgregarArticulo.CodArticulo = textCodigo.Text;
                AgregarArticulo.Nombre = textNombre.Text;
                AgregarArticulo.Descripcion = textDescripcion.Text;
                AgregarArticulo.Marca = (Marca)cbMarca.SelectedItem;
                AgregarArticulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                AgregarArticulo.Precio = double.Parse(textPrecio.Text);
                // AgregarArticulo.UrlImagen = new Imagenes();
                AgregarArticulo.UrlImagen = textUrlImagen.Text;

                AgregarArticuloBD.ingresar(AgregarArticulo);

                List<Articulo> listaId = articulos.listar();
                Articulo UltimoObjeto = listaId.Last();

                AgregarImagen.ingresarUrl(textUrlImagen.Text, UltimoObjeto.IdProductos);

                MessageBox.Show("Agregado exitosamente");
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(textUrlImagen.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
