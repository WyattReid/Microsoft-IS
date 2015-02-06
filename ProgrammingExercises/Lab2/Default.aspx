<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Blogging For Fun</h1>
        <p class="lead">This is a great place to blog and view blogs for building great Web sites and Web applications using HTML, CSS, and JavaScript.
                        <br/><br/> 
                        <small><strong>Unauthenticated users may only browse posts</strong></small>
        </p>
        <p>
           <a href="/CreatePost.aspx" class="btn btn-primary btn-lg">Post Now &raquo;</a>
        </p>
    </div>

    <div class="well outerwell">
    <div class="page-header text-center well innerwell">
        <h1><strong>Blog Roll</strong></h1>
    </div>

    <div class="row">
         <asp:ListView ID="PostList" runat="server">
        <ItemTemplate>
            <div class="panel panel-default PostListItem">
              <div class="panel-heading">
                <h2 class="panel-title">
                    <strong>
                    <asp:HyperLink runat="server" Text='<%# DataBinder.Eval(this.GetDataItem(), "PostTitle") %>'
                                   NavigateUrl='<%#"~/Posts.aspx?Title=" +
                                                   System.Web.Security.AntiXss.AntiXssEncoder.UrlEncode(Eval("PostTitle").ToString()) %>'/>
                    </strong>
                </h2>
                <h3 class="panel-title"><%# DataBinder.Eval(this.GetDataItem(),"Author") %></h3>
                <h3 class="panel-title"><%# DataBinder.Eval(this.GetDataItem(),"PostDate") %></h3>
              </div>
              <div class="panel-body">
                <%# DataBinder.Eval(this.GetDataItem(),"PostBody") %>
              </div>
            </div>
        </ItemTemplate>
    </asp:ListView>

    </div>
        </div>

</asp:Content>
