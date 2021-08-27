<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579857/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T500219)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxDashboard_ServerExport/Default.aspx) (VB: [Default.aspx](./VB/ASPxDashboard_ServerExport/Default.aspx))
* [Default.aspx.cs](./CS/ASPxDashboard_ServerExport/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxDashboard_ServerExport/Default.aspx.vb))
* [InitializeControls.js](./CS/ASPxDashboard_ServerExport/Scripts/InitializeControls.js) (VB: [InitializeControls.js](./VB/ASPxDashboard_ServerExport/Scripts/InitializeControls.js))
<!-- default file list end -->
# ASPxDashboard - How to implement server-side export


<p>This example demonstrates how to export a dashboard displayed in <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardtopic">ASPxDashboard</a> on the server side using the <a href="https://documentation.devexpress.com/Dashboard/clsDevExpressDashboardWebASPxDashboardExportertopic.aspx">ASPxDashboardExporter</a> class. The following API is used to implement this capability.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_CustomJSPropertiestopic">ASPxDashboard.CustomJSProperties</a> server-side event is used to pass information about available dashboards to the client side.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_LoadDashboardtopic">ASPxClientDashboard.LoadDashboard</a> method opens a selected dashboard.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_PerformDataCallbacktopic">ASPxClientDashboard.PerformDataCallback</a> client-side method is used to pass the dashboard identifier and state to the server side. On the server side, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_CustomDataCallbacktopic">ASPxDashboard.CustomDataCallback</a> event is used to obtain and parse these values.<br>- <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboardExporter.ExportToPdf.overloads">ASPxDashboardExporter.ExportToPdf</a> is used to export the selected dashboard with the state passed from the client side.<br><br>See also: <a href="https://www.devexpress.com/Support/Center/Example/Details/T590027/asp-net-mvc-dashboard-how-to-implement-server-side-export">ASP.NET MVC Dashboard - How to implement server-side export</a></p>

<br/>


