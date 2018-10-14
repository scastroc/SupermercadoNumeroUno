using Biblioteca.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class registrar_empleado : System.Web.UI.Page
    {
        private List<TipoEmpleadoEntity> tipos;
        private List<EmpleadoEntity> empleados;
        private List<ComunaEntity> comunas;
        

        protected void Page_Load(object sender, EventArgs e)
        {            
            
            crearEmpleados();

            if (!IsPostBack)
            {
                cargarTipoEmpleados();
                cargarComunas();

                EmpleadoEntity updateEmp = (EmpleadoEntity)Session["updateEmp"];

                if (updateEmp != null)
                {
                    txt_nombres.Text = updateEmp.Nombres.ToString();
                    txt_apellidoPaterno.Text = updateEmp.ApellidoPaterno.ToString();
                    txt_apellidoMaterno.Text = updateEmp.ApellidoMaterno.ToString();
                    txt_run.Text = updateEmp.Run.ToString();
                    txt_telefono.Text = updateEmp.Telefono.ToString();
                    txt_remuneracion.Text = updateEmp.Remuneracion.ToString();
                    txt_nombre_calle.Text = updateEmp.Direccion.NombreCalle.ToString();
                    txt_numero.Text = updateEmp.Direccion.Numero.ToString();
                    txt_fecha_nacimiento.Text = updateEmp.FechaNacimiento.ToString("yyyy-MM-dd");
                    txt_fecha_nacimiento.DataBind();
                    //cmb_tipo_empleado.Text = updateEmp.TipoEmpleadoEntity.Nombre.ToString();
                    //cmb_tipo_empleado.DataBind();
                    //cmb_comuna.Text = updateEmp.DireccionEntity.ComunaEntity.Nombre.ToString();
                    //cmb_comuna.DataBind();


                    txt_nombres.Enabled = false;
                    txt_apellidoPaterno.Enabled = false;
                    txt_apellidoMaterno.Enabled = false;
                    txt_run.Enabled = false;
                    txt_fecha_nacimiento.Enabled = false;

                    lbl_mensaje.Text = "EDITAR DATOS DE EMPLEADO";
                    lbl_mensaje.CssClass = "skyblue-message";


                }
            }
        }

        
        private void crearEmpleados()
        {
            List<EmpleadoEntity> listaEmpleados = (List<EmpleadoEntity>)Session["empleados"];

            if (listaEmpleados != null)
            {
                empleados = listaEmpleados;

            }
            else
            {
                empleados = new List<EmpleadoEntity>();
            }
        }

        private void cargarTipoEmpleados()
        {
            TipoEmpleadoEntity jefeTi = new TipoEmpleadoEntity();
            jefeTi.Codigo = "01";
            jefeTi.Nombre = "Jefe TI";

            TipoEmpleadoEntity programador = new TipoEmpleadoEntity();
            programador.Codigo = "02";
            programador.Nombre = "Programador";

            TipoEmpleadoEntity cajera = new TipoEmpleadoEntity();
            cajera.Codigo ="03";
            cajera.Nombre = "Cajera";

            TipoEmpleadoEntity supervisor = new TipoEmpleadoEntity();
            supervisor.Codigo = "04";
            supervisor.Nombre = "Supervisor";

            tipos = new List<TipoEmpleadoEntity>();
            tipos.Add(jefeTi);
            tipos.Add(programador);
            tipos.Add(cajera);
            tipos.Add(supervisor);            

            cmb_tipo_empleado.DataSource = tipos;
            cmb_tipo_empleado.DataBind();

            Session["tipoEmpleados"] = tipos;
        }

        private void cargarComunas()
        {

            ComunaEntity santiago = new ComunaEntity();
            santiago.Codigo = 1;
            santiago.Nombre = "Santiago";

            ComunaEntity maipu = new ComunaEntity();
            maipu.Codigo = 2;
            maipu.Nombre = "Maipu";

            ComunaEntity penaflor = new ComunaEntity();
            penaflor.Codigo = 3;
            penaflor.Nombre = "Peñaflor";

            comunas = new List<ComunaEntity>();
            comunas.Add(santiago);
            comunas.Add(maipu);
            comunas.Add(penaflor);

            cmb_comuna.DataSource = comunas;
            cmb_comuna.DataBind();

            Session["comunas"] = comunas;

            

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                EmpleadoEntity nuevoEmpleado = new EmpleadoEntity();
                nuevoEmpleado.Direccion = new DireccionEntity();

                nuevoEmpleado.Nombres = txt_nombres.Text;
                nuevoEmpleado.ApellidoPaterno = txt_apellidoPaterno.Text;
                nuevoEmpleado.ApellidoMaterno = txt_apellidoMaterno.Text;
                nuevoEmpleado.Run = txt_run.Text;

                TipoEmpleadoEntity tipoEmpSeleccion = ((List<TipoEmpleadoEntity>)Session["tipoEmpleados"]).
                    FirstOrDefault(
                    tipos => tipos.Codigo == cmb_tipo_empleado.SelectedValue);
                TipoEmpleadoEntity newTipoEmp = new TipoEmpleadoEntity();
                newTipoEmp.Nombre = tipoEmpSeleccion.Nombre;
                newTipoEmp.Codigo = tipoEmpSeleccion.Codigo;
                nuevoEmpleado.TipoEmpleado = newTipoEmp;
                nuevoEmpleado.Direccion.NombreCalle = txt_nombre_calle.Text;
                nuevoEmpleado.Direccion.Numero = Int32.Parse(txt_numero.Text);
                ComunaEntity comunaSeleccion = ((List<ComunaEntity>)Session["comunas"]).FirstOrDefault(
                    comuna => comuna.Codigo.ToString() == cmb_comuna.SelectedValue);
                ComunaEntity newComunaEmp = new ComunaEntity();
                newComunaEmp.Codigo = comunaSeleccion.Codigo;
                newComunaEmp.Nombre = comunaSeleccion.Nombre;
                nuevoEmpleado.Direccion.Comuna = newComunaEmp;
                nuevoEmpleado.Telefono = Int32.Parse(txt_telefono.Text);
                nuevoEmpleado.Remuneracion = Int32.Parse(txt_remuneracion.Text);
                nuevoEmpleado.FechaNacimiento = DateTime.Parse(txt_fecha_nacimiento.Text);

                List<EmpleadoEntity> listaEmpleados = (List<EmpleadoEntity>)Session["empleados"];
                EmpleadoEntity updateEmp = (EmpleadoEntity)Session["updateEmp"];

                if (updateEmp == null)
                {
                    if (listaEmpleados != null)
                    {
                        empleados = listaEmpleados;
                        empleados.Add(nuevoEmpleado);
                    }
                    else
                    {
                        empleados = new List<EmpleadoEntity>();
                        empleados.Add(nuevoEmpleado);
                    }
                    lbl_mensaje.Text = "EmpleadoEntity registrado exitosamente.";
                    lbl_mensaje.CssClass = "green-mesage";

                }
                else
                {
                    //empleados.FirstOrDefault(
                    //       empleado => empleado.Nombres == nuevoEmpleado.Nombres).TipoEmpleadoEntity = nuevoEmpleado.TipoEmpleadoEntity;
                    empleados.FirstOrDefault(
                        empleado => empleado.Nombres == nuevoEmpleado.Nombres).Remuneracion = nuevoEmpleado.Remuneracion;
                    empleados.FirstOrDefault(
                        empleado => empleado.Nombres == nuevoEmpleado.Nombres).Telefono = nuevoEmpleado.Telefono;

                    lbl_mensaje.Text = "Información actualizada";

                    Session["updateEmpleado"] = null;
                    //Habilitando nombre
                    txt_nombres.Enabled = true;
                }

                Session["empleados"] = empleados;

            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = ex.Message;
                lbl_mensaje.CssClass = "red-message";
            }
            

        }

        public void validar()
        {
            string error = "";

            if ("".Equals(txt_nombres.Text))
            {
                error = error + "<p>- Debe ingresar información en campo Nombres </p>";
            }
            else if (txt_nombres.Text.Length > 60)
            {
                error = error + "<p>- Nombres debe tener máximo 60 caracteres</p>";
            }

            if ("".Equals(txt_apellidoPaterno.Text))
            {
                error = error + "<p>- Debe ingresar un Apellido Paterno </p>";
            }
            else if (txt_apellidoPaterno.Text.Length > 60)
            {
                error = error + "<p>- Apellido Paterno debe tener máximo 60 caracteres</p>";
            }

            if ("".Equals(txt_apellidoMaterno.Text))
            {
                error = error + "<p>- Debe ingresar un Apellido Materno </p>";
            }
            else if (txt_apellidoMaterno.Text.Length > 60)
            {
                error = error + "<p>- Apellido Materno debe tener máximo 60 caracteres</p>";
            }

            if (txt_telefono.Text.Length < 9)
            {

                error = error + "<p>- Debe ingresar al menos 9 caracteres </p>";
            }

            if ("".Equals(txt_fecha_nacimiento.Text))
            {

                error = error + "<p>- Debe ingresar información en campo Fecha </p>";
            }
            else if (DateTime.Parse("01-01-2000").CompareTo(DateTime.Parse(txt_fecha_nacimiento.Text)) < 0)
            {
                error = error + "<p>- El nuevo empleado debe ser mayor de edad</p>";
            }

            if (!"".Equals(error))
            {
                throw new Exception(error);
            }
        }
    }
}