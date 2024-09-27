using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsUsuario
    {
        private int id_tipo, identificacion, telefono;
        private string nombre, correo, contraseña;
        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        public ClsUsuario(int id_tipo, int identificacion, int telefono, string nombre, string correo, string contraseña, string mensajeError, string valorScalar, DataTable dtResultados)
        {
            this.id_tipo = id_tipo;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.nombre = nombre;
            this.correo = correo;
            this.contraseña = contraseña;
        }

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
    }
}
