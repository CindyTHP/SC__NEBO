using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SC__NEBO.Formularios
{
    public partial class Frm_Menu : Form
    {

        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btnNotaPeso_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Notas_de_Peso.Frm_Notas_Peso form = new Formularios_de_Menu.Notas_de_Peso.Frm_Notas_Peso();
            this.AddOwnedForm(form);
            form.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Clientes.Frm_Clientes form = new Formularios_de_Menu.Clientes.Frm_Clientes();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Formularios_de_Menu.Clientes.Frm_Clientes());
            Formularios.Formularios_de_Menu.Clientes.Frm_Clientes form = new Formularios_de_Menu.Clientes.Frm_Clientes();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void btnNotaPeso_Click_1(object sender, EventArgs e)
        {

            Formularios.Formularios_de_Menu.Notas_de_Peso.Frm_Notas_Peso form = new Formularios_de_Menu.Notas_de_Peso.Frm_Notas_Peso();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void btnIHCAFE_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.IHCAFE.Frm_IHCAFE form = new Formularios_de_Menu.IHCAFE.Frm_IHCAFE();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Config.FrmInfoGral frm = new Formularios_de_Menu.Config.FrmInfoGral();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Prestamos.Frm_Reporte_Prestamo form = new Formularios_de_Menu.Prestamos.Frm_Reporte_Prestamo();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void btnLquidación_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Liquidacion.Frm_Liquidacion form = new Formularios_de_Menu.Liquidacion.Frm_Liquidacion();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Reportes.Frm_Reportes form = new Formularios_de_Menu.Reportes.Frm_Reportes();
            this.AddOwnedForm(form);
            form.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 219)
            {
                this.tmContraerMenu.Start();
            }
            else if (panel3.Width == 44)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void tmExpandirMenu_Tick_1(object sender, EventArgs e)
        {
            if (panel3.Width >= 219)
                this.tmExpandirMenu.Stop();
            else
                panel3.Width = panel3.Width + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panel3.Width <= 44)
                this.tmContraerMenu.Stop();
            else
                panel3.Width = panel3.Width - 5;
        }

        //ABRIR UN FORMULARION DENTRO DEL PANEL
        //private void AbrirFormHijo(object formhijo)
        //{
        //    if (this.panelcontenedor.Controls.Count > 0)
        //        this.panelcontenedor.Controls.RemoveAt(0);
        //    Form fh = formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelcontenedor.Controls.Add(fh);
        //    this.panelcontenedor.Tag = fh;
        //    fh.Show();

        //}
    }
}
