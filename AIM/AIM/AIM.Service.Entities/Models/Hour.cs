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
        [Display(Name = "Mon Open")]
        public Nullable<System.TimeSpan> monOpen { get; set; }
        [DataMember]
        [Display(Name = "Mon Close")]
        public Nullable<System.TimeSpan> monClose { get; set; }
        [DataMember]
        [Display(Name = "Tue Open")]
        public Nullable<System.TimeSpan> tueOpen { get; set; }
        [DataMember]
        [Display(Name = "Tue Close")]
        public Nullable<System.TimeSpan> tueClose { get; set; }
        [DataMember]
        [Display(Name = "Wed Open")]
        public Nullable<System.TimeSpan> wedOpen { get; set; }
        [DataMember]
        [Display(Name = "Wed Close")]
        public Nullable<System.TimeSpan> wedClose { get; set; }
        [DataMember]
        [Display(Name = "Thurs Open")]
        public Nullable<System.TimeSpan> thursOpen { get; set; }
        [DataMember]
        [Display(Name = "Thurs Close")]
        public Nullable<System.TimeSpan> thursClose { get; set; }
        [DataMember]
        [Display(Name = "Fri Open")]
        public Nullable<System.TimeSpan> friOpen { get; set; }
        [DataMember]
        [Display(Name = "Fri Close")]
        public Nullable<System.TimeSpan> friClose { get; set; }
        [DataMember]
        [Display(Name = "Sat Open")]
        public Nullable<System.TimeSpan> satOpen { get; set; }
        [DataMember]
        [Display(Name = "Sat Close")]
        public Nullable<System.TimeSpan> satClose { get; set; }
        [DataMember]
        [Display(Name = "Sun Open")]
        public Nullable<System.TimeSpan> sunOpen { get; set; }
        [DataMember]
        [Display(Name = "Sun Close")]
        public Nullable<System.TimeSpan> sunClose { get; set; }
        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }
        [DataMember]
        [Display(Name = "Jobs List")]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
