using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class JobHistory : ITrackable
    {
        [DataMember]
        public int jobHistoryId { get; set; }
        [DataMember]
        public string employerName { get; set; }
        [DataMember]
        public string position { get; set; }
        [DataMember]
        public string responsibilities { get; set; }
        [DataMember]
        public string supervisor { get; set; }
        [DataMember]
        public Nullable<decimal> startingSalary { get; set; }
        [DataMember]
        public Nullable<decimal> endingSalary { get; set; }
        [DataMember]
        public string reasonForLeaving { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dateFrom { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dateTo { get; set; }
        [DataMember]
        public string street { get; set; }
        [DataMember]
        public string street2 { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public Nullable<int> state { get; set; }
        [DataMember]
        public string zip { get; set; }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        public Nullable<int> applicantId { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
