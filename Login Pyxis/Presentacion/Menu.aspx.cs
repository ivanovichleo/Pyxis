using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using DataBase;

namespace Presentacion
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {Usuarios objUSuario = (Usuarios)Session["Usuario"];
                lbsaludo.Text = "bienvenido" + objUSuario.nombre;

                }
                catch (Exception  Ex)
                {
                    Session.Abandon();
                    Response.Redirect("Inicio.aspx");
                    
                }
                

            }


        }
    }
}