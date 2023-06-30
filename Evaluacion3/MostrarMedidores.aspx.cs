using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3
{
    public partial class MostrarMedidores : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }

        protected void cargagrilla()
        {
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            this.grillaMedidores.DataSource = lecturas;
            this.grillaMedidores.DataBind();
        }

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
           
        }
    }
}