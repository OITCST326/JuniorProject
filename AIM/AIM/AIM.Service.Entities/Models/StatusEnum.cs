using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Service.Entities.Models
{
    [DataContract(Name = "Status")]
    public enum StatusEnum : int
    {
        [EnumMember]
        InitalApplicationNonSubmitted = 0,
        [EnumMember]
        PhoneInterviewQueue = 1,
        [EnumMember]
        InPersonInterviewQueue = 2,
        [EnumMember]
        CheckReferenceQueue = 3,
        [EnumMember]
        Rejected = 4,
        [EnumMember]
        PendingReviewQueue = 5,
        [EnumMember]
        HiredStatus = 6
    }
}
