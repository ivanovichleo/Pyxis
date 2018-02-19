using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;


namespace Negocio
{
    public class Usuario : Respuesta
    {

        PyxisdblDataContext data = new PyxisdblDataContext();

        public List<OrganizarPaseadorResult> Organizarpaseador()
        {
            try
            {
                List<OrganizarPaseadorResult> objlista = data.OrganizarPaseador().ToList();
                setCodigo("ok");
                setRTA("todo correcto");
                return objlista;

            }
            catch (Exception ex)
            {
                setCodigo("ERROR");
                setRTA(ex.Message);
                return null;
            }
        }

        public List<buscarpaseadorNResult> BuscarUsuario(string nombre)
        {
            try
            {
                List<buscarpaseadorNResult> objulista = data.buscarpaseadorN(nombre).ToList();
                setCodigo("ok");
                setRTA("busqueda efectuada correctamente");
                return objulista;
            }
            catch (Exception ex)
            {
                setCodigo("error");
                setRTA(ex.Message);
                return null;
            }

        }


        public Usuarios Login(string correo, string contreseña)
        {
            try
            {
                Usuarios objuUsuario = (from f in data.Usuarios
                                          where f.correo == correo && f.contrasena == contreseña
                                          select f).FirstOrDefault();
                setCodigo("ok");
                setRTA("se realizo la consulta exitosamente");
                return objuUsuario;
            }
            catch (Exception Ex)
            {
                setCodigo("Error");
                setRTA(Ex.Message);
                return null;

            }

        }
        public bool CrearUsuario(string nombre, string apellido,string contraseña, string correo, string barrio,int telefono,string tipodoc,int documento)
        {
            try
            {
                data.CrearUsuario(nombre, apellido,contraseña, correo, telefono,barrio,documento,tipodoc);
                setCodigo ("OK");
                setRTA ("Se ingresó el contacto correctamente");
                return true;
            }
            catch (Exception EX) { 
            
                setCodigo("error");
                setRTA(EX.Message);
                return false;
            }
          
        }
        public ConsultarpaseadorResult consultarpaseador(int id)
        {
            try
            {
                ConsultarpaseadorResult job = data.Consultarpaseador(id).FirstOrDefault();
                setCodigo("ok");
                setRTA("se consulto correctamente");
                return job;

            }
            catch (Exception ex)
            {
                setCodigo("ERROR");
                setRTA(ex.Message);
                return null;
            }



        }

        public bool Inactivarpaseador(int id)
        {
            try
            {
                data.Inactivarpaseador(id);
                setCodigo("ok");
                setRTA("se inactivo correctamente");
                return true;

            }
            catch (Exception ex)
            {
                setCodigo("Error");
                setRTA(ex.Message);
                return false;
            }

        }

        public bool ActualizarUsuario(int id, string nombre, string apellido, int telefono, string correo, string direccion, string tiusuario)
        {
            try
            {
                data.ActualizarUsuario(id, nombre, apellido, telefono, correo, direccion);
                setCodigo("Ok");
                setRTA("se actualizo el usuario");
                return true;
            }
            catch (Exception ex)
            {
                setCodigo("error");
                setRTA(ex.Message);
                return false;
            }

        }

    }

}
