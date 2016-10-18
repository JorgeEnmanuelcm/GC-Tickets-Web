using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace GCTicketsWeb.Consultas
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string condicion;
            UsuariosClass Usuario = new UsuariosClass();
            if (BuscarTextBox.Text.Trim().Length == 0)
            {
                condicion = " 1=1 ";
            }
            else
            {
                if (CamposDropDownList.SelectedIndex == 0)
                {
                    condicion = CamposDropDownList.SelectedItem.Text + " = " + BuscarTextBox.Text;
                }
                else
                {
                    condicion = CamposDropDownList.SelectedItem.Text + " like " + "'%" + BuscarTextBox.Text + "%'";
                }
            }
            ConsultaGridView.DataSource = Usuario.Listado(" * ", condicion, " ");
            ConsultaGridView.DataBind();
        }
    }
}