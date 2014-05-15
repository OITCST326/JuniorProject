using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIM.Service.Entities.Models;

namespace AIM.Web.Admin.Models
{
    public class CondenseQJsonProperties
    {
        public int qJsonId { get; set; }
        public TypeEnum qJsonType { get; set; }
        public string qJsonText { get; set; }
        public IList<string> qJsonOptionsList { get; set; }
        public IList<string> qJsonAnswerList { get; set; } 
    }
}