<%@ Page Title="Search and Update Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search and Update.aspx.cs" Inherits="SMT_Web_Form._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Incident Management Master Application</h1>
        
        <table>
            <tr>
                <th>Record Search</th>
            </tr>
            <tr>
                <td>
                    <div style="margin-left: 40px">
                        <asp:Label ID="Label1" runat="server" Text="Enter Incident Number"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Width="295px"></asp:TextBox>
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />

                    </div>

                </td>
            </tr>

        </table>
        
        <table id ="Table1">
            <tr>
                <th style="width: 303px">Data Point</th>
                <th style="width: 330px">Value</th>
            </tr>
            <tr>
                <td style="width: 303px">Incident Number (INCxxxx)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox2" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Contract Signed</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox3" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Customer Name</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox4" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Incident Received Date (mm/dd/yyyy)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox5" runat="server" Width="295px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td style="width: 303px">Rush</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox6" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Engineer</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox7" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Form 1</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox8" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Form 2 (Yes/No)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox9" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Form 3</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox10" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Incident Count</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox11" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice Number</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox12" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Invoice Date</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox13" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Total Invoice Amount (CAD)</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox14" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Issues</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox15" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Times Followed Up</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox16" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date of last follow up</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox17" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date last email sent</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox18" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Date Supplier was entered into eCM</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox19" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Type of Request</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox20" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">EFT/Contact</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox21" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Status</td>
                <td style="width: 330px">
                        <asp:TextBox ID="TextBox22" runat="server" Width="295px"></asp:TextBox>
                        </td>
            </tr>
            <tr>
                <td style="width: 303px">Intake closed date</td>
                <td style="width: 330px">
                    <asp:TextBox ID="TextBox23" runat="server" Width="295px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 303px">Update Details?</td>
                <td style="width: 330px">
                    <asp:Button ID="btnUpdate" text= "Update" runat="server" Width="295px" OnClick="btnUpdate_Click"></asp:Button>
                </td>
            </tr>

        </table>
        

    </div>




    </asp:Content>
