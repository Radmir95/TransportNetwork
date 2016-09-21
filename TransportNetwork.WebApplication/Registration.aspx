<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TransportNetwork.WebApplication.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div align="center" runat="server">
        <table id="FailTable" width="100%">
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="Dynamic" runat="server" ErrorMessage="Вы не ввели пароль" ControlToValidate="Password" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Display="Dynamic" runat="server" ErrorMessage="Имя не может быть пустым" ControlToValidate="Name" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" runat="server" ErrorMessage="Фамилия не может быть пустой" ControlToValidate="LastName" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:CompareValidator ID="CompareValidator1" Display="Dynamic" runat="server" ControlToCompare="Password" ControlToValidate="Password_repeat" ErrorMessage="Пароли не совпадают" ForeColor="Red"></asp:CompareValidator></td>
            </tr>

            <tr>
                <td>
                    <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Вы не ввели Email" ControlToValidate="Email" ForeColor="Red" /></td>
            </tr>
            <tr>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic" runat="server" ControlToValidate="Email" ErrorMessage="Не верный формат Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
        </table>
    </div>
    <div align="center">
        <table id="loginTable">
            <tr>
                <td>Имя:</td>
                <td>
                    <asp:TextBox ID="Name" runat="server" type="text" size="20" name="name" MaxLength="20" /></td>
            </tr>
            <tr>
                <td>Фамилия</td>
                <td>
                    <asp:TextBox ID="LastName" runat="server" type="text" size="20" name="lastname" MaxLength="20" /></td>
            </tr>
            <tr>
                <td>Отчество</td>
                <td>
                    <asp:TextBox ID="MiddleName" runat="server" type="text" size="20" name="middleName" MaxLength="20" /></td>
            </tr>
            <tr>

                <td>Пароль</td>
                <td>
                    <asp:TextBox runat="server" ID="Password" type="password" size="20" MaxLength="20" name="password" /></td>
            </tr>
            <tr>
                <td>Подтверждения пароля</td>
                <td>
                    <asp:TextBox runat="server" ID="Password_repeat" type="password" size="20" MaxLength="20" name="password2" />

                </td>
            </tr>
            <tr>
                <td>E-mail</td>
                <td>
                    <asp:TextBox runat="server" ID="Email" type="text" size="20" name="email" />

                </td>
            </tr>
            <tr>
                <td>Телефон</td>
                <td>
                    <asp:TextBox runat="server" ID="Telephone" type="text" size="20" name="telephone" />

                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <asp:Button runat="server" type="submit" Text="Зарегистрироваться" name="submit" OnClick="submit_OnClick" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
