using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Hour : ITrackable
    {
        public Hour()
        {
            this.Jobs = new List<Job>();
        }

        [DataMember]
        public int hoursId { get; set; }
        [DataMember]
        public Nullable<int> applicantId { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> monOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> monClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> tueOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> tueClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> wedOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> wedClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> thursOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> thursClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> friOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> friClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> satOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> satClose { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> sunOpen { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> sunClose { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }
        [DataMember]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
