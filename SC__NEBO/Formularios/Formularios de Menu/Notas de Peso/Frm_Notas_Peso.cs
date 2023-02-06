using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios.Formularios_de_Menu.Notas_de_Peso
{
    public partial class Frm_Notas_Peso : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Asistente a = new Clases.Asistente();

        int errors;

        string cosecha, direccion, fecha, id_cliente, cliente, id_nota, bodega, fletes, raintforest, fairtrade, organico, peso_bruto, sacos, descuentos, qq_netos;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public Frm_Notas_Peso()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Menu menu = new Frm_Menu();
            menu.Show();
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Boot()
        {
            btnNuevo.Enabled = Clases.Auth.save == "S" ? true : false;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            pbSalir.Enabled = true;

            txtIdCliente.Enabled = false;
            txtCosecha.Enabled = false;
            txtDireccion.Enabled = false;
            dtpFecha.Enabled = false;
            txtCliente.Enabled = false;
            txtIdNota.Enabled = false;
            txtBodega.Enabled = false;
            txtFletes.Enabled = false;
            txtPesoBruto.Enabled = false;
            txtSacos.Enabled = false;
            txtDescuento.Enabled = false;
            txtQQNetos.Enabled = false;
            txtObservaciones.Enabled = false;

            lblMsg.Visible = false;

            //DgvData.Rows.Clear();
            //txtBuscar.Clear();
            //txtBuscar.Focus();

        }

        private void Clear()
        {
            txtCosecha.Clear();
            //dtpFecha_Compra.Clear();
            txtDireccion.Clear();
            dtpFecha.Format(-1);
            txtIdCliente.Clear();
            txtCliente.Clear();
            txtIdNota.Clear();
            txtBodega.Clear();
            txtFletes.Clear();
            txtPesoBruto.Clear();
            txtSacos.Clear();
            txtDescuento.Clear();
            txtQQNetos.Clear();
            txtObservaciones.Clear();
        }

        public void ValidateData()
        {
            errors = 0;
            cosecha = a.Clean(txtCosecha.Text.Trim());
            comprobante_compra = a.Clean(txtComprobante_Compra.Text.Trim());
            lugar_compra = a.Clean(txtLugar_Compra.Text.Trim());
            cliente = a.Clean(txtCliente.Text.Trim());
            rtn = a.Clean(txtRTN.Text.Trim());
            clave = a.Clean(txtClave.Text.Trim());
            telefono = a.Clean(txtTelefono.Text.Trim());
            domicilio = a.Clean(txtDomicilio.Text.Trim());
            municipio = a.Clean(txtMunicipio.Text.Trim());
            depto = txtDepto.Text.Trim();
            ubicacion_finca = a.Clean(txtUbicac_Finca.Text.Trim());
            municipio_finca = a.Clean(txtMunicipio_Finca.Text.Trim());
            depto_finca = a.Clean(txtDepto_Finca.Text.Trim());
            cantidad_qq_oro = a.Clean(txtCantqq_Oro.Text.Trim());
            cantidad_oro_letra = a.Clean(txtCantqq_Oro_Letra.Text.Trim());
            valor_venta = a.Clean(txtValor_Venta.Text.Trim());
            valor_venta_letra = txtCant_ValorVenta_Letra.Text.Trim();
            num_licencia_operacion = a.Clean(txtNum_Lic_Operacion.Text.Trim());

            if (cosecha.Length == 0)
            {
                a.Advertencia("INGRESAR LA COSECHA!");
                txtCosecha.Text = "";
                txtCosecha.Focus();
                errors++;
                return;
            }

            if (comprobante_compra.Length == 0)
            {
                a.Advertencia("INGRESAR EL COMPROBANTE DE COMPRA!");
                txtComprobante_Compra.Text = "";
                txtComprobante_Compra.Focus();
                errors++;
            }

            if (lugar_compra.Length == 0)
            {
                a.Advertencia("INGRESAR EL LUGAR DE COMPRA!");
                txtLugar_Compra.Text = "";
                txtLugar_Compra.Focus();
                errors++;
            }

            if (cliente.Length == 0)
            {
                a.Advertencia("INGRESAR EL NOMBRE DEL CLIENTE!");
                txtCliente.Text = "";
                txtCliente.Focus();
                errors++;
            }

            if (rtn.Length == 0)
            {
                a.Advertencia("INGRESAR EL RTN DEL CLIENTE!");
                txtRTN.Text = "";
                txtRTN.Focus();
                errors++;
            }

            if (clave.Length == 0)
            {
                a.Advertencia("INGRESAR EL CLAVE DEL CLIENTE!");
                txtClave.Text = "";
                txtClave.Focus();
                errors++;
            }

            /*if (telefono.MaskFull == false)
            {
                a.Advertencia("INGRESAR EL NUMERO DE TELÉFONO DEL CLIENTE!");
                txtTelefono.Text = "";
                txtTelefono.Focus();
                errors++;
            }*/
            if (domicilio.Length == 0)
            {
                a.Advertencia("INGRESE EL DOMICILIO EN EL QUE RESIDE DEL CLIENTE!");
                txtDomicilio.Text = "";
                txtDomicilio.Focus();
                errors++;
            }

            if (municipio.Length == 0)
            {
                a.Advertencia("INGRESE EL MUNICIPIO EN EL QUE RESIDE DEL CLIENTE!");
                txtMunicipio.Text = "";
                txtMunicipio.Focus();
                errors++;
            }

            if (depto.Length == 0)
            {
                a.Advertencia("INGRESE EL DEPARTAMENTO EN EL QUE RESIDE DEL CLIENTE!");
                txtDepto.Text = telefono;
                txtDepto.Focus();
                errors++;
                return;
            }

            if (ubicacion_finca.Length == 0)
            {
                a.Advertencia("INGRESAR LA UBICACIÓN DE LA FINCA!");
                txtUbicac_Finca.Text = "";
                txtUbicac_Finca.Focus();
                errors++;
            }

            if (municipio_finca.Length == 0)
            {
                a.Advertencia("INGRESAR EL MUNICIPIO DE UBICACIÓN DE LA FINCA!");
                txtMunicipio_Finca.Text = "";
                txtMunicipio_Finca.Focus();
                errors++;
            }

            if (depto_finca.Length == 0)
            {
                a.Advertencia("INGRESAR EL DEPARTAMENTO DE UBICACIÓN DE LA FINCA!");
                txtDepto_Finca.Text = "";
                txtDepto_Finca.Focus();
                errors++;
            }

            if (cantidad_qq_oro.Length == 0)
            {
                a.Advertencia("INGRESAR LA CANTIDAD DE QUINTALES EN ORO!");
                txtCantqq_Oro.Text = "";
                txtCantqq_Oro.Focus();
                errors++;
            }

            if (cantidad_oro_letra.Length == 0)
            {
                a.Advertencia("INGRESAR LA CANTIDAD DE QUINTALES DE CAFÉ ORO EN LETRAS!");
                txtCantqq_Oro_Letra.Text = "";
                txtCantqq_Oro_Letra.Focus();
                errors++;
            }

            if (depto_finca.Length == 0)
            {
                a.Advertencia("INGRESAR EL DEPARTAMENTO DE UBICACIÓN DE LA FINCA!");
                txtDepto_Finca.Text = "";
                txtDepto_Finca.Focus();
                errors++;
            }

            if (valor_venta.Length == 0)
            {
                a.Advertencia("INGRESAR EL VALOR DE VENTA!");
                txtValor_Venta.Text = "";
                txtValor_Venta.Focus();
                errors++;
            }

            if (valor_venta_letra.Length == 0)
            {
                a.Advertencia("INGRESAR EL VALOR DE VENTA EN LETRAS!");
                txtCant_ValorVenta_Letra.Text = "";
                txtCant_ValorVenta_Letra.Focus();
                errors++;
            }

            if (num_licencia_operacion.Length == 0)
            {
                a.Advertencia("INGRESAR EL NUMERO DE LICENCIA DE OPERACIÓN!");
                txtNum_Lic_Operacion.Text = "";
                txtNum_Lic_Operacion.Focus();
                errors++;
            }
        }
    }

    private void Frm_Notas_Peso_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string msg = "¿DESEA CANCELAR LA ACCION?";

            if (a.Pregunta(msg) == true)
            {
                Clear();
                Boot();
            }
        }
    }
}
