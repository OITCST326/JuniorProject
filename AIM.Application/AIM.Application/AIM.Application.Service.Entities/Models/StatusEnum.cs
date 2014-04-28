namespace AIM.Application.Service.Entities.Models
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
