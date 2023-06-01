
namespace FarmaciaGomez
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelInicioSecion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarraUsuario = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panelTopLogin = new System.Windows.Forms.Panel();
            this.btnMiximizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnIniciar = new FontAwesome.Sharp.IconButton();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopLogo = new System.Windows.Forms.Panel();
            this.panelInicioSecion.SuspendLayout();
            this.panelTopLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicioSecion
            // 
            this.panelInicioSecion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.panelInicioSecion.Controls.Add(this.panel1);
            this.panelInicioSecion.Controls.Add(this.panelBarraUsuario);
            this.panelInicioSecion.Controls.Add(this.lblAviso);
            this.panelInicioSecion.Controls.Add(this.panelTopLogin);
            this.panelInicioSecion.Controls.Add(this.btnIniciar);
            this.panelInicioSecion.Controls.Add(this.txtContrasena);
            this.panelInicioSecion.Controls.Add(this.txtUsuario);
            this.panelInicioSecion.Controls.Add(this.lblDescripcion);
            this.panelInicioSecion.Controls.Add(this.lblLogo);
            this.panelInicioSecion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInicioSecion.Location = new System.Drawing.Point(293, 0);
            this.panelInicioSecion.Name = "panelInicioSecion";
            this.panelInicioSecion.Size = new System.Drawing.Size(560, 432);
            this.panelInicioSecion.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(110, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1);
            this.panel1.TabIndex = 10;
            // 
            // panelBarraUsuario
            // 
            this.panelBarraUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelBarraUsuario.Location = new System.Drawing.Point(110, 198);
            this.panelBarraUsuario.Name = "panelBarraUsuario";
            this.panelBarraUsuario.Size = new System.Drawing.Size(350, 1);
            this.panelBarraUsuario.TabIndex = 9;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Enabled = false;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblAviso.Location = new System.Drawing.Point(165, 297);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(252, 18);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Usuario o Constraseña incorrecto";
            this.lblAviso.Visible = false;
            // 
            // panelTopLogin
            // 
            this.panelTopLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelTopLogin.Controls.Add(this.btnMiximizar);
            this.panelTopLogin.Controls.Add(this.btnMaximizar);
            this.panelTopLogin.Controls.Add(this.btnClose);
            this.panelTopLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLogin.Location = new System.Drawing.Point(0, 0);
            this.panelTopLogin.Name = "panelTopLogin";
            this.panelTopLogin.Size = new System.Drawing.Size(560, 27);
            this.panelTopLogin.TabIndex = 3;
            this.panelTopLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopLogin_MouseDown);
            // 
            // btnMiximizar
            // 
            this.btnMiximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiximizar.FlatAppearance.BorderSize = 0;
            this.btnMiximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMiximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMiximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiximizar.IconSize = 22;
            this.btnMiximizar.Location = new System.Drawing.Point(461, 0);
            this.btnMiximizar.Name = "btnMiximizar";
            this.btnMiximizar.Size = new System.Drawing.Size(28, 24);
            this.btnMiximizar.TabIndex = 2;
            this.btnMiximizar.UseVisualStyleBackColor = true;
            this.btnMiximizar.Click += new System.EventHandler(this.btnMiximizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Enabled = false;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 22;
            this.btnMaximizar.Location = new System.Drawing.Point(495, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 24);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 22;
            this.btnClose.Location = new System.Drawing.Point(529, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnIniciar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIniciar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciar.IconSize = 30;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(110, 348);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(350, 40);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasena.Location = new System.Drawing.Point(110, 248);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(350, 24);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.Text = "CONTRASEÑA";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(192)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(110, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 24);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblDescripcion.Location = new System.Drawing.Point(165, 101);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(230, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Ingresa los datos para iniciar";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblLogo.Location = new System.Drawing.Point(197, 44);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(172, 36);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelTopLogo
            // 
            this.panelTopLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelTopLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLogo.Location = new System.Drawing.Point(0, 0);
            this.panelTopLogo.Name = "panelTopLogo";
            this.panelTopLogo.Size = new System.Drawing.Size(293, 27);
            this.panelTopLogo.TabIndex = 4;
            this.panelTopLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopLogo_MouseDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(853, 432);
            this.Controls.Add(this.panelTopLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInicioSecion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Seción";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelInicioSecion.ResumeLayout(false);
            this.panelInicioSecion.PerformLayout();
            this.panelTopLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicioSecion;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnIniciar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTopLogin;
        private System.Windows.Forms.Panel panelTopLogo;
        private FontAwesome.Sharp.IconButton btnMiximizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBarraUsuario;
    }
}

