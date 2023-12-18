function onBeforeRender(s,e) {
    var dashboardControl = s.GetDashboardControl();
    $("#buttonContainer").dxButton({
        text: "Export to PDF",
        onClick: function (param) {
            var selectedDashboardID = dashboardControl.getDashboardId();
            var dashboardState = dashboardControl.getDashboardState();
            var parameters = selectedDashboardID + "|" + dashboardState;
            webDashboard.PerformDataCallback(parameters, null);
        }
    });

    $("#selectBox").dxSelectBox({
        dataSource: getDashboardIDs(),
        value: getDashboardIDs()[0],
        onValueChanged: function (param) {
            dashboardControl.loadDashboard(param.value);
        }
    });
}

function getDashboardIDs() {
    return webDashboard.cpGetDashboardIDs;
};

function dashboardExportedSuccess(args) {
    DevExpress.ui.notify('A dashboard was exported to ' + args.result, 'success', 5000);
};