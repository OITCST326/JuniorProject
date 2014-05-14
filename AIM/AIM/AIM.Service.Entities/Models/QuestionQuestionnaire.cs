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
    public partial class QuestionQuestionnaire : ITrackable
    {
        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }
        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public int questionnaireId { get; set; }
        [DataMember]
        [Display(Name = "Number Of Questions")]
        public int? numberOfQuestions { get; set; }
        [DataMember]
        [Display(Name = "Questionnaire")]
        public Questionnaire Questionnaire { get; set; }
        [DataMember]
        [Display(Name = "Question")]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
