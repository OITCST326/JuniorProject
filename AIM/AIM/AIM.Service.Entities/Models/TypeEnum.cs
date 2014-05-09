using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Service.Entities.Models
{
    [DataContract(Name = "QuestionType")]
    public enum TypeEnum : int
    {
        [EnumMember]
        MultipleChoice = 0,
        [EnumMember]
        AllThatApply = 1,
        [EnumMember]
        FreeForm = 2
    }
}
