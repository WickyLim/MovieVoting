<%@ Page Title="What's your favourite movie?" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieVoting._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 style="text-align: center">Vote for Movie of the Year 2018</h2>
    </div>

    <div class="row">
        <asp:ListView ID="movieList"  
            ItemType="MovieVoting.Models.Movie" 
            runat="server"
            SelectMethod="GetMovies" >
            <ItemTemplate>
                <div class="col-md-4" style="text-align: center">
                    <p>No. of votes: <%#: Item.Votes %></p>
                    <asp:Image runat="server" ImageUrl=<%#: String.Format("~/Images/{0}", Item.ImagePath) %> BorderStyle="None" Width="100%" />
                    <h2><%#: Item.MovieName %></h2>
                    <p>
                        <a class="btn btn-default" href="/CastVote.aspx?MovieID=<%#:Item.MovieID %>">Vote</a>
                    </p>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

</asp:Content>
