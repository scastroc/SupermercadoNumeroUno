<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_empleado.aspx.cs" Inherits="Presentacion.app.site.listar_empleado" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Listar Empleados</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <asp:GridView ID="tbl_empleados" runat="server"
            OnRowEditing="tbl_empleados_RowEditing"
            OnRowDeleting="tbl_empleados_RowDeleting"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Nombres" DataField="Nombres"/>
                <asp:BoundField HeaderText="Apellido Paterno" DataField="ApellidoPaterno"/>
                <asp:BoundField HeaderText="Apellido Materno" DataField="ApellidoMaterno"/>
                <asp:BoundField HeaderText="Run" DataField="Run"/>
                <asp:BoundField HeaderText="Tipo Empleado" DataField="TipoEmpleado.Nombre"/>
                <asp:BoundField HeaderText="Direccion Calle" DataField="Direccion.NombreCalle"/>
                <asp:BoundField HeaderText="Numero" DataField="Direccion.Numero"/>
                <asp:BoundField HeaderText="Comuna" DataField="Direccion.Comuna.Nombre"/>
                <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                <asp:BoundField HeaderText="Remuneracion" DataField="Remuneracion"/>
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento"
                    DataFormatString="{0:dd/MM/yyyy}"/>

               <asp:TemplateField HeaderText="" ItemStyle-CssClass="skyblue-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_edit" runat="server"
                            Text="EDITAR" CommandName="Edit" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="" ItemStyle-CssClass="red-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server"
                            Text="ELIMINAR" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
