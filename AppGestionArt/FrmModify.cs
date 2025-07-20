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
using static System.Net.Mime.MediaTypeNames;


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

        private int idArticuloSeleccionado;


        private void FrmModify_Load(object sender, EventArgs e)
        {
            Cargar();
            tBoxDescripcion.MaxLength = 150;
            tBoxDescripcion.TextChanged += tBoxDescripcion_TextChanged;

            lblCaracteres.Text = "0/150";

           
        }

        private void Cargar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            MarcaDatos marca = new MarcaDatos();
            CategoriaDatos categoria = new CategoriaDatos();

            try
            {

                listaArticulos = datos.listar();
                listaMarca = marca.listarMarca();
                listaCategorias = categoria.listarCategorias();

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
                        DescripcionMarca.Add(new Marca { id = art.id, marca = art.marca });
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
                        DescripcionCategoria.Add(new Categoria { Id = art.Id, categoria = art.categoria });
                    }

                }
                DescripcionCategoria.Insert(0, new Categoria { categoria = "" });
                cBoxCategoria.DataSource = DescripcionCategoria;
                cBoxCategoria.DisplayMember = "categoria";
                cBoxCategoria.ValueMember = "categoria";


                cBoxCCategoria.DataSource = DescripcionCategoria;
                cBoxCCategoria.DisplayMember = "categoria";
                cBoxCCategoria.ValueMember = "categoria";

                DGVMarca.DataSource = marca.listarMarca();
                lblTotalRegistros.Text = $"{listaMarca.Count}";

                DGVCategoria.DataSource = categoria.listarCategorias();
                lblCTotalRegistros.Text = $"{listaCategorias.Count}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /*Modificacion de articulos*/
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
                    idArticuloSeleccionado = encontrado.IdProductos;
                    tBoxCodigo.Text = encontrado.CodArticulo;
                    tBoxNombre.Text = encontrado.Nombre;
                    tBoxDescripcion.Text = encontrado.Descripcion;
                    cBoxMarca.Text = encontrado.Marca?.marca ?? "";
                    cBoxCategoria.Text = encontrado.Categoria?.categoria ?? "";
                    tBoxPrecio.Text = encontrado.Precio.ToString();

                    lblCaracteres.Text = encontrado.Descripcion.Length + "/150";

                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo con los criterios seleccionados.", "Resultado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                MessageBox.Show(ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void tBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            int caracteresActuales = tBoxDescripcion.Text.Length;
            lblCaracteres.Text = caracteresActuales + "/150";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo ArticuloModificado = new Articulo();
            CnxnTbArticulo ModificarArticuloBD = new CnxnTbArticulo();

            try
            {
                ArticuloModificado.IdProductos = idArticuloSeleccionado;
                ArticuloModificado.CodArticulo = tBoxCodigo.Text;
                ArticuloModificado.Nombre = tBoxNombre.Text;
                ArticuloModificado.Descripcion = tBoxDescripcion.Text;
                ArticuloModificado.Marca = (Marca)cBoxMarca.SelectedItem;
                ArticuloModificado.Categoria = (Categoria)cBoxCategoria.SelectedItem;
                ArticuloModificado.Precio = double.Parse(tBoxPrecio.Text);

                ModificarArticuloBD.modificar(ArticuloModificado);

                DialogResult ok= MessageBox.Show("El artículo se ha modificado correctamente", "Modificación");
                if (ok == DialogResult.OK)
                {
                    limpiarTB();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El articulo no se ha podido modificar. " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiarTB()
        {
            cboxCodigo.Text=
            cboxArticulo.Text =
            tBoxCodigo.Text =
            tBoxNombre.Text =
            tBoxDescripcion.Text =
            cBoxMarca.Text =
            cBoxCategoria.Text =
            tBoxPrecio.Text = "";

            lblCaracteres.Text = "0/150";
        }

        /*Modificacion de imagenes*/

        private void btnIBuscar_Click(object sender, EventArgs e)
        {
            string codSeleccionado = cBoxICodigo.Text;
            string nombreSeleccionado = cBoxINombre.Text;
            string placeholderUrl = "https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg";

            Articulo articuloSeleccionado = listaArticulos.FirstOrDefault(x =>
                (string.IsNullOrEmpty(codSeleccionado) || x.CodArticulo == codSeleccionado) &&
                (string.IsNullOrEmpty(nombreSeleccionado) || x.Nombre == nombreSeleccionado));

            if (articuloSeleccionado != null)
            {
                ImagenesDatos imgDatos = new ImagenesDatos();
                listaImagenes = imgDatos.listarImagenes()
                    .Where(img => img.IdArticulo == articuloSeleccionado.IdProductos).ToList();

                idArticuloSeleccionado = articuloSeleccionado.IdProductos;

                if (listaImagenes.Count == 0)
                {
                    try
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create(placeholderUrl);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Bitmap bmp = new Bitmap(responseStream);
                        lblImagen.Image = bmp;
                        lblURL.Text = "El artículo no tiene imagenes cargadas";
                        btnDown.Enabled = false;
                        btnUP.Enabled = false;
                        /*imagenArt.Images.Add(bmp);
                        lblURL.Text = "";*/

                    }
                    catch (Exception ex)
                    {
                        imagenArt.Images.Clear();
                        lblImagen.Image = null;
                        lblURL.Text = "";
                        MessageBox.Show("Error al cargar imagen: " + ex.Message, "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                imagenArt.Images.Clear();
                indice = 0;
                btnDown.Enabled = true;
                btnUP.Enabled = true;

                foreach (var imagen in listaImagenes)
                {
                    if(listaImagenes.Count==1)
                    {
                        btnDown.Enabled = false;
                        btnUP.Enabled = false;
                    }
                    else
                    {
                        btnDown.Enabled = true;
                        btnUP.Enabled = true;
                    }
                    try
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create(imagen.ImagenUrl);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Bitmap bmp = new Bitmap(responseStream);
                        imagenArt.Images.Add(bmp);


                    }
                    catch (Exception)
                    {
                        try
                        {
                            System.Net.WebRequest request = System.Net.WebRequest.Create(placeholderUrl);
                            System.Net.WebResponse response = request.GetResponse();
                            System.IO.Stream responseStream = response.GetResponseStream();
                            Bitmap bmp = new Bitmap(responseStream);
                            /*lblImagen.Image = bmp;
                            lblURL.Text = "Imagen no disponible";*/
                            imagenArt.Images.Add(bmp);
                            lblURL.Text = "";
                        }
                        catch
                        {
                            imagenArt.Images.Add(new Bitmap(100, 100)); // Imagen en blanco
                        }
                    }
                }

                if (imagenArt.Images.Count > 0 && listaImagenes.Count > indice)
                {
                    lblImagen.Image = imagenArt.Images[indice];
                    lblURL.Text = listaImagenes[indice].ImagenUrl;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo válido.");
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if (imagenArt.Images.Count == 0) return;

            indice++;
            if (indice >= imagenArt.Images.Count)
                indice = 0;

            if (indice < imagenArt.Images.Count && indice < listaImagenes.Count)
            {
                lblImagen.Image = imagenArt.Images[indice];
                lblURL.Text = listaImagenes[indice].ImagenUrl;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (imagenArt.Images.Count == 0) return;

            indice--;
            if (indice < 0)
                indice = imagenArt.Images.Count - 1;

            if (indice < imagenArt.Images.Count && indice < listaImagenes.Count)
            {
                lblImagen.Image = imagenArt.Images[indice];
                lblURL.Text = listaImagenes[indice].ImagenUrl;
            }
        }

        private void btnIModificar_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (indice < 0 || indice >= listaImagenes.Count)
            {
                MessageBox.Show("Índice de imagen no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Imagenes imagenSeleccionada = listaImagenes[indice];
            CnxnTbImagenes datosImagen = new CnxnTbImagenes();
            string nuevaUrl = tBoxURL.Text.Trim();

            try
            {
                if(imagenSeleccionada.ImagenUrl== lblURL.Text)
                {
                    datosImagen.ModificarImagen(imagenSeleccionada.id, nuevaUrl);
                    MessageBox.Show("La imagen se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK);
                    tBoxURL.Text = "";
                    btnIBuscar_Click(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnIDelete_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (indice < 0 || indice >= listaImagenes.Count)
            {
                MessageBox.Show("Índice de imagen no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Imagenes imagenSeleccionada = listaImagenes[indice];
            CnxnTbImagenes datosImagen = new CnxnTbImagenes();
            string url= lblURL.Text.Trim();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar esta imagen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datosImagen.eliminarPorURL(url);
                    listaImagenes.RemoveAt(indice);
                    imagenArt.Images.RemoveAt(indice);

                    if (imagenArt.Images.Count > 0)
                    {
                        lblImagen.Image = imagenArt.Images[0];
                        lblURL.Text = listaImagenes[0].ImagenUrl;
                        indice = 0;
                    }
                    else
                    {
                        lblImagen.Image = null;
                        lblURL.Text = "";
                        indice = -1; // No hay imágenes
                    }

                    btnIBuscar_Click(sender, e);

                    MessageBox.Show("La imagen se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnIAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxURL.Text))
            {
                MessageBox.Show("Debe ingresar una URL válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevaUrl = tBoxURL.Text.Trim();
            CnxnTbImagenes datosImagen = new CnxnTbImagenes();
            
            try
            {
                if (idArticuloSeleccionado <= 0)
                {
                    MessageBox.Show("Debe seleccionar un artículo antes de agregar una imagen.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datosImagen.ingresarUrl(nuevaUrl, idArticuloSeleccionado);
                listaImagenes.Add(new Imagenes { ImagenUrl = nuevaUrl, IdArticulo = idArticuloSeleccionado });
                //imagenArt.Images.Add(new Bitmap(100, 100)); // Imagen en blanco como placeholder

                lblURL.Text = nuevaUrl;
                tBoxURL.Text = ""; // Limpiar el campo de entrada

                MessageBox.Show("La imagen se ha agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                btnIBuscar_Click(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*Modificacion de marcas*/
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
        private void BtnMEliminar_Click(object sender, EventArgs e)
        {
            if (DGVMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una marca para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Marca marcaSeleccionada = (Marca)DGVMarca.SelectedRows[0].DataBoundItem;
            CnxnTbMarcas datosMarca = new CnxnTbMarcas();

            try
            {
                DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar la marca '{marcaSeleccionada.marca}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datosMarca.eliminarFisico(marcaSeleccionada.id);
                    MessageBox.Show("La marca se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK);
                    Cargar();
                    tBoxNuevaMarca.Text =
                    cBoxMMarca.Text = "";
                    btnCBuscar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnMAgregar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = tBoxNuevaMarca.Text.Trim();
            CnxnTbMarcas datosMarca = new CnxnTbMarcas();

            try
            {
                if (string.IsNullOrWhiteSpace(nuevaMarca))
                {
                    MessageBox.Show("Debe ingresar una marca válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datosMarca.agregarMarca(nuevaMarca);

                MessageBox.Show("La marca se ha agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                Cargar();
                tBoxNuevaMarca.Text =
                cBoxMMarca.Text = "";

                btnMBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnMModificar_Click(object sender, EventArgs e)
        {
            if (DGVMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una marca para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Marca marcaSeleccionada = (Marca)DGVMarca.SelectedRows[0].DataBoundItem;
            CnxnTbMarcas datosMarca = new CnxnTbMarcas();
            string nuevaMarca = tBoxNuevaMarca.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(nuevaMarca))
                {
                    MessageBox.Show("Debe ingresar una marca válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datosMarca.modificarMarca(marcaSeleccionada.id, nuevaMarca);

                MessageBox.Show("La marca se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK);
                Cargar();
                tBoxNuevaMarca.Text =
                cBoxMMarca.Text = "";
                btnMBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*Modificacion de categorias*/
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

        private void BtnCAgregar_Click(object sender, EventArgs e)
        {
            string nuevaCategoria = tBoxNuevaCategoria.Text.Trim();
            CnxnTbCategorias datosCategoria = new CnxnTbCategorias();

            try
            {
                if (string.IsNullOrWhiteSpace(nuevaCategoria))
                {
                    MessageBox.Show("Debe ingresar una categoría válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datosCategoria.agregarCategoria(nuevaCategoria);

                MessageBox.Show("La categoría se ha agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                Cargar();
                tBoxNuevaCategoria.Text =
                cBoxCCategoria.Text = "";

                btnCBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCEliminar_Click(object sender, EventArgs e)
        {
            if (DGVCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)DGVCategoria.SelectedRows[0].DataBoundItem;
            CnxnTbCategorias datosCategoria = new CnxnTbCategorias();

            try
            {
                DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar la categoría '{categoriaSeleccionada.categoria}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datosCategoria.eliminarFisico(categoriaSeleccionada.Id);
                    MessageBox.Show("La categoría se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK);
                    Cargar();
                    tBoxNuevaCategoria.Text =
                    cBoxCCategoria.Text = "";
                    btnCBuscar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCModificar_Click(object sender, EventArgs e)
        {
            if (DGVCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)DGVCategoria.SelectedRows[0].DataBoundItem;
            CnxnTbCategorias datosCategoria = new CnxnTbCategorias();
            string nuevaCategoria = tBoxNuevaCategoria.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(nuevaCategoria))
                {
                    MessageBox.Show("Debe ingresar una categoría válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datosCategoria.modificarCategoria(categoriaSeleccionada.Id, nuevaCategoria);

                MessageBox.Show("La categoría se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK);
                Cargar();
                tBoxNuevaCategoria.Text =
                cBoxCCategoria.Text = "";
                btnCBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
