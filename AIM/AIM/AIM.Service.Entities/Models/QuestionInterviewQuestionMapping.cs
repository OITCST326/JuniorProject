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
    public partial class QuestionInterviewQuestionMapping : ITrackable
    {
        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }
        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public int interviewQuestionsId { get; set; }
        [DataMember]
        [Display(Name = "Number Of Questions")]
        public Nullable<int> numberOfQuestions { get; set; }
        [DataMember]
        [Display(Name = "Interview Question")]
        public InterviewQuestion InterviewQuestion { get; set; }
        [DataMember]
        [Display(Name = "Question")]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
