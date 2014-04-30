using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIM.Service.Entities.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AIM.Web.Admin.Models
{
    [JsonObject(IsReference = true)]
    public class ExpandedQuestion
    {
        [JsonProperty]
        public int QId { get; set; }
        [JsonIgnore]
        public int? QuestionnaireQId { get; set; }
        [JsonIgnore]
        public int? InterviewQId { get; set; }
        [JsonIgnore]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        [JsonIgnore]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }
        [JsonIgnore]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [JsonProperty]
        public string QText { get; set; }
        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public Type? QType { get; set; }
        [JsonProperty]
        public IList<string> QOptions { get; set; }
        [JsonProperty]
        public IList<string> QAnswers { get; set; }

        private ExpandedQuestion() { }

        public ExpandedQuestion Expand(Question question)
        {
            if (question == null)
                throw new ArgumentNullException("question");

            var expandedQuestion = new ExpandedQuestion
            {
                QId = question.questionId,
                QuestionnaireQId = question.questionnaireId,
                InterviewQId = question.interviewQuestionsId
            };

            foreach (var item in ApplicantQuestionAnswers.Where(item => item != null))
            {
                ApplicantQuestionAnswers.Add(item);
            }
            foreach (var item in QuestionInterviewQuestionMappings.Where(item => item != null))
            {
                QuestionInterviewQuestionMappings.Add(item);
            }
            foreach (var item in QuestionQuestionnaires.Where(item => item != null))
            {
                QuestionQuestionnaires.Add(item);
            }

            expandedQuestion = JsonConvert.DeserializeObject<ExpandedQuestion>(question.qJsonProperties);
            
            return expandedQuestion;
        }

        public List<ExpandedQuestion> ExpandList(List<Question> questions)
        {
            var expandedQuestions = new List<ExpandedQuestion>();

            foreach (var question in questions)
            {
                var expandedQuestion = new ExpandedQuestion();
                expandedQuestion.QId = question.questionId;
                expandedQuestion.QuestionnaireQId = question.questionnaireId;
                expandedQuestion.InterviewQId = question.interviewQuestionsId;
            

                foreach (var item in ApplicantQuestionAnswers.Where(item => item != null))
                {
                    ApplicantQuestionAnswers.Add(item);
                }
                foreach (var item in QuestionInterviewQuestionMappings.Where(item => item != null))
                {
                    QuestionInterviewQuestionMappings.Add(item);
                }
                foreach (var item in QuestionQuestionnaires.Where(item => item != null))
                {
                    QuestionQuestionnaires.Add(item);
                }

                JsonConvert.DeserializeObject<ExpandedQuestion>(question.qJsonProperties);

                expandedQuestions.Add(expandedQuestion);
            }

            return expandedQuestions;
        }
    }

    public enum Type : int
    {
        MultipleChoice = 0,
        AllThatApply = 1,
        FreeForm = 2
    }

}