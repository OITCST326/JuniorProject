using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class QuestionQuestionnaire : ITrackable
    {
        [DataMember]
        public int questionId { get; set; }
        [DataMember]
        public int questionnaireId { get; set; }
        [DataMember]
        public Nullable<int> numberOfQuestions { get; set; }
        [DataMember]
        public Questionnaire Questionnaire { get; set; }
        [DataMember]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}