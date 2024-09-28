using PryEntidades;
using PryLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmRegistro : Form
    {
        private ClsUsuario ObjUsuario = null;
        private readonly ClsUsuarioLn ObjUsuarioLn = new ClsUsuarioLn();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "Identificacion";
            txtIdentificacion.ForeColor = Color.Gray;

            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Gray;

            txtTelefono.Text = "Telefono";
            txtTelefono.ForeColor = Color.Gray;

            txtCorreo.Text = "Correo Electronico";
            txtCorreo.ForeColor = Color.Gray;

            txtContrasena.Text = "Contraseña";
            txtContrasena.ForeColor = Color.Gray;
        }

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "Identificacion")
            {
                txtIdentificacion.Text = "";
                txtIdentificacion.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo Electronico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                txtIdentificacion.Text = "Identificacion";
                txtIdentificacion.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Correo Electronico";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Gray;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ObjUsuario = new ClsUsuario()
            {
                Identificacion = Convert.ToInt32(txtIdentificacion.Text),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Id_tipo = 3,
                Contraseña = txtContrasena.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
            };
            ObjUsuarioLn.Create(ref ObjUsuario);
            if (ObjUsuario.MensajeError == null)
            {
                MessageBox.Show("Tu usuario: " + ObjUsuario.ValorScalar + " fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ObjUsuario.MensajeError, "Error en la creacion del usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTelefono.Text = "";
            txtNombre.Text = "";
            txtIdentificacion.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
