using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class listar_empleado : System.Web.UI.Page
    {
        private List<EmpleadoEntity> empleados;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargaListaEmpleados();
            if (!IsPostBack)
            {
                refrescarTabla();
            }
            

        }

        private void refrescarTabla()
        {
            tbl_empleados.DataSource = empleados;
            tbl_empleados.DataBind();
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

            //if (listaEmpleados != null)
            //{
            //    empleados = listaEmpleados;

            //}
            //else
            //{
            //    empleados = new List<EmpleadoEntity>();
            //}

            
        }

        protected void tbl_empleados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = tbl_empleados.Rows[e.NewEditIndex];

            string nombres = row.Cells[0].Text;
            string apePaterno = row.Cells[1].Text;
            string apeMaterno = row.Cells[2].Text;
            string run = row.Cells[3].Text;
            string tipoEmpleados = row.Cells[4].Text;
            string calle = row.Cells[5].Text;
            string numero = row.Cells[6].Text;
            string comuna = row.Cells[7].Text;
            string telefono = row.Cells[8].Text;
            string remuneracion = row.Cells[9].Text;
            string fechaNacimiento = row.Cells[10].Text;

            EmpleadoEntity actualizarEmp = new EmpleadoEntity();
            actualizarEmp.Direccion = new DireccionEntity();

            actualizarEmp.Nombres = nombres;
            actualizarEmp.ApellidoPaterno = apePaterno;
            actualizarEmp.ApellidoMaterno = apeMaterno;
            actualizarEmp.Run = run;
            TipoEmpleadoEntity tipoEmp = new TipoEmpleadoEntity();
            tipoEmp.Nombre = tipoEmpleados;
            actualizarEmp.TipoEmpleado = tipoEmp;
            actualizarEmp.Direccion.NombreCalle = calle;
            actualizarEmp.Direccion.Numero = Int32.Parse(numero);
            ComunaEntity comu = new ComunaEntity();
            comu.Nombre = comuna;
            actualizarEmp.Direccion.Comuna = comu;
            actualizarEmp.Telefono = Int32.Parse(telefono);
            actualizarEmp.Remuneracion = Int32.Parse(remuneracion);
            actualizarEmp.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            

            Session["updateEmp"] = actualizarEmp;
            Response.Redirect("registrar_empleado.aspx");


        }

        protected void tbl_empleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = tbl_empleados.Rows[e.RowIndex];
            string run = row.Cells[3].Text;
            EmpleadoEntity deleteEmpleado = empleados.FirstOrDefault(
                empleado => empleado.Run == run);
            empleados.Remove(deleteEmpleado);
            refrescarTabla();
        }
    }
}