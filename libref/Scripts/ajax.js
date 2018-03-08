// A '.tsx' file enables JSX support in the TypeScript compiler, 
// for more information see the following page on the TypeScript wiki:
// https://github.com/Microsoft/TypeScript/wiki/JSX
$.ajax({
    dataType: "jsonp",
    url: queryUrl,
    success: function (data) {
        //alert("hhhh data.head.vars [" + data.head.vars +"]");
        //alert("data.results.bindings [" + data.results.bindings +"]");
        // get the table element
        document.getElementById("results").innerHTML = "";
        var table = $("#results");
        // get the sparql variables from the 'head' of the data.
        var headerVars = data.head.vars;
        // using the vars, make some table headers and add them to the table;
        var trHeaders = getTableHeaders(headerVars);
        table.append(trHeaders);
        // grab the actual results from the data. 
        var bindings = data.results.bindings;
        // for each result, make a table row and add it to the table.
        for (rowIdx in bindings) {
            table.append(getTableRow(headerVars, bindings[rowIdx]));
        }
    }
});
    < !-- -  >
    function getTableHeaders(headerVars) {
        var trHeaders = $("<tr></tr>");
        for (var i in headerVars) {
            trHeaders.append($("<th>" + headerVars[i] + "</th>"));
        }
        return trHeaders;
    };
function getTableRow(headerVars, rowData) {
    var tr = $("<tr></tr>");
    for (var i in headerVars) {
        tr.append(getTableCell(headerVars[i], rowData));
    }
    return tr;
}
function getTableCell(fieldName, rowData) {
    var td = $("<td></td>");
    var fieldData = rowData[fieldName];
    //alert("fieldName = ["+fieldName +"] rowData[fieldName][value] = ["+rowData[fieldName]["value"] + "]");
    td.html(fieldData["value"]);
    return td;
}
