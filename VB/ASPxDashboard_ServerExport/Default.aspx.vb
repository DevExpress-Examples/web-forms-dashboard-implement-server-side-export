Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace ASPxDashboard_ServerExport
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Private fileStorage As New DashboardFileStorage("App_Data/Dashboards")
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxDashboard1.AllowExportDashboard = False
			ASPxDashboard1.SetDashboardStorage(fileStorage)
		End Sub

		Protected Sub ASPxDashboard1_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.CustomJSPropertiesEventArgs)
			Dim dashboardIDs As New List(Of String)()
			For Each dashboardInfo As DashboardInfo In (DirectCast(fileStorage, IDashboardStorage)).GetAvailableDashboardsInfo()
				dashboardIDs.Add(dashboardInfo.ID)
			Next dashboardInfo
			e.Properties.Add("cpGetDashboardIDs", dashboardIDs)
		End Sub

		Protected Sub ASPxDashboard1_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.CustomDataCallbackEventArgs)
			Using stream As New MemoryStream()
				Dim selectedDashboardID As String = e.Parameter.Split("|"c)(0)
				Dim dashboardStateJson As String = e.Parameter.Split("|"c)(1)
				Dim dashboardState As New DashboardState()
				dashboardState.LoadFromJson(dashboardStateJson)

				Dim pdfOptions As New DashboardPdfExportOptions()
				pdfOptions.ExportFilters = True
				pdfOptions.DashboardStatePosition = DashboardStateExportPosition.Below

				Dim dateTimeNow As String = Date.Now.ToString("yyyyMMddHHmmss")
				Dim filePath As String = "~/App_Data/Export/" & selectedDashboardID & "_" & dateTimeNow & ".pdf"
				Dim exporter As New ASPxDashboardExporter(ASPxDashboard1)
				exporter.ExportToPdf(selectedDashboardID, stream, New System.Drawing.Size(1920, 1080), dashboardState, pdfOptions)
				SaveFile(stream, filePath)
				e.Result = filePath
			End Using
		End Sub

		Private Sub SaveFile(ByVal stream As MemoryStream, ByVal path As String)
			Dim fileStream = File.Create(Server.MapPath(path))
			stream.WriteTo(fileStream)
			fileStream.Close()
		End Sub
	End Class
End Namespace
