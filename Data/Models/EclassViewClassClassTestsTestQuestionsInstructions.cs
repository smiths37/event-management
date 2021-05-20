using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassTestsTestQuestionsInstructions
    {
        public int ClassTestId { get; set; }
        public string TestDescription { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public string QuestionText { get; set; }
        public int ResponseTypeId { get; set; }
        public short? WebSortOrder { get; set; }
        public int ClassId { get; set; }
        public int TestQuestionId { get; set; }
        public string NameOfClass { get; set; }
        public string Instructions { get; set; }
        public string MailinInstructions { get; set; }
        public string PreTestInstructions { get; set; }
        public string PreTestMailinInstructions { get; set; }
        public string TestLongDesc { get; set; }
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
        public string Classcode { get; set; }
    }
}
