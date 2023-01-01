
namespace SC__NEBO.Formularios.Formularios_de_Menu.Clientes
{
    partial class Frm_Lista_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lista_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.dcIDSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Size = new System.Drawing.Size(1357, 41);
            this.panel2.TabIndex = 14;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1270, 7);
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
            this.pbSalir.Location = new System.Drawing.Point(1318, 7);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(27, 27);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSalir.TabIndex = 1;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(6, 1);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(39, 39);
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
            this.dcIDSocio,
            this.DcNombre,
            this.DcDNI,
            this.DcRTN,
            this.DcDireccion,
            this.DcEstado});
            this.DgvData.Location = new System.Drawing.Point(12, 63);
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
            this.DgvData.Size = new System.Drawing.Size(1333, 514);
            this.DgvData.TabIndex = 37;
            // 
            // dcIDSocio
            // 
            this.dcIDSocio.HeaderText = "ID SOCIO";
            this.dcIDSocio.MinimumWidth = 8;
            this.dcIDSocio.Name = "dcIDSocio";
            this.dcIDSocio.ReadOnly = true;
            this.dcIDSocio.Width = 150;
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "NOMBRE";
            this.DcNombre.MinimumWidth = 8;
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.ReadOnly = true;
            this.DcNombre.Width = 350;
            // 
            // DcDNI
            // 
            this.DcDNI.HeaderText = "DNI";
            this.DcDNI.MinimumWidth = 8;
            this.DcDNI.Name = "DcDNI";
            this.DcDNI.ReadOnly = true;
            this.DcDNI.Width = 180;
            // 
            // DcRTN
            // 
            this.DcRTN.HeaderText = "RTN";
            this.DcRTN.MinimumWidth = 8;
            this.DcRTN.Name = "DcRTN";
            this.DcRTN.ReadOnly = true;
            this.DcRTN.Width = 180;
            // 
            // DcDireccion
            // 
            this.DcDireccion.HeaderText = "DIRECCION";
            this.DcDireccion.MinimumWidth = 8;
            this.DcDireccion.Name = "DcDireccion";
            this.DcDireccion.ReadOnly = true;
            this.DcDireccion.Width = 320;
            // 
            // DcEstado
            // 
            this.DcEstado.HeaderText = "ESTADO";
            this.DcEstado.MinimumWidth = 8;
            this.DcEstado.Name = "DcEstado";
            this.DcEstado.ReadOnly = true;
            // 
            // Frm_Lista_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1357, 635);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Lista_Clientes";
            this.Text = "Frm_Lista_Clientes";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcIDSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEstado;
    }
}