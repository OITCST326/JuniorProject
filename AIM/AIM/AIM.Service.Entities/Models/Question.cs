using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;
using System.ComponentModel.DataAnnotations;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Question : ITrackable
    {
        public Question()
        {
            this.ApplicantQuestionAnswers = new List<ApplicantQuestionAnswer>();
            this.QuestionInterviewQuestionMappings = new List<QuestionInterviewQuestionMapping>();
            this.QuestionQuestionnaires = new List<QuestionQuestionnaire>();
        }

        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }
        [DataMember]
        [Display(Name = "Json Properties")]
        public string qJsonProperties { get; set; }
        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public Nullable<int> questionnaireId { get; set; }
        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public int interviewQuestionsId { get; set; }
        [DataMember]
        [Display(Name = "Applicant Question Answers")]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        [DataMember]
        [Display(Name = "Question Interview Question Mappings")]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }
        [DataMember]
        [Display(Name = "Question Questionnaires")]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [DataMember]
        [Display(Name = "Traqcking State")]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        [Display(Name = "Modified Properties")]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
