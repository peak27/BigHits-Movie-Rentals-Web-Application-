using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BigHits.Models
{
    public class EmailFormModel
    {
        [DataType(DataType.EmailAddress), Display(Name = "To")]
        public string ToEmail { get; set; }
        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string EMailBody { get; set; }
        [Display(Name = "Subject")]
        public string EmailSubject { get; set; }
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "CC")]
        //public string EmailCC { get; set; }
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "BCC")]
        //public string EmailBCC { get; set; }
    }
}