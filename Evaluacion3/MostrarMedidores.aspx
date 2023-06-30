<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="Evaluacion3.MostrarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
        <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" 
                         OnRowCommand="grillaMedidores_RowCommand"
                         AutoGenerateColumns="false" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="Fecha" HeaderText="Dia" />
                            <asp:BoundField DataField="Minuto" HeaderText="Minutos" />
                            <asp:BoundField DataField="Hora" HeaderText="Horas"/>
                            <asp:BoundField DataField="ValorConsumo" HeaderText="Valor del consumo" />
                            <asp:BoundField DataField="MedidorElegido.TipoMedidor" HeaderText="Medidor elegido" />

                            <asp:TemplateField>
                                
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

