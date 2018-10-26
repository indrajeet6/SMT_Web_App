<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboards.aspx.cs" Inherits="SMT_Web_Form.Dashboards" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboards</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Incident Management Dashboards</h1>
            <p>&nbsp;</p>
        </div>
        <p>
            <asp:Chart ID="Chart1" runat="server" Height="600px" Width="600px">
                <series>
                    <asp:Series Name="Series1" ChartArea="MainChartArea">
                    </asp:Series>
                </series>
                   <Titles> 
                       <asp:Title Text="Incidents per Engineer"></asp:Title> 
                   </Titles>
                <chartareas>
                    <asp:ChartArea Name="MainChartArea">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conn_String %>" SelectCommand="Select SMT_Data.Requestor as 'Patrtner Name', COUNT (INC) AS 'Count of Incidents' from SMT_Data GROUP BY SMT_Data.Requestor"></asp:SqlDataSource>
        </p>
    </form>
</body>
</html>
