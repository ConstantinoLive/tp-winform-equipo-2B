namespace AppGestionArt
{
    partial class FrmSerch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerch));
            this.pcbSerch = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cBoxCodigo = new System.Windows.Forms.ComboBox();
            this.cBoxNombre = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblRCodigo = new System.Windows.Forms.Label();
            this.lblRNombre = new System.Windows.Forms.Label();
            this.lblRDescripcion = new System.Windows.Forms.Label();
            this.lblRMarca = new System.Windows.Forms.Label();
            this.lblRCategoria = new System.Windows.Forms.Label();
            this.lblRPrecio = new System.Windows.Forms.Label();
            this.lblResultadoID = new System.Windows.Forms.Label();
            this.lblResultadoCodigo = new System.Windows.Forms.Label();
            this.lblResultadoNombre = new System.Windows.Forms.Label();
            this.lblResultadoMarca = new System.Windows.Forms.Label();
            this.lblResultadoCategoria = new System.Windows.Forms.Label();
            this.lblResultadoPrecio = new System.Windows.Forms.Label();
            this.tBoxResultadoDescripcion = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSerch)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSerch
            // 
            this.pcbSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbSerch.BackColor = System.Drawing.Color.Transparent;
            this.pcbSerch.Location = new System.Drawing.Point(434, 111);
            this.pcbSerch.Name = "pcbSerch";
            this.pcbSerch.Size = new System.Drawing.Size(374, 342);
            this.pcbSerch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSerch.TabIndex = 0;
            this.pcbSerch.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCodigo.Location = new System.Drawing.Point(28, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 29);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(350, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // cBoxCodigo
            // 
            this.cBoxCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCodigo.FormattingEnabled = true;
            this.cBoxCodigo.Items.AddRange(new object[] {
            ""});
            this.cBoxCodigo.Location = new System.Drawing.Point(125, 32);
            this.cBoxCodigo.Name = "cBoxCodigo";
            this.cBoxCodigo.Size = new System.Drawing.Size(190, 37);
            this.cBoxCodigo.TabIndex = 3;
            // 
            // cBoxNombre
            // 
            this.cBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNombre.FormattingEnabled = true;
            this.cBoxNombre.Location = new System.Drawing.Point(454, 32);
            this.cBoxNombre.Name = "cBoxNombre";
            this.cBoxNombre.Size = new System.Drawing.Size(190, 37);
            this.cBoxNombre.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(697, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.BackColor = System.Drawing.Color.Transparent;
            this.lblRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.ForeColor = System.Drawing.Color.White;
            this.lblRID.Location = new System.Drawing.Point(42, 111);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(120, 25);
            this.lblRID.TabIndex = 6;
            this.lblRID.Text = "ID Producto:";
            // 
            // lblRCodigo
            // 
            this.lblRCodigo.AutoSize = true;
            this.lblRCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblRCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRCodigo.ForeColor = System.Drawing.Color.White;
            this.lblRCodigo.Location = new System.Drawing.Point(11, 156);
            this.lblRCodigo.Name = "lblRCodigo";
            this.lblRCodigo.Size = new System.Drawing.Size(151, 25);
            this.lblRCodigo.TabIndex = 7;
            this.lblRCodigo.Text = "Código Artículo:";
            // 
            // lblRNombre
            // 
            this.lblRNombre.AutoSize = true;
            this.lblRNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblRNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNombre.ForeColor = System.Drawing.Color.White;
            this.lblRNombre.Location = new System.Drawing.Point(75, 203);
            this.lblRNombre.Name = "lblRNombre";
            this.lblRNombre.Size = new System.Drawing.Size(87, 25);
            this.lblRNombre.TabIndex = 8;
            this.lblRNombre.Text = "Nombre:";
            // 
            // lblRDescripcion
            // 
            this.lblRDescripcion.AutoSize = true;
            this.lblRDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblRDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblRDescripcion.Location = new System.Drawing.Point(42, 248);
            this.lblRDescripcion.Name = "lblRDescripcion";
            this.lblRDescripcion.Size = new System.Drawing.Size(120, 25);
            this.lblRDescripcion.TabIndex = 9;
            this.lblRDescripcion.Text = "Descripción:";
            // 
            // lblRMarca
            // 
            this.lblRMarca.AutoSize = true;
            this.lblRMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblRMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMarca.ForeColor = System.Drawing.Color.White;
            this.lblRMarca.Location = new System.Drawing.Point(89, 384);
            this.lblRMarca.Name = "lblRMarca";
            this.lblRMarca.Size = new System.Drawing.Size(73, 25);
            this.lblRMarca.TabIndex = 10;
            this.lblRMarca.Text = "Marca:";
            // 
            // lblRCategoria
            // 
            this.lblRCategoria.AutoSize = true;
            this.lblRCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblRCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRCategoria.ForeColor = System.Drawing.Color.White;
            this.lblRCategoria.Location = new System.Drawing.Point(59, 428);
            this.lblRCategoria.Name = "lblRCategoria";
            this.lblRCategoria.Size = new System.Drawing.Size(103, 25);
            this.lblRCategoria.TabIndex = 11;
            this.lblRCategoria.Text = "Categoría:";
            // 
            // lblRPrecio
            // 
            this.lblRPrecio.AutoSize = true;
            this.lblRPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblRPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPrecio.ForeColor = System.Drawing.Color.White;
            this.lblRPrecio.Location = new System.Drawing.Point(136, 505);
            this.lblRPrecio.Name = "lblRPrecio";
            this.lblRPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblRPrecio.TabIndex = 12;
            this.lblRPrecio.Text = "Precio:";
            // 
            // lblResultadoID
            // 
            this.lblResultadoID.AutoSize = true;
            this.lblResultadoID.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoID.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoID.Location = new System.Drawing.Point(186, 111);
            this.lblResultadoID.Name = "lblResultadoID";
            this.lblResultadoID.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoID.TabIndex = 13;
            // 
            // lblResultadoCodigo
            // 
            this.lblResultadoCodigo.AutoSize = true;
            this.lblResultadoCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCodigo.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCodigo.Location = new System.Drawing.Point(186, 156);
            this.lblResultadoCodigo.Name = "lblResultadoCodigo";
            this.lblResultadoCodigo.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoCodigo.TabIndex = 14;
            // 
            // lblResultadoNombre
            // 
            this.lblResultadoNombre.AutoSize = true;
            this.lblResultadoNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoNombre.Location = new System.Drawing.Point(186, 203);
            this.lblResultadoNombre.Name = "lblResultadoNombre";
            this.lblResultadoNombre.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoNombre.TabIndex = 15;
            // 
            // lblResultadoMarca
            // 
            this.lblResultadoMarca.AutoSize = true;
            this.lblResultadoMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoMarca.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoMarca.Location = new System.Drawing.Point(186, 384);
            this.lblResultadoMarca.Name = "lblResultadoMarca";
            this.lblResultadoMarca.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoMarca.TabIndex = 16;
            // 
            // lblResultadoCategoria
            // 
            this.lblResultadoCategoria.AutoSize = true;
            this.lblResultadoCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCategoria.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoCategoria.Location = new System.Drawing.Point(186, 428);
            this.lblResultadoCategoria.Name = "lblResultadoCategoria";
            this.lblResultadoCategoria.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoCategoria.TabIndex = 17;
            // 
            // lblResultadoPrecio
            // 
            this.lblResultadoPrecio.AutoSize = true;
            this.lblResultadoPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPrecio.ForeColor = System.Drawing.Color.Gray;
            this.lblResultadoPrecio.Location = new System.Drawing.Point(238, 505);
            this.lblResultadoPrecio.Name = "lblResultadoPrecio";
            this.lblResultadoPrecio.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoPrecio.TabIndex = 18;
            // 
            // tBoxResultadoDescripcion
            // 
            this.tBoxResultadoDescripcion.BackColor = System.Drawing.Color.White;
            this.tBoxResultadoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxResultadoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxResultadoDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.tBoxResultadoDescripcion.Location = new System.Drawing.Point(168, 248);
            this.tBoxResultadoDescripcion.Multiline = true;
            this.tBoxResultadoDescripcion.Name = "tBoxResultadoDescripcion";
            this.tBoxResultadoDescripcion.ReadOnly = true;
            this.tBoxResultadoDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxResultadoDescripcion.Size = new System.Drawing.Size(236, 133);
            this.tBoxResultadoDescripcion.TabIndex = 19;
            // 
            // BtnRight
            // 
            this.BtnRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRight.FlatAppearance.BorderSize = 0;
            this.BtnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.Image")));
            this.BtnRight.Location = new System.Drawing.Point(635, 486);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(36, 36);
            this.BtnRight.TabIndex = 21;
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLeft.FlatAppearance.BorderSize = 0;
            this.BtnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.Image")));
            this.BtnLeft.Location = new System.Drawing.Point(552, 486);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(36, 36);
            this.BtnLeft.TabIndex = 20;
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // FrmSerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 565);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.tBoxResultadoDescripcion);
            this.Controls.Add(this.lblResultadoPrecio);
            this.Controls.Add(this.lblResultadoCategoria);
            this.Controls.Add(this.lblResultadoMarca);
            this.Controls.Add(this.lblResultadoNombre);
            this.Controls.Add(this.lblResultadoCodigo);
            this.Controls.Add(this.lblResultadoID);
            this.Controls.Add(this.lblRPrecio);
            this.Controls.Add(this.lblRCategoria);
            this.Controls.Add(this.lblRMarca);
            this.Controls.Add(this.lblRDescripcion);
            this.Controls.Add(this.lblRNombre);
            this.Controls.Add(this.lblRCodigo);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cBoxNombre);
            this.Controls.Add(this.cBoxCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pcbSerch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 612);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 612);
            this.Name = "FrmSerch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar registo";
            this.Load += new System.EventHandler(this.FrmSerch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSerch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSerch;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cBoxCodigo;
        private System.Windows.Forms.ComboBox cBoxNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblRCodigo;
        private System.Windows.Forms.Label lblRNombre;
        private System.Windows.Forms.Label lblRDescripcion;
        private System.Windows.Forms.Label lblRMarca;
        private System.Windows.Forms.Label lblRCategoria;
        private System.Windows.Forms.Label lblRPrecio;
        private System.Windows.Forms.Label lblResultadoID;
        private System.Windows.Forms.Label lblResultadoCodigo;
        private System.Windows.Forms.Label lblResultadoNombre;
        private System.Windows.Forms.Label lblResultadoMarca;
        private System.Windows.Forms.Label lblResultadoCategoria;
        private System.Windows.Forms.Label lblResultadoPrecio;
        private System.Windows.Forms.TextBox tBoxResultadoDescripcion;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
    }
}