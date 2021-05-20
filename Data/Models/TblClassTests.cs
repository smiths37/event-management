using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTests
    {
        public TblClassTests()
        {
            TblClassTestCredits = new HashSet<TblClassTestCredits>();
            TblClassTestOrder = new HashSet<TblClassTestOrder>();
            TblClassTestQuestions = new HashSet<TblClassTestQuestions>();
        }

        public int ClassTestId { get; set; }
        public int ClassId { get; set; }
        public int? ClassEvaluationId { get; set; }
        public string TestDescription { get; set; }
        public string TestLongDesc { get; set; }
        public string Instructions { get; set; }
        public string MailinInstructions { get; set; }
        public string PreTestInstructions { get; set; }
        public string PreTestMailinInstructions { get; set; }
        public bool AllowOnWeb { get; set; }
        public bool Active { get; set; }
        public double Fee { get; set; }
        public double? RetakeTestFee { get; set; }
        public short? MaxRetakes { get; set; }
        public bool? PaymentRequired { get; set; }
        public string Comments { get; set; }
        public double? PointsToPassMin { get; set; }
        public double? MaxPoints { get; set; }
        public double PercentMin { get; set; }
        public int? ScoringMethod { get; set; }
        public bool Lock { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? WebDisplayCreditsOffered { get; set; }
        public bool? AllowPrintMailInTests { get; set; }
        public bool? AllowPrintOnlineCertificate { get; set; }
        public bool? AllowDisplayTestResults { get; set; }
        public bool? CreateTestOrderForMailin { get; set; }
        public bool? WebDisplayInstructions { get; set; }
        public bool? WebDisplayMailInInstructions { get; set; }
        public bool? EarnCredits { get; set; }
        public bool? AllowRetakes { get; set; }
        public int? TestTimeSpanMinutes { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClassTestCredits> TblClassTestCredits { get; set; }
        public virtual ICollection<TblClassTestOrder> TblClassTestOrder { get; set; }
        public virtual ICollection<TblClassTestQuestions> TblClassTestQuestions { get; set; }
    }
}
