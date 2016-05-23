using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace WEBGUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Tab1_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Clicked";
            tabUA.CssClass = "Initial";
            tabUR.CssClass = "Initial";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Initial";
            tabUA.CssClass = "Clicked";
            tabUR.CssClass = "Initial";
            MainView.ActiveViewIndex = 1;
        }

        protected void Tab3_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Initial";
            tabUA.CssClass = "Initial";
            tabUR.CssClass = "Clicked";
            MainView.ActiveViewIndex = 2;
        }

        protected void tbAlLogin_Click(object sender, EventArgs e)
        {
          if(!Usuarios.autenticarUsuario(tbAlCorreo.Text, tbAlPass.Text, 1))
                //send not logged in message
            else
            {

                Response.Redirect("~/alumnoMain.aspx?UsuarioId=" + Usuarios.getUserNumber());
            }
                
        }
    }
}