<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>

        <form id="form1" >
       

            <table style="font-family:Arial; border: 1px solid black; text-align:center">
                      <tr>
                        <th>Counter 1</th>
                        <th>Counter 2</th>
                        <th>Counter 3</th>
                        
                      </tr>
                      <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                      </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" />
                            </td>
                            <td>
                                <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" />
                            </td>
                            <td>
                                <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" />
                            </td>
                            </tr>
                     
                    </table>

            </form>
      
    </div>

    

</asp:Content>
