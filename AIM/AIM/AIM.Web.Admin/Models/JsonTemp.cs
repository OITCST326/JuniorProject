using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AIM.Web.Admin.Models
{
    public class JsonTemp
    {

        public string qText;
        public string qType;
        public List<string> qOptions;
        public List<string> qAnswers;

        public JsonTemp()
        {
            qText = "What will be asked?";
            qType = "MultiChoice";
            qOptions.Add("Option1");
            qOptions.Add("Option2");

            qAnswers.Add("Answer1");
        }

    }
}