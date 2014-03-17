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
    public partial class Employee : ITrackable
    {
        public Employee()
        {
            this.Users = new List<User>();
        }

        [DataMember]
        [Display(Name = "Employee ID")]
        public int employeeId { get; set; }
        [DataMember]
        [Display(Name = "Permissions")]
        public Nullable<int> permissions { get; set; }
        [DataMember]
        [Display(Name = "Job ID")]
        public Nullable<int> jobId { get; set; }
        [DataMember]
        [Display(Name = "Job")]
        public Job Job { get; set; }
        [DataMember]
        [Display(Name = "Users")]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
