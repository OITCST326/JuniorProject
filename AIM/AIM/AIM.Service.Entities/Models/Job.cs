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
    public partial class Job : ITrackable
    {
        public Job()
        {
            this.Applications = new List<Application>();
            this.Employees = new List<Employee>();
        }

        [DataMember]
        [Display(Name = "Job ID")]
        public int jobId { get; set; }
        [DataMember]
        [Display(Name = "Position")]
        public string position { get; set; }
        [DataMember]
        [Display(Name = "Description")]
        public string description { get; set; }
        [DataMember]
        [Display(Name = "Full/Part Time")]
        public string fullPartTime { get; set; }
        [DataMember]
        [Display(Name = "Salary Range")]
        public string salaryRange { get; set; }
        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public Nullable<int> questionnaireId { get; set; }
        [DataMember]
        [Display(Name = "Hours ID")]
        public Nullable<int> hoursId { get; set; }
        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public Nullable<int> InterviewquestionId { get; set; }
        [DataMember]
        [Display(Name = "Applications")]
        public List<Application> Applications { get; set; }
        [DataMember]
        [Display(Name = "Employees")]
        public List<Employee> Employees { get; set; }
        [DataMember]
        [Display(Name = "Hour")]
        public Hour Hour { get; set; }
        [DataMember]
        [Display(Name = "Interview Question")]
        public InterviewQuestion InterviewQuestion { get; set; }
        [DataMember]
        [Display(Name = "Questionnaire")]
        public Questionnaire Questionnaire { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
