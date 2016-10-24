using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace GCTicketsWeb.Registros
{
    public partial class TipoEventoForm : System.Web.UI.Page
    {
        TipoEventoClass TipoEvento = new TipoEventoClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            TipoEventoIdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
        }

        private bool ObtenerDatos()
        {
            bool Retorno = true;
            int id;
            int.TryParse(TipoEventoIdTextBox.Text, out id);
            if(id > 0)
            {
                TipoEvento.TipoEventoId = id;
            }
            else
            {
                Retorno = false;
            }
            if (DescripcionTextBox.Text.Length > 0)
            {
                TipoEvento.Descripcion = DescripcionTextBox.Text;
            }
            else
            {
                Retorno = false;
            }
            return Retorno;
        }

        private void DevolverDatos()
        {
            TipoEventoIdTextBox.Text = TipoEvento.TipoEventoId.ToString();
            DescripcionTextBox.Text = TipoEvento.Descripcion.ToString();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(TipoEventoIdTextBox.Text, out id);
            if (id < 0)
            {
                Response.Write("<script>alert('error')</script>");
            }
            else
            {
                if (TipoEvento.Buscar(id))
                {
                    DevolverDatos();
                }
                else
                {
                    Response.Write("<script>alert('error')</script>");
                }
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (TipoEvento.UnicaDescripcion(DescripcionTextBox.Text))
            {
                Response.Write("<script>alert('error')</script>");
                DescripcionTextBox.Text = string.Empty;
            }
            else
            {
                if (TipoEventoIdTextBox.Text.Length == 0)
            {
                ObtenerDatos();
                if (TipoEvento.Insertar())
                {
                    Limpiar();
                    Response.Write("<script>alert('Inserto')</script>");
                }
                else
                {
                    Response.Write("<script>alert('error')</script>");
                }
            }
            if (TipoEventoIdTextBox.Text.Length > 0)
            {
                ObtenerDatos();
                if (TipoEvento.Editar())
                {
                    Response.Write("<script>alert('Modifico')</script>");
                }
                else
                {
                    Response.Write("<script>alert('error')</script>");
                }
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos();
                if (TipoEvento.Buscar(TipoEvento.TipoEventoId))
                {
                    if (TipoEvento.Eliminar())
                    {
                        Limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('error')</script>");
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('error')</script>");
            }
        }
    }
}