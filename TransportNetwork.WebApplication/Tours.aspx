<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tours.aspx.cs" Inherits="TransportNetwork.WebApplication.Tours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListView ID="ListOfProducts" runat="server" ItemType="NetShop.Domain.Entity.Product" ItemPlaceholderID="itemPlaceholder">

                <LayoutTemplate>

                    <table>
                        <tr>
                            <tr runat="server" style="background-color: #77c6d0">
                                <th></th>
                                <th runat="server">Название</th>
                                <th>
                                    <asp:LinkButton ID="sortByCount" runat="server" CommandName="Sort" CommandArgument="Cost"
                                        Text="Стоимость" /></th>

                                <th runat="server">Количество</th>
                                <th runat="server"></th>
                            </tr>
                        </tr>
                        <tr id="itemPlaceholder" runat="server"></tr>
                    </table>

                </LayoutTemplate>


                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LabelIdProduct" Visible="False" Text="<%#:Item.ProductId %>" /></td>
                        <td>
                            <asp:Label runat="server" ID="LabelName" Text="<%#:Item.Name %>" /></td>
                        <td>
                            <asp:Label runat="server" ID="LabelCost" Text="<%#:Item.Cost %>" /></td>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxCount" MaxLength="2"></asp:TextBox></td>
                        <td>
                            <asp:LinkButton ID="InCartId" runat="server" CommandName="InCart">В корзину</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="AddInfo" runat="server" CommandName="AddInformation">Дополнительно</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>


            </asp:ListView>

        </div>
    </form>
</body>
</html>
