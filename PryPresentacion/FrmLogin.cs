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
            ObjUsuarioLn.Validar(ref ObjUsuario);

            if (ObjUsuario.MensajeError == null)
            {
                if (ObjUsuario.DtResultados.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido a la aplicacion FitPass " + ObjUsuario.Contraseña, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var item in cblTipo.CheckedItems)
                    {
                        if (item.ToString() == "Administrativo")
                        {
                            /*FrmMenu frmMenu = new FrmMenu();
                            frmMenu.Show();
                            this.Hide();*/
                        }
                        else if (item.ToString() == "Cliente")
                        {
                            /*FrmMenu frmMenu = new FrmMenu();
                            frmMenu.Show();
                            this.Hide();*/
                        }
                        else if (item.ToString() == "Empleado/entrenador")
                        {
                            /*FrmMenu frmMenu = new FrmMenu();
                            frmMenu.Show();
                            this.Hide();*/
                        }
                    }

                }
                else
                {
                    MessageBox.Show(ObjUsuario.MensajeError, "Usuario y/o Contraseña incorrecta ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error DB " + ObjUsuario.MensajeError);
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
