using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Application : ITrackable
    {
        [DataMember]
        public int applicationId { get; set; }
        [DataMember]
        public Nullable<int> applicantId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> dateCreated { get; set; }
        [DataMember]
        public string preEmploymentStatement { get; set; }
        [DataMember]
        public Nullable<int> jobId { get; set; }
        [DataMember]
        public Nullable<int> status { get; set; }
        [DataMember]
        public string salaryExpectation { get; set; }
        [DataMember]
        public Nullable<bool> isFullTime { get; set; }
        [DataMember]
        public Nullable<bool> isDays { get; set; }
        [DataMember]
        public Nullable<bool> isEvenings { get; set; }
        [DataMember]
        public Nullable<bool> isWeekends { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }
        [DataMember]
        public Job Job { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
