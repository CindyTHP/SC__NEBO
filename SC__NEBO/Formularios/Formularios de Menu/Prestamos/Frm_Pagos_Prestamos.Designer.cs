
namespace SC__NEBO.Formularios.Formularios_de_Menu.Prestamos
{
    partial class Frm_Pagos_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pagos_Prestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad_Abonar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.dcNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar_Prestamo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.pbMinimizar);
            this.panel2.Controls.Add(this.pbSalir);
            this.panel2.Controls.Add(this.pbMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 40);
            this.panel2.TabIndex = 17;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(841, 8);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(27, 27);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            // 
            // pbSalir
            // 
            this.pbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(889, 8);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(27, 27);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSalir.TabIndex = 1;
            this.pbSalir.TabStop = false;
            // 
            // pbMenu
            // 
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(6, 2);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(39, 39);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(139, 63);
            this.txtNombre.MaxLength = 14;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 30);
            this.txtNombre.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 84;
            this.label1.Text = "CLIENTE:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(625, 66);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 30);
            this.dtpFecha.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(550, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "FECHA:";
            // 
            // txtCantidad_Abonar
            // 
            this.txtCantidad_Abonar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad_Abonar.Location = new System.Drawing.Point(324, 129);
            this.txtCantidad_Abonar.MaxLength = 14;
            this.txtCantidad_Abonar.Name = "txtCantidad_Abonar";
            this.txtCantidad_Abonar.Size = new System.Drawing.Size(135, 30);
            this.txtCantidad_Abonar.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 22);
            this.label5.TabIndex = 99;
            this.label5.Text = "CANTIDAD A ABONAR:";
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
            this.DcSaldo});
            this.DgvData.Location = new System.Drawing.Point(71, 193);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 5;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(772, 495);
            this.DgvData.TabIndex = 101;
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
            this.DcFechaEntrega.Width = 200;
            // 
            // DcSaldo
            // 
            this.DcSaldo.HeaderText = "SALDO";
            this.DcSaldo.MinimumWidth = 8;
            this.DcSaldo.Name = "DcSaldo";
            this.DcSaldo.ReadOnly = true;
            this.DcSaldo.Width = 150;
            // 
            // btnSeleccionar_Prestamo
            // 
            this.btnSeleccionar_Prestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnSeleccionar_Prestamo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionar_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar_Prestamo.Location = new System.Drawing.Point(585, 132);
            this.btnSeleccionar_Prestamo.Name = "btnSeleccionar_Prestamo";
            this.btnSeleccionar_Prestamo.Size = new System.Drawing.Size(258, 38);
            this.btnSeleccionar_Prestamo.TabIndex = 102;
            this.btnSeleccionar_Prestamo.Text = "SELECCIONAR PRÉSTAMO";
            this.btnSeleccionar_Prestamo.UseVisualStyleBackColor = false;
            // 
            // Frm_Pagos_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(928, 730);
            this.Controls.Add(this.btnSeleccionar_Prestamo);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.txtCantidad_Abonar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Pagos_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Pagos_Prestamos";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad_Abonar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcSaldo;
        private System.Windows.Forms.Button btnSeleccionar_Prestamo;
    }
}