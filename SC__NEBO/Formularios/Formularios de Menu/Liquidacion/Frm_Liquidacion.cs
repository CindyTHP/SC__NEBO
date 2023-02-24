using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios.Formularios_de_Menu.Liquidacion
{
    public partial class Frm_Liquidacion : Form
    {
        public Frm_Liquidacion()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Prestamos.Frm_Prestamos_por_Persona form = new Formularios_de_Menu.Prestamos.Frm_Prestamos_por_Persona();
            this.AddOwnedForm(form);
            form.Show();
        }
    }
}
