using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Reference : ITrackable
    {
        [DataMember]
        public int referenceId { get; set; }
        [DataMember]
        public string refFullName { get; set; }
        [DataMember]
        public string refCompany { get; set; }
        [DataMember]
        public string refTitle { get; set; }
        [DataMember]
        public Nullable<decimal> refPhone { get; set; }
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
