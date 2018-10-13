<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="registrar_empleado.aspx.cs" Inherits="Presentacion.app.site.registrar_empleado" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Registar Empleados</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-50">
            <span>NOMBRES</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombres" runat="server"
                value="" placeholder="Nombres">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>APELLIDO PATERNO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_apellidoPaterno" runat="server"
                value="" placeholder="apellido paterno">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>APELLIDO MATERNO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_apellidoMaterno" runat="server"
                value="" placeholder="apellido materno">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>RUN</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_run" runat="server" TextMode="Number"
                value="" placeholder="00000000-0">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>TIPO DE EMPLEADO</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_tipo_empleado" runat="server" DataValueField="Codigo"
               DataTextField="Nombre">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>DIRECCION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombre_calle" runat="server"
                value="" placeholder="Calle">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>NUMERO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_numero" runat="server" TextMode="Number"
                value="" placeholder="000">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>COMUNA</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_comuna" runat="server" DataValueField="Codigo"
               DataTextField="Nombre">
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>TELEFONO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_telefono" runat="server" TextMode="Number"
                value="" placeholder="000000000">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>REMUNERACION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_remuneracion" runat="server" TextMode="Number"
                value="" placeholder="0000000">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>FECHA DE NACIMIENTO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_fecha_nacimiento" runat="server" TextMode="Date" >
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_registrar" runat="server"
                Text="CREAR"  OnClick="btn_registrar_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="col-100">
            <asp:Label ID="lbl_mensaje" runat="server" />
        </div>
    </div>
</asp:Content>
