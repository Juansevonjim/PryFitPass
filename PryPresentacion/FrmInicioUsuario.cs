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
    public partial class FrmInicioUsuario : Form
    {
        private string correo;
        private ClsUsuario Objusuario = null;
        private readonly ClsUsuarioLn ObjUsuarioLn = new ClsUsuarioLn();

        public FrmInicioUsuario(string correo)
        {
            InitializeComponent();
            this.correo = correo;
        }


        private void FrmInicioUsuario_Load(object sender, EventArgs e)
        {
            Objusuario = new ClsUsuario()
            {
                Correo = correo 
            };
            ObjUsuarioLn.Read(ref  Objusuario);

            txtIdentificacion.Text = Objusuario.Identificacion.ToString();
            txtNombre.Text = Objusuario.Nombre;
            txtEmail.Text = Objusuario.Correo;
            txtTelefono.Text = Objusuario.Telefono.ToString();
            txtContrasena.Text = Objusuario.Contraseña;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu(correo);

            Objusuario = new ClsUsuario()
            {

                Identificacion = Convert.ToInt32(txtIdentificacion.Text),
                Nombre = txtNombre.Text,
                Correo = txtEmail.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Contraseña = txtContrasena.Text,
            };

            ObjUsuarioLn.Update(ref Objusuario);
            if (Objusuario.MensajeError == null)
            {
                MessageBox.Show("El usuario fue actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Objusuario.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
