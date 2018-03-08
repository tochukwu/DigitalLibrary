using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VDS.RDF;
using VDS.RDF.Query;

namespace libref.Controllers
{
    public class sarqlController : Controller
    {
        public static void Main(String[] args)
        {
            // new endpoint connection
            SparqlRemoteEndpoint endpoint = new SparqlRemoteEndpoint(new Uri("http://dbpedia.org/sparql"), "http://dbpedia.org");

            Debug.WriteLine("SQLAQL query example");
            //Define a remote endpoint
            //Use the DBPedia SPARQL endpoint with the default Graph set to DBPedia
            SparqlRemoteEndpoint endpoint = new SparqlRemoteEndpoint(new Uri("http://dbpedia.org/sparql"), "http://dbpedia.org");

            String queryString = "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>  " +
              "PREFIX type: <http://dbpedia.org/class/yago/> " +
              "PREFIX prop: <http://dbpedia.org/property/>  " +
              "PREFIX ppl: < http://dbpedia.org/resource/>" +
              "PREFIX dbr: < http://dbpedia.org/resource/>" +
              "PREFIX dbo: < http://dbpedia.org/ontology/>" +
             /////////'''''''''''''''''''''''''''''''''''''//
             " SELECT ? Author ? Also_wrote" +
#pragma warning disable CS1002 // ; expected
#pragma warning disable CS1010 // Newline in constant
#pragma warning disable CS1002 // ; expected
            "WHERE "{",
#pragma warning restore CS1002 // ; expected
#pragma warning restore CS1010 // Newline in constant
#pragma warning restore CS1002 // ; expected
        " ?author dbp:author? see." +
         "? see rdfs:label? Also_wrote." +
         "?author dbp:name? Author." +
          " FILTER(lang(?Author) = 'en')." +
        "}" +
            "LIMIT 30 ";

            ////'''''''''''''''''''''''''''''''''''''/////////

            Debug.WriteLine("queryString: [" + queryString + "]");

            //Make a SELECT query against the Endpoint
            SparqlResultSet results = endpoint.QueryWithResultSet(queryString);
            foreach (SparqlResult result in results)
            {
                Debug.WriteLine(result.ToString());
            }

        }
    }


    /*  "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>  " +
                "PREFIX type: <http://dbpedia.org/class/yago/> " +
                "PREFIX prop: <http://dbpedia.org/property/>  " +
                "PREFIX ppl: < http://dbpedia.org/resource/>"+
     * 
     *  "SELECT ?country_name ?population ?cptl  " +
                "WHERE {  " +
                "?country rdf:type type:Country108544813.  " +
                "?country rdfs:label ?country_name.  " +
                "?country prop:populationEstimate ?population.  " +
                "?country dbo:capital ?cptl  " +
                "FILTER (?population > 1000000000) .  " +
                "}" +
                "LIMIT 30 ";
                */
    /*
     // GET: sarql
     public ActionResult Index()
     {
         return View();
     }
     */
}
}