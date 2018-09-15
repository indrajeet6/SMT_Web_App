<%@ Page Title="Add New Record Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add New Record.aspx.cs" Inherits="SMT_Web_Form._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SMT Master Application</h1>
        <p class="lead">This is a Proof of Concept regarding making a Web Forms Application for the SMT Team.</p>
        <table id ="Table1">
            <tr>
                <th style="width: 303px">Data Point</th>
                <th style="width: 330px">Value</th>
            </tr>
            <tr>
                <td style="width: 303px">INC Number</td>
                <td style="width: 330px">
                        <asp:Label ID="lblINCNo" runat="server"></asp:Label>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Contract</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox3" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Supplier</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox4" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Intake Received Date (mm/dd/yyyy)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox5" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Rush</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox6" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Requestor</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox7" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">6109</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox8" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice/6108 (Yes/No)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox9" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">W9/W8</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox10" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice Count</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox11" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice Number</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox12" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice Received Date</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox13" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Total Invoice Amount (CAD)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox14" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Issue</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox15" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Times Followed Up</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox16" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date of last follow up</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox17" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date last email sent</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox18" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date Supplier was entered into eCM</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox19" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Type of Request</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox20" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">EFT/Contact</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox21" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Status</td>
                <td style="width: 330px">
                        <asp:TextBox ID="txtBox22" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Intake closed date</td>
                <td style="width: 330px">
                    <asp:TextBox ID="txtBox23" runat="server" Width="295px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 330px" colspan="2" text-align: center;>
                    <asp:Button ID="btnAdd" text= "Add Record" runat="server" Width="295px" OnClick="btnAdd_Click"></asp:Button>
                </td>
            </tr>

        </table>
        
        

    </div>




    </asp:Content>
