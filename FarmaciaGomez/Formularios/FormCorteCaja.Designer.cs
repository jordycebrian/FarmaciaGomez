
namespace FarmaciaGomez.Formularios
{
    partial class FormCorteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorteCaja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCierreDeCaja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarBilletes = new System.Windows.Forms.Button();
            this.btnAgregarMoneda = new System.Windows.Forms.Button();
            this.txtCantidadBilletes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadMonedas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMonedas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBilletes = new System.Windows.Forms.ComboBox();
            this.lblBilletes = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.labelTotalInvercion = new System.Windows.Forms.Label();
            this.txtTotalEfectivoEnCaja = new System.Windows.Forms.TextBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.dgvCorteCaja = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.lblLogo);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1168, 74);
            this.panelTop.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 22;
            this.btnMin.Location = new System.Drawing.Point(1077, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 24);
            this.btnMin.TabIndex = 10;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 22;
            this.btnMax.Location = new System.Drawing.Point(1111, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(28, 24);
            this.btnMax.TabIndex = 9;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 22;
            this.btnCerrar.Location = new System.Drawing.Point(1136, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 24);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblLogo.Location = new System.Drawing.Point(319, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(535, 69);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Farmacia Gomez";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(126, 74);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.panelFooter.Controls.Add(this.label3);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 484);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1168, 38);
            this.panelFooter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(376, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Desarollado por Jordy Rodriguez Cebrian";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.panelDesktop.Controls.Add(this.btnCancelar);
            this.panelDesktop.Controls.Add(this.txtCierreDeCaja);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.btnAgregarBilletes);
            this.panelDesktop.Controls.Add(this.btnAgregarMoneda);
            this.panelDesktop.Controls.Add(this.txtCantidadBilletes);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.txtCantidadMonedas);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.comboBoxMonedas);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.comboBoxBilletes);
            this.panelDesktop.Controls.Add(this.lblBilletes);
            this.panelDesktop.Controls.Add(this.txtTotalVentas);
            this.panelDesktop.Controls.Add(this.labelTotalInvercion);
            this.panelDesktop.Controls.Add(this.txtTotalEfectivoEnCaja);
            this.panelDesktop.Controls.Add(this.lblCaja);
            this.panelDesktop.Controls.Add(this.dgvCorteCaja);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1168, 410);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(455, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 32);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar un monto";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCierreDeCaja
            // 
            this.txtCierreDeCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCierreDeCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.txtCierreDeCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCierreDeCaja.ForeColor = System.Drawing.Color.White;
            this.txtCierreDeCaja.Location = new System.Drawing.Point(221, 310);
            this.txtCierreDeCaja.Name = "txtCierreDeCaja";
            this.txtCierreDeCaja.ReadOnly = true;
            this.txtCierreDeCaja.Size = new System.Drawing.Size(198, 27);
            this.txtCierreDeCaja.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Cierre de caja:";
            // 
            // btnAgregarBilletes
            // 
            this.btnAgregarBilletes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarBilletes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarBilletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBilletes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarBilletes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarBilletes.Location = new System.Drawing.Point(220, 252);
            this.btnAgregarBilletes.Name = "btnAgregarBilletes";
            this.btnAgregarBilletes.Size = new System.Drawing.Size(198, 29);
            this.btnAgregarBilletes.TabIndex = 52;
            this.btnAgregarBilletes.Text = "Agregar";
            this.btnAgregarBilletes.UseVisualStyleBackColor = true;
            this.btnAgregarBilletes.Click += new System.EventHandler(this.btnAgregarBilletes_Click);
            // 
            // btnAgregarMoneda
            // 
            this.btnAgregarMoneda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarMoneda.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMoneda.Location = new System.Drawing.Point(220, 138);
            this.btnAgregarMoneda.Name = "btnAgregarMoneda";
            this.btnAgregarMoneda.Size = new System.Drawing.Size(198, 29);
            this.btnAgregarMoneda.TabIndex = 51;
            this.btnAgregarMoneda.Text = "Agregar";
            this.btnAgregarMoneda.UseVisualStyleBackColor = true;
            this.btnAgregarMoneda.Click += new System.EventHandler(this.btnAgregarMoneda_Click);
            // 
            // txtCantidadBilletes
            // 
            this.txtCantidadBilletes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadBilletes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.txtCantidadBilletes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadBilletes.ForeColor = System.Drawing.Color.White;
            this.txtCantidadBilletes.Location = new System.Drawing.Point(220, 219);
            this.txtCantidadBilletes.Name = "txtCantidadBilletes";
            this.txtCantidadBilletes.Size = new System.Drawing.Size(198, 27);
            this.txtCantidadBilletes.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cantidad de billetes:";
            // 
            // txtCantidadMonedas
            // 
            this.txtCantidadMonedas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadMonedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.txtCantidadMonedas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadMonedas.ForeColor = System.Drawing.Color.White;
            this.txtCantidadMonedas.Location = new System.Drawing.Point(220, 105);
            this.txtCantidadMonedas.Name = "txtCantidadMonedas";
            this.txtCantidadMonedas.Size = new System.Drawing.Size(198, 27);
            this.txtCantidadMonedas.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cantidad de monedas:";
            // 
            // comboBoxMonedas
            // 
            this.comboBoxMonedas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMonedas.FormattingEnabled = true;
            this.comboBoxMonedas.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "50"});
            this.comboBoxMonedas.Location = new System.Drawing.Point(220, 76);
            this.comboBoxMonedas.Name = "comboBoxMonedas";
            this.comboBoxMonedas.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMonedas.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ingresar modedas:";
            // 
            // comboBoxBilletes
            // 
            this.comboBoxBilletes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxBilletes.FormattingEnabled = true;
            this.comboBoxBilletes.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.comboBoxBilletes.Location = new System.Drawing.Point(220, 190);
            this.comboBoxBilletes.Name = "comboBoxBilletes";
            this.comboBoxBilletes.Size = new System.Drawing.Size(198, 23);
            this.comboBoxBilletes.TabIndex = 44;
            // 
            // lblBilletes
            // 
            this.lblBilletes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBilletes.AutoSize = true;
            this.lblBilletes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBilletes.ForeColor = System.Drawing.Color.White;
            this.lblBilletes.Location = new System.Drawing.Point(57, 190);
            this.lblBilletes.Name = "lblBilletes";
            this.lblBilletes.Size = new System.Drawing.Size(154, 22);
            this.lblBilletes.TabIndex = 43;
            this.lblBilletes.Text = "Ingresar billetes:";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.txtTotalVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalVentas.ForeColor = System.Drawing.Color.White;
            this.txtTotalVentas.Location = new System.Drawing.Point(221, 27);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(198, 27);
            this.txtTotalVentas.TabIndex = 42;
            // 
            // labelTotalInvercion
            // 
            this.labelTotalInvercion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalInvercion.AutoSize = true;
            this.labelTotalInvercion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalInvercion.ForeColor = System.Drawing.Color.White;
            this.labelTotalInvercion.Location = new System.Drawing.Point(85, 27);
            this.labelTotalInvercion.Name = "labelTotalInvercion";
            this.labelTotalInvercion.Size = new System.Drawing.Size(129, 22);
            this.labelTotalInvercion.TabIndex = 41;
            this.labelTotalInvercion.Text = "Total Ventas:";
            // 
            // txtTotalEfectivoEnCaja
            // 
            this.txtTotalEfectivoEnCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalEfectivoEnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.txtTotalEfectivoEnCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEfectivoEnCaja.ForeColor = System.Drawing.Color.White;
            this.txtTotalEfectivoEnCaja.Location = new System.Drawing.Point(925, 364);
            this.txtTotalEfectivoEnCaja.Name = "txtTotalEfectivoEnCaja";
            this.txtTotalEfectivoEnCaja.ReadOnly = true;
            this.txtTotalEfectivoEnCaja.Size = new System.Drawing.Size(198, 27);
            this.txtTotalEfectivoEnCaja.TabIndex = 14;
            // 
            // lblCaja
            // 
            this.lblCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaja.ForeColor = System.Drawing.Color.White;
            this.lblCaja.Location = new System.Drawing.Point(738, 365);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(165, 22);
            this.lblCaja.TabIndex = 13;
            this.lblCaja.Text = "Efectivo en caja:";
            // 
            // dgvCorteCaja
            // 
            this.dgvCorteCaja.AllowUserToAddRows = false;
            this.dgvCorteCaja.AllowUserToDeleteRows = false;
            this.dgvCorteCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCorteCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorteCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            this.dgvCorteCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCorteCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorteCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCorteCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorteCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.dataGridViewTextBoxColumn1,
            this.Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(51)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorteCaja.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCorteCaja.EnableHeadersVisualStyles = false;
            this.dgvCorteCaja.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCorteCaja.Location = new System.Drawing.Point(455, 27);
            this.dgvCorteCaja.Name = "dgvCorteCaja";
            this.dgvCorteCaja.ReadOnly = true;
            this.dgvCorteCaja.RowHeadersVisible = false;
            this.dgvCorteCaja.RowTemplate.Height = 25;
            this.dgvCorteCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorteCaja.Size = new System.Drawing.Size(668, 310);
            this.dgvCorteCaja.TabIndex = 12;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo de Efectivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FormCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 522);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCorteCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCorteCaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCorteCaja_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblLogo;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.TextBox txtTotalEfectivoEnCaja;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.DataGridView dgvCorteCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtCierreDeCaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarBilletes;
        private System.Windows.Forms.Button btnAgregarMoneda;
        private System.Windows.Forms.TextBox txtCantidadBilletes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadMonedas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMonedas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBilletes;
        private System.Windows.Forms.Label lblBilletes;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label labelTotalInvercion;
        private System.Windows.Forms.Button btnCancelar;
    }
}