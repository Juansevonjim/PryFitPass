using PryEntidades;
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
    public partial class FrmMenu : Form
    {
        private string correo;
        public FrmMenu(string correo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.correo = correo;
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmInicioUsuario frmInicioUsuario = new FrmInicioUsuario(correo);

            frmInicioUsuario.TopLevel = false; 
            frmInicioUsuario.FormBorderStyle = FormBorderStyle.None;
            frmInicioUsuario.Dock = DockStyle.Fill;

            PnContenido.Controls.Clear();
            PnContenido.Controls.Add(frmInicioUsuario);

            frmInicioUsuario.Show();
        }

        private void BtnQR_Click(object sender, EventArgs e)
        {
            FrmQR frmQR = new FrmQR();

            frmQR.Dock = DockStyle.Fill;
            frmQR.TopLevel = false;

            PnContenido.Controls.Clear();
            PnContenido.Controls.Add(frmQR);
            frmQR.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                frmLogin.Show();
                this.Hide();
            }
        }
    }
}
