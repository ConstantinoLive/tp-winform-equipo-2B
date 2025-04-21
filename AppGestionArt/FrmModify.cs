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
using Conexion;
using System.Collections;
using System.Text.RegularExpressions;


namespace AppGestionArt
{
    public partial class FrmModify : Form
    {
        private int indice;

        public FrmModify()
        {
            InitializeComponent();
            indice = 0;
        }

        private List<Articulo> listaArticulos;

        private List<Marca> listaMarca;

        private List<Categoria> listaCategorias;

        private List<Imagenes> listaImagenes;


        private void FrmModify_Load(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            MarcaDatos marca = new MarcaDatos();
            CategoriaDatos categoria = new CategoriaDatos();

            try
            {
                listaArticulos = datos.listar();
                listaMarca = marca.listarMarca();
                listaCategorias=categoria.listarCategorias();

                // ComboBox Código
                List<Articulo> codigos = new List<Articulo>();
                HashSet<string> codigosUnicos = new HashSet<string>();
                foreach (var art in listaArticulos)
                {
                    if (codigosUnicos.Add(art.CodArticulo)) // Agrega si no existía
                    {
                        codigos.Add(new Articulo { CodArticulo = art.CodArticulo });
                    }
                }
                codigos.Insert(0, new Articulo { CodArticulo = "" });
                cboxCodigo.DataSource = codigos;
                cboxCodigo.DisplayMember = "CodArticulo";
                cboxCodigo.ValueMember = "CodArticulo";

                cBoxICodigo.DataSource = codigos;
                cBoxICodigo.DisplayMember = "CodArticulo";
                cBoxICodigo.ValueMember = "CodArticulo";

                // ComboBox Nombre
                List<Articulo> nombres = new List<Articulo>();
                HashSet<string> nombresUnicos = new HashSet<string>();
                foreach (var art in listaArticulos)
                {
                    if (nombresUnicos.Add(art.Nombre))
                    {
                        nombres.Add(new Articulo { Nombre = art.Nombre });
                    }
                }
                nombres.Insert(0, new Articulo { Nombre = "" });
                cboxArticulo.DataSource = nombres;
                cboxArticulo.DisplayMember = "Nombre";
                cboxArticulo.ValueMember = "Nombre";

                cBoxINombre.DataSource = nombres;
                cBoxINombre.DisplayMember = "Nombre";
                cBoxINombre.ValueMember = "Nombre";


                // ComboBox Marca
                List<Marca> DescripcionMarca = new List<Marca>();
                HashSet<string> DescMarca = new HashSet<string>();
                foreach (var art in listaMarca)
                {
                    if (DescMarca.Add(art.marca))
                    {
                        DescripcionMarca.Add(new Marca { marca = art.marca });
                    }

                }
                DescripcionMarca.Insert(0, new Marca { marca = "" });
                cBoxMarca.DataSource = DescripcionMarca;
                cBoxMarca.DisplayMember = "marca";
                cBoxMarca.ValueMember = "marca";

                cBoxMMarca.DataSource = DescripcionMarca;
                cBoxMMarca.DisplayMember = "marca";
                cBoxMMarca.ValueMember = "marca";


                // ComboBox Categoria
                List<Categoria> DescripcionCategoria = new List<Categoria>();
                HashSet<string> DescCate = new HashSet<string>();
                foreach (var art in listaCategorias)
                {
                    if (DescCate.Add(art.categoria))
                    {
                        DescripcionCategoria.Add(new Categoria { categoria = art.categoria });
                    }

                }
                DescripcionCategoria.Insert(0, new Categoria { categoria = "" });
                cBoxCategoria.DataSource = DescripcionCategoria;
                cBoxCategoria.DisplayMember = "categoria";
                cBoxCategoria.ValueMember = "categoria";


                cBoxCCategoria.DataSource = DescripcionCategoria;
                cBoxCCategoria.DisplayMember = "categoria";
                cBoxCCategoria.ValueMember = "categoria";



                tBoxDescripcion.MaxLength = 150;
                tBoxDescripcion.TextChanged += tBoxDescripcion_TextChanged;

                lblCaracteres.Text = "0/150";

                DGVMarca.DataSource = marca.listarMarca();
                lblTotalRegistros.Text= $"{listaMarca.Count}";

                DGVCategoria.DataSource= categoria.listarCategorias();
                lblCTotalRegistros.Text = $"{listaCategorias.Count}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btonBuscar_Click(object sender, EventArgs e)
        {
            string codSeleccionado = cboxCodigo.Text;
            string nombreSeleccionado = cboxArticulo.Text;
            try
            {
                Articulo encontrado = listaArticulos.FirstOrDefault(x =>
                (string.IsNullOrEmpty(codSeleccionado) || x.CodArticulo == codSeleccionado) &&
                (string.IsNullOrEmpty(nombreSeleccionado) || x.Nombre == nombreSeleccionado));

                if (encontrado != null)
                {
                    tBoxCodigo.Text = encontrado.CodArticulo;
                    tBoxNombre.Text = encontrado.Nombre;
                    tBoxDescripcion.Text = encontrado.Descripcion;
                    cBoxMarca.Text = encontrado.Marca?.marca ?? "";
                    cBoxCategoria.Text = encontrado.Categoria?.categoria ?? "";
                    tBoxPrecio.Text = encontrado.Precio.ToString("C");

                    lblCaracteres.Text = encontrado.Descripcion.Length + "/150";

                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo con los criterios seleccionados.", "Resultado no encontrado", MessageBoxButtons.OK);

                    tBoxCodigo.Text =
                    tBoxNombre.Text =
                    tBoxDescripcion.Text =
                    cBoxMarca.Text =
                    cBoxCategoria.Text =
                    tBoxPrecio.Text = "";

                    lblCaracteres.Text = "0/150";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró ningún artículo con los criterios seleccionados.", "Resultado no encontrado", MessageBoxButtons.OK);
                // throw;
            }

        }
        private void tBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            int caracteresActuales = tBoxDescripcion.Text.Length;
            lblCaracteres.Text = caracteresActuales + "/150";
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            /*indice++;
            if (indice >7)
            {
                indice = 0;
            }
            lblImagen.ImageIndex = indice;*/

            if (imagenArt.Images.Count == 0) return;

            indice++;
            if (indice >= imagenArt.Images.Count)
                indice = 0;

            lblImagen.Image = imagenArt.Images[indice];
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            /* indice--;
             if (indice < 0)
             {
                 indice = 7;
             }
             lblImagen.ImageIndex = indice;*/

            if (imagenArt.Images.Count == 0) return;

            indice--;
            if (indice < 0)
                indice = imagenArt.Images.Count - 1;

            lblImagen.Image = imagenArt.Images[indice];
        }

        private void btnMBuscar_Click(object sender, EventArgs e)
        {
            List<Marca> listafiltradaMarcas;
            string filtro= cBoxMMarca.Text;

            if(filtro!="")
            {
                listafiltradaMarcas = listaMarca.FindAll(x => x.marca == filtro);
                
            }
            else
            {
                listafiltradaMarcas = listaMarca;
            }
            DGVMarca.DataSource = null;
            DGVMarca.DataSource = listafiltradaMarcas;

            tBoxNuevaMarca.Text= filtro;
        }

        private void btnCBuscar_Click(object sender, EventArgs e)
        {
            List<Categoria> listaFiltradaCategorias;
            string filtro= cBoxCCategoria.Text;

            if (filtro != "")
            {
                listaFiltradaCategorias = listaCategorias.FindAll(x => x.categoria == filtro);

            }
            else
            {
                listaFiltradaCategorias = listaCategorias;
            }
            DGVCategoria.DataSource = null;
            DGVCategoria.DataSource = listaFiltradaCategorias;

            tBoxNuevaCategoria.Text = filtro;
        }

        private void btnIBuscar_Click(object sender, EventArgs e)
        {
            string codSeleccionado = cBoxICodigo.Text;
            string nombreSeleccionado = cBoxINombre.Text;

            Articulo articuloSeleccionado = listaArticulos.FirstOrDefault(x =>
                (string.IsNullOrEmpty(codSeleccionado) || x.CodArticulo == codSeleccionado) &&
                (string.IsNullOrEmpty(nombreSeleccionado) || x.Nombre == nombreSeleccionado));

            if (articuloSeleccionado != null)
            {
                ImagenesDatos imgDatos = new ImagenesDatos();
                listaImagenes = imgDatos.listarImagenes();
                List<Imagenes> imagenesFiltradas = listaImagenes
                    .Where(img => img.IdArticulo == articuloSeleccionado.IdProductos).ToList();

                if (imagenesFiltradas.Count == 0)
                {
                    MessageBox.Show("No hay imágenes disponibles para este artículo.");
                    return;
                }

                imagenArt.Images.Clear();
                indice = 0;

                foreach (var imagen in imagenesFiltradas)
                {
                    try
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create(imagen.ImagenUrl);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Bitmap bmp = new Bitmap(responseStream);
                        imagenArt.Images.Add(bmp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar imagen desde URL: " + ex.Message);
                       
                       
                    }
                }

                if (imagenArt.Images.Count > 0)
                {
                    lblImagen.Image = imagenArt.Images[indice];
                }
                else
                {
                    MessageBox.Show("No se pudo cargar ninguna imagen para este artículo.");
                    lblImagen.Image = null; 
                }
               
                //lblImagen.Image = imagenArt.Images[indice];
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo válido.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
