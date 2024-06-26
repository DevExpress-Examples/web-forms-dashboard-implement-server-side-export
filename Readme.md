<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579857/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T500219)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# BI Dashboard for Web Forms - How to implement server-side export

This example demonstrates how to export a dashboard displayed in <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardtopic">ASPxDashboard</a> on the server side using the <a href="https://documentation.devexpress.com/Dashboard/clsDevExpressDashboardWebASPxDashboardExportertopic.aspx">ASPxDashboardExporter</a> class. The following API is used to implement this capability.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_CustomJSPropertiestopic">ASPxDashboard.CustomJSProperties</a> server-side event is used to pass information about available dashboards to the client side.<br>- The <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard#js_aspxclientdashboard_loaddashboard_dashboardid_">ASPxClientDashboard.LoadDashboard</a> method opens a selected dashboard.<br>- The <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard#js_aspxclientdashboard_performdatacallback_parameter_oncallback_">ASPxClientDashboard.PerformDataCallback</a> client-side method is used to pass the dashboard identifier and state to the server side. On the server side, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_CustomDataCallbacktopic">ASPxDashboard.CustomDataCallback</a> event is used to obtain and parse these values.<br>- <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboardExporter.ExportToPdf.overloads">ASPxDashboardExporter.ExportToPdf</a> is used to export the selected dashboard with the state passed from the client side.<br>

## Files to Review

* [Default.aspx](./CS/ASPxDashboard_ServerExport/Default.aspx) (VB: [Default.aspx](./VB/ASPxDashboard_ServerExport/Default.aspx))
* [Default.aspx.cs](./CS/ASPxDashboard_ServerExport/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxDashboard_ServerExport/Default.aspx.vb))
* [InitializeControls.js](./CS/ASPxDashboard_ServerExport/Scripts/InitializeControls.js) (VB: [InitializeControls.js](./VB/ASPxDashboard_ServerExport/Scripts/InitializeControls.js))

## Documentation

- [Manage Exporting Capabilities in ASP.NET Web Forms](https://docs.devexpress.com/Dashboard/12140/web-dashboard/integrate-dashboard-component/aspnet-web-forms-dashboard-control/manage-exporting-capabilities?p=netframework)
- [ASPxDashboardExporter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboardExporter)

## More Example

- [BI Dashboard for MVC - How to implement server-side export](https://github.com/DevExpress-Examples/asp-net-mvc-dashboard-implement-server-side-export)
- [BI Dashboard for Web Forms - How to export Web Dashboard into PDF with different filter values on different pages](https://github.com/DevExpress-Examples/web-forms-dashboard-pdf-export-with-filter-values-on-different-pages)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-dashboard-implement-server-side-export&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-dashboard-implement-server-side-export&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
