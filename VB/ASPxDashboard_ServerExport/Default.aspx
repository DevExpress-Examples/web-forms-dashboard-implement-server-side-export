<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ASPxDashboard_ServerExport.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v23.1.Web.WebForms, Version=23.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div id="selectBox" style="float: left;"></div>
    <div id="buttonContainer" style="float: left; margin-left: 150px;"></div>
    <div style="position: absolute; left: 0; right: 0; top:50px; bottom:0;">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" Width="100%" Height="100%" WorkingMode="Viewer"
            ClientInstanceName="webDashboard"
            OnCustomDataCallback="ASPxDashboard1_CustomDataCallback" 
            OnCustomJSProperties="ASPxDashboard1_CustomJSProperties">
             <ClientSideEvents 
                 BeforeRender="function(s, e) { onBeforeRender(s,e); }"
                 CustomDataCallback="function(s, e) { dashboardExportedSuccess(e); }"/>  
            </dx:ASPxDashboard>
    </div>
    </form>
</body>
</html>
<script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/InitializeControls.js") %>"></script>
