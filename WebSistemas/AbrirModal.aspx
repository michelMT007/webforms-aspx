<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbrirModal.aspx.cs" Inherits="WebSistemas.AbrirModal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .modalstyle {
          width: 450;
          border: 1px solid grey;
          padding: 5px;
          margin: 10px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
           <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
                    <asp:TextBox runat="server" ID="txtMensagemChk" ></asp:TextBox>
                    <asp:CheckBox runat="server" ID="chkModal" Text="marque aqui" AutoPostBack="True" OnCheckedChanged="chkModal_CheckedChanged"/>
                    <asp:TextBox ID="txtMostrarCodigo" runat="server" ></asp:TextBox>
                    
                    <asp:Button runat="server" ID="btnModal" OnClick="btnModal_Click"/>
                    <asp:TextBox runat="server" ID="txtBtn" ></asp:TextBox>
            <%--    </ContentTemplate>
            </asp:UpdatePanel>--%>
            </div>
            <div >
                <%--<asp:ScriptManager ID="asm" runat="server" />--%>
                <%--<ajaxToolkit:ModalPopupExtender ID="mpe" runat="server" TargetControlId="ClientButton" 
                    PopupControlID="ModalTesteAbrir" OkControlID="OKButton" />--%>
                <asp:Panel class="modalstyle" ID="ModalTesteAbrir" runat="server" Width="500px">
                    <asp:TextBox ID="txtCodigoInicial" runat="server" ></asp:TextBox>
                    <asp:TextBox ID="txtAnoCodigo" runat="server" ></asp:TextBox>
                    <asp:Button ID="btnSalvarCodigo" runat="server" Text="Salvar" OnClick="btnSalvarCodigo_Click"/>
                    <asp:Button ID="OKButton" runat="server" Text="Close" />
                </asp:Panel>
            </div>
            
        </div>
    </form>
</body>
</html>
