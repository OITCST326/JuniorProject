using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Job : ITrackable
    {
        public Job()
        {
            this.Applications = new List<Application>();
            this.Employees = new List<Employee>();
        }

        [DataMember]
        public int jobId { get; set; }
        [DataMember]
        public string position { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string fullPartTime { get; set; }
        [DataMember]
        public string salaryRange { get; set; }
        [DataMember]
        public Nullable<int> questionnaireId { get; set; }
        [DataMember]
        public Nullable<int> hoursId { get; set; }
        [DataMember]
        public Nullable<int> InterviewquestionId { get; set; }
        [DataMember]
        public List<Application> Applications { get; set; }
        [DataMember]
        public List<Employee> Employees { get; set; }
        [DataMember]
        public Hour Hour { get; set; }
        [DataMember]
        public InterviewQuestion InterviewQuestion { get; set; }
        [DataMember]
        public Questionnaire Questionnaire { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}