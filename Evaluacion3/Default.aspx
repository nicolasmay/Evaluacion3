<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Evaluacion3.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"> </asp:Label> 
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Minuto</label>
                        <asp:TextBox ID="minutotxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Calendario</label>
                        <asp:Calendar ID="calendario" runat="server"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="rutTxt">Hora</label>
                        <asp:TextBox ID="horatxt" CssClass="form-control" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="rutTxt">Valor consumo</label>
                        <asp:TextBox ID="valorconsumotxt" CssClass="form-control" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="medidorDbl">Lectura</label>                        
      <!--<select>-->  <asp:DropDownList runat="server" ID="lecturaDbl" CssClass="form-select" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione una opcion"></asp:ListItem>

                        </asp:DropDownList>
                    </div>
                    
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>