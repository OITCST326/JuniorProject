using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIM.Application.Client.Entities.Models
{
    public enum StatusEnum : int
    {
        InitalApplicationNonSubmitted = 0,
        PhoneInterviewQueue = 1,
        InPersonInterviewQueue = 2,
        CheckReferenceQueue = 3,
        Rejected = 4,
        PendingReviewQueue = 5,
        HiredStatus = 6
    }
}
