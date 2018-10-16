<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="buscar_empleado.aspx.cs" Inherits="Presentacion.app.site.buscar_empleado" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Buscar Empleados</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    

    <div class="row">
        <div class="col-50">            
            <span>BUSCAR EMPLEADO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_buscar_run" runat="server"
                value=""  placeholder="Ingrese Run">
            </asp:TextBox>
        </div>
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        
        <div class="col-50">            
            <span>NOMBRES</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombres" runat="server"
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>APELLIDO PATERNO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_apellidoPaterno" runat="server"
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>APELLIDO MATERNO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_apellidoMaterno" runat="server"
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>RUN</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_run" runat="server" 
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>TIPO DE EMPLEADO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_tipo_empleado" runat="server"
                value="" >
            </asp:TextBox>
        </div>
        
    </div>
    <div class="row">
        <div class="col-50">
            <span>DIRECCION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombre_calle" runat="server"
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>NUMERO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_numero" runat="server" 
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>COMUNA</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_comuna" runat="server"
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>TELEFONO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_telefono" runat="server" 
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>REMUNERACION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_remuneracion" runat="server" 
                value="" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>FECHA DE NACIMIENTO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_fecha_nacimiento" runat="server">
            </asp:TextBox>
        </div>
    </div>


</asp:Content>
