using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PryAccesoDatos;
using PryEntidades;

namespace PryLogicaNegocio
{
    public class ClsUsuarioLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_Index_usuario]",
                Scalar = false
            };
            Ejecutar(ref ObjUsuario);
        }
        #endregion

        private void Ejecutar(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUsuario.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUsuario.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjUsuario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjUsuario.DtResultados.Rows)
                        {
                            ObjUsuario.Id_tipo = Convert.ToInt32( item["Id_tipo"].ToString());
                            ObjUsuario.Identificacion = Convert.ToInt32(item["Identificacion"].ToString());
                            ObjUsuario.Nombre = item["nombre"].ToString();
                            ObjUsuario.Correo = item["correo"].ToString();
                            ObjUsuario.Telefono = Convert.ToInt32(item["telefono"].ToString());
                            ObjUsuario.Contraseña = item["contrasena"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjUsuario.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }


        #region MetodosCRUD
        public void Create(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_Create_usuario]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Id_tipo", "4", ObjUsuario.Id_tipo);
            ObjDataBase.DtParametros.Rows.Add(@"@Identificacion", "4", ObjUsuario.Identificacion);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "15", ObjUsuario.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@correo", "15", ObjUsuario.Correo);
            ObjDataBase.DtParametros.Rows.Add(@"@telefono", "4", ObjUsuario.Telefono);
            ObjDataBase.DtParametros.Rows.Add(@"@contrasena", "15", ObjUsuario.Contraseña);

            Ejecutar(ref ObjUsuario);
        }

        public void Update(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_Update_usuario]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@identificacion", "4", ObjUsuario.Identificacion);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "15", ObjUsuario.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@correo", "15", ObjUsuario.Correo);
            ObjDataBase.DtParametros.Rows.Add(@"@telefono", "4", ObjUsuario.Telefono);
            ObjDataBase.DtParametros.Rows.Add(@"@contrasena", "15", ObjUsuario.Contraseña);

            Ejecutar(ref ObjUsuario);
        }

        public void Delete(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_Delete_usuario]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@identificacion", "4", ObjUsuario.Identificacion);
            Ejecutar(ref ObjUsuario);
        }

        public void Read(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_Read_usuario]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@identificacion", "4", ObjUsuario.Identificacion);

            Ejecutar(ref ObjUsuario);
        }

        public void Validar(ref ClsUsuario objUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[Sp_ValidarUsuario]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@correo", "15", objUsuario.Correo);
            ObjDataBase.DtParametros.Rows.Add(@"@contra", "15", objUsuario.Contraseña);
            Ejecutar(ref objUsuario);
        }
        #endregion
    }
}
