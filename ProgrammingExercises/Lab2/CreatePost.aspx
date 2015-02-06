<%@ Page Title="Create Post" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreatePost.aspx.cs" Inherits="Lab2.CreatePost" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       
    <div class="page-header">
        <h1>Wanting to post on the blog...? <small>look no further</small></h1>
    </div>

    <div class="form-group">
        <label for="titleArea">Post Title:</label>
        <asp:TextBox ID="titleBox" runat="server" TextMode="SingleLine" columns="10" CssClass ="form-control"></asp:TextBox>
     
        <label for="postArea">Your Post:</label>
        <asp:TextBox ID="postBox" runat="server" TextMode="MultiLine" Rows="20" columns="20" CssClass ="form-control"></asp:TextBox>
        
    </div>

    <div class="row">
        <asp:Button ID="postButton" runat="server" Text="Post" class="btn btn-success" OnClick="postButton_Click" />
        <asp:Button ID="clearButton" runat="server" Text="Clear" class="btn btn-danger" OnClick="clearButton_Click" />
    </div>

</asp:Content>
