<%@ Page Title="View Posts" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="Lab2.Posts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
    <div class="page-header text-center">
        <strong><h1>
            <asp:Label runat="server" ID="titleDisplay" />
        </h1></strong>
    </div>


            <div class="panel panel-default PostListItem">
              <div class="panel-heading">
                <h3 class="panel-title"><asp:Label runat="server" ID="authorDisplay" /></h3>
                <h3 class="panel-title"><asp:Label runat="server" ID="dateDisplay" /></h3>
              </div>
              <div class="panel-body">
                <asp:Label runat="server" ID="bodyDisplay" />
              </div>
            </div>
    
    

</asp:Content>
