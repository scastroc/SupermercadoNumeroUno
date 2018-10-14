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
        private List<EmpleadoEntity> empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargaListaEmpleados();



            //EmpleadoEntity buscarEmp = empleados.FirstOrDefault(
            //    empleado => empleado.Run == run);


        }

        private void cargaListaEmpleados()
        {
            List<EmpleadoEntity> listaEmpleados = (List<EmpleadoEntity>)Session["empleados"];

            if (listaEmpleados == null || listaEmpleados.Count == 0)
            {
                empleados = new List<EmpleadoEntity>();
            }
            else
            {
                empleados = listaEmpleados;
            }
        }
    }
}