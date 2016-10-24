using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace GCTicketsWeb.Registros
{
    public partial class EventosForm : System.Web.UI.Page
    {
        EventosClass Evento = new EventosClass();
        DataTable dt = new DataTable();
        TipoEventoClass Tipo = new TipoEventoClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //TipoEventoIdDropDownList.DataSource = Tipo.Listado(" * ", "1=1", "");
                //TipoEventoIdDropDownList.DataTextField = "Descripcion";
                //TipoEventoIdDropDownList.DataValueField = "TipoEventoId";
                //TipoEventoIdDropDownList.DataBind();

                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("DescTicket"), new DataColumn("CantDisponible"), new DataColumn("PrecioTicket") });
                ViewState["EventosClass"] = dt;
            }
        }

        private void Limpiar()
        {
            EventoIdTextBox.Text = string.Empty;
            TipoEventoIdDropDownList.ClearSelection();
            NombreEventoTextBox.Text = string.Empty;
            FechaEventoTextBox.Text = string.Empty;
            LugarEventoTextBox.Text = string.Empty;
            DescTicketTextBox.Text = string.Empty;
            CantDisponibleTextBox.Text = string.Empty;
            PrecioTicketTextBox.Text = string.Empty;
            EventosGridView.DataSource = string.Empty;
            EventosGridView.DataBind();
        }

        private bool ObtenerDatos()
        {
            bool Retorno = true;
            int id;
            int tipoEventoid;
            int.TryParse(EventoIdTextBox.Text, out id);
            int.TryParse(TipoEventoIdDropDownList.SelectedValue, out tipoEventoid);
            if(id > 0)
            {
                Evento.EventoId = id;
            }
            else
            {
                Retorno = false;
            }
            if (tipoEventoid > 0)
            {
                Evento.TipoEventoId = tipoEventoid;
            }
            else
            {              
                Retorno = false;
            }
            if (NombreEventoTextBox.Text.Length > 0)
            {
                Evento.NombreEvento = NombreEventoTextBox.Text;
            }
            else
            {
                Retorno = false;
            }
            if (FechaEventoTextBox.Text.Length > 0)
            {
                Evento.FechaEvento = FechaEventoTextBox.Text;
            }
            else
            {
                Retorno = false;
            }
            if (LugarEventoTextBox.Text.Length > 0)
            {
                Evento.LugarEvento = LugarEventoTextBox.Text;
            }
            else
            {
                Retorno = false;
            }
            if (EventosGridView.Rows.Count > 0)
            {
                foreach (GridViewRow var in EventosGridView.Rows)
                {
                    Evento.AgregarTickets(var.Cells[0].Text, Convert.ToInt32(var.Cells[1].Text), Convert.ToInt32(var.Cells[2].Text));
                }
            }
            else
            {
                Retorno = false;
            }
            return Retorno;
        }

        public void DevolverDatos()
        {
            EventoIdTextBox.Text = Evento.EventoId.ToString();
            TipoEventoIdDropDownList.SelectedValue = Evento.TipoEventoId.ToString();
            FechaEventoTextBox.Text = Evento.FechaEvento.ToString();
            LugarEventoTextBox.Text = Evento.LugarEvento.ToString();
            foreach (var item in Evento.Detalle)
            {
                dt = (DataTable)ViewState["EventosClass"];
                dt.Rows.Add(item.DescTicket, item.CantDisponible, item.PrecioTicket);
                ViewState["EventosClass"] = dt;
                EventosGridView.DataSource = (DataTable)ViewState["EventosClass"];
                EventosGridView.DataBind();
                CantDisponibleTextBox.Text = string.Empty;
                PrecioTicketTextBox.Text = string.Empty;
                EventosGridView.DataSource = string.Empty;
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["EventosClass"];
            dt.Rows.Add(DescTicketTextBox.Text, CantDisponibleTextBox.Text, PrecioTicketTextBox.Text);
            ViewState["EventosClass"] = dt;
            EventosGridView.DataSource = dt;
            EventosGridView.DataBind();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Evento.UnicoEvento(NombreEventoTextBox.Text))
            {
                Response.Write("<script>alert('error')</script>");
                NombreEventoTextBox.Text = string.Empty;
            }
            else
            {
                if (EventoIdTextBox.Text.Length == 0)
                {
                    ObtenerDatos();
                    if (Evento.Insertar())
                    {
                        Limpiar();
                        Response.Write("<script>alert('Inserto')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('error')</script>");
                    }
                }
                if (EventoIdTextBox.Text.Length > 0)
                {
                    ObtenerDatos();
                    if (Evento.Editar())
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
                if (Evento.Buscar(Evento.EventoId))
                {
                    if (Evento.Eliminar())
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

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(EventoIdTextBox.Text, out id);
            if (id < 0)
            {
                Response.Write("<script>alert('error')</script>");
            }
            else
            {
                if (Evento.Buscar(id))
                {
                    DevolverDatos();
                }
                else
                {
                    Response.Write("<script>alert('error')</script>");
                }
            }
        }
    }
}