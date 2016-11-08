//load app common object as application alias
var application = app;

$(document).ready(function() {

    //jQuery methods

    //numeric fields for unsupported browsers
    $('input[name="Stock"],input[name="ProductAttribute1"],input[name="ProductAttribute2"]').keypress(function (e) {
        var numericTool = application.utilities.numeric();
        numericTool.setKeyEntered(e.keyCode);
        return numericTool.forceNumeric();
    });

    //generic function to apply datatables
    var dataTables = application.tables.init();
    dataTables.setTableId = '#products-table';
    dataTables.init();
});