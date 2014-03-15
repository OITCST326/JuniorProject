using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class PersonalInfo : ITrackable
    {
        public PersonalInfo()
        {
            this.Users = new List<User>();
        }

        [DataMember]
        public int PersonalInfoId { get; set; }
        [DataMember]
        public string alias { get; set; }
        [DataMember]
        public string street { get; set; }
        [DataMember]
        public string street2 { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public int state { get; set; }
        [DataMember]
        public Nullable<decimal> zip { get; set; }
        [DataMember]
        public Nullable<decimal> phone { get; set; }
        [DataMember]
        public Nullable<int> userId { get; set; }
        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
