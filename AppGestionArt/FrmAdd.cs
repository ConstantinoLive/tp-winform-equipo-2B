using Conexion;
using Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionArt
{
    public partial class FrmAdd : Form
    {
        private List<Marca> listaMarca;

        private List<Categoria> listaCategorias;
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
                listaMarca = ArtMarca.listarMarca();
                listaCategorias = ArtCategoria.listarCategorias();

                List<Marca> DescripcionMarca = new List<Marca>();
                HashSet<string> DescMarca = new HashSet<string>();
                foreach (var art in listaMarca)
                {
                    if (DescMarca.Add(art.marca))
                    {
                        DescripcionMarca.Add(new Marca { id = art.id, marca = art.marca });
                    }

                }
                DescripcionMarca.Insert(0, new Marca { marca = "" });
                cbMarca.DataSource = DescripcionMarca;
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "marca";

                // ComboBox Categoria
                List<Categoria> DescripcionCategoria = new List<Categoria>();
                HashSet<string> DescCate = new HashSet<string>();
                foreach (var art in listaCategorias)
                {
                    if (DescCate.Add(art.categoria))
                    {
                        DescripcionCategoria.Add(new Categoria { Id = art.Id, categoria = art.categoria });
                    }

                }
                DescripcionCategoria.Insert(0, new Categoria { categoria = "" });
                cbCategoria.DataSource = DescripcionCategoria;
                cbCategoria.DisplayMember = "categoria";
                cbCategoria.ValueMember = "categoria";


                textDescripcion.MaxLength = 150;
                textDescripcion.TextChanged += textDescripcion_TextChanged;

                lblCaracteres.Text = "0/150";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {
            int caracteresActuales = textDescripcion.Text.Length;
            lblCaracteres.Text = caracteresActuales + "/150";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCodigo.Text) ||
               string.IsNullOrWhiteSpace(textNombre.Text) ||
               string.IsNullOrWhiteSpace(textDescripcion.Text) ||
               string.IsNullOrWhiteSpace(textPrecio.Text) ||
               cbMarca.SelectedIndex == -1 ||
               cbCategoria.SelectedIndex == -1 ||
               lstBxURL.Items.Count == 0)
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                //AgregarArticulo.UrlImagen = textUrlImagen.Text;

                AgregarArticuloBD.ingresar(AgregarArticulo);

                List<Articulo> listaId = articulos.listar();
                Articulo UltimoObjeto = listaId.Last();

                int nuevoId = UltimoObjeto.IdProductos;

                foreach (var url in lstBxURL.Items)
                {
                    AgregarImagen.ingresarUrl(url.ToString(), nuevoId);
                }

                MessageBox.Show("El artículo fue agregado exitosamente","Felicitaciones");
               
                limpiarRegistros();
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lstBxURL.Items.Add(textUrlImagen.Text);
            textUrlImagen.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lstBxURL.Items.Remove(lstBxURL.SelectedItem);
        }

        private void limpiarRegistros()
        {           
            textCodigo.Clear();
            textNombre.Clear();
            textDescripcion.Clear();
            textPrecio.Clear();
            cbMarca.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            lstBxURL.Items.Clear();
            textUrlImagen.Clear();
        }
    }
}
