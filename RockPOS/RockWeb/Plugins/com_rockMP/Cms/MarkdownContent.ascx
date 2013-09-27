<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarkdownContent.ascx.cs" Inherits="RockWeb.Plugins.com_rockMP.Cms.MarkdownContent" %>

<asp:UpdatePanel ID="upPanel" runat="server">
    <ContentTemplate>
        <asp:Button ID="btnRestart" runat="server" CssClass="btn btn-danger" Text="Restart WebApp" OnClick="btnRestart_Click" />
        <div class="row">
            <Rock:RockTextBox ID="tbMarkdownInput" runat="server" Label="Edit Markdown" Rows="20" Font-Names="Courier-New" TextMode="MultiLine" CssClass="col-md-6" />
            <div class="col-md-6"><asp:Literal ID="lCheatSheet" runat="server" Text="Here is the cheatsheet..." /></div>
        </div>
        <asp:Button ID="btnTransform" runat="server" OnClick="btnTransform_Click" CssClass="btn" Text="Transform" />
        <asp:Button ID="Button1" runat="server" OnClick="btnTransform_Click" CssClass="btn" Text="Transform" />
        <asp:Button ID="Button3" runat="server" OnClick="btnTransform_Click" CssClass="btn" Text="Transform" />
        <asp:Button ID="Button2" runat="server" OnClick="btnTransform_Click" CssClass="btn" Text="Transform" />
        <div class="jumbotron">
            <asp:Literal ID="lHtml" runat="server" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
