using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Collections.Generic;
using System.IO;

namespace ASPxDashboard_ServerExport
{
    public partial class Default : System.Web.UI.Page
    {
        DashboardFileStorage fileStorage = new DashboardFileStorage("App_Data/Dashboards");
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxDashboard1.AllowExportDashboard = false;         
            ASPxDashboard1.SetDashboardStorage(fileStorage);
        }

        protected void ASPxDashboard1_CustomJSProperties(object sender, DevExpress.Web.CustomJSPropertiesEventArgs e)
        {
            List<string> dashboardIDs = new List<string>();
            foreach (DashboardInfo dashboardInfo in ((IDashboardStorage)fileStorage).GetAvailableDashboardsInfo())
            {
                dashboardIDs.Add(dashboardInfo.ID);
            }
            e.Properties.Add("cpGetDashboardIDs", dashboardIDs);
        }

        protected void ASPxDashboard1_CustomDataCallback(object sender, DevExpress.Web.CustomDataCallbackEventArgs e)
        {
            using (MemoryStream stream = new MemoryStream()) {
                string selectedDashboardID = e.Parameter.Split('|')[0];
                string dashboardStateJson = e.Parameter.Split('|')[1];
                DashboardState dashboardState = new DashboardState();
                dashboardState.LoadFromJson(dashboardStateJson);

                DashboardPdfExportOptions pdfOptions = new DashboardPdfExportOptions();
                pdfOptions.ExportFilters = true;
                pdfOptions.DashboardStatePosition = DashboardStateExportPosition.Below;

                string dateTimeNow = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = "~/App_Data/Export/" + selectedDashboardID + "_" + dateTimeNow + ".pdf";
                ASPxDashboardExporter exporter = new ASPxDashboardExporter(ASPxDashboard1);
                exporter.ExportToPdf(selectedDashboardID, stream, new System.Drawing.Size(1024, 768), dashboardState, pdfOptions);
                SaveFile(stream, filePath);
                e.Result = filePath;
            }
        }

        private void SaveFile(MemoryStream stream, string path)
        {
            var fileStream = File.Create(Server.MapPath(path));
            stream.WriteTo(fileStream);  
            fileStream.Close();
        }
    }
}