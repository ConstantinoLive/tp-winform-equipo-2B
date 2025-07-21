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
using Dominios;

namespace AppGestionArt
{
    public partial class FrmSerch : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagenes> listaImagenes;
        private int indice;
        private int idArticuloActual;

        public FrmSerch()
        {
            InitializeComponent();
            indice = 0;
            listaImagenes = new List<Imagenes>();
            BtnLeft.Enabled = false;
            BtnRight.Enabled = false;
        }

        private void FrmSerch_Load(object sender, EventArgs e)
        {
            Cargar(); 
        }

        private void Cargar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                listaArticulos = datos.listar();


                // ComboBox Código
                List<Articulo> codigos = new List<Articulo>();
                HashSet<string> codigosUnicos = new HashSet<string>();
                foreach (var art in listaArticulos)
                {
                    if (codigosUnicos.Add(art.CodArticulo))
                    {
                        codigos.Add(new Articulo { CodArticulo = art.CodArticulo });
                    }
                }
                codigos.Insert(0, new Articulo { CodArticulo = "" });
                cBoxCodigo.DataSource = codigos;
                cBoxCodigo.DisplayMember = "CodArticulo";
                cBoxCodigo.ValueMember = "CodArticulo";


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
                cBoxNombre.DataSource = nombres;
                cBoxNombre.DisplayMember = "Nombre";
                cBoxNombre.ValueMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codSeleccionado = cBoxCodigo.Text;
            string nombreSeleccionado = cBoxNombre.Text;
            

            try
            {
                Articulo encontrado = listaArticulos.FirstOrDefault(x =>
                (string.IsNullOrEmpty(codSeleccionado) || x.CodArticulo == codSeleccionado) &&
                (string.IsNullOrEmpty(nombreSeleccionado) || x.Nombre == nombreSeleccionado));

                if (encontrado != null)
                {
                    idArticuloActual = encontrado.IdProductos;

                    lblResultadoID.Text = encontrado.IdProductos.ToString();
                    lblResultadoCodigo.Text = encontrado.CodArticulo;
                    lblResultadoNombre.Text = encontrado.Nombre;
                    tBoxResultadoDescripcion.Text = encontrado.Descripcion;
                    lblResultadoMarca.Text = encontrado.Marca?.marca ?? "";
                    lblResultadoCategoria.Text = encontrado.Categoria?.categoria ?? "";
                    lblResultadoPrecio.Text = encontrado.Precio.ToString("C");

                    CargarImagenesArticulo(encontrado.IdProductos);

                    MostrarImagenActual();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo con los criterios seleccionados.", "Resultado no encontrado", MessageBoxButtons.OK);

                    idArticuloActual = -1;
                    listaImagenes.Clear();

                    BtnLeft.Enabled = false;
                    BtnRight.Enabled = false;
                    lblResultadoID.Text =
                    lblResultadoCodigo.Text =
                    lblResultadoNombre.Text =
                    tBoxResultadoDescripcion.Text =
                    lblResultadoMarca.Text =
                    lblResultadoCategoria.Text =
                    lblResultadoPrecio.Text = "";
                    pcbSerch.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró ningún artículo con los criterios seleccionados." + ex.ToString(), "Resultado no encontrado", MessageBoxButtons.OK);
               // throw;
            }
        }

        private void CargarImagenesArticulo(int idArticulo)
        {
            ImagenesDatos imgDatos = new ImagenesDatos();
            listaImagenes = imgDatos.listarImagenes()
                .Where(img => img.IdArticulo == idArticulo).ToList();

            indice = 0; 
        }

        private void MostrarImagenActual()
        {
            if (listaImagenes.Count == 0)
            {
                BtnLeft.Enabled = false;
                BtnRight.Enabled = false;
                pcbSerch.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
                return;
            }

            try
            {
                if(listaImagenes.Count <=1)
                {
                    BtnLeft.Enabled = false;
                    BtnRight.Enabled = false;
                   
                }
                else
                {
                    BtnLeft.Enabled = true;
                    BtnRight.Enabled = true;
                }
                pcbSerch.Load(listaImagenes[indice].ImagenUrl);
            }
            catch (Exception)
            {
                pcbSerch.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
                
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;

            indice--;
            if (indice < 0)
                indice = listaImagenes.Count - 1;

            MostrarImagenActual();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;

            indice++;
            if (indice >= listaImagenes.Count)
                indice = 0;

            MostrarImagenActual();
        }
    }
}
