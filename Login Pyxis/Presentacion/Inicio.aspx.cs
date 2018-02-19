using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBase;
using Negocio;
 
namespace Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Usuario Objusuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        { if((Usuarios)Session["Usuario"]!=null)
            { 
                Response.Redirect("Menu.aspx");
                
            }
               
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {

                Usuarios objUsuario = Objusuario.Login(Textusua.Text, Textcontra.Text);

                if (objUsuario != null)
                {
                    Session["Usuario"] = objUsuario;
                    
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    labelRespuesta.Text = "no se pudo ingresar, verifique sus datos" + Objusuario.getRTA();
                }
            }
            catch (Exception Ex)
            {
                labelRespuesta.Text = Ex.Message;

            }


            }

        }
    }
