
namespace SC__NEBO.Formularios.Formularios_de_Menu.Prestamos
{
    partial class Frm_Reporte_Prestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Prestamo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNuevo_Prestamo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnPagare = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.dcNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcTasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcIntereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcSaldoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panel5.Controls.Add(this.btnNuevo_Prestamo);
            this.panel5.Controls.Add(this.btnRegresar);
            this.panel5.Controls.Add(this.btnListaClientes);
            this.panel5.Controls.Add(this.btnFactura);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btnRecibo);
            this.panel5.Controls.Add(this.btnPagare);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 478);
            this.panel5.TabIndex = 19;
            // 
            // btnNuevo_Prestamo
            // 
            this.btnNuevo_Prestamo.FlatAppearance.BorderSize = 0;
            this.btnNuevo_Prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnNuevo_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo_Prestamo.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo_Prestamo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo_Prestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo_Prestamo.Image")));
            this.btnNuevo_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo_Prestamo.Location = new System.Drawing.Point(1, 101);
            this.btnNuevo_Prestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo_Prestamo.Name = "btnNuevo_Prestamo";
            this.btnNuevo_Prestamo.Size = new System.Drawing.Size(149, 28);
            this.btnNuevo_Prestamo.TabIndex = 8;
            this.btnNuevo_Prestamo.Text = "NUEVO";
            this.btnNuevo_Prestamo.UseVisualStyleBackColor = true;
            this.btnNuevo_Prestamo.Click += new System.EventHandler(this.btnNuevo_Prestamo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(0, 31);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(140, 27);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "    REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListaClientes.FlatAppearance.BorderSize = 0;
            this.btnListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientes.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnListaClientes.ForeColor = System.Drawing.Color.White;
            this.btnListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListaClientes.Image")));
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(0, 443);
            this.btnListaClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(151, 35);
            this.btnListaClientes.TabIndex = 6;
            this.btnListaClientes.Text = "       NOTA DE PESO";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            // 
            // btnFactura
            // 
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(2, 274);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(140, 27);
            this.btnFactura.TabIndex = 5;
            this.btnFactura.Text = "REPORTE";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "COAEDCAL";
            // 
            // btnRecibo
            // 
            this.btnRecibo.FlatAppearance.BorderSize = 0;
            this.btnRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibo.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnRecibo.ForeColor = System.Drawing.Color.White;
            this.btnRecibo.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibo.Image")));
            this.btnRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibo.Location = new System.Drawing.Point(2, 165);
            this.btnRecibo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(149, 28);
            this.btnRecibo.TabIndex = 1;
            this.btnRecibo.Text = "RECIBO";
            this.btnRecibo.UseVisualStyleBackColor = true;
            // 
            // btnPagare
            // 
            this.btnPagare.FlatAppearance.BorderSize = 0;
            this.btnPagare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnPagare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagare.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagare.ForeColor = System.Drawing.Color.White;
            this.btnPagare.Image = ((System.Drawing.Image)(resources.GetObject("btnPagare.Image")));
            this.btnPagare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagare.Location = new System.Drawing.Point(2, 133);
            this.btnPagare.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagare.Name = "btnPagare";
            this.btnPagare.Size = new System.Drawing.Size(149, 27);
            this.btnPagare.TabIndex = 0;
            this.btnPagare.Text = "PAGARÉ";
            this.btnPagare.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.pbMinimizar);
            this.panel2.Controls.Add(this.pbSalir);
            this.panel2.Controls.Add(this.pbMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 27);
            this.panel2.TabIndex = 18;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1025, 5);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(18, 18);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            // 
            // pbSalir
            // 
            this.pbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(1057, 5);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(2);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(18, 18);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSalir.TabIndex = 1;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(4, 1);
            this.pbMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(26, 26);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToOrderColumns = true;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcNO,
            this.DcFechaEntrega,
            this.DcCliente,
            this.DcMonto,
            this.DcTasa,
            this.DcIntereses,
            this.DcSaldoAcumulado,
            this.DcEstado});
            this.DgvData.Location = new System.Drawing.Point(175, 98);
            this.DgvData.Margin = new System.Windows.Forms.Padding(2);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 5;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(877, 364);
            this.DgvData.TabIndex = 38;
            // 
            // dcNO
            // 
            this.dcNO.HeaderText = "NO";
            this.dcNO.MinimumWidth = 8;
            this.dcNO.Name = "dcNO";
            this.dcNO.ReadOnly = true;
            this.dcNO.Width = 135;
            // 
            // DcFechaEntrega
            // 
            this.DcFechaEntrega.HeaderText = "FECHA";
            this.DcFechaEntrega.MinimumWidth = 8;
            this.DcFechaEntrega.Name = "DcFechaEntrega";
            this.DcFechaEntrega.ReadOnly = true;
            this.DcFechaEntrega.Width = 150;
            // 
            // DcCliente
            // 
            this.DcCliente.HeaderText = "CLIENTE";
            this.DcCliente.MinimumWidth = 8;
            this.DcCliente.Name = "DcCliente";
            this.DcCliente.ReadOnly = true;
            this.DcCliente.Width = 320;
            // 
            // DcMonto
            // 
            this.DcMonto.HeaderText = "MONTO";
            this.DcMonto.MinimumWidth = 8;
            this.DcMonto.Name = "DcMonto";
            this.DcMonto.ReadOnly = true;
            this.DcMonto.Width = 150;
            // 
            // DcTasa
            // 
            this.DcTasa.HeaderText = "TASA";
            this.DcTasa.MinimumWidth = 8;
            this.DcTasa.Name = "DcTasa";
            this.DcTasa.ReadOnly = true;
            this.DcTasa.Width = 80;
            // 
            // DcIntereses
            // 
            this.DcIntereses.HeaderText = "INTERÉSES";
            this.DcIntereses.MinimumWidth = 8;
            this.DcIntereses.Name = "DcIntereses";
            this.DcIntereses.ReadOnly = true;
            this.DcIntereses.Width = 120;
            // 
            // DcSaldoAcumulado
            // 
            this.DcSaldoAcumulado.HeaderText = "SALDO ACUMULADO";
            this.DcSaldoAcumulado.MinimumWidth = 8;
            this.DcSaldoAcumulado.Name = "DcSaldoAcumulado";
            this.DcSaldoAcumulado.ReadOnly = true;
            this.DcSaldoAcumulado.Width = 200;
            // 
            // DcEstado
            // 
            this.DcEstado.HeaderText = "ESTADO";
            this.DcEstado.MinimumWidth = 8;
            this.DcEstado.Name = "DcEstado";
            this.DcEstado.ReadOnly = true;
            this.DcEstado.Width = 150;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(229, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 14;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 22);
            this.txtNombre.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "DESDE:";
            // 
            // dtpFecha_Desde
            // 
            this.dtpFecha_Desde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Desde.Location = new System.Drawing.Point(501, 50);
            this.dtpFecha_Desde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha_Desde.Name = "dtpFecha_Desde";
            this.dtpFecha_Desde.Size = new System.Drawing.Size(88, 22);
            this.dtpFecha_Desde.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "HASTA:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(801, 49);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 14;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 22);
            this.textBox2.TabIndex = 96;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(734, 51);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(68, 16);
            this.txtEstado.TabIndex = 95;
            this.txtEstado.Text = "COSECHA:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 22);
            this.dateTimePicker1.TabIndex = 97;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(970, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 14;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(915, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "ESTADO:";
            // 
            // lblResumen
            // 
            this.lblResumen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumen.Location = new System.Drawing.Point(849, 482);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(203, 13);
            this.lblResumen.TabIndex = 109;
            this.lblResumen.Text = "Mostrando N de M registros.";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(151, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 5);
            this.panel1.TabIndex = 110;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1078, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 473);
            this.panel3.TabIndex = 111;
            // 
            // Frm_Reporte_Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1083, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha_Desde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Reporte_Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reporte_Prestamo";
            this.Load += new System.EventHandler(this.Frm_Reporte_Prestamo_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnPagare;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcIntereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcSaldoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha_Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnNuevo_Prestamo;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}