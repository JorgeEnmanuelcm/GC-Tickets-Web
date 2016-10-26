using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace GCTicketsWeb
{
    public partial class MenuDataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                EventosClass Evento = new EventosClass();
                MenuDataList1.DataSource = Evento.Dat();
                MenuDataList1.DataBind();
            }

        }
    }
}