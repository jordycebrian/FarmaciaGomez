
namespace FarmaciaGomez.Formularios
{
    partial class FormularioMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMenu));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblinvercion = new System.Windows.Forms.Label();
            this.lblcorteCaja = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvercion = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorteCaja = new System.Windows.Forms.PictureBox();
            this.btnProveedor = new System.Windows.Forms.PictureBox();
            this.btnInvercion = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvercion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorteCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvercion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProductos)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblLogo);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 74);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 22;
            this.btnMinimizar.Location = new System.Drawing.Point(1093, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 22;
            this.btnMaximizar.Location = new System.Drawing.Point(1127, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 24);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 22;
            this.btnClose.Location = new System.Drawing.Point(1152, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblLogo.Location = new System.Drawing.Point(331, -1);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(535, 69);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Farmacia Gomez";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(62, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(126, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(0, 74);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(1184, 5);
            this.panelSombra.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Controls.Add(this.lblUsuarios);
            this.panelDesktop.Controls.Add(this.lblinvercion);
            this.panelDesktop.Controls.Add(this.lblcorteCaja);
            this.panelDesktop.Controls.Add(this.lblProveedores);
            this.panelDesktop.Controls.Add(this.lblVentas);
            this.panelDesktop.Controls.Add(this.lblProductos);
            this.panelDesktop.Controls.Add(this.btnVentas);
            this.panelDesktop.Controls.Add(this.pictureBoxInvercion);
            this.panelDesktop.Controls.Add(this.pictureBoxCorteCaja);
            this.panelDesktop.Controls.Add(this.btnProveedor);
            this.panelDesktop.Controls.Add(this.btnInvercion);
            this.panelDesktop.Controls.Add(this.btnProductos);
            this.panelDesktop.Location = new System.Drawing.Point(0, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1184, 482);
            this.panelDesktop.TabIndex = 2;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblUsuarios.Location = new System.Drawing.Point(941, 232);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(97, 23);
            this.lblUsuarios.TabIndex = 11;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lblinvercion
            // 
            this.lblinvercion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblinvercion.AutoSize = true;
            this.lblinvercion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblinvercion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblinvercion.Location = new System.Drawing.Point(550, 232);
            this.lblinvercion.Name = "lblinvercion";
            this.lblinvercion.Size = new System.Drawing.Size(107, 23);
            this.lblinvercion.TabIndex = 10;
            this.lblinvercion.Text = "Inverción";
            // 
            // lblcorteCaja
            // 
            this.lblcorteCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcorteCaja.AutoSize = true;
            this.lblcorteCaja.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblcorteCaja.Location = new System.Drawing.Point(93, 232);
            this.lblcorteCaja.Name = "lblcorteCaja";
            this.lblcorteCaja.Size = new System.Drawing.Size(141, 23);
            this.lblcorteCaja.TabIndex = 9;
            this.lblcorteCaja.Text = "Corte de caja";
            // 
            // lblProveedores
            // 
            this.lblProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblProveedores.Location = new System.Drawing.Point(915, 25);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(137, 23);
            this.lblProveedores.TabIndex = 8;
            this.lblProveedores.Text = "Proveedores";
            // 
            // lblVentas
            // 
            this.lblVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblVentas.Location = new System.Drawing.Point(559, 15);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(78, 23);
            this.lblVentas.TabIndex = 7;
            this.lblVentas.Text = "Ventas";
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.lblProductos.Location = new System.Drawing.Point(120, 15);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(114, 23);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Productos";
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Image = global::FarmaciaGomez.Properties.Resources.caja_Farmacia;
            this.btnVentas.Location = new System.Drawing.Point(496, 52);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(206, 153);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVentas.TabIndex = 5;
            this.btnVentas.TabStop = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pictureBoxInvercion
            // 
            this.pictureBoxInvercion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInvercion.Image = global::FarmaciaGomez.Properties.Resources.invercion_Farmacia;
            this.pictureBoxInvercion.Location = new System.Drawing.Point(505, 271);
            this.pictureBoxInvercion.Name = "pictureBoxInvercion";
            this.pictureBoxInvercion.Size = new System.Drawing.Size(206, 153);
            this.pictureBoxInvercion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInvercion.TabIndex = 4;
            this.pictureBoxInvercion.TabStop = false;
            this.pictureBoxInvercion.Click += new System.EventHandler(this.pictureBoxInvercion_Click);
            // 
            // pictureBoxCorteCaja
            // 
            this.pictureBoxCorteCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCorteCaja.Image = global::FarmaciaGomez.Properties.Resources.factura_Farmacia;
            this.pictureBoxCorteCaja.Location = new System.Drawing.Point(62, 271);
            this.pictureBoxCorteCaja.Name = "pictureBoxCorteCaja";
            this.pictureBoxCorteCaja.Size = new System.Drawing.Size(206, 153);
            this.pictureBoxCorteCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCorteCaja.TabIndex = 3;
            this.pictureBoxCorteCaja.TabStop = false;
            this.pictureBoxCorteCaja.Click += new System.EventHandler(this.pictureBoxCorteCaja_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.Image = global::FarmaciaGomez.Properties.Resources.proveedor_Farmacia;
            this.btnProveedor.Location = new System.Drawing.Point(885, 63);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(206, 153);
            this.btnProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.TabStop = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnInvercion
            // 
            this.btnInvercion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvercion.Image = global::FarmaciaGomez.Properties.Resources.usuarios_Farmacia;
            this.btnInvercion.Location = new System.Drawing.Point(885, 271);
            this.btnInvercion.Name = "btnInvercion";
            this.btnInvercion.Size = new System.Drawing.Size(206, 153);
            this.btnInvercion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInvercion.TabIndex = 1;
            this.btnInvercion.TabStop = false;
            this.btnInvercion.Click += new System.EventHandler(this.btnInvercion_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Image = global::FarmaciaGomez.Properties.Resources.productos_Farmacia;
            this.btnProductos.Location = new System.Drawing.Point(62, 52);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(206, 153);
            this.btnProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProductos.TabIndex = 0;
            this.btnProductos.TabStop = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.panelFooter.Controls.Add(this.lblUsuario);
            this.panelFooter.Controls.Add(this.lblHora);
            this.panelFooter.Controls.Add(this.lblAutor);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 523);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1184, 38);
            this.panelFooter.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblUsuario.Location = new System.Drawing.Point(25, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 23);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "usario";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblHora.Location = new System.Drawing.Point(900, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 23);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "00:00";
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblAutor.Location = new System.Drawing.Point(405, 13);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(421, 23);
            this.lblAutor.TabIndex = 12;
            this.lblAutor.Text = "Desarollado por Jordy Rodriguez Cebrian";
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvercion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorteCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvercion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProductos)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblLogo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnProductos;
        private System.Windows.Forms.PictureBox btnInvercion;
        private System.Windows.Forms.PictureBox btnProveedor;
        private System.Windows.Forms.PictureBox pictureBoxCorteCaja;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBoxInvercion;
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblinvercion;
        private System.Windows.Forms.Label lblcorteCaja;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblUsuario;
    }
}