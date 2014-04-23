using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Store : ITrackable
    {
        public Store()
        {
            this.OpenJobs = new List<OpenJob>();
        }

        [DataMember]
        public int storeId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Nullable<int> regionId { get; set; }
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
        public List<OpenJob> OpenJobs { get; set; }
        [DataMember]
        public Region Region { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
