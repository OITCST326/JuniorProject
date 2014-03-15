using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Education : ITrackable
    {
        [DataMember]
        public int educationId { get; set; }
        [DataMember]
        public string schoolName { get; set; }
        [DataMember]
        public string degree { get; set; }
        [DataMember]
        public Nullable<System.DateTime> graduated { get; set; }
        [DataMember]
        public string yearsAttended { get; set; }
        [DataMember]
        public string street { get; set; }
        [DataMember]
        public string street2 { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public Nullable<int> state { get; set; }
        [DataMember]
        public Nullable<decimal> zip { get; set; }
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