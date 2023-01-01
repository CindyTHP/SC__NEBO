﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC__NEBO.Formularios.Formularios_de_Menu.Clientes
{
    public partial class Frm_Clientes : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Asistente a = new Clases.Asistente();

        int errors;

        string idcliente, nombre, apellido, direccion, dni, rtn, estadocivil, comunidad, claveihcafe, municipio, telefono;

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim().Length == 5)
            {
                string id = a.Clean(txtIdCliente.Text.Trim());
                CheckIfIdExist(id);
            }
            else
            {
                lblMsg.Visible = false;
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
                    string id_cliente = txtIdCliente.Text.Trim();
                    string stmt = "DNI='"+dni+"',NOMBRES='" + nombre + "',APELLIDOS='" + apellido + "',RTN='"+rtn+"',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "'," +
                        "ESTADO_CIVIL='" + estadocivil + "',CLAVE_IHCAFE='" + claveihcafe + "',COMUNIDAD='" + comunidad + "',MUNICIPIO='" + municipio + "',";
                    string condicion = "ID_CLIENTE='" + id_cliente + "'";

                    if (db.Update("CLIENTES", stmt, condicion) > 0)
                    {
                        a.Aprueba("LOS CAMBIOS SE APLICARON CORRECTAMENTE!");
                        Clear();
                        Boot();
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidateData();

            string msg = "¿DESEA GUARDAR EL CLIENTE " + apellido + "?";

            if (errors == 0)
            {
                if (a.Pregunta(msg) == true)
                {
                    string campos = "ID_CLIENTE, NOMBRES, APELLIDOS, RTN, DIRECCION, TELEFONO, ESTADO_CIVIL, CLAVE_IHCAFE, COMUNIDAD, MUNICIPIO";

                    string valores = "'" + idcliente + "', '" + nombre + "','" + apellido + "', '"+ rtn +"','" + direccion + "','" + telefono + "', '" + estadocivil + "', '" + claveihcafe + "', '"+comunidad+"','"+municipio+"'";


                    if (db.Save("CLIENTES", campos, valores) > 0)
                    {
                        db.RawSQL(q);
                        a.Aprueba("EL CLIENTE " + apellido + " HA SIDO REGISTRADO CON ÉXITO!");
                        db.SetLast(idcorre);
                        Clear();
                        Boot();
                    }
                }
            }
        }

        private void Clear()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtRTN.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtClaveIHCAFE.Clear();
            txtComunidad.Clear();
            txtMunicipio.Clear();
            txtTelefono.Clear();
        }

        public void ValidateData()
        {
            errors = 0;
            idcliente = a.Clean(txtIdCliente.Text.Trim());
            nombre = a.Clean(txtNombre.Text.Trim());
            apellido = a.Clean(txtApellido.Text.Trim());
            rtn = a.Clean(txtRTN.Text.Trim());
            dni = a.Clean(txtDNI.Text.Trim());
            direccion = a.Clean(txtDireccion.Text.Trim());
            telefono = txtTelefono.Text.Trim();
            claveihcafe = a.Clean(txtClaveIHCAFE.Text.Trim());
            comunidad = a.Clean(txtComunidad.Text.Trim());
            municipio = a.Clean(txtMunicipio.Text.Trim());

            if (idcliente.Length == 0)
            {
                a.Advertencia("INGRESAR EL ID DEL CLIENTE!");
                txtIdCliente.Text = "";
                txtIdCliente.Focus();
                errors++;
                return;
            }

            if (nombre.Length == 0)
            {
                h.Warning("INGRESAR EL NOMBRE DEL CLIENTE!");
                txtNombre.Text = "";
                txtNombre.Focus();
                errors++;
            }

            if (apellido.Length == 0)
            {
                h.Warning("INGRESAR EL APELLIDO DEL CLIENTE!");
                txtApellidos.Text = "";
                txtApellidos.Focus();
                errors++;
            }

            if (direccion.Length == 0)
            {
                h.Warning("INGRESAR LA DIRECCION!");
                txtDireccion.Text = "";
                txtDireccion.Focus();
                errors++;
            }

            if (txtTelefono.MaskFull == false)
            {
                h.Warning("INGRESAR EL NUMERO DE TELEFONO!");
                txtTelefono.Text = telefono;
                txtTelefono.Focus();
                errors++;
                return;
            }

            if (correo.Length == 0)
            {
                h.Warning("INGRESAR EL CORREO ELECTRONICO!");
                txtCorreo.Text = "";
                txtCorreo.Focus();
                errors++;
            }

            if (detalles.Length == 0)
            {
                h.Warning("INGRESAR EL NOMBRE DEL RECTOR!");
                txtDetalles.Text = "";
                txtDetalles.Focus();
                errors++;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = Clases.Auth.save == "S" ? true : false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnRegresar.Enabled = false;

            txtIdCliente.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtDNI.Enabled = true;
            txtRTN.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            txtComunidad.Enabled = true;
            txtClaveIHCAFE.Enabled = true;
            txtMunicipio.Enabled = true;
            txtTelefono.Enabled = true;

            txtNombre.Focus();
        }

        private void GetDocente(string search = "")
        {
            string campos, condicion;
            campos = "IDDOCENTE, NOMBRE + ' ' + APELLIDOS, DIRECCION";

            if (search != "")
            {
                condicion = "NOMBRE LIKE '%" + search + "%' AND DEL = 'N'";

            }
            else
            {
                condicion = "DEL = 'N'";
            }

            DataTable data = db.Find("DOCENTES", campos, condicion);

            DgvData.Rows.Clear();

            int i;
            string _iddocente, _docente, _direccion;

            for (i = 0; i < data.Rows.Count; i++)
            {
                iddocente = data.Rows[i][0].ToString();
                _docente = data.Rows[i][1].ToString();
                _direccion = data.Rows[i][2].ToString();
                DgvData.Rows.Add(iddocente, _docente, _direccion);
            }

            lblResumen.Text = "Mostrando " + data.Rows.Count.ToString() + "registros de " + db.Count("DOCENTES", "DEL = 'N'").ToString();
            data.Dispose();
        }

        private void Boot()
        {
            BtnNuevo.Enabled = Clases.Auth.save == "S" ? true : false;
            BtnGuardar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnSalir.Enabled = true;

            txtIdDocente.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtDetalles.Enabled = false;

            lblMsg.Visible = false;

            DgvData.Rows.Clear();
            txtBuscar.Clear();
            txtBuscar.Focus();

        }

        private void GetInfoDocente(string id)
        {
            string condicion = "IDDOCENTE ='" + id + "' AND DEL = 'N'";
            DataTable campus = db.Find("DOCENTES", "*", condicion);

            if (campus.Rows.Count > 0)
            {
                BtnNuevo.Enabled = false;
                BtnGuardar.Enabled = false;
                BtnActualizar.Enabled = Clases.Auth.update == "S" ? true : false;
                BtnEliminar.Enabled = Clases.Auth.delete == "S" ? true : false;
                BtnCancelar.Enabled = true;
                BtnSalir.Enabled = false;


                DataRow info = campus.Rows[0];
                txtIdDocente.Text = info["IDDOCENTE"].ToString();
                txtNombre.Text = info["NOMBRE"].ToString();
                txtApellidos.Text = info["APELLIDOS"].ToString();
                txtDireccion.Text = info["DIRECCION"].ToString();
                txtTelefono.Text = info["TELEFONO"].ToString();
                txtCorreo.Text = info["CORREO"].ToString();
                txtDetalles.Text = info["DETALLES"].ToString();

                txtIdDocente.Enabled = false;
                txtNombre.Enabled = Clases.Auth.update == "S" ? true : false;
                txtApellidos.Enabled = Clases.Auth.update == "S" ? true : false;
                txtDireccion.Enabled = Clases.Auth.update == "S" ? true : false;
                txtTelefono.Enabled = Clases.Auth.update == "S" ? true : false;
                txtCorreo.Enabled = Clases.Auth.update == "S" ? true : false;
                txtDetalles.Enabled = Clases.Auth.update == "S" ? true : false;

                lblMsg.Visible = false;
            }
            else
            {
                h.Warning("ERROR AL RECUPERAR LOS DATOS DEL REGISTRO SELECCIONADO!");
            }

            campus.Dispose();
        }

        private void txtIdCliente_Validating(object sender, CancelEventArgs e)
        {
            string id = a.Clean(txtIdCliente.Text.Trim());
            CheckIfIdExist(id);
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
                string id_cliente = txtIdCliente.Text.Trim();

                if (db.Delete("CLIENTES", "ID_CLIENTE", id_cliente) > 0)
                {
                    a.Aprueba("EL DOCENTE SE ELIMINÓ CON EXITO");
                    Clear();
                    Boot();
                }
            }
        }

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void CheckIfIdExist(string id)
        {
            if (txtIdCliente.Text.Trim().Length == 5)
            {
                if (db.VerifyIfExists("CLIENTES", "ID_CLIENTE", id) == true)
                {
                    lblMsg.Text = "EL CODIGO QUE INTENTA ASIGNAR YA EXISTE. PERTENECE A " + db.Hook("NOMBRE", "CLIENTES", "ID_CLIENTE = '" + a.Clean(txtIdCliente.Text.Trim()) + "'");
                    lblMsg.Visible = true;

                }
                else
                {
                    lblMsg.Visible = false;
                }
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Menu menu = new Frm_Menu();
            menu.Show();
            this.Hide();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            Formularios.Formularios_de_Menu.Clientes.Frm_Lista_Clientes form = new Formularios_de_Menu.Clientes.Frm_Lista_Clientes();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {

        }
        
    }
}