using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace GCTicketsWeb
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EventosClass Evento = new EventosClass();
                DataList1.DataSource = Evento.Dat();
                DataList1.DataBind();
            }
        }
    }
}