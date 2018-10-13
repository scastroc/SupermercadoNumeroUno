using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class buscar_empleado : System.Web.UI.Page
    {
        private List<Empleado> empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargaListaEmpleados();



            //Empleado buscarEmp = empleados.FirstOrDefault(
            //    empleado => empleado.Run == run);


        }

        private void cargaListaEmpleados()
        {
            List<Empleado> listaEmpleados = (List<Empleado>)Session["empleados"];

            if (listaEmpleados == null || listaEmpleados.Count == 0)
            {
                empleados = new List<Empleado>();
            }
            else
            {
                empleados = listaEmpleados;
            }
        }
    }
}