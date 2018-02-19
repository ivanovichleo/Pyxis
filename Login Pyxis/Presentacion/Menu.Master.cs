using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBase;

namespace Presentacion
{
    public partial class Menu1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {if ((Usuarios)Session["Usuario"] == null)
            {
                Session.Abandon();
                Response.Redirect("Inicio");
                    
            }

        }

        protected void salirbtn(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Inicio.aspx");
        }

        protected void ControlUS(object sender, EventArgs e)
        {
            Response.Redirect("ControlUS.aspx");
        }
    }
}