namespace AppGestionArt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnserch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btntrash = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblreg = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pcbArticulos = new System.Windows.Forms.PictureBox();
            this.btnmodify = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnserch
            // 
            this.btnserch.BackColor = System.Drawing.Color.Transparent;
            this.btnserch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnserch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnserch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnserch.ForeColor = System.Drawing.Color.DimGray;
            this.btnserch.Image = ((System.Drawing.Image)(resources.GetObject("btnserch.Image")));
            this.btnserch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnserch.Location = new System.Drawing.Point(91, 35);
            this.btnserch.Name = "btnserch";
            this.btnserch.Size = new System.Drawing.Size(120, 130);
            this.btnserch.TabIndex = 1;
            this.btnserch.Text = "Buscar";
            this.btnserch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnserch.UseVisualStyleBackColor = false;
            this.btnserch.Click += new System.EventHandler(this.btnserch_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DimGray;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadd.Location = new System.Drawing.Point(253, 35);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 130);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Agregar";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btntrash
            // 
            this.btntrash.BackColor = System.Drawing.Color.Transparent;
            this.btntrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrash.ForeColor = System.Drawing.Color.DimGray;
            this.btntrash.Image = ((System.Drawing.Image)(resources.GetObject("btntrash.Image")));
            this.btntrash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntrash.Location = new System.Drawing.Point(415, 35);
            this.btntrash.Name = "btntrash";
            this.btntrash.Size = new System.Drawing.Size(120, 130);
            this.btntrash.TabIndex = 3;
            this.btntrash.Text = "Eliminar";
            this.btntrash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntrash.UseVisualStyleBackColor = false;
            this.btntrash.Click += new System.EventHandler(this.btntrash_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.Location = new System.Drawing.Point(91, 237);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1311, 556);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblreg
            // 
            this.lblreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblreg.AutoSize = true;
            this.lblreg.BackColor = System.Drawing.Color.Transparent;
            this.lblreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblreg.Location = new System.Drawing.Point(94, 835);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(96, 20);
            this.lblreg.TabIndex = 0;
            this.lblreg.Text = "Registros:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(201, 836);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 20);
            this.lblCantidad.TabIndex = 0;
            // 
            // pcbArticulos
            // 
            this.pcbArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbArticulos.BackColor = System.Drawing.Color.Transparent;
            this.pcbArticulos.Location = new System.Drawing.Point(1436, 232);
            this.pcbArticulos.Name = "pcbArticulos";
            this.pcbArticulos.Size = new System.Drawing.Size(348, 309);
            this.pcbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArticulos.TabIndex = 6;
            this.pcbArticulos.TabStop = false;
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Transparent;
            this.btnmodify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.DimGray;
            this.btnmodify.Image = ((System.Drawing.Image)(resources.GetObject("btnmodify.Image")));
            this.btnmodify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodify.Location = new System.Drawing.Point(577, 35);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(120, 130);
            this.btnmodify.TabIndex = 4;
            this.btnmodify.Text = "Modificar";
            this.btnmodify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.FlatAppearance.BorderSize = 0;
            this.BtnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.Image")));
            this.BtnLeft.Location = new System.Drawing.Point(1708, 626);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(41, 44);
            this.BtnLeft.TabIndex = 6;
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRight.FlatAppearance.BorderSize = 0;
            this.BtnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.Image")));
            this.BtnRight.Location = new System.Drawing.Point(1791, 626);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(45, 44);
            this.BtnRight.TabIndex = 7;
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1877, 872);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.pcbArticulos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btntrash);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnserch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control de gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnserch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btntrash;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pcbArticulos;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
    }
}

