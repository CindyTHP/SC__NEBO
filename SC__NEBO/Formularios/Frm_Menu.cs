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
            Formularios.Formularios_de_Menu.Prestamos.Frm_Prestamos form = new Formularios_de_Menu.Prestamos.Frm_Prestamos();
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
    }
}
