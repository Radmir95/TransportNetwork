<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="TransportNetwork.WebApplication.Account.OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>Используйте для входа другую службу.</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="Войдите, используя <%#: Item %> свою учетную запись.">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
       
    </asp:ListView>
</div>
