using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios.Formularios_de_Menu.IHCAFE
{
    public partial class Frm_IHCAFE : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Asistente a = new Clases.Asistente();

        int errors;

        string cosecha, fecha_compra, comprobante_compra, lugar_compra, cliente, rtn, clave, telefono;

        string domicilio, municipio, depto, ubicacion_finca, municipio_finca, depto_finca;

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?";

            if (a.Pregunta(msg) == true)
            {
                string id_cliente = txtComprobante_Compra.Text.Trim();

                if (db.Delete("CLIENTES", "ID_CLIENTE", id_cliente) > 0)
                {
                    a.Aprueba("EL DOCENTE SE ELIMINÓ CON EXITO");
                    //Clear();
                    //Boot();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //ValidateData();

            if (errors == 0)
            {
                string msg = "DESEA GUARDAR LOS CAMBIOS DEL REGISTRO SELECCIONADO";
                if (a.Pregunta(msg) == true)
                {
                    //            string id_cliente = txtIdCliente.Text.Trim();
                    //            string stmt = "DNI='" + dni + "',NOMBRES='" + nombre + "',APELLIDOS='" + apellido + "',RTN='" + rtn + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "'," +
                    //                "ESTADO_CIVIL='" + estadocivil + "',CLAVE_IHCAFE='" + claveihcafe + "',COMUNIDAD='" + comunidad + "',MUNICIPIO='" + municipio + "',";
                    //            string condicion = "ID_CLIENTE='" + id_cliente + "'";

                    //            if (db.Update("CLIENTES", stmt, condicion) > 0)
                    //            {
                    //                a.Aprueba("LOS CAMBIOS SE APLICARON CORRECTAMENTE!");
                    //                Clear();
                    //                Boot();
                    //            }
                    //        }
                    //    }
                    //}

                    //private void btnGuardar_Click(object sender, EventArgs e)
                    //{
                    //    ValidateData();

                    //    string msg = "¿DESEA GUARDAR EL CLIENTE " + cliente + "?";

                    //    if (errors == 0)
                    //    {
                    //        if (a.Pregunta(msg) == true)
                    //        {
                    //            string campos = "ID_CLIENTE, NOMBRES, APELLIDOS,DNI, RTN, DIRECCION, TELEFONO, ESTADO_CIVIL, CLAVE_IHCAFE, COMUNIDAD, MUNICIPIO";

                    //            string valores = "'" + idcliente + "', '" + nombre + "','" + apellido + "','" + dni + "', '" + rtn + "','" + direccion + "','" + telefono + "', '" + estadocivil + "', '" + claveihcafe + "', '" + comunidad + "','" + municipio + "'";


                    //            if (db.Save("CLIENTES", campos, valores) > 0)
                    //            {
                    //                //db.RawSQL(query);
                    //                db.SetLast("CLIENT");
                    //                a.Aprueba("EL CLIENTE " + cliente + " HA SIDO REGISTRADO CON ÉXITO!");
                    //                //db.SetLast(idcorre);
                    //                Clear();
                    //                Boot();
                    //            }
                    //        }
                    //    }
                    //}

                    //string cantidad_qq_oro, cantidad_oro_letra, valor_venta, valor_venta_letra, num_licencia_operacion;

                    //private void btnCancelar_Click(object sender, EventArgs e)
                    //{
                    //    string msg = "¿DESEA CANCELAR LA ACCION?";

                    //    if (a.Pregunta(msg) == true)
                    //    {
                    //        Clear();
                    //        Boot();
                    //    }
                    //}

                    //private void btnNuevo_Click(object sender, EventArgs e)
                    //{
                    //    btnNuevo.Enabled = false;
                    //    btnGuardar.Enabled = Clases.Auth.save == "S" ? true : false;
                    //    btnActualizar.Enabled = false;
                    //    btnEliminar.Enabled = false;
                    //    btnCancelar.Enabled = true;
                    //    btnRegresar.Enabled = false;

                    //    //aun no hay correlativo
                    //    txtCosecha.Text = "CLT" + db.GetNext("CLIEN");

                    //    txtCosecha.Enabled = false;
                    //    dtpFecha_Compra.Enabled = true;
                    //    txtComprobante_Compra.Enabled = true;
                    //    txtLugar_Compra.Enabled = true;
                    //    txtCliente.Enabled = false;
                    //    txtRTN.Enabled = true;
                    //    txtClave.Enabled = true;
                    //    txtTelefono.Enabled = true;
                    //    txtDomicilio.Enabled = true;
                    //    txtMunicipio.Enabled = true;
                    //    txtDepto.Enabled = true;
                    //    txtRTN.Enabled = true;
                    //    txtUbicac_Finca.Enabled = true;
                    //    txtMunicipio_Finca.Enabled = true;
                    //    txtDepto_Finca.Enabled = true;
                    //    txtCantqq_Oro.Enabled = true;
                    //    txtCantqq_Oro_Letra.Enabled = true;
                    //    txtValor_Venta.Enabled = true;
                    //    txtCant_ValorVenta_Letra.Enabled = true;
                    //    txtNum_Lic_Operacion.Enabled = true;


                    //    txtCosecha.Focus();
                    //}

                    //public Frm_IHCAFE()
                    //{
                    //    InitializeComponent();
                    //}

                    //private void Frm_IHCAFE_Load(object sender, EventArgs e)
                    //{

                    //}

                    //private void Boot()
                    //{
                    //    btnNuevo.Enabled = Clases.Auth.save == "S" ? true : false;
                    //    btnGuardar.Enabled = false;
                    //    btnActualizar.Enabled = false;
                    //    btnEliminar.Enabled = false;
                    //    btnCancelar.Enabled = false;
                    //    pbSalir.Enabled = true;

                    //    txtCosecha.Enabled = false;
                    //    dtpFecha_Compra.Enabled = false;
                    //    txtComprobante_Compra.Enabled = false;
                    //    txtLugar_Compra.Enabled = false;
                    //    txtCliente.Enabled = false;
                    //    txtRTN.Enabled = false;
                    //    txtClave.Enabled = false;
                    //    txtTelefono.Enabled = false;
                    //    txtDomicilio.Enabled = false;
                    //    txtMunicipio.Enabled = false;
                    //    txtDepto.Enabled = false;
                    //    txtUbicac_Finca.Enabled = false;
                    //    txtMunicipio_Finca.Enabled = false;
                    //    txtDepto_Finca.Enabled = false;
                    //    txtCantqq_Oro.Enabled = false;
                    //    txtCantqq_Oro_Letra.Enabled = false;
                    //    txtValor_Venta.Enabled = false;
                    //    txtCant_ValorVenta_Letra.Enabled = false;
                    //    txtNum_Lic_Operacion.Enabled = false;

                    //    //lblMsg.Visible = false;

                    //    //DgvData.Rows.Clear();
                    //    //txtBuscar.Clear();
                    //    //txtBuscar.Focus();

                    //}

                    //private void Clear()
                    //{
                    //    txtCosecha.Clear();
                    //    //dtpFecha_Compra.Clear();
                    //    txtComprobante_Compra.Clear();
                    //    txtLugar_Compra.Clear();
                    //    txtCliente.Clear();
                    //    txtRTN.Clear();
                    //    txtClave.Clear();
                    //    txtTelefono.Clear();
                    //    txtTelefono.Clear();
                    //    txtDomicilio.Clear();
                    //    txtMunicipio.Clear();
                    //    txtDepto.Clear();
                    //    txtUbicac_Finca.Clear();
                    //    txtMunicipio_Finca.Clear();
                    //    txtDepto_Finca.Clear();
                    //    txtCantqq_Oro.Clear();
                    //    txtCantqq_Oro_Letra.Clear();
                    //    txtValor_Venta.Clear();
                    //    txtCant_ValorVenta_Letra.Clear();
                    //    txtNum_Lic_Operacion.Clear();
                    //}

                    //public void ValidateData()
                    //{
                    //    errors = 0;
                    //    cosecha = a.Clean(txtCosecha.Text.Trim());
                    //    comprobante_compra = a.Clean(txtComprobante_Compra.Text.Trim());
                    //    lugar_compra = a.Clean(txtLugar_Compra.Text.Trim());
                    //    cliente = a.Clean(txtCliente.Text.Trim());
                    //    rtn = a.Clean(txtRTN.Text.Trim());
                    //    clave = a.Clean(txtClave.Text.Trim());
                    //    telefono = a.Clean(txtTelefono.Text.Trim());
                    //    domicilio = a.Clean(txtDomicilio.Text.Trim());
                    //    municipio = a.Clean(txtMunicipio.Text.Trim());
                    //    depto = txtDepto.Text.Trim();
                    //    ubicacion_finca = a.Clean(txtUbicac_Finca.Text.Trim());
                    //    municipio_finca = a.Clean(txtMunicipio_Finca.Text.Trim());
                    //    depto_finca = a.Clean(txtDepto_Finca.Text.Trim());
                    //    cantidad_qq_oro = a.Clean(txtCantqq_Oro.Text.Trim());
                    //    cantidad_oro_letra = a.Clean(txtCantqq_Oro_Letra.Text.Trim());
                    //    valor_venta = a.Clean(txtValor_Venta.Text.Trim());
                    //    valor_venta_letra = txtCant_ValorVenta_Letra.Text.Trim();
                    //    num_licencia_operacion = a.Clean(txtNum_Lic_Operacion .Text.Trim());

                    //    if (cosecha.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR LA COSECHA!");
                    //        txtCosecha.Text = "";
                    //        txtCosecha.Focus();
                    //        errors++;
                    //        return;
                    //    }

                    //    if (comprobante_compra.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL COMPROBANTE DE COMPRA!");
                    //        txtComprobante_Compra.Text = "";
                    //        txtComprobante_Compra.Focus();
                    //        errors++;
                    //    }

                    //    if (lugar_compra.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL LUGAR DE COMPRA!");
                    //        txtLugar_Compra.Text = "";
                    //        txtLugar_Compra.Focus();
                    //        errors++;
                    //    }

                    //    if (cliente.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL NOMBRE DEL CLIENTE!");
                    //        txtCliente.Text = "";
                    //        txtCliente.Focus();
                    //        errors++;
                    //    }

                    //    if (rtn.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL RTN DEL CLIENTE!");
                    //        txtRTN.Text = "";
                    //        txtRTN.Focus();
                    //        errors++;
                    //    }

                    //    if (clave.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL CLAVE DEL CLIENTE!");
                    //        txtClave.Text = "";
                    //        txtClave.Focus();
                    //        errors++;
                    //    }

                    //    /*if (telefono.MaskFull == false)
                    //    {
                    //        a.Advertencia("INGRESAR EL NUMERO DE TELÉFONO DEL CLIENTE!");
                    //        txtTelefono.Text = "";
                    //        txtTelefono.Focus();
                    //        errors++;
                    //    }*/
                    //    if (domicilio.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESE EL DOMICILIO EN EL QUE RESIDE DEL CLIENTE!");
                    //        txtDomicilio.Text = "";
                    //        txtDomicilio.Focus();
                    //        errors++;
                    //    }

                    //    if (municipio.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESE EL MUNICIPIO EN EL QUE RESIDE DEL CLIENTE!");
                    //        txtMunicipio.Text = "";
                    //        txtMunicipio.Focus();
                    //        errors++;
                    //    }

                    //    if (depto.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESE EL DEPARTAMENTO EN EL QUE RESIDE DEL CLIENTE!");
                    //        txtDepto.Text = telefono;
                    //        txtDepto.Focus();
                    //        errors++;
                    //        return;
                    //    }

                    //    if (ubicacion_finca.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR LA UBICACIÓN DE LA FINCA!");
                    //        txtUbicac_Finca.Text = "";
                    //        txtUbicac_Finca.Focus();
                    //        errors++;
                    //    }

                    //    if (municipio_finca.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL MUNICIPIO DE UBICACIÓN DE LA FINCA!");
                    //        txtMunicipio_Finca.Text = "";
                    //        txtMunicipio_Finca.Focus();
                    //        errors++;
                    //    }

                    //    if (depto_finca.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL DEPARTAMENTO DE UBICACIÓN DE LA FINCA!");
                    //        txtDepto_Finca.Text = "";
                    //        txtDepto_Finca.Focus();
                    //        errors++;
                    //    }

                    //    if (cantidad_qq_oro.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR LA CANTIDAD DE QUINTALES EN ORO!");
                    //        txtCantqq_Oro.Text = "";
                    //        txtCantqq_Oro.Focus();
                    //        errors++;
                    //    }

                    //    if (cantidad_oro_letra.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR LA CANTIDAD DE QUINTALES DE CAFÉ ORO EN LETRAS!");
                    //        txtCantqq_Oro_Letra.Text = "";
                    //        txtCantqq_Oro_Letra.Focus();
                    //        errors++;
                    //    }

                    //    if (depto_finca.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL DEPARTAMENTO DE UBICACIÓN DE LA FINCA!");
                    //        txtDepto_Finca.Text = "";
                    //        txtDepto_Finca.Focus();
                    //        errors++;
                    //    }

                    //    if (valor_venta.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL VALOR DE VENTA!");
                    //        txtValor_Venta.Text = "";
                    //        txtValor_Venta.Focus();
                    //        errors++;
                    //    }

                    //    if (valor_venta_letra.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL VALOR DE VENTA EN LETRAS!");
                    //        txtCant_ValorVenta_Letra.Text = "";
                    //        txtCant_ValorVenta_Letra.Focus();
                    //        errors++;
                    //    }

                    //    if (num_licencia_operacion.Length == 0)
                    //    {
                    //        a.Advertencia("INGRESAR EL NUMERO DE LICENCIA DE OPERACIÓN!");
                    //        txtNum_Lic_Operacion.Text = "";
                    //        txtNum_Lic_Operacion.Focus();
                    //        errors++;
                    //    }
                }
            }
        }
    }
}
