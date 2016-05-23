using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ISW.SUSS.Clases;

namespace WEBGUI
{
    public partial class alumnoMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
            if (!Session["UsuarioId"].Equals(null))
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));
                //nameLabel=
            }
            else
            {

            }
        }
    }
}