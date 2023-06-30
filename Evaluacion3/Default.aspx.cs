using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lectorDAL = new LecturaDALObjetos();

        // metodo a utilizar cuando se carga el form:
        // - cuando es una peticion GET (!PostBack)
        // - cuando es una peticion POST (PostBack)
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> lecturas  = medidorDAL.ObtenerMedidores();
                this.lecturaDbl.DataSource = lecturas;
                this.lecturaDbl.DataTextField = "TipoMedidor";
                this.lecturaDbl.DataValueField = "NumeroSerie";
                
                this.lecturaDbl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del fomulario
            DateTime fecha = this.calendario.SelectedDate;
            string hora = this.horatxt.Text.Trim();
            string minutos = this.minutotxt.Text.Trim();
            int valorConsumo = Convert.ToInt32(valorconsumotxt.Text);
            //obtiene el valor del DropDown
            string MedidorSeleccionado= this.lecturaDbl.SelectedValue;
            //obtiene el valor del Texto del DropDown
            string MedidorTexto = this.lecturaDbl.SelectedItem.Text;

            //2.1 Construir el obejeto Bebida

            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            Medidor medidor = medidores.Find(b => b.NumeroSerie== this.lecturaDbl.SelectedItem.Value);

            //2.2  Construir el objeto de tipo cliente

            Lectura lectura = new Lectura()
            {
                Fecha = fecha,
                Hora = hora,
                Minuto = minutos,
                ValorConsumo=valorConsumo,
                MedidorElegido= medidor

              
            };
            //3. Llamar al DAL

            lectorDAL.Agregar(lectura);
            //4. Mostrar mensaje de exito

            this.mensajesLbl.Text = "Cliente Guardado correctamente";
            Response.Redirect("MostrarMedidores.aspx");
        }
    }
}