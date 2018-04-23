function initializeControls() {
    $("#buttonContainer").dxButton({
        text: "Export to PDF",
        onClick: function (param) {
            var selectedDashboardID = webDashboard.GetDashboardId();
            var dashboardState = webDashboard.GetDashboardState();
            var parameters = selectedDashboardID + "|" + dashboardState;
            webDashboard.PerformDataCallback(parameters, null);
        }
    });

    $("#selectBox").dxSelectBox({
        dataSource: getDashboardIDs(),
        value: getDashboardIDs()[0],
        onValueChanged: function (param) {
            webDashboard.LoadDashboard(param.value);
        }
    });
}

function getDashboardIDs() {
    return webDashboard.cpGetDashboardIDs;
};

function dashboardExportedSuccess(args) {
    DevExpress.ui.notify('A dashboard was exported to ' + args.result, 'success', 5000);
};