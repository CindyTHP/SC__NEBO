using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
