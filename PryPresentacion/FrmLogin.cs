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
    public partial class FrmLogin : Form
    {
        private ClsUsuario ObjUsuario = null;
        private readonly ClsUsuarioLn ObjUsuarioLn = new ClsUsuarioLn();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtCorreoElectronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text == "Correo Electronico")
            {
                txtCorreoElectronico.Text = "";
                txtCorreoElectronico.ForeColor = Color.Black;
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                txtCorreoElectronico.Text = "Correo Electronico";
                txtCorreoElectronico.ForeColor= Color.Gray;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtCorreoElectronico.Text = "Correo Electronico";
            txtCorreoElectronico.ForeColor = Color.Gray;

            txtContrasena.Text = "Contraseña";
            txtContrasena.ForeColor = Color.Gray;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            ObjUsuario = new ClsUsuario()
            {
                Correo = txtCorreoElectronico.Text,
                Contraseña = txtContrasena.Text,
            };

            // Llamar a la función de validación
            ObjUsuarioLn.Validar(ref ObjUsuario);

            // Verificar si hubo algún error en la base de datos o en la validación
            if (ObjUsuario.MensajeError == null)
            {
                // Verificamos si hay resultados en DtResultados (simulación de éxito)
                if (ObjUsuario.DtResultados != null && ObjUsuario.DtResultados.Rows.Count == 0)
                {
                    MessageBox.Show("Bienvenido a la aplicación FitPass " + ObjUsuario.Correo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Verificar el tipo de usuario seleccionado en cblTipo
                    foreach (var item in cblTipo.CheckedItems)
                    {
                        if (item.ToString() == "Administrativo")
                        {
                            // Mostrar el menú correspondiente al usuario administrativo
                            FrmMenu frmMenu = new FrmMenu();
                            frmMenu.Show();
                            this.Hide();
                        }
                        else if (item.ToString() == "Cliente")
                        {
                            // Mostrar el menú correspondiente al cliente
                             FrmMenu frmMenu = new FrmMenu();
                             frmMenu.Show();
                             this.Hide();
                        }
                        else if (item.ToString() == "Empleado/entrenador")
                        {
                            //Mostrar el menú correspondiente al empleado/entrenador
                            FrmMenu frmMenu = new FrmMenu();
                            frmMenu.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar el error si hubo un problema en la validación o base de datos
                MessageBox.Show("Error DB: " + ObjUsuario.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cblTipo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar todos los ítems excepto el que se está marcando
                for (int i = 0; i < cblTipo.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        cblTipo.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
