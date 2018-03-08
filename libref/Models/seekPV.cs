using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace libref.Models
{
    public class seekPV
    {
        internal object partialModel;

        [StringLength(80, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(80, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [DataType(DataType.Text)]
        [Display(Name = "Author")]
        public  string Author { get; set; }

        // 10-13 this is due to ISBN pre &post 2007 changes in numbering method
        [StringLength(13, ErrorMessage = "Something's off here!", MinimumLength = 10)] 
        [RegularExpression(@"^[0-9]*$")]
        [DataType(DataType.ISBN)]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [StringLength(80, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [DataType(DataType.Text)]
        [Display(Name = "Genere")]
        public string Genere { get; set; }



        /* atemping to implement  a loging system that  logs when a serch was made
         *  for future monitisation purposes  (extra feature)
       *//*
        [Display(Name = "Date of search")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]
        public DateTime of search { get; set; }*/

        internal static IHttpActionResult ToList()
        {throw new NotImplementedException();}
    }
}