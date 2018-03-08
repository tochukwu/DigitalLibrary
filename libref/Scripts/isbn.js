<script src="http://ajax.googleapis.com/…/li…/jquery/1.11.0/jquery.min.js"></script>
<script type="text/javascript"> 
seek.onclick = function(){
    var criteria = document.getElementById("isbn").value;
    var url = "http://dbpedia.org/sparql";
    var query = ["PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>",
    "PREFIX type: <http://dbpedia.org/class/yago/>",
   "PREFIX prpty: <http://dbpedia.org/property/>",
   " PREFIX ppl: <http://dbpedia.org/resource/>",
    "PREFIX owl: <http://dbpedia.org/resource/classes#>",

    "SELECT ?ISDN ?Title ?Author ?Description",  
"{",
       " ?Book dbo:isbn ?ISBN.",
     "?Book prpty:title ?Title.",
      "?Book prpty:author ?Au.",
      "?Au rdfs:label ?Author.",
      "?Book dbo:abstract ?Description",

   
     "FILTER (lang(?Title) ='en').",
     "FILTER (lang(?Author) ='en').",
     "FILTER ( regex (str(?ISDN ),'" +criteria + "', 'i') )",
"}",  
     "LIMIT 30",
    ].join(" ");

   
    var queryUrl= url+"?query="+ encodeURIComponent(query) +"&format=json";
    document.getElementById("query1").innerHTML="SPARQL Query "+ query;
    $.ajax({ 
        dataType: "jsonp",
        url: queryUrl,
        success: function(data) { 
            
            // get the table element
            document.getElementById("results").innerHTML="";
            var table = $("#results");
            // get the sparql variables from the 'head' of the data.
            var headerVars = data.head.vars;
            // using the vars, make some table headers and add them to the table;
            var trHeaders = getTableHeaders(headerVars);
            table.append(trHeaders);
            // grab the actual results from the data. 
            var bindings = data.results.bindings;
            // for each result, make a table row and add it to the table.
            for(rowIdx in bindings){
                table.append(getTableRow(headerVars, bindings[rowIdx]));
            }
        }
    });

}