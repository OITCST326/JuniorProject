using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIM.Service.Entities.Models;
using Newtonsoft.Json;

namespace AIM.Web.Admin.Models
{
    public class QuestionExpanded
    {
        int qID;
        int? questionnaireID;

        string qText;
        string qType;

        List<string> qOptions;
        List<string> qAnswers;

        

        public QuestionExpanded(Question input)
        {
            JsonTemp temp = JsonConvert.DeserializeObject<JsonTemp>(input.qJsonProperties);

            qID = input.questionId;
            questionnaireID = input.questionnaireId;

            qText = temp.qText;
            qType = temp.qType;

            foreach(string entry in temp.qOptions)
            {
                this.qOptions.Add(entry);
            }

            foreach(string entry in temp.qAnswers)
            {
                this.qAnswers.Add(entry);
            }
        }

        Question createDBQuestion(QuestionExpanded input)
        {    

            string properties = JsonConvert.SerializeObject(input);
            Question question = new Question();

            question.questionId = input.qID;
            question.questionnaireId = input.questionnaireID;
            question.qJsonProperties = properties;

            return question;
        }
    }
}