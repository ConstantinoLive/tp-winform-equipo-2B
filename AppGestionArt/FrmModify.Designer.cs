namespace AppGestionArt
{
    partial class FrmModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModify));
            this.imagenArt = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCModificar = new System.Windows.Forms.Button();
            this.lblCTotalRegistros = new System.Windows.Forms.Label();
            this.lblCRegistos = new System.Windows.Forms.Label();
            this.tBoxNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblCNuevaCategoria = new System.Windows.Forms.Label();
            this.btnCBuscar = new System.Windows.Forms.Button();
            this.cBoxCCategoria = new System.Windows.Forms.ComboBox();
            this.lblCCategoria = new System.Windows.Forms.Label();
            this.DGVCategoria = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnMAgregar = new System.Windows.Forms.Button();
            this.BtnMEliminar = new System.Windows.Forms.Button();
            this.btnMModificar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblMRegistros = new System.Windows.Forms.Label();
            this.tBoxNuevaMarca = new System.Windows.Forms.TextBox();
            this.lblNMarca = new System.Windows.Forms.Label();
            this.btnMBuscar = new System.Windows.Forms.Button();
            this.cBoxMMarca = new System.Windows.Forms.ComboBox();
            this.lblMMarca = new System.Windows.Forms.Label();
            this.DGVMarca = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnIAgregar = new System.Windows.Forms.Button();
            this.BtnIDelete = new System.Windows.Forms.Button();
            this.lblIURL = new System.Windows.Forms.Label();
            this.btnIModificar = new System.Windows.Forms.Button();
            this.tBoxURL = new System.Windows.Forms.TextBox();
            this.lblURLNueva = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnIBuscar = new System.Windows.Forms.Button();
            this.cBoxINombre = new System.Windows.Forms.ComboBox();
            this.cBoxICodigo = new System.Windows.Forms.ComboBox();
            this.lblINombre = new System.Windows.Forms.Label();
            this.lblICodigo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.tBoxPrecio = new System.Windows.Forms.TextBox();
            this.tBoxDescripcion = new System.Windows.Forms.TextBox();
            this.tBoxNombre = new System.Windows.Forms.TextBox();
            this.tBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblAPrecio = new System.Windows.Forms.Label();
            this.lblACategoria = new System.Windows.Forms.Label();
            this.lblAMarca = new System.Windows.Forms.Label();
            this.lblADecripcion = new System.Windows.Forms.Label();
            this.lblANombre = new System.Windows.Forms.Label();
            this.lblACodigo = new System.Windows.Forms.Label();
            this.btonBuscar = new System.Windows.Forms.Button();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.cboxCodigo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabModify = new System.Windows.Forms.TabControl();
            this.BtnCAgregar = new System.Windows.Forms.Button();
            this.BtnCEliminar = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarca)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenArt
            // 
            this.imagenArt.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imagenArt.ImageSize = new System.Drawing.Size(150, 150);
            this.imagenArt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.BtnCEliminar);
            this.tabPage4.Controls.Add(this.BtnCAgregar);
            this.tabPage4.Controls.Add(this.btnCModificar);
            this.tabPage4.Controls.Add(this.lblCTotalRegistros);
            this.tabPage4.Controls.Add(this.lblCRegistos);
            this.tabPage4.Controls.Add(this.tBoxNuevaCategoria);
            this.tabPage4.Controls.Add(this.lblCNuevaCategoria);
            this.tabPage4.Controls.Add(this.btnCBuscar);
            this.tabPage4.Controls.Add(this.cBoxCCategoria);
            this.tabPage4.Controls.Add(this.lblCCategoria);
            this.tabPage4.Controls.Add(this.DGVCategoria);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(665, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Categoría";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCModificar
            // 
            this.btnCModificar.AutoSize = true;
            this.btnCModificar.BackColor = System.Drawing.Color.Gray;
            this.btnCModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnCModificar.Image")));
            this.btnCModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCModificar.Location = new System.Drawing.Point(434, 479);
            this.btnCModificar.Name = "btnCModificar";
            this.btnCModificar.Size = new System.Drawing.Size(145, 50);
            this.btnCModificar.TabIndex = 28;
            this.btnCModificar.Text = "Modificar";
            this.btnCModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCModificar.UseVisualStyleBackColor = false;
            this.btnCModificar.Click += new System.EventHandler(this.btnCModificar_Click);
            // 
            // lblCTotalRegistros
            // 
            this.lblCTotalRegistros.AutoSize = true;
            this.lblCTotalRegistros.ForeColor = System.Drawing.Color.White;
            this.lblCTotalRegistros.Location = new System.Drawing.Point(157, 349);
            this.lblCTotalRegistros.Name = "lblCTotalRegistros";
            this.lblCTotalRegistros.Size = new System.Drawing.Size(0, 16);
            this.lblCTotalRegistros.TabIndex = 27;
            // 
            // lblCRegistos
            // 
            this.lblCRegistos.AutoSize = true;
            this.lblCRegistos.ForeColor = System.Drawing.Color.White;
            this.lblCRegistos.Location = new System.Drawing.Point(86, 349);
            this.lblCRegistos.Name = "lblCRegistos";
            this.lblCRegistos.Size = new System.Drawing.Size(68, 16);
            this.lblCRegistos.TabIndex = 26;
            this.lblCRegistos.Text = "Registros:";
            // 
            // tBoxNuevaCategoria
            // 
            this.tBoxNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNuevaCategoria.Location = new System.Drawing.Point(190, 396);
            this.tBoxNuevaCategoria.Name = "tBoxNuevaCategoria";
            this.tBoxNuevaCategoria.Size = new System.Drawing.Size(422, 30);
            this.tBoxNuevaCategoria.TabIndex = 25;
            // 
            // lblCNuevaCategoria
            // 
            this.lblCNuevaCategoria.AutoSize = true;
            this.lblCNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCNuevaCategoria.Location = new System.Drawing.Point(25, 399);
            this.lblCNuevaCategoria.Name = "lblCNuevaCategoria";
            this.lblCNuevaCategoria.Size = new System.Drawing.Size(159, 25);
            this.lblCNuevaCategoria.TabIndex = 24;
            this.lblCNuevaCategoria.Text = "Nueva Categoría";
            // 
            // btnCBuscar
            // 
            this.btnCBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCBuscar.AutoSize = true;
            this.btnCBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnCBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCBuscar.FlatAppearance.BorderSize = 0;
            this.btnCBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnCBuscar.Image")));
            this.btnCBuscar.Location = new System.Drawing.Point(412, 13);
            this.btnCBuscar.Name = "btnCBuscar";
            this.btnCBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnCBuscar.TabIndex = 23;
            this.btnCBuscar.UseVisualStyleBackColor = false;
            this.btnCBuscar.Click += new System.EventHandler(this.btnCBuscar_Click);
            // 
            // cBoxCCategoria
            // 
            this.cBoxCCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCCategoria.FormattingEnabled = true;
            this.cBoxCCategoria.Location = new System.Drawing.Point(149, 14);
            this.cBoxCCategoria.Name = "cBoxCCategoria";
            this.cBoxCCategoria.Size = new System.Drawing.Size(246, 37);
            this.cBoxCCategoria.TabIndex = 22;
            // 
            // lblCCategoria
            // 
            this.lblCCategoria.AutoSize = true;
            this.lblCCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.lblCCategoria.Location = new System.Drawing.Point(28, 18);
            this.lblCCategoria.Name = "lblCCategoria";
            this.lblCCategoria.Size = new System.Drawing.Size(118, 29);
            this.lblCCategoria.TabIndex = 21;
            this.lblCCategoria.Text = "Categoría";
            // 
            // DGVCategoria
            // 
            this.DGVCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoria.Location = new System.Drawing.Point(53, 89);
            this.DGVCategoria.Name = "DGVCategoria";
            this.DGVCategoria.RowHeadersWidth = 51;
            this.DGVCategoria.RowTemplate.Height = 24;
            this.DGVCategoria.Size = new System.Drawing.Size(559, 257);
            this.DGVCategoria.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.BtnMAgregar);
            this.tabPage3.Controls.Add(this.BtnMEliminar);
            this.tabPage3.Controls.Add(this.btnMModificar);
            this.tabPage3.Controls.Add(this.lblTotalRegistros);
            this.tabPage3.Controls.Add(this.lblMRegistros);
            this.tabPage3.Controls.Add(this.tBoxNuevaMarca);
            this.tabPage3.Controls.Add(this.lblNMarca);
            this.tabPage3.Controls.Add(this.btnMBuscar);
            this.tabPage3.Controls.Add(this.cBoxMMarca);
            this.tabPage3.Controls.Add(this.lblMMarca);
            this.tabPage3.Controls.Add(this.DGVMarca);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnMAgregar
            // 
            this.BtnMAgregar.BackColor = System.Drawing.Color.Gray;
            this.BtnMAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnMAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMAgregar.Image")));
            this.BtnMAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMAgregar.Location = new System.Drawing.Point(110, 479);
            this.BtnMAgregar.Name = "BtnMAgregar";
            this.BtnMAgregar.Size = new System.Drawing.Size(145, 50);
            this.BtnMAgregar.TabIndex = 21;
            this.BtnMAgregar.Text = "Agregar";
            this.BtnMAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMAgregar.UseVisualStyleBackColor = false;
            this.BtnMAgregar.Click += new System.EventHandler(this.BtnMAgregar_Click);
            // 
            // BtnMEliminar
            // 
            this.BtnMEliminar.BackColor = System.Drawing.Color.Gray;
            this.BtnMEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnMEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMEliminar.Image")));
            this.BtnMEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMEliminar.Location = new System.Drawing.Point(273, 479);
            this.BtnMEliminar.Name = "BtnMEliminar";
            this.BtnMEliminar.Size = new System.Drawing.Size(145, 50);
            this.BtnMEliminar.TabIndex = 20;
            this.BtnMEliminar.Text = "Eliminar";
            this.BtnMEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMEliminar.UseVisualStyleBackColor = false;
            this.BtnMEliminar.Click += new System.EventHandler(this.BtnMEliminar_Click);
            // 
            // btnMModificar
            // 
            this.btnMModificar.AutoSize = true;
            this.btnMModificar.BackColor = System.Drawing.Color.Gray;
            this.btnMModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnMModificar.Image")));
            this.btnMModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMModificar.Location = new System.Drawing.Point(434, 479);
            this.btnMModificar.Name = "btnMModificar";
            this.btnMModificar.Size = new System.Drawing.Size(145, 50);
            this.btnMModificar.TabIndex = 19;
            this.btnMModificar.Text = "Modificar";
            this.btnMModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMModificar.UseVisualStyleBackColor = false;
            this.btnMModificar.Click += new System.EventHandler(this.btnMModificar_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.White;
            this.lblTotalRegistros.Location = new System.Drawing.Point(157, 349);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRegistros.TabIndex = 18;
            // 
            // lblMRegistros
            // 
            this.lblMRegistros.AutoSize = true;
            this.lblMRegistros.ForeColor = System.Drawing.Color.White;
            this.lblMRegistros.Location = new System.Drawing.Point(86, 349);
            this.lblMRegistros.Name = "lblMRegistros";
            this.lblMRegistros.Size = new System.Drawing.Size(68, 16);
            this.lblMRegistros.TabIndex = 17;
            this.lblMRegistros.Text = "Registros:";
            // 
            // tBoxNuevaMarca
            // 
            this.tBoxNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNuevaMarca.Location = new System.Drawing.Point(160, 396);
            this.tBoxNuevaMarca.Name = "tBoxNuevaMarca";
            this.tBoxNuevaMarca.Size = new System.Drawing.Size(444, 30);
            this.tBoxNuevaMarca.TabIndex = 16;
            // 
            // lblNMarca
            // 
            this.lblNMarca.AutoSize = true;
            this.lblNMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNMarca.ForeColor = System.Drawing.Color.White;
            this.lblNMarca.Location = new System.Drawing.Point(25, 399);
            this.lblNMarca.Name = "lblNMarca";
            this.lblNMarca.Size = new System.Drawing.Size(129, 25);
            this.lblNMarca.TabIndex = 15;
            this.lblNMarca.Text = "Nueva Marca";
            // 
            // btnMBuscar
            // 
            this.btnMBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMBuscar.AutoSize = true;
            this.btnMBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnMBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnMBuscar.FlatAppearance.BorderSize = 0;
            this.btnMBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnMBuscar.Image")));
            this.btnMBuscar.Location = new System.Drawing.Point(385, 13);
            this.btnMBuscar.Name = "btnMBuscar";
            this.btnMBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnMBuscar.TabIndex = 14;
            this.btnMBuscar.UseVisualStyleBackColor = false;
            this.btnMBuscar.Click += new System.EventHandler(this.btnMBuscar_Click);
            // 
            // cBoxMMarca
            // 
            this.cBoxMMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMMarca.FormattingEnabled = true;
            this.cBoxMMarca.Location = new System.Drawing.Point(123, 14);
            this.cBoxMMarca.Name = "cBoxMMarca";
            this.cBoxMMarca.Size = new System.Drawing.Size(246, 37);
            this.cBoxMMarca.TabIndex = 13;
            // 
            // lblMMarca
            // 
            this.lblMMarca.AutoSize = true;
            this.lblMMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMMarca.ForeColor = System.Drawing.Color.DimGray;
            this.lblMMarca.Location = new System.Drawing.Point(15, 18);
            this.lblMMarca.Name = "lblMMarca";
            this.lblMMarca.Size = new System.Drawing.Size(79, 29);
            this.lblMMarca.TabIndex = 11;
            this.lblMMarca.Text = "Marca";
            // 
            // DGVMarca
            // 
            this.DGVMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMarca.Location = new System.Drawing.Point(53, 89);
            this.DGVMarca.Name = "DGVMarca";
            this.DGVMarca.RowHeadersWidth = 51;
            this.DGVMarca.RowTemplate.Height = 24;
            this.DGVMarca.Size = new System.Drawing.Size(559, 254);
            this.DGVMarca.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.BtnIAgregar);
            this.tabPage2.Controls.Add(this.BtnIDelete);
            this.tabPage2.Controls.Add(this.lblIURL);
            this.tabPage2.Controls.Add(this.btnIModificar);
            this.tabPage2.Controls.Add(this.tBoxURL);
            this.tabPage2.Controls.Add(this.lblURLNueva);
            this.tabPage2.Controls.Add(this.lblURL);
            this.tabPage2.Controls.Add(this.btnDown);
            this.tabPage2.Controls.Add(this.btnUP);
            this.tabPage2.Controls.Add(this.lblImagen);
            this.tabPage2.Controls.Add(this.btnIBuscar);
            this.tabPage2.Controls.Add(this.cBoxINombre);
            this.tabPage2.Controls.Add(this.cBoxICodigo);
            this.tabPage2.Controls.Add(this.lblINombre);
            this.tabPage2.Controls.Add(this.lblICodigo);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imagen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnIAgregar
            // 
            this.BtnIAgregar.BackColor = System.Drawing.Color.Gray;
            this.BtnIAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnIAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnIAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnIAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnIAgregar.Image")));
            this.BtnIAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIAgregar.Location = new System.Drawing.Point(110, 479);
            this.BtnIAgregar.Name = "BtnIAgregar";
            this.BtnIAgregar.Size = new System.Drawing.Size(145, 50);
            this.BtnIAgregar.TabIndex = 19;
            this.BtnIAgregar.Text = "Agregar";
            this.BtnIAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIAgregar.UseVisualStyleBackColor = false;
            this.BtnIAgregar.Click += new System.EventHandler(this.BtnIAgregar_Click);
            // 
            // BtnIDelete
            // 
            this.BtnIDelete.BackColor = System.Drawing.Color.Gray;
            this.BtnIDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnIDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnIDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnIDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnIDelete.Image")));
            this.BtnIDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIDelete.Location = new System.Drawing.Point(273, 479);
            this.BtnIDelete.Name = "BtnIDelete";
            this.BtnIDelete.Size = new System.Drawing.Size(145, 50);
            this.BtnIDelete.TabIndex = 18;
            this.BtnIDelete.Text = "Eliminar";
            this.BtnIDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIDelete.UseVisualStyleBackColor = false;
            this.BtnIDelete.Click += new System.EventHandler(this.BtnIDelete_Click);
            // 
            // lblIURL
            // 
            this.lblIURL.AutoSize = true;
            this.lblIURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIURL.ForeColor = System.Drawing.Color.White;
            this.lblIURL.Location = new System.Drawing.Point(92, 387);
            this.lblIURL.Name = "lblIURL";
            this.lblIURL.Size = new System.Drawing.Size(43, 20);
            this.lblIURL.TabIndex = 17;
            this.lblIURL.Text = "URL";
            // 
            // btnIModificar
            // 
            this.btnIModificar.BackColor = System.Drawing.Color.Gray;
            this.btnIModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnIModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnIModificar.Image")));
            this.btnIModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIModificar.Location = new System.Drawing.Point(434, 479);
            this.btnIModificar.Name = "btnIModificar";
            this.btnIModificar.Size = new System.Drawing.Size(145, 50);
            this.btnIModificar.TabIndex = 16;
            this.btnIModificar.Text = "Modificar";
            this.btnIModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIModificar.UseVisualStyleBackColor = false;
            this.btnIModificar.Click += new System.EventHandler(this.btnIModificar_Click);
            // 
            // tBoxURL
            // 
            this.tBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxURL.Location = new System.Drawing.Point(144, 429);
            this.tBoxURL.Name = "tBoxURL";
            this.tBoxURL.Size = new System.Drawing.Size(320, 26);
            this.tBoxURL.TabIndex = 15;
            // 
            // lblURLNueva
            // 
            this.lblURLNueva.AutoSize = true;
            this.lblURLNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLNueva.ForeColor = System.Drawing.Color.White;
            this.lblURLNueva.Location = new System.Drawing.Point(41, 432);
            this.lblURLNueva.Name = "lblURLNueva";
            this.lblURLNueva.Size = new System.Drawing.Size(95, 20);
            this.lblURLNueva.TabIndex = 14;
            this.lblURLNueva.Text = "Nueva URL";
            // 
            // lblURL
            // 
            this.lblURL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblURL.Location = new System.Drawing.Point(144, 386);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(320, 23);
            this.lblURL.TabIndex = 13;
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(516, 211);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(38, 38);
            this.btnDown.TabIndex = 12;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUP
            // 
            this.btnUP.AutoSize = true;
            this.btnUP.BackColor = System.Drawing.Color.Transparent;
            this.btnUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUP.FlatAppearance.BorderSize = 0;
            this.btnUP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUP.Image = ((System.Drawing.Image)(resources.GetObject("btnUP.Image")));
            this.btnUP.Location = new System.Drawing.Point(516, 132);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(38, 38);
            this.btnUP.TabIndex = 11;
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.BackColor = System.Drawing.Color.White;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Black;
            this.lblImagen.ImageList = this.imagenArt;
            this.lblImagen.Location = new System.Drawing.Point(141, 77);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(320, 288);
            this.lblImagen.TabIndex = 10;
            // 
            // btnIBuscar
            // 
            this.btnIBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIBuscar.AutoSize = true;
            this.btnIBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnIBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnIBuscar.FlatAppearance.BorderSize = 0;
            this.btnIBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnIBuscar.Image")));
            this.btnIBuscar.Location = new System.Drawing.Point(616, 13);
            this.btnIBuscar.Name = "btnIBuscar";
            this.btnIBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnIBuscar.TabIndex = 9;
            this.btnIBuscar.UseVisualStyleBackColor = false;
            this.btnIBuscar.Click += new System.EventHandler(this.btnIBuscar_Click);
            // 
            // cBoxINombre
            // 
            this.cBoxINombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxINombre.FormattingEnabled = true;
            this.cBoxINombre.Location = new System.Drawing.Point(392, 14);
            this.cBoxINombre.Name = "cBoxINombre";
            this.cBoxINombre.Size = new System.Drawing.Size(207, 37);
            this.cBoxINombre.TabIndex = 8;
            // 
            // cBoxICodigo
            // 
            this.cBoxICodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxICodigo.FormattingEnabled = true;
            this.cBoxICodigo.Location = new System.Drawing.Point(110, 14);
            this.cBoxICodigo.Name = "cBoxICodigo";
            this.cBoxICodigo.Size = new System.Drawing.Size(159, 37);
            this.cBoxICodigo.TabIndex = 7;
            // 
            // lblINombre
            // 
            this.lblINombre.AutoSize = true;
            this.lblINombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblINombre.Location = new System.Drawing.Point(288, 18);
            this.lblINombre.Name = "lblINombre";
            this.lblINombre.Size = new System.Drawing.Size(101, 29);
            this.lblINombre.TabIndex = 6;
            this.lblINombre.Text = "Nombre";
            // 
            // lblICodigo
            // 
            this.lblICodigo.AutoSize = true;
            this.lblICodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblICodigo.Location = new System.Drawing.Point(15, 18);
            this.lblICodigo.Name = "lblICodigo";
            this.lblICodigo.Size = new System.Drawing.Size(92, 29);
            this.lblICodigo.TabIndex = 5;
            this.lblICodigo.Text = "Código";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lblCaracteres);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.cBoxCategoria);
            this.tabPage1.Controls.Add(this.cBoxMarca);
            this.tabPage1.Controls.Add(this.tBoxPrecio);
            this.tabPage1.Controls.Add(this.tBoxDescripcion);
            this.tabPage1.Controls.Add(this.tBoxNombre);
            this.tabPage1.Controls.Add(this.tBoxCodigo);
            this.tabPage1.Controls.Add(this.lblAPrecio);
            this.tabPage1.Controls.Add(this.lblACategoria);
            this.tabPage1.Controls.Add(this.lblAMarca);
            this.tabPage1.Controls.Add(this.lblADecripcion);
            this.tabPage1.Controls.Add(this.lblANombre);
            this.tabPage1.Controls.Add(this.lblACodigo);
            this.tabPage1.Controls.Add(this.btonBuscar);
            this.tabPage1.Controls.Add(this.cboxArticulo);
            this.tabPage1.Controls.Add(this.cboxCodigo);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artículo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteres.Location = new System.Drawing.Point(505, 274);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(0, 15);
            this.lblCaracteres.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(392, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 50);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(184, 359);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(379, 33);
            this.cBoxCategoria.TabIndex = 16;
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(184, 306);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(379, 33);
            this.cBoxMarca.TabIndex = 15;
            // 
            // tBoxPrecio
            // 
            this.tBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPrecio.Location = new System.Drawing.Point(184, 414);
            this.tBoxPrecio.Name = "tBoxPrecio";
            this.tBoxPrecio.Size = new System.Drawing.Size(379, 30);
            this.tBoxPrecio.TabIndex = 14;
            // 
            // tBoxDescripcion
            // 
            this.tBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDescripcion.Location = new System.Drawing.Point(184, 180);
            this.tBoxDescripcion.Multiline = true;
            this.tBoxDescripcion.Name = "tBoxDescripcion";
            this.tBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDescripcion.Size = new System.Drawing.Size(379, 91);
            this.tBoxDescripcion.TabIndex = 13;
            // 
            // tBoxNombre
            // 
            this.tBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNombre.Location = new System.Drawing.Point(184, 134);
            this.tBoxNombre.Name = "tBoxNombre";
            this.tBoxNombre.Size = new System.Drawing.Size(379, 30);
            this.tBoxNombre.TabIndex = 12;
            // 
            // tBoxCodigo
            // 
            this.tBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCodigo.Location = new System.Drawing.Point(184, 88);
            this.tBoxCodigo.Name = "tBoxCodigo";
            this.tBoxCodigo.Size = new System.Drawing.Size(379, 30);
            this.tBoxCodigo.TabIndex = 11;
            // 
            // lblAPrecio
            // 
            this.lblAPrecio.AutoSize = true;
            this.lblAPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPrecio.ForeColor = System.Drawing.Color.White;
            this.lblAPrecio.Location = new System.Drawing.Point(99, 419);
            this.lblAPrecio.Name = "lblAPrecio";
            this.lblAPrecio.Size = new System.Drawing.Size(67, 25);
            this.lblAPrecio.TabIndex = 10;
            this.lblAPrecio.Text = "Precio";
            // 
            // lblACategoria
            // 
            this.lblACategoria.AutoSize = true;
            this.lblACategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACategoria.ForeColor = System.Drawing.Color.White;
            this.lblACategoria.Location = new System.Drawing.Point(69, 359);
            this.lblACategoria.Name = "lblACategoria";
            this.lblACategoria.Size = new System.Drawing.Size(97, 25);
            this.lblACategoria.TabIndex = 9;
            this.lblACategoria.Text = "Categoria";
            // 
            // lblAMarca
            // 
            this.lblAMarca.AutoSize = true;
            this.lblAMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMarca.ForeColor = System.Drawing.Color.White;
            this.lblAMarca.Location = new System.Drawing.Point(99, 309);
            this.lblAMarca.Name = "lblAMarca";
            this.lblAMarca.Size = new System.Drawing.Size(67, 25);
            this.lblAMarca.TabIndex = 8;
            this.lblAMarca.Text = "Marca";
            // 
            // lblADecripcion
            // 
            this.lblADecripcion.AutoSize = true;
            this.lblADecripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADecripcion.ForeColor = System.Drawing.Color.White;
            this.lblADecripcion.Location = new System.Drawing.Point(52, 185);
            this.lblADecripcion.Name = "lblADecripcion";
            this.lblADecripcion.Size = new System.Drawing.Size(114, 25);
            this.lblADecripcion.TabIndex = 7;
            this.lblADecripcion.Text = "Descripción";
            // 
            // lblANombre
            // 
            this.lblANombre.AutoSize = true;
            this.lblANombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANombre.ForeColor = System.Drawing.Color.White;
            this.lblANombre.Location = new System.Drawing.Point(85, 133);
            this.lblANombre.Name = "lblANombre";
            this.lblANombre.Size = new System.Drawing.Size(81, 25);
            this.lblANombre.TabIndex = 6;
            this.lblANombre.Text = "Nombre";
            // 
            // lblACodigo
            // 
            this.lblACodigo.AutoSize = true;
            this.lblACodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACodigo.ForeColor = System.Drawing.Color.White;
            this.lblACodigo.Location = new System.Drawing.Point(91, 88);
            this.lblACodigo.Name = "lblACodigo";
            this.lblACodigo.Size = new System.Drawing.Size(75, 25);
            this.lblACodigo.TabIndex = 5;
            this.lblACodigo.Text = "Código";
            // 
            // btonBuscar
            // 
            this.btonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonBuscar.AutoSize = true;
            this.btonBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btonBuscar.FlatAppearance.BorderSize = 0;
            this.btonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btonBuscar.Image")));
            this.btonBuscar.Location = new System.Drawing.Point(616, 13);
            this.btonBuscar.Name = "btonBuscar";
            this.btonBuscar.Size = new System.Drawing.Size(36, 36);
            this.btonBuscar.TabIndex = 4;
            this.btonBuscar.UseVisualStyleBackColor = false;
            this.btonBuscar.Click += new System.EventHandler(this.btonBuscar_Click);
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(392, 14);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(207, 37);
            this.cboxArticulo.TabIndex = 3;
            // 
            // cboxCodigo
            // 
            this.cboxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCodigo.FormattingEnabled = true;
            this.cboxCodigo.Location = new System.Drawing.Point(110, 14);
            this.cboxCodigo.Name = "cboxCodigo";
            this.cboxCodigo.Size = new System.Drawing.Size(159, 37);
            this.cboxCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(288, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCodigo.Location = new System.Drawing.Point(15, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 29);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // tabModify
            // 
            this.tabModify.Controls.Add(this.tabPage1);
            this.tabModify.Controls.Add(this.tabPage2);
            this.tabModify.Controls.Add(this.tabPage3);
            this.tabModify.Controls.Add(this.tabPage4);
            this.tabModify.Location = new System.Drawing.Point(12, 12);
            this.tabModify.Multiline = true;
            this.tabModify.Name = "tabModify";
            this.tabModify.SelectedIndex = 0;
            this.tabModify.Size = new System.Drawing.Size(673, 580);
            this.tabModify.TabIndex = 0;
            // 
            // BtnCAgregar
            // 
            this.BtnCAgregar.BackColor = System.Drawing.Color.Gray;
            this.BtnCAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCAgregar.Image")));
            this.BtnCAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCAgregar.Location = new System.Drawing.Point(110, 479);
            this.BtnCAgregar.Name = "BtnCAgregar";
            this.BtnCAgregar.Size = new System.Drawing.Size(145, 50);
            this.BtnCAgregar.TabIndex = 29;
            this.BtnCAgregar.Text = "Agregar";
            this.BtnCAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCAgregar.UseVisualStyleBackColor = false;
            this.BtnCAgregar.Click += new System.EventHandler(this.BtnCAgregar_Click);
            // 
            // BtnCEliminar
            // 
            this.BtnCEliminar.BackColor = System.Drawing.Color.Gray;
            this.BtnCEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCEliminar.Image")));
            this.BtnCEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCEliminar.Location = new System.Drawing.Point(273, 479);
            this.BtnCEliminar.Name = "BtnCEliminar";
            this.BtnCEliminar.Size = new System.Drawing.Size(145, 50);
            this.BtnCEliminar.TabIndex = 30;
            this.BtnCEliminar.Text = "Eliminar";
            this.BtnCEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCEliminar.UseVisualStyleBackColor = false;
            this.BtnCEliminar.Click += new System.EventHandler(this.BtnCEliminar_Click);
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 604);
            this.Controls.Add(this.tabModify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.FrmModify_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarca)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabModify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imagenArt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCModificar;
        private System.Windows.Forms.Label lblCTotalRegistros;
        private System.Windows.Forms.Label lblCRegistos;
        private System.Windows.Forms.TextBox tBoxNuevaCategoria;
        private System.Windows.Forms.Label lblCNuevaCategoria;
        private System.Windows.Forms.Button btnCBuscar;
        private System.Windows.Forms.ComboBox cBoxCCategoria;
        private System.Windows.Forms.Label lblCCategoria;
        private System.Windows.Forms.DataGridView DGVCategoria;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMModificar;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblMRegistros;
        private System.Windows.Forms.TextBox tBoxNuevaMarca;
        private System.Windows.Forms.Label lblNMarca;
        private System.Windows.Forms.Button btnMBuscar;
        private System.Windows.Forms.ComboBox cBoxMMarca;
        private System.Windows.Forms.Label lblMMarca;
        private System.Windows.Forms.DataGridView DGVMarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnIDelete;
        private System.Windows.Forms.Label lblIURL;
        private System.Windows.Forms.Button btnIModificar;
        private System.Windows.Forms.TextBox tBoxURL;
        private System.Windows.Forms.Label lblURLNueva;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnIBuscar;
        private System.Windows.Forms.ComboBox cBoxINombre;
        private System.Windows.Forms.ComboBox cBoxICodigo;
        private System.Windows.Forms.Label lblINombre;
        private System.Windows.Forms.Label lblICodigo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.TextBox tBoxPrecio;
        private System.Windows.Forms.TextBox tBoxDescripcion;
        private System.Windows.Forms.TextBox tBoxNombre;
        private System.Windows.Forms.TextBox tBoxCodigo;
        private System.Windows.Forms.Label lblAPrecio;
        private System.Windows.Forms.Label lblACategoria;
        private System.Windows.Forms.Label lblAMarca;
        private System.Windows.Forms.Label lblADecripcion;
        private System.Windows.Forms.Label lblANombre;
        private System.Windows.Forms.Label lblACodigo;
        private System.Windows.Forms.Button btonBuscar;
        private System.Windows.Forms.ComboBox cboxArticulo;
        private System.Windows.Forms.ComboBox cboxCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabControl tabModify;
        private System.Windows.Forms.Button BtnIAgregar;
        private System.Windows.Forms.Button BtnMAgregar;
        private System.Windows.Forms.Button BtnMEliminar;
        private System.Windows.Forms.Button BtnCEliminar;
        private System.Windows.Forms.Button BtnCAgregar;
    }
}