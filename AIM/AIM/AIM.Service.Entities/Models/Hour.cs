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
    public partial class Hour : ITrackable
    {
        public Hour()
        {
            this.Jobs = new List<Job>();
        }

        [DataMember]
        [Display(Name = "Hours ID")]
        public int hoursId { get; set; }
        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }
        [DataMember]
        [Display(Name = "Monday Open")]
        public Nullable<System.TimeSpan> monOpen { get; set; }
        [DataMember]
        [Display(Name = "Monday Close")]
        public Nullable<System.TimeSpan> monClose { get; set; }
        [DataMember]
        [Display(Name = "Tuesday Open")]
        public Nullable<System.TimeSpan> tueOpen { get; set; }
        [DataMember]
        [Display(Name = "Tuesday Close")]
        public Nullable<System.TimeSpan> tueClose { get; set; }
        [DataMember]
        [Display(Name = "Wednesday Open")]
        public Nullable<System.TimeSpan> wedOpen { get; set; }
        [DataMember]
        [Display(Name = "Wednesday Close")]
        public Nullable<System.TimeSpan> wedClose { get; set; }
        [DataMember]
        [Display(Name = "Thursday Open")]
        public Nullable<System.TimeSpan> thursOpen { get; set; }
        [DataMember]
        [Display(Name = "Thursday Close")]
        public Nullable<System.TimeSpan> thursClose { get; set; }
        [DataMember]
        [Display(Name = "Friday Open")]
        public Nullable<System.TimeSpan> friOpen { get; set; }
        [DataMember]
        [Display(Name = "Friday Close")]
        public Nullable<System.TimeSpan> friClose { get; set; }
        [DataMember]
        [Display(Name = "Saturday Open")]
        public Nullable<System.TimeSpan> satOpen { get; set; }
        [DataMember]
        [Display(Name = "Saturday Close")]
        public Nullable<System.TimeSpan> satClose { get; set; }
        [DataMember]
        [Display(Name = "Sunday Open")]
        public Nullable<System.TimeSpan> sunOpen { get; set; }
        [DataMember]
        [Display(Name = "Sunday Close")]
        public Nullable<System.TimeSpan> sunClose { get; set; }
        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }
        [DataMember]
        [Display(Name = "Jobs")]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
