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
    }
}
