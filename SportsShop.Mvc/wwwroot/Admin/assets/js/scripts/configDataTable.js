$(document).ready(function () {

    $("#DataTable_filter").css("display", "none");

    var table = $("#DataTable").DataTable();

    $('#mySearchText').keyup(function () {
        table.search($(this).val()).draw();
    });

    table.page.len(100).draw();

});