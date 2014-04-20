using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
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
        public int questionId { get; set; }
        [DataMember]
        public string qJsonProperties { get; set; }
        [DataMember]
        public Nullable<int> questionnaireId { get; set; }
        [DataMember]
        public int interviewQuestionsId { get; set; }
        [DataMember]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        [DataMember]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }
        [DataMember]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
