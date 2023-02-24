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

namespace SC__NEBO.Formularios.Formularios_de_Menu.Prestamos
{
    public partial class Frm_Prestamos : Form
    {
        public Frm_Prestamos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        Clases.DB db = new Clases.DB();
        Clases.Asistente a = new Clases.Asistente();

        int errors;

        string prestamo_codigo, fecha_inicio, fecha_final;
        string cliente, identidad, telefono, estado_civil, municipio, depto, domicilio;

        string tipo_prestamo, cantidad_lps, interes, interes_moratorio, garantia, forma_pago, entregado_por;

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Prestamos.Frm_Reporte_Prestamo form = new Formularios_de_Menu.Prestamos.Frm_Reporte_Prestamo();
            this.AddOwnedForm(form);
            form.Show();
            this.Hide();
        }

        private void btnBuscar_Cliente_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Clientes.Frm_Lista_Clientes lista_clientes = new Clientes.Frm_Lista_Clientes();
            this.AddOwnedForm(lista_clientes);
            lista_clientes.Show();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?";

            if (a.Pregunta(msg) == true)
            {
                string id_cliente = txtPrestamo_Codigo.Text.Trim();

                if (db.Delete("PRESTAMOS", "PRESTAMO_CODIGO", id_cliente) > 0)
                {
                    a.Aprueba("EL PRÉSTAMO SE ELIMINÓ CON EXITO");
                    Clear();
                    Boot();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidateData();

            string msg = "¿DESEA GUARDAR ESTE PRÉSTAMO AL CLIENTE " + cliente + "?";

            if (errors == 0)
            {
                if (a.Pregunta(msg) == true)
                {
                    //No se si ya se creo esta tabla
                    string campos = "PRESTAMO_CODIGO, FECHA_INICIO, FECHA_FINAL, CLIENTE, NO_IDENTIDAD, TELEFONO, ESTADO_CIVIL, MUNICIPIO, DEPARTAMENTO, DOMICILIO, TIPO_PRESTAMO," +
                        " CANTIDAD_LPS, INTERES, INTERES_MORATORIO, GARANTIA, FORMA_PAGO, ENTREGADO_POR";

                    string valores = "'" + prestamo_codigo + "', '" + fecha_inicio + "','" + fecha_final + "','" + cliente + "', '" + identidad + "','" + telefono + "','" + estado_civil + "'" +
                        "'" + municipio + "', '" + depto + "', '" + domicilio + "''" + tipo_prestamo + "', '" + cantidad_lps + "', '" + interes + "', '" + interes_moratorio + "', '" + garantia + "'" +
                        "'" + forma_pago + "', '" + entregado_por + "',";


                    if (db.Save("PRESTAMOS", campos, valores) > 0)
                    {
                        //db.RawSQL(query);
                        db.SetLast("CLIENT");
                        a.Aprueba("EL PRÉSTAMO DEL CLIENTE " + cliente + " HA SIDO REGISTRADO CON ÉXITO!");
                        //db.SetLast(idcorre);
                        Clear();
                        Boot();
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                string msg = "DESEA GUARDAR LOS CAMBIOS DEL REGISTRO SELECCIONADO";
                if (a.Pregunta(msg) == true)
                {
                    string id_cliente = txtPrestamo_Codigo.Text.Trim();
                    string stmt = "FECHA_INICIO='" + fecha_inicio + "',FECHA_FINAL='" + fecha_final + "',CLIENTE='" + cliente + "',NO_IDENTIDAD='" + identidad + "' " +
                        "TELEFONO='" + telefono + "',ESTADO_CIVIL='" + estado_civil + "',MUNICIPIO='" + municipio + "',DEPARTAMENTO='" + depto + "',DOMICILIO='" + domicilio + "' " +
                        "TIPO_PRESTAMO='" + tipo_prestamo + "',CANTIDAD_LPS='" + cantidad_lps + "',INTERES='" + interes + "',INTERES_MORATORIO='" + interes_moratorio + "' " +
                        "GARANTIA='" + garantia + "',FORMA_PAGO='" + forma_pago + "',ENTREGADO_POR='" + entregado_por + "'";
                    
                    string condicion = "ID_CLIENTE='" + id_cliente + "'";

                    if (db.Update("PRESTAMOS", stmt, condicion) > 0)
                    {
                        a.Aprueba("LOS CAMBIOS SE APLICARON CORRECTAMENTE!");
                        Clear();
                        Boot();
                    }
                }
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = Clases.Auth.save == "S" ? true : false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnRegresar.Enabled = false;

            txtPrestamo_Codigo.Text = "CLT" + db.GetNext("CLIEN");

            txtPrestamo_Codigo.Enabled = true;
            cmbTipo_Prestamo.Enabled = true;
            txtCantidad_Lps.Enabled = true;
            txtIntereses.Enabled = true;
            txtInteres_Moratorio.Enabled = true;
            cmbGarantia.Enabled = true;
            cmbForma_Pago.Enabled = true;
            txtEntregado_por.Enabled = true;
            

            //txtNombre.Focus();
        }

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
