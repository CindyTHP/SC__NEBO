using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios.Formularios_de_Menu.Prestamos
{
    public partial class Frm_Prestamos : Form
    {
        public Frm_Prestamos()
        {
            InitializeComponent();
        }

        Clases.DB db = new Clases.DB();
        Clases.Asistente a = new Clases.Asistente();

        int errors;

        string prestamo_codigo, fecha_inicio, fecha_final;
        string cliente, identidad, telefono, estado_civil, municipio, depto, domicilio;
        string tipo_prestamo, cantidad_lps, interes, interes_moratorio, garantia, forma_pago, entregado_por;

        private void Frm_Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtPrestamo_Codigo.Clear();
            dtpFecha_Inicio.Text="";
            dtpFecha_Final.Text="";
            txtCliente.Clear();
            txtIdentidad.Clear();
            txtTelefono.Clear();
            cmbEstadoCivil.SelectedIndex = -1;
            txtMunicipio.Clear();
            txtDepto.Clear();
            txtDomicilio.Clear();

            cmbTipo_Prestamo.SelectedIndex = -1;
            txtCantidad_Lps.Clear();
            txtIntereses.Clear();
            txtInteres_Moratorio.Clear();
            txtCantidad_Lps.Clear();
            cmbGarantia.SelectedIndex = -1;
            cmbForma_Pago.SelectedIndex = -1;
            txtEntregado_por.Clear();
        }

        public void ValidateData()
        {
            errors = 0;
            prestamo_codigo = a.Clean(txtPrestamo_Codigo.Text.Trim());
            fecha_inicio = a.Clean(dtpFecha_Inicio.Text.Trim());
            fecha_final = a.Clean(dtpFecha_Final.Text.Trim());
            cliente = a.Clean(txtCliente.Text.Trim());
            identidad = a.Clean(txtIdentidad.Text.Trim());
            telefono = a.Clean(txtTelefono.Text.Trim());
            estado_civil = a.Clean(cmbEstadoCivil.Text.Trim());
            municipio = a.Clean(txtMunicipio.Text.Trim());
            depto = a.Clean(txtDepto.Text.Trim());
            domicilio = a.Clean(cmbEstadoCivil.Text.Trim());

            tipo_prestamo = a.Clean(cmbTipo_Prestamo.Text.Trim());
            cantidad_lps = a.Clean(txtCantidad_Lps.Text.Trim());
            interes = txtIntereses.Text.Trim();
            cantidad_lps = a.Clean(txtCantidad_Lps.Text.Trim());
            garantia = a.Clean(cmbGarantia.Text.Trim());
            forma_pago = a.Clean(cmbForma_Pago.Text.Trim());
            entregado_por = a.Clean(txtEntregado_por.Text.Trim());

            if (prestamo_codigo.Length == 0)
            {
                a.Advertencia("¡INGRESAR UN CÓDIGO DE PRÉSTAMO VÁLIDO!");
                txtPrestamo_Codigo.Text = "";
                txtPrestamo_Codigo.Focus();
                errors++;
                return;
            }

            if (fecha_inicio.Length == 0)
            {
                a.Advertencia("¡SELECCIONE UNA FECHA INICIAL VÁLIDA!");
                dtpFecha_Inicio.Text = fecha_inicio;
                dtpFecha_Inicio.Focus();
                errors++;
                return;
            }

            if (fecha_final.Length == 0)
            {
                a.Advertencia("¡SELECCIONE UNA FECHA FINAL VÁLIDA!");
                dtpFecha_Final.Text = fecha_inicio;
                dtpFecha_Final.Focus();
                errors++;
                return;
            }

            if (cliente.Length == 0)
            {
                a.Advertencia("¡SELECCIONE EL NOMBRE DEL CLIENTE CORRESPONDIENTE!");
                txtCliente.Text = "";
                txtCliente.Focus();
                errors++;
            }


            if (tipo_prestamo.Length == 0)
            {
                a.Advertencia("¡SELECCIONE EL TIPO DE PRÉSTAMO CORRESPONDIENTE!");
                cmbTipo_Prestamo.Text = "";
                cmbTipo_Prestamo.Focus();
                errors++;
            }

            if (cantidad_lps.Length == 0)
            {
                a.Advertencia("¡INGRESAR LA CANTIDAD EN LEMPIRAS!");
                txtCantidad_Lps.Text = "";
                txtCantidad_Lps.Focus();
                errors++;
            }

            if (interes.Length == 0)
            {
                a.Advertencia("¡INGRESAR EL INTERÉS CORRESPONDIENTE!");
                txtIntereses.Text = "";
                txtIntereses.Focus();
                errors++;
            }

            if (interes_moratorio.Length == 0)
            {
                a.Advertencia("¡INGRESAR EL INTERÉS MORATORIO!");
                txtInteres_Moratorio.Text = "";
                txtInteres_Moratorio.Focus();
                errors++;
            }
            if (garantia.Length == 0)
            {
                a.Advertencia("¡SELECCIONE EL TIPO DE GARANTÍA!");
                cmbGarantia.Text = "";
                cmbGarantia.Focus();
                errors++;
            }

            if (forma_pago.Length == 0)
            {
                a.Advertencia("¡SELECCIONE LA FORMA DE PAGO!");
                cmbForma_Pago.Text = "";
                cmbForma_Pago.Focus();
                errors++;
            }

            if (entregado_por.Length == 0)
            {
                a.Advertencia("INGRESAR EL NOMBRE DE QUIEN ENTREGA EL PRÉSTAMO!");
                txtEntregado_por.Text = "";
                txtEntregado_por.Focus();
                errors++;
                return;
            }                       

        }

        private void Boot()
        {
            btnNuevo.Enabled = Clases.Auth.save == "S" ? true : false;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            pbSalir.Enabled = true;

            dtpFecha_Inicio.Enabled = false;
            dtpFecha_Final.Enabled = false;
            cmbTipo_Prestamo.Enabled = false;
            txtCantidad_Lps.Enabled = false;
            txtIntereses.Enabled = false;
            txtInteres_Moratorio.Enabled = false;
            cmbGarantia.Enabled = false;
            cmbForma_Pago.Enabled = false;
            txtEntregado_por.Enabled = false;

            lblMsg.Visible = false;

            //DgvData.Rows.Clear();
            //txtBuscar.Clear();
            //txtBuscar.Focus();

        }                
    }
}
