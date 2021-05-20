using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluation
    {
        public TblEvaluation()
        {
            TblEvaluationOrder = new HashSet<TblEvaluationOrder>();
            TblEvaluationQuestions = new HashSet<TblEvaluationQuestions>();
        }

        public int EvaluationId { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public string EvaluationDescription { get; set; }
        public string EvaluationLongDesc { get; set; }
        public string Instructions { get; set; }
        public string MailinInstructions { get; set; }
        public string PreEvaluationInstructions { get; set; }
        public string PreEvaluationMailinInstructions { get; set; }
        public bool AllowOnWeb { get; set; }
        public bool? WebDisplayInstructions { get; set; }
        public bool? WebDisplayMailInInstructions { get; set; }
        public bool Active { get; set; }
        public bool? AllowPrintMailInEvaluations { get; set; }
        public bool? CreateEvaluationOrderForMailin { get; set; }
        public string Comments { get; set; }
        public bool? AllowRetakes { get; set; }
        public short? MaxRetakes { get; set; }
        public bool AllowAnonymous { get; set; }
        public bool Lock { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public short? SortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblEvaluationOrder> TblEvaluationOrder { get; set; }
        public virtual ICollection<TblEvaluationQuestions> TblEvaluationQuestions { get; set; }
    }
}
