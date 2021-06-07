using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MeetingTrak.Data.Models
{
    public partial class MeetingTrakTestNEWContext : DbContext
    {
        public MeetingTrakTestNEWContext()
        {
        }

        public MeetingTrakTestNEWContext(DbContextOptions<MeetingTrakTestNEWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EclassViewClassClassEvaluations> EclassViewClassClassEvaluations { get; set; }
        public virtual DbSet<EclassViewClassClassEvaluationsEvaluationQuestions> EclassViewClassClassEvaluationsEvaluationQuestions { get; set; }
        public virtual DbSet<EclassViewClassClassEvaluationsOrders> EclassViewClassClassEvaluationsOrders { get; set; }
        public virtual DbSet<EclassViewClassClassInstructors> EclassViewClassClassInstructors { get; set; }
        public virtual DbSet<EclassViewClassClassParticipants> EclassViewClassClassParticipants { get; set; }
        public virtual DbSet<EclassViewClassClassTests> EclassViewClassClassTests { get; set; }
        public virtual DbSet<EclassViewClassClassTestsOrders> EclassViewClassClassTestsOrders { get; set; }
        public virtual DbSet<EclassViewClassClassTestsTestQuestions> EclassViewClassClassTestsTestQuestions { get; set; }
        public virtual DbSet<EclassViewClassClassTestsTestQuestionsInstructions> EclassViewClassClassTestsTestQuestionsInstructions { get; set; }
        public virtual DbSet<EclassViewClassMain> EclassViewClassMain { get; set; }
        public virtual DbSet<EclassViewClassTestsOrdersPayments> EclassViewClassTestsOrdersPayments { get; set; }
        public virtual DbSet<EmailUpdates> EmailUpdates { get; set; }
        public virtual DbSet<TblAccountCodes> TblAccountCodes { get; set; }
        public virtual DbSet<TblAddressTypes> TblAddressTypes { get; set; }
        public virtual DbSet<TblAvItems> TblAvItems { get; set; }
        public virtual DbSet<TblBatchRegList> TblBatchRegList { get; set; }
        public virtual DbSet<TblBatchSessDefaults> TblBatchSessDefaults { get; set; }
        public virtual DbSet<TblBroadcastLetters> TblBroadcastLetters { get; set; }
        public virtual DbSet<TblBudgetCodes> TblBudgetCodes { get; set; }
        public virtual DbSet<TblCategories> TblCategories { get; set; }
        public virtual DbSet<TblChargeTypes> TblChargeTypes { get; set; }
        public virtual DbSet<TblClass> TblClass { get; set; }
        public virtual DbSet<TblClassAudienceTypes> TblClassAudienceTypes { get; set; }
        public virtual DbSet<TblClassEvaluationOrder> TblClassEvaluationOrder { get; set; }
        public virtual DbSet<TblClassEvaluationOrderResponses> TblClassEvaluationOrderResponses { get; set; }
        public virtual DbSet<TblClassEvaluationQuestions> TblClassEvaluationQuestions { get; set; }
        public virtual DbSet<TblClassEvaluationQuestionsItems> TblClassEvaluationQuestionsItems { get; set; }
        public virtual DbSet<TblClassEvaluations> TblClassEvaluations { get; set; }
        public virtual DbSet<TblClassFaq> TblClassFaq { get; set; }
        public virtual DbSet<TblClassFaqdefaultQuestions> TblClassFaqdefaultQuestions { get; set; }
        public virtual DbSet<TblClassInstructorList> TblClassInstructorList { get; set; }
        public virtual DbSet<TblClassInstructors> TblClassInstructors { get; set; }
        public virtual DbSet<TblClassLinkTypes> TblClassLinkTypes { get; set; }
        public virtual DbSet<TblClassLinks> TblClassLinks { get; set; }
        public virtual DbSet<TblClassMediaTypes> TblClassMediaTypes { get; set; }
        public virtual DbSet<TblClassNews> TblClassNews { get; set; }
        public virtual DbSet<TblClassNotes> TblClassNotes { get; set; }
        public virtual DbSet<TblClassObjectives> TblClassObjectives { get; set; }
        public virtual DbSet<TblClassParticipation> TblClassParticipation { get; set; }
        public virtual DbSet<TblClassParticipationMethods> TblClassParticipationMethods { get; set; }
        public virtual DbSet<TblClassParticipationNotes> TblClassParticipationNotes { get; set; }
        public virtual DbSet<TblClassQuestionBank> TblClassQuestionBank { get; set; }
        public virtual DbSet<TblClassQuestionBankItems> TblClassQuestionBankItems { get; set; }
        public virtual DbSet<TblClassQuestionCategory> TblClassQuestionCategory { get; set; }
        public virtual DbSet<TblClassQuestionDisplayType> TblClassQuestionDisplayType { get; set; }
        public virtual DbSet<TblClassRelatedClasses> TblClassRelatedClasses { get; set; }
        public virtual DbSet<TblClassRequiredMediaTypes> TblClassRequiredMediaTypes { get; set; }
        public virtual DbSet<TblClassSubjectAreas> TblClassSubjectAreas { get; set; }
        public virtual DbSet<TblClassTestCredits> TblClassTestCredits { get; set; }
        public virtual DbSet<TblClassTestOrder> TblClassTestOrder { get; set; }
        public virtual DbSet<TblClassTestOrderPayments> TblClassTestOrderPayments { get; set; }
        public virtual DbSet<TblClassTestOrderResponses> TblClassTestOrderResponses { get; set; }
        public virtual DbSet<TblClassTestQuestions> TblClassTestQuestions { get; set; }
        public virtual DbSet<TblClassTestQuestionsItems> TblClassTestQuestionsItems { get; set; }
        public virtual DbSet<TblClassTests> TblClassTests { get; set; }
        public virtual DbSet<TblClassTopics> TblClassTopics { get; set; }
        public virtual DbSet<TblCommentStatus> TblCommentStatus { get; set; }
        public virtual DbSet<TblCommitteeCodes> TblCommitteeCodes { get; set; }
        public virtual DbSet<TblCommitteeMembership> TblCommitteeMembership { get; set; }
        public virtual DbSet<TblCommitteePositionCodes> TblCommitteePositionCodes { get; set; }
        public virtual DbSet<TblCompanies> TblCompanies { get; set; }
        public virtual DbSet<TblCompanyAddresses> TblCompanyAddresses { get; set; }
        public virtual DbSet<TblCompanyDirectory> TblCompanyDirectory { get; set; }
        public virtual DbSet<TblCompanyEmails> TblCompanyEmails { get; set; }
        public virtual DbSet<TblCompanyTypes> TblCompanyTypes { get; set; }
        public virtual DbSet<TblCompanyVendor> TblCompanyVendor { get; set; }
        public virtual DbSet<TblCongress> TblCongress { get; set; }
        public virtual DbSet<TblCongressComments> TblCongressComments { get; set; }
        public virtual DbSet<TblCongressCommitteeAssignments> TblCongressCommitteeAssignments { get; set; }
        public virtual DbSet<TblCongressCommittees> TblCongressCommittees { get; set; }
        public virtual DbSet<TblCongressInterests> TblCongressInterests { get; set; }
        public virtual DbSet<TblCongressionalDistricts> TblCongressionalDistricts { get; set; }
        public virtual DbSet<TblContactMethodCodes> TblContactMethodCodes { get; set; }
        public virtual DbSet<TblContactTypeCodes> TblContactTypeCodes { get; set; }
        public virtual DbSet<TblContactTypes> TblContactTypes { get; set; }
        public virtual DbSet<TblContacts> TblContacts { get; set; }
        public virtual DbSet<TblCountries> TblCountries { get; set; }
        public virtual DbSet<TblCreateRenewTokens> TblCreateRenewTokens { get; set; }
        public virtual DbSet<TblCreditMemo> TblCreditMemo { get; set; }
        public virtual DbSet<TblCreditMemoLines> TblCreditMemoLines { get; set; }
        public virtual DbSet<TblCreditTypes> TblCreditTypes { get; set; }
        public virtual DbSet<TblDefaultLetterSetup> TblDefaultLetterSetup { get; set; }
        public virtual DbSet<TblDefaultMeetings> TblDefaultMeetings { get; set; }
        public virtual DbSet<TblDefaultRenewalLetterSetup> TblDefaultRenewalLetterSetup { get; set; }
        public virtual DbSet<TblDepartments> TblDepartments { get; set; }
        public virtual DbSet<TblDirectoryInfo> TblDirectoryInfo { get; set; }
        public virtual DbSet<TblDupeContacts> TblDupeContacts { get; set; }
        public virtual DbSet<TblDupeMbrPayments> TblDupeMbrPayments { get; set; }
        public virtual DbSet<TblDupeMembership> TblDupeMembership { get; set; }
        public virtual DbSet<TblDupeOrderLines> TblDupeOrderLines { get; set; }
        public virtual DbSet<TblDupeOrders> TblDupeOrders { get; set; }
        public virtual DbSet<TblDupeSubscriptions> TblDupeSubscriptions { get; set; }
        public virtual DbSet<TblDupeTransactions> TblDupeTransactions { get; set; }
        public virtual DbSet<TblEmailTypes> TblEmailTypes { get; set; }
        public virtual DbSet<TblErrataS0008Sql2005> TblErrataS0008Sql2005 { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLog { get; set; }
        public virtual DbSet<TblEvalQuestionBank> TblEvalQuestionBank { get; set; }
        public virtual DbSet<TblEvalQuestions> TblEvalQuestions { get; set; }
        public virtual DbSet<TblEvalResponse> TblEvalResponse { get; set; }
        public virtual DbSet<TblEvalResponseChoices> TblEvalResponseChoices { get; set; }
        public virtual DbSet<TblEvalResponseDtl> TblEvalResponseDtl { get; set; }
        public virtual DbSet<TblEvalResponseEntry> TblEvalResponseEntry { get; set; }
        public virtual DbSet<TblEvalResponseTypes> TblEvalResponseTypes { get; set; }
        public virtual DbSet<TblEvalSections> TblEvalSections { get; set; }
        public virtual DbSet<TblEvaluation> TblEvaluation { get; set; }
        public virtual DbSet<TblEvaluationOrder> TblEvaluationOrder { get; set; }
        public virtual DbSet<TblEvaluationOrderResponses> TblEvaluationOrderResponses { get; set; }
        public virtual DbSet<TblEvaluationQuestionBank> TblEvaluationQuestionBank { get; set; }
        public virtual DbSet<TblEvaluationQuestionBankItems> TblEvaluationQuestionBankItems { get; set; }
        public virtual DbSet<TblEvaluationQuestionCategory> TblEvaluationQuestionCategory { get; set; }
        public virtual DbSet<TblEvaluationQuestionDisplayType> TblEvaluationQuestionDisplayType { get; set; }
        public virtual DbSet<TblEvaluationQuestions> TblEvaluationQuestions { get; set; }
        public virtual DbSet<TblEvaluationQuestionsItems> TblEvaluationQuestionsItems { get; set; }
        public virtual DbSet<TblEvaluations> TblEvaluations { get; set; }
        public virtual DbSet<TblExhibitors> TblExhibitors { get; set; }
        public virtual DbSet<TblExpenses> TblExpenses { get; set; }
        public virtual DbSet<TblFbItems> TblFbItems { get; set; }
        public virtual DbSet<TblGovernmentTypes> TblGovernmentTypes { get; set; }
        public virtual DbSet<TblGuaranteeTypes> TblGuaranteeTypes { get; set; }
        public virtual DbSet<TblGuestReg> TblGuestReg { get; set; }
        public virtual DbSet<TblGuestTypes> TblGuestTypes { get; set; }
        public virtual DbSet<TblHotelContacts> TblHotelContacts { get; set; }
        public virtual DbSet<TblHotelCounts> TblHotelCounts { get; set; }
        public virtual DbSet<TblHotelRoomTypes> TblHotelRoomTypes { get; set; }
        public virtual DbSet<TblHotelTypes> TblHotelTypes { get; set; }
        public virtual DbSet<TblHotels> TblHotels { get; set; }
        public virtual DbSet<TblHousing> TblHousing { get; set; }
        public virtual DbSet<TblIncome> TblIncome { get; set; }
        public virtual DbSet<TblInfoCodes> TblInfoCodes { get; set; }
        public virtual DbSet<TblInfoRequestItems> TblInfoRequestItems { get; set; }
        public virtual DbSet<TblInformationRequests> TblInformationRequests { get; set; }
        public virtual DbSet<TblInterestCodes> TblInterestCodes { get; set; }
        public virtual DbSet<TblInterests> TblInterests { get; set; }
        public virtual DbSet<TblItinerary> TblItinerary { get; set; }
        public virtual DbSet<TblLegislation> TblLegislation { get; set; }
        public virtual DbSet<TblLetterSetup> TblLetterSetup { get; set; }
        public virtual DbSet<TblListMembers> TblListMembers { get; set; }
        public virtual DbSet<TblLists> TblLists { get; set; }
        public virtual DbSet<TblMbrPayments> TblMbrPayments { get; set; }
        public virtual DbSet<TblMeetingCredits> TblMeetingCredits { get; set; }
        public virtual DbSet<TblMeetingCreditsHist> TblMeetingCreditsHist { get; set; }
        public virtual DbSet<TblMeetingTasks> TblMeetingTasks { get; set; }
        public virtual DbSet<TblMeetings> TblMeetings { get; set; }
        public virtual DbSet<TblMeetingsHist> TblMeetingsHist { get; set; }
        public virtual DbSet<TblMembership> TblMembership { get; set; }
        public virtual DbSet<TblMembershipDirectory> TblMembershipDirectory { get; set; }
        public virtual DbSet<TblMembershipHistory> TblMembershipHistory { get; set; }
        public virtual DbSet<TblMembershipList> TblMembershipList { get; set; }
        public virtual DbSet<TblMembershipOrganizations> TblMembershipOrganizations { get; set; }
        public virtual DbSet<TblMembershipProducts> TblMembershipProducts { get; set; }
        public virtual DbSet<TblMembershipTypeCodes> TblMembershipTypeCodes { get; set; }
        public virtual DbSet<TblNamePrefixes> TblNamePrefixes { get; set; }
        public virtual DbSet<TblNews> TblNews { get; set; }
        public virtual DbSet<TblNotes> TblNotes { get; set; }
        public virtual DbSet<TblOrderLines> TblOrderLines { get; set; }
        public virtual DbSet<TblOrderTypes> TblOrderTypes { get; set; }
        public virtual DbSet<TblOrders> TblOrders { get; set; }
        public virtual DbSet<TblPartyCodes> TblPartyCodes { get; set; }
        public virtual DbSet<TblPassword> TblPassword { get; set; }
        public virtual DbSet<TblPaymentMethods> TblPaymentMethods { get; set; }
        public virtual DbSet<TblPaymentNumFormats> TblPaymentNumFormats { get; set; }
        public virtual DbSet<TblPaymentTypes> TblPaymentTypes { get; set; }
        public virtual DbSet<TblPayments> TblPayments { get; set; }
        public virtual DbSet<TblPaymentsHist> TblPaymentsHist { get; set; }
        public virtual DbSet<TblPaytrakConfig> TblPaytrakConfig { get; set; }
        public virtual DbSet<TblPeople> TblPeople { get; set; }
        public virtual DbSet<TblPeopleAddresses> TblPeopleAddresses { get; set; }
        public virtual DbSet<TblPeopleCecredits> TblPeopleCecredits { get; set; }
        public virtual DbSet<TblPeopleCreditTypes> TblPeopleCreditTypes { get; set; }
        public virtual DbSet<TblPeopleEmails> TblPeopleEmails { get; set; }
        public virtual DbSet<TblPeopleSourceCodes> TblPeopleSourceCodes { get; set; }
        public virtual DbSet<TblPeopleTypes> TblPeopleTypes { get; set; }
        public virtual DbSet<TblPhoneTypes> TblPhoneTypes { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblRegHistory> TblRegHistory { get; set; }
        public virtual DbSet<TblRegTypes> TblRegTypes { get; set; }
        public virtual DbSet<TblRegTypesHist> TblRegTypesHist { get; set; }
        public virtual DbSet<TblRegistration> TblRegistration { get; set; }
        public virtual DbSet<TblRenewalLetterSetup> TblRenewalLetterSetup { get; set; }
        public virtual DbSet<TblRenewalTypes> TblRenewalTypes { get; set; }
        public virtual DbSet<TblReports> TblReports { get; set; }
        public virtual DbSet<TblReps> TblReps { get; set; }
        public virtual DbSet<TblRoomSetups> TblRoomSetups { get; set; }
        public virtual DbSet<TblRoommates> TblRoommates { get; set; }
        public virtual DbSet<TblServiceCodes> TblServiceCodes { get; set; }
        public virtual DbSet<TblSessReg> TblSessReg { get; set; }
        public virtual DbSet<TblSessRegHist> TblSessRegHist { get; set; }
        public virtual DbSet<TblSessionAvItems> TblSessionAvItems { get; set; }
        public virtual DbSet<TblSessionCredits> TblSessionCredits { get; set; }
        public virtual DbSet<TblSessionCreditsHist> TblSessionCreditsHist { get; set; }
        public virtual DbSet<TblSessionDefaults> TblSessionDefaults { get; set; }
        public virtual DbSet<TblSessionFbItems> TblSessionFbItems { get; set; }
        public virtual DbSet<TblSessionSetupItems> TblSessionSetupItems { get; set; }
        public virtual DbSet<TblSessionWaitList> TblSessionWaitList { get; set; }
        public virtual DbSet<TblSessions> TblSessions { get; set; }
        public virtual DbSet<TblSessionsHist> TblSessionsHist { get; set; }
        public virtual DbSet<TblSetupItems> TblSetupItems { get; set; }
        public virtual DbSet<TblShippingMethods> TblShippingMethods { get; set; }
        public virtual DbSet<TblSources> TblSources { get; set; }
        public virtual DbSet<TblSpeakerTypes> TblSpeakerTypes { get; set; }
        public virtual DbSet<TblSpeakers> TblSpeakers { get; set; }
        public virtual DbSet<TblSpecialties> TblSpecialties { get; set; }
        public virtual DbSet<TblStates> TblStates { get; set; }
        public virtual DbSet<TblSubscriptions> TblSubscriptions { get; set; }
        public virtual DbSet<TblSystemDefaults> TblSystemDefaults { get; set; }
        public virtual DbSet<TblTasksTemplatesDtl> TblTasksTemplatesDtl { get; set; }
        public virtual DbSet<TblTasksTemplatesHdr> TblTasksTemplatesHdr { get; set; }
        public virtual DbSet<TblTransactions> TblTransactions { get; set; }
        public virtual DbSet<TblUserDefaults> TblUserDefaults { get; set; }
        public virtual DbSet<TblUserFields> TblUserFields { get; set; }
        public virtual DbSet<TblVendorInvoices> TblVendorInvoices { get; set; }
        public virtual DbSet<TblVendorPayments> TblVendorPayments { get; set; }
        public virtual DbSet<TblVendorTypes> TblVendorTypes { get; set; }
        public virtual DbSet<TblVotingRecord> TblVotingRecord { get; set; }
        public virtual DbSet<TblgtpConfig> TblgtpConfig { get; set; }
        public virtual DbSet<TempPeopleCecredits> TempPeopleCecredits { get; set; }
        public virtual DbSet<TmpCompanyPaymentsDtl> TmpCompanyPaymentsDtl { get; set; }
        public virtual DbSet<ViewCtctpeopleAddressPrimary> ViewCtctpeopleAddressPrimary { get; set; }
        public virtual DbSet<ViewCtctpeopleCriteria> ViewCtctpeopleCriteria { get; set; }
        public virtual DbSet<ViewCtctregistrationCriteria> ViewCtctregistrationCriteria { get; set; }
        public virtual DbSet<ViewDupeProcessing> ViewDupeProcessing { get; set; }
        public virtual DbSet<ViewfrmCompanyMembership> ViewfrmCompanyMembership { get; set; }
        public virtual DbSet<ViewfrmGuestSessRegSubform> ViewfrmGuestSessRegSubform { get; set; }
        public virtual DbSet<ViewfrmMembership> ViewfrmMembership { get; set; }
        public virtual DbSet<ViewfrmRegFinancialSubform> ViewfrmRegFinancialSubform { get; set; }
        public virtual DbSet<ViewfrmSessRegSubform1> ViewfrmSessRegSubform1 { get; set; }
        public virtual DbSet<ViewfrmSubscriptions> ViewfrmSubscriptions { get; set; }
        public virtual DbSet<ViewrptBadges> ViewrptBadges { get; set; }
        public virtual DbSet<ViewrptBadgesGuest> ViewrptBadgesGuest { get; set; }
        public virtual DbSet<ViewrptCertificateMeetingCreditsSub> ViewrptCertificateMeetingCreditsSub { get; set; }
        public virtual DbSet<ViewrptCertificateMeetingNotesSub> ViewrptCertificateMeetingNotesSub { get; set; }
        public virtual DbSet<ViewrptCertificateMeetings> ViewrptCertificateMeetings { get; set; }
        public virtual DbSet<ViewrptCertificateSessionCreditsSub> ViewrptCertificateSessionCreditsSub { get; set; }
        public virtual DbSet<ViewrptCertificateSessionNotesSub> ViewrptCertificateSessionNotesSub { get; set; }
        public virtual DbSet<ViewrptCertificateSessions> ViewrptCertificateSessions { get; set; }
        public virtual DbSet<ViewrptCompany> ViewrptCompany { get; set; }
        public virtual DbSet<ViewrptCompanyPeopleCount> ViewrptCompanyPeopleCount { get; set; }
        public virtual DbSet<ViewrptCreditStatsUnionMeetings> ViewrptCreditStatsUnionMeetings { get; set; }
        public virtual DbSet<ViewrptDefaultReg> ViewrptDefaultReg { get; set; }
        public virtual DbSet<ViewrptDefaultRegSess> ViewrptDefaultRegSess { get; set; }
        public virtual DbSet<ViewrptEvalResponses> ViewrptEvalResponses { get; set; }
        public virtual DbSet<ViewrptEvalsEvaluationsEvaluationQuestions> ViewrptEvalsEvaluationsEvaluationQuestions { get; set; }
        public virtual DbSet<ViewrptEvaluations> ViewrptEvaluations { get; set; }
        public virtual DbSet<ViewrptExhibitorAddresses> ViewrptExhibitorAddresses { get; set; }
        public virtual DbSet<ViewrptExhibitorLetters> ViewrptExhibitorLetters { get; set; }
        public virtual DbSet<ViewrptExhibitors> ViewrptExhibitors { get; set; }
        public virtual DbSet<ViewrptFinancial> ViewrptFinancial { get; set; }
        public virtual DbSet<ViewrptGuestReg> ViewrptGuestReg { get; set; }
        public virtual DbSet<ViewrptGuests> ViewrptGuests { get; set; }
        public virtual DbSet<ViewrptGuestsSessionCount> ViewrptGuestsSessionCount { get; set; }
        public virtual DbSet<ViewrptHistoryLabels> ViewrptHistoryLabels { get; set; }
        public virtual DbSet<ViewrptHistoryParticipant> ViewrptHistoryParticipant { get; set; }
        public virtual DbSet<ViewrptHistoryParticipantSub> ViewrptHistoryParticipantSub { get; set; }
        public virtual DbSet<ViewrptHotels> ViewrptHotels { get; set; }
        public virtual DbSet<ViewrptHousing> ViewrptHousing { get; set; }
        public virtual DbSet<ViewrptHousingRegByMeetingwHotel> ViewrptHousingRegByMeetingwHotel { get; set; }
        public virtual DbSet<ViewrptHousingRoomingList> ViewrptHousingRoomingList { get; set; }
        public virtual DbSet<ViewrptHousingRoommates> ViewrptHousingRoommates { get; set; }
        public virtual DbSet<ViewrptIncomeExpense> ViewrptIncomeExpense { get; set; }
        public virtual DbSet<ViewrptIncomeExpenseGratuity> ViewrptIncomeExpenseGratuity { get; set; }
        public virtual DbSet<ViewrptIncomeExpensePlmeetingExpenseSub> ViewrptIncomeExpensePlmeetingExpenseSub { get; set; }
        public virtual DbSet<ViewrptIncomeExpensePlmeetingIncomeSub> ViewrptIncomeExpensePlmeetingIncomeSub { get; set; }
        public virtual DbSet<ViewrptIncomeExpensePlmeetings> ViewrptIncomeExpensePlmeetings { get; set; }
        public virtual DbSet<ViewrptIncomeExpensePlsessions> ViewrptIncomeExpensePlsessions { get; set; }
        public virtual DbSet<ViewrptIncomeExpenseSessions> ViewrptIncomeExpenseSessions { get; set; }
        public virtual DbSet<ViewrptIncomeExpenseTax> ViewrptIncomeExpenseTax { get; set; }
        public virtual DbSet<ViewrptIncomeExpenseVendor> ViewrptIncomeExpenseVendor { get; set; }
        public virtual DbSet<ViewrptItineraryArrival> ViewrptItineraryArrival { get; set; }
        public virtual DbSet<ViewrptItineraryDeparture> ViewrptItineraryDeparture { get; set; }
        public virtual DbSet<ViewrptLettersMeetingCode> ViewrptLettersMeetingCode { get; set; }
        public virtual DbSet<ViewrptLettersRegCode> ViewrptLettersRegCode { get; set; }
        public virtual DbSet<ViewrptMeetingSetupAudit> ViewrptMeetingSetupAudit { get; set; }
        public virtual DbSet<ViewrptMeetingSetupAuditAttendeesSub> ViewrptMeetingSetupAuditAttendeesSub { get; set; }
        public virtual DbSet<ViewrptMeetingSetupAuditCancellationsSub> ViewrptMeetingSetupAuditCancellationsSub { get; set; }
        public virtual DbSet<ViewrptMeetingSetupAuditOtherSub> ViewrptMeetingSetupAuditOtherSub { get; set; }
        public virtual DbSet<ViewrptMeetingSetupLetterText> ViewrptMeetingSetupLetterText { get; set; }
        public virtual DbSet<ViewrptMeetingSetupRegTypeLetterText> ViewrptMeetingSetupRegTypeLetterText { get; set; }
        public virtual DbSet<ViewrptMeetingSetupSessionCodes> ViewrptMeetingSetupSessionCodes { get; set; }
        public virtual DbSet<ViewrptNotesContacts> ViewrptNotesContacts { get; set; }
        public virtual DbSet<ViewrptNotesMeeting> ViewrptNotesMeeting { get; set; }
        public virtual DbSet<ViewrptNotesPeople> ViewrptNotesPeople { get; set; }
        public virtual DbSet<ViewrptOpenendedResponses> ViewrptOpenendedResponses { get; set; }
        public virtual DbSet<ViewrptOrigPaymentInfoSub> ViewrptOrigPaymentInfoSub { get; set; }
        public virtual DbSet<ViewrptPayments> ViewrptPayments { get; set; }
        public virtual DbSet<ViewrptPeople> ViewrptPeople { get; set; }
        public virtual DbSet<ViewrptRefundsDue> ViewrptRefundsDue { get; set; }
        public virtual DbSet<ViewrptRegLettersSessionRegAttendee> ViewrptRegLettersSessionRegAttendee { get; set; }
        public virtual DbSet<ViewrptRegLettersSessionRegGuest> ViewrptRegLettersSessionRegGuest { get; set; }
        public virtual DbSet<ViewrptRegistration> ViewrptRegistration { get; set; }
        public virtual DbSet<ViewrptRegistrationAttendeeListFalse> ViewrptRegistrationAttendeeListFalse { get; set; }
        public virtual DbSet<ViewrptRegistrationAttendeeListTrue> ViewrptRegistrationAttendeeListTrue { get; set; }
        public virtual DbSet<ViewrptRegistrationCancelled> ViewrptRegistrationCancelled { get; set; }
        public virtual DbSet<ViewrptRegistrationGuestFees> ViewrptRegistrationGuestFees { get; set; }
        public virtual DbSet<ViewrptRegistrationGuestSessionFees> ViewrptRegistrationGuestSessionFees { get; set; }
        public virtual DbSet<ViewrptRegistrationHousingCosts> ViewrptRegistrationHousingCosts { get; set; }
        public virtual DbSet<ViewrptRegistrationPayments> ViewrptRegistrationPayments { get; set; }
        public virtual DbSet<ViewrptRegistrationSessionFees> ViewrptRegistrationSessionFees { get; set; }
        public virtual DbSet<ViewrptResponseStatistics> ViewrptResponseStatistics { get; set; }
        public virtual DbSet<ViewrptSessWaitList> ViewrptSessWaitList { get; set; }
        public virtual DbSet<ViewrptSessionAvitemsSub> ViewrptSessionAvitemsSub { get; set; }
        public virtual DbSet<ViewrptSessionFbitemsSub> ViewrptSessionFbitemsSub { get; set; }
        public virtual DbSet<ViewrptSessionInfoAndStats> ViewrptSessionInfoAndStats { get; set; }
        public virtual DbSet<ViewrptSessionReg> ViewrptSessionReg { get; set; }
        public virtual DbSet<ViewrptSessionRoster> ViewrptSessionRoster { get; set; }
        public virtual DbSet<ViewrptSessionSetupItems> ViewrptSessionSetupItems { get; set; }
        public virtual DbSet<ViewrptSessionSetupItemsSub> ViewrptSessionSetupItemsSub { get; set; }
        public virtual DbSet<ViewrptSessionSignIn> ViewrptSessionSignIn { get; set; }
        public virtual DbSet<ViewrptSessionSpeakersSub> ViewrptSessionSpeakersSub { get; set; }
        public virtual DbSet<ViewrptSpeaker> ViewrptSpeaker { get; set; }
        public virtual DbSet<ViewrptSpeakerLetter> ViewrptSpeakerLetter { get; set; }
        public virtual DbSet<ViewrptSpeakerLetterSub> ViewrptSpeakerLetterSub { get; set; }
        public virtual DbSet<ViewrptSponsorPrimaryContact> ViewrptSponsorPrimaryContact { get; set; }
        public virtual DbSet<ViewrptSponsors> ViewrptSponsors { get; set; }
        public virtual DbSet<ViewrptStatistics> ViewrptStatistics { get; set; }
        public virtual DbSet<ViewrptTasks> ViewrptTasks { get; set; }
        public virtual DbSet<ViewrptTicketsAttendee> ViewrptTicketsAttendee { get; set; }
        public virtual DbSet<ViewrptTicketsGuests> ViewrptTicketsGuests { get; set; }
        public virtual DbSet<ViewrptTranscript> ViewrptTranscript { get; set; }
        public virtual DbSet<ViewrptTranscriptMain> ViewrptTranscriptMain { get; set; }
        public virtual DbSet<ViewrptTranscriptSelection> ViewrptTranscriptSelection { get; set; }
        public virtual DbSet<ViewrptUnionMeetings> ViewrptUnionMeetings { get; set; }
        public virtual DbSet<ViewrptUnionSessions> ViewrptUnionSessions { get; set; }
        public virtual DbSet<ViewrptVendor1099> ViewrptVendor1099 { get; set; }
        public virtual DbSet<ViewrptVendorInvoice> ViewrptVendorInvoice { get; set; }
        public virtual DbSet<ViewrptVendorInvoiceSub> ViewrptVendorInvoiceSub { get; set; }
        public virtual DbSet<ViewrptVendorInvoicerptSub> ViewrptVendorInvoicerptSub { get; set; }
        public virtual DbSet<ViewrptVendorListing> ViewrptVendorListing { get; set; }
        public virtual DbSet<ViewrptVendorPayments> ViewrptVendorPayments { get; set; }
        public virtual DbSet<ViewrptsubResponseHeader> ViewrptsubResponseHeader { get; set; }
        public virtual DbSet<ZzzMsysObjTypes> ZzzMsysObjTypes { get; set; }
        public virtual DbSet<ZzzNotes> ZzzNotes { get; set; }
        public virtual DbSet<ZzzRelationTypes> ZzzRelationTypes { get; set; }
        public virtual DbSet<ZzzRelations> ZzzRelations { get; set; }
        public virtual DbSet<ZzzTempEdith> ZzzTempEdith { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=eflextest; Database = MeetingTrakTestNEW; User Id = mtrakNEWuser; Password = #4NEWmtrakTest;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EclassViewClassClassEvaluations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassEvaluations");

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassEvaluationsEvaluationQuestions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassEvaluations_EvaluationQuestions");

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassEvaluationsOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassEvaluationsOrders");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationOrderDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassInstructors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassInstructors");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bio).HasColumnType("text");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.Degree)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InstructorName)
                    .IsRequired()
                    .HasMaxLength(158)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebSiteUrl)
                    .HasColumnName("WebSiteURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassParticipants>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassParticipants");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BadgeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateMaterialsReviewed).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassTests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassTests");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassTestsOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassTestsOrders");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCertificatePrinted).HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.DateTestEvaluationCompleted).HasColumnType("datetime");

                entity.Property(e => e.DiscountReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OtherFeesDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefundReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TestOrderDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassTestsTestQuestions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassTests_TestQuestions");

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclassViewClassClassTestsTestQuestionsInstructions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_ClassTests_TestQuestions_Instructions");

                entity.Property(e => e.Classcode)
                    .HasColumnName("classcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.MailinInstructions).HasColumnType("text");

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreTestInstructions).HasColumnType("text");

                entity.Property(e => e.PreTestMailinInstructions).HasColumnType("text");

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TestLongDesc).HasColumnType("text");
            });

            modelBuilder.Entity<EclassViewClassMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_Main");

                entity.Property(e => e.AudienceTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOriginalRelease).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDesc).HasColumnType("text");

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationMethodDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StatementOfIntent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectAreaDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDisplayFaq).HasColumnName("WebDisplayFAQ");

                entity.Property(e => e.WebExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EclassViewClassTestsOrdersPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("eclassViewClass_TestsOrdersPayments");
            });

            modelBuilder.Entity<EmailUpdates>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMail Address")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.NewEmail).HasMaxLength(255);

                entity.Property(e => e.NewEmailAddress)
                    .HasColumnName("NewEMailAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.NewOrganization)
                    .HasColumnName("New Organization")
                    .HasMaxLength(255);

                entity.Property(e => e.Organization).HasMaxLength(255);
            });

            modelBuilder.Entity<TblAccountCodes>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("aaaaatblAccountCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblAccountCodes");

                entity.HasIndex(e => e.GlaccountCode)
                    .HasName("GLAccountCode");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.GlaccountCode)
                    .HasColumnName("GLAccountCode")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountDescription)
                    .HasColumnName("GLAccountDescription")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblAddressTypes>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId)
                    .HasName("aaaaatblAddressTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblAddressTypes");

                entity.HasIndex(e => e.AddressTypeDesc)
                    .HasName("Address Type Desc")
                    .IsUnique();

                entity.Property(e => e.AddressTypeId).HasColumnName("Address Type ID");

                entity.Property(e => e.AddressTypeDesc)
                    .IsRequired()
                    .HasColumnName("Address Type Desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblAvItems>(entity =>
            {
                entity.HasKey(e => e.AvId)
                    .HasName("aaaaatblAvItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblAvItems");

                entity.HasIndex(e => e.AvDesc)
                    .HasName("Setup Description")
                    .IsUnique();

                entity.Property(e => e.AvId).HasColumnName("AV ID");

                entity.Property(e => e.AvDesc)
                    .IsRequired()
                    .HasColumnName("AV Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblBatchRegList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBatchRegList");

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasColumnName("Person ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBatchSessDefaults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBatchSessDefaults");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBroadcastLetters>(entity =>
            {
                entity.HasKey(e => e.LetterName)
                    .HasName("aaaaatblBroadcastLetters_PK")
                    .IsClustered(false);

                entity.ToTable("tblBroadcastLetters");

                entity.Property(e => e.LetterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.Body).HasColumnType("ntext");

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.Header).HasColumnType("ntext");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblBudgetCodes>(entity =>
            {
                entity.HasKey(e => e.BudgetCode)
                    .HasName("aaaaatblBudgetCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblBudgetCodes");

                entity.HasIndex(e => e.BudgetType)
                    .HasName("Budget Type");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("Department Responsible");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetType)
                    .HasColumnName("Budget Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("Department ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("aaaaatblCategories_PK")
                    .IsClustered(false);

                entity.ToTable("tblCategories");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("CategoryName")
                    .IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblChargeTypes>(entity =>
            {
                entity.HasKey(e => e.ChargeTypeId)
                    .HasName("aaaaatblChargeTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblChargeTypes");

                entity.HasIndex(e => e.ChargeTypeDesc)
                    .HasName("IX_tblChargeDesc")
                    .IsUnique();

                entity.Property(e => e.ChargeTypeId).HasColumnName("Charge Type ID");

                entity.Property(e => e.ChargeTypeDesc)
                    .IsRequired()
                    .HasColumnName("Charge Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("tblClass");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_tblClass");

                entity.HasIndex(e => new { e.NameOfClass, e.MeetingCode })
                    .HasName("Unique_ClassName_MeetingCode")
                    .IsUnique();

                entity.Property(e => e.ClassDetailInstructions).HasColumnType("text");

                entity.Property(e => e.ClassMaterialInstruction).HasColumnType("text");

                entity.Property(e => e.ClassMinSysRequirements).HasColumnType("text");

                entity.Property(e => e.ClassTestInstructions).HasColumnType("text");

                entity.Property(e => e.Classcode)
                    .HasColumnName("classcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateOriginalRelease).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LongDesc).HasColumnType("text");

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedMeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StatementOfIntent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WebDisplayFaq).HasColumnName("WebDisplayFAQ");

                entity.Property(e => e.WebExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.AudienceType)
                    .WithMany(p => p.TblClass)
                    .HasForeignKey(d => d.AudienceTypeId)
                    .HasConstraintName("FK_tblClass_tblClassAudienceTypes");

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblClass)
                    .HasForeignKey(d => d.MeetingCode)
                    .HasConstraintName("FK_tblClass_tblMeetings");

                entity.HasOne(d => d.ParticipationMethod)
                    .WithMany(p => p.TblClass)
                    .HasForeignKey(d => d.ParticipationMethodId)
                    .HasConstraintName("FK_tblClass_tblClassParticipationMethods");

                entity.HasOne(d => d.SubjectArea)
                    .WithMany(p => p.TblClass)
                    .HasForeignKey(d => d.SubjectAreaId)
                    .HasConstraintName("FK_tblClass_tblClassSubjectAreas");
            });

            modelBuilder.Entity<TblClassAudienceTypes>(entity =>
            {
                entity.HasKey(e => e.AudienceTypeId);

                entity.ToTable("tblClassAudienceTypes");

                entity.HasIndex(e => e.AudienceTypeDesc)
                    .HasName("Unique_AudienceTypeDesc")
                    .IsUnique();

                entity.Property(e => e.AudienceTypeDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassEvaluationOrder>(entity =>
            {
                entity.HasKey(e => e.EvaluationOrderId);

                entity.ToTable("tblClassEvaluationOrder");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.EvaluationOrderDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailInPrintDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClassEvaluation)
                    .WithMany(p => p.TblClassEvaluationOrder)
                    .HasForeignKey(d => d.ClassEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluationOrder_tblClassEvaluations");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.TblClassEvaluationOrder)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluationOrder_tblClassParticipation");
            });

            modelBuilder.Entity<TblClassEvaluationOrderResponses>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .HasName("PK_tblClassEvaluationResponses");

                entity.ToTable("tblClassEvaluationOrderResponses");

                entity.HasIndex(e => new { e.EvaluationOrderId, e.EvaluationQuestionId })
                    .HasName("Unique_EvalOrderId_EvalQuestionId")
                    .IsUnique();

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedAnswer).HasColumnType("text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EvaluationOrder)
                    .WithMany(p => p.TblClassEvaluationOrderResponses)
                    .HasForeignKey(d => d.EvaluationOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluationResponses_tblClassEvaluationOrder");
            });

            modelBuilder.Entity<TblClassEvaluationQuestions>(entity =>
            {
                entity.HasKey(e => e.EvaluationQuestionId);

                entity.ToTable("tblClassEvaluationQuestions");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblClassEvaluationQuestions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblClassEvaluationQuestions_tblClassQuestionCategory");

                entity.HasOne(d => d.ClassEvaluation)
                    .WithMany(p => p.TblClassEvaluationQuestions)
                    .HasForeignKey(d => d.ClassEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluationQuestions_tblClassEvaluations");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblClassEvaluationQuestions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_tblClassEvaluationQuestions_tblClassQuestionDisplayType");
            });

            modelBuilder.Entity<TblClassEvaluationQuestionsItems>(entity =>
            {
                entity.HasKey(e => e.QuestionItemId);

                entity.ToTable("tblClassEvaluationQuestionsItems");

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.ItemDisplay })
                    .HasName("Unique_EvalQuestionId_ItemDisplay")
                    .IsUnique();

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.ItemValue })
                    .HasName("Unique_EvalQuestionId_ItemValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.QuestionItemText })
                    .HasName("UniqueEvalQuestionID_ItemText")
                    .IsUnique();

                entity.Property(e => e.ItemComment).HasColumnType("text");

                entity.Property(e => e.ItemDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionItemText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EvaluationQuestion)
                    .WithMany(p => p.TblClassEvaluationQuestionsItems)
                    .HasForeignKey(d => d.EvaluationQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluationQuestionsItems_tblClassEvaluationQuestions");
            });

            modelBuilder.Entity<TblClassEvaluations>(entity =>
            {
                entity.HasKey(e => e.ClassEvaluationId);

                entity.ToTable("tblClassEvaluations");

                entity.HasIndex(e => new { e.ClassId, e.EvaluationDescription })
                    .HasName("Unique_ClassId_EvalDesc")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationLongDesc).HasColumnType("text");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.MailinInstructions).HasColumnType("text");

                entity.Property(e => e.PreEvaluationInstructions).HasColumnType("text");

                entity.Property(e => e.PreEvaluationMailinInstructions).HasColumnType("text");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblClassEvaluations)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassEvaluations_tblClass");
            });

            modelBuilder.Entity<TblClassFaq>(entity =>
            {
                entity.ToTable("tblClassFAQ");

                entity.Property(e => e.AnswerPrompt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionAnswer)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.QuestionNumberDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionPrompt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UrlhelpLink)
                    .HasColumnName("URLhelpLink")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblClassFaq)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassFAQ_tblClass");
            });

            modelBuilder.Entity<TblClassFaqdefaultQuestions>(entity =>
            {
                entity.ToTable("tblClassFAQDefaultQuestions");

                entity.Property(e => e.AnswerPrompt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionAnswer)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.QuestionNumberDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionPrompt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UrlhelpLink)
                    .HasColumnName("URLhelpLink")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblClassInstructorList>(entity =>
            {
                entity.HasKey(e => e.InstructorId);

                entity.ToTable("tblClassInstructorList");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bio).HasColumnType("text");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Degree)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WebSiteUrl)
                    .HasColumnName("WebSiteURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblClassInstructors>(entity =>
            {
                entity.ToTable("tblClassInstructors");

                entity.HasIndex(e => new { e.InstructorId, e.ClassId })
                    .HasName("Unique_InstructorId_ClassId")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassLinkTypes>(entity =>
            {
                entity.HasKey(e => e.LinkTypeId);

                entity.ToTable("tblClassLinkTypes");

                entity.HasIndex(e => e.LinkTypeDesc)
                    .HasName("Unique_LinkTypeDesc")
                    .IsUnique();

                entity.Property(e => e.LinkTypeDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("tblClassLinks");

                entity.HasIndex(e => new { e.ClassId, e.LinkWebDesc })
                    .HasName("Unique_ClassId_LinkDesc")
                    .IsUnique();

                entity.Property(e => e.LinkComment).HasColumnType("text");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkWebDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UrllinkDisplayText)
                    .HasColumnName("URLlinkDisplayText")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.LinkType)
                    .WithMany(p => p.TblClassLinks)
                    .HasForeignKey(d => d.LinkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassLinks_tblClassLinkTypes1");
            });

            modelBuilder.Entity<TblClassMediaTypes>(entity =>
            {
                entity.HasKey(e => e.MediaTypeId);

                entity.ToTable("tblClassMediaTypes");

                entity.HasIndex(e => e.MediaTypeDesc)
                    .HasName("Unique_MediaTypeDesc")
                    .IsUnique();

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDesc).HasColumnType("text");

                entity.Property(e => e.MediaDownLoadUrl)
                    .HasColumnName("MediaDownLoadURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTypeDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassNews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("tblClassNews");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgDetail).HasColumnType("text");

                entity.Property(e => e.MsgHeader)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("tblClassNotes");

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassObjectives>(entity =>
            {
                entity.HasKey(e => e.ObjectiveId);

                entity.ToTable("tblClassObjectives");

                entity.HasIndex(e => new { e.ClassId, e.ObjectiveDesc })
                    .HasName("Unique_ClassId_ObjDesc")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.ObjectiveDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassParticipation>(entity =>
            {
                entity.HasKey(e => e.ParticipantId);

                entity.ToTable("tblClassParticipation");

                entity.HasIndex(e => new { e.PersonId, e.ClassId })
                    .HasName("UniquePersonId_ClassId")
                    .IsUnique();

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BadgeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateMaterialsReviewed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblClassParticipation)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassParticipation_tblClass");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblClassParticipation)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassParticipation_tblPeople");
            });

            modelBuilder.Entity<TblClassParticipationMethods>(entity =>
            {
                entity.HasKey(e => e.ParticipationMethodId);

                entity.ToTable("tblClassParticipationMethods");

                entity.HasIndex(e => e.ParticipationMethodDesc)
                    .HasName("Unique_ParticipationMethodDesc")
                    .IsUnique();

                entity.Property(e => e.ParticipationMethodDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassParticipationNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("tblClassParticipationNotes");

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassQuestionBank>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("tblClassQuestionBank");

                entity.Property(e => e.BankSortOrder).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.QuestionAnswer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblClassQuestionBank)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblClassQuestionBank_tblClassQuestionCategory");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblClassQuestionBank)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_tblClassQuestionBank_tblClassQuestionDisplayType");
            });

            modelBuilder.Entity<TblClassQuestionBankItems>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tblClassQuestionBankItems");

                entity.HasIndex(e => new { e.QuestionId, e.ItemDisplay })
                    .HasName("Unique_QuestionId_ItemDisplay")
                    .IsUnique();

                entity.HasIndex(e => new { e.QuestionId, e.ItemValue })
                    .HasName("UniqueQuestionId_ItemValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.QuestionId, e.QuestionItemText })
                    .HasName("Unique_QuestionID_QuestionItemText")
                    .IsUnique();

                entity.Property(e => e.ItemDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionItemText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TblClassQuestionBankItems)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassQuestionBankItems_tblClassQuestionBank");
            });

            modelBuilder.Entity<TblClassQuestionCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblClassQuestionCategory");

                entity.HasIndex(e => e.CategoryDesc)
                    .HasName("Unique_CategoryDesc")
                    .IsUnique();

                entity.Property(e => e.CategoryDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassQuestionDisplayType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tblClassQuestionDisplayType");

                entity.HasIndex(e => e.TypeDesc)
                    .HasName("UniqueTypeDesc")
                    .IsUnique();

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassRelatedClasses>(entity =>
            {
                entity.ToTable("tblClassRelatedClasses");

                entity.HasIndex(e => new { e.ClassId, e.RelatedClassId })
                    .HasName("Unique_ClassId_RelatedClassId")
                    .IsUnique();

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Urllink)
                    .HasColumnName("URLLink")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblClassRequiredMediaTypes>(entity =>
            {
                entity.HasKey(e => e.MediaId);

                entity.ToTable("tblClassRequiredMediaTypes");

                entity.HasIndex(e => new { e.ClassId, e.MediaTypeId })
                    .HasName("Unique_ClassId_MediaTypeId")
                    .IsUnique();

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.TblClassRequiredMediaTypes)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassRequiredMediaTypes_tblClassMediaTypes");
            });

            modelBuilder.Entity<TblClassSubjectAreas>(entity =>
            {
                entity.HasKey(e => e.SubjectAreaId);

                entity.ToTable("tblClassSubjectAreas");

                entity.HasIndex(e => e.SubjectAreaId)
                    .HasName("Unique_SubjectAreaDesc")
                    .IsUnique();

                entity.Property(e => e.LongDesc).HasColumnType("text");

                entity.Property(e => e.SubjectAreaDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassTestCredits>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tblClassTestCredits");

                entity.HasIndex(e => new { e.ClassTestId, e.CreditTypeCode })
                    .HasName("UniqueTestId_CreditType")
                    .IsUnique();

                entity.Property(e => e.CreditTypeCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClassTest)
                    .WithMany(p => p.TblClassTestCredits)
                    .HasForeignKey(d => d.ClassTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestCredits_tblClassTests");
            });

            modelBuilder.Entity<TblClassTestOrder>(entity =>
            {
                entity.HasKey(e => e.TestOrderId);

                entity.ToTable("tblClassTestOrder");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateCertificatePrinted).HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.DateTestEvaluationCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DiscountReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MailInPrintDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OtherFeesDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefundReason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.TestOrderDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClassTest)
                    .WithMany(p => p.TblClassTestOrder)
                    .HasForeignKey(d => d.ClassTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestOrder_tblClassTests");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.TblClassTestOrder)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestOrder_tblClassParticipation");
            });

            modelBuilder.Entity<TblClassTestOrderPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("tblClassTestOrderPayments");

                entity.Property(e => e.Approval)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Pnref)
                    .HasColumnName("PNREF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.TestOrder)
                    .WithMany(p => p.TblClassTestOrderPayments)
                    .HasForeignKey(d => d.TestOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestOrderPayments_tblClassTestOrder");
            });

            modelBuilder.Entity<TblClassTestOrderResponses>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .HasName("PK_tblClassTestResponses");

                entity.ToTable("tblClassTestOrderResponses");

                entity.HasIndex(e => e.ResponseId)
                    .HasName("Unique_TestOrderId_TestQuestionId")
                    .IsUnique();

                entity.HasIndex(e => new { e.TestOrderId, e.TestQuestionId })
                    .HasName("UniqueOrderId_TestQuestionId")
                    .IsUnique();

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedAnswer).HasColumnType("text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TestOrder)
                    .WithMany(p => p.TblClassTestOrderResponses)
                    .HasForeignKey(d => d.TestOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestOrderResponses_tblClassTestOrder");

                entity.HasOne(d => d.TestQuestion)
                    .WithMany(p => p.TblClassTestOrderResponses)
                    .HasForeignKey(d => d.TestQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestOrderResponses_tblClassTestQuestions");
            });

            modelBuilder.Entity<TblClassTestQuestions>(entity =>
            {
                entity.HasKey(e => e.TestQuestionId);

                entity.ToTable("tblClassTestQuestions");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionAnswer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ThumbnailUrl)
                    .HasColumnName("ThumbnailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblClassTestQuestions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblClassTestQuestions_tblClassQuestionCategory");

                entity.HasOne(d => d.ClassTest)
                    .WithMany(p => p.TblClassTestQuestions)
                    .HasForeignKey(d => d.ClassTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestQuestions_tblClassTests");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblClassTestQuestions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_tblClassTestQuestions_tblClassQuestionDisplayType");
            });

            modelBuilder.Entity<TblClassTestQuestionsItems>(entity =>
            {
                entity.HasKey(e => e.QuestionItemId);

                entity.ToTable("tblClassTestQuestionsItems");

                entity.HasIndex(e => new { e.TestQuestionId, e.ItemDisplay })
                    .HasName("Unique_TestQuestionID_ItemDisplay")
                    .IsUnique();

                entity.HasIndex(e => new { e.TestQuestionId, e.ItemValue })
                    .HasName("Unique_TestQuestionId_ItemValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.TestQuestionId, e.QuestionItemText })
                    .HasName("Unique_TestQuestionId_QuestionItemText")
                    .IsUnique();

                entity.Property(e => e.ItemComment).HasColumnType("text");

                entity.Property(e => e.ItemDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionItemText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TestQuestion)
                    .WithMany(p => p.TblClassTestQuestionsItems)
                    .HasForeignKey(d => d.TestQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClassTestQuestionsItems_tblClassTestQuestions");
            });

            modelBuilder.Entity<TblClassTests>(entity =>
            {
                entity.HasKey(e => e.ClassTestId);

                entity.ToTable("tblClassTests");

                entity.HasIndex(e => new { e.ClassId, e.TestDescription })
                    .HasName("Unique_ClassId_TestDesc")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.MailinInstructions).HasColumnType("text");

                entity.Property(e => e.PreTestInstructions).HasColumnType("text");

                entity.Property(e => e.PreTestMailinInstructions).HasColumnType("text");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TestLongDesc).HasColumnType("text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblClassTopics>(entity =>
            {
                entity.HasKey(e => e.TopicId);

                entity.ToTable("tblClassTopics");

                entity.HasIndex(e => new { e.ClassId, e.TopicDesc })
                    .HasName("Unique_ClassId_TopicDesc")
                    .IsUnique();

                entity.Property(e => e.TopicDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TopicLongDesc).HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCommentStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode)
                    .HasName("aaaaatblCommentStatus_PK")
                    .IsClustered(false);

                entity.ToTable("tblCommentStatus");

                entity.HasIndex(e => e.Status)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCommitteeCodes>(entity =>
            {
                entity.HasKey(e => e.CommitteeCode)
                    .HasName("aaaaatblCommitteeCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblCommitteeCodes");

                entity.HasIndex(e => e.CommitteeDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.CommitteeCode).HasColumnName("Committee Code");

                entity.Property(e => e.CommitteeDescription)
                    .IsRequired()
                    .HasColumnName("Committee Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InceptDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCommitteeMembership>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.CommitteeCode, e.EffectiveDate })
                    .HasName("aaaaatblCommitteeMembership_PK")
                    .IsClustered(false);

                entity.ToTable("tblCommitteeMembership");

                entity.HasIndex(e => e.CommitteeCode)
                    .HasName("Committee Code");

                entity.HasIndex(e => e.EffectiveDate)
                    .HasName("Effective Date");

                entity.HasIndex(e => e.PersonAddressId)
                    .HasName("PersonAddressID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.HasIndex(e => e.PositionCode)
                    .HasName("Position Code");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.CommitteeCode).HasColumnName("Committee Code");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonAddressId).HasColumnName("PersonAddressID");

                entity.Property(e => e.PositionCode).HasColumnName("Position Code");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CommitteeCodeNavigation)
                    .WithMany(p => p.TblCommitteeMembership)
                    .HasForeignKey(d => d.CommitteeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCommitteeMembership_FK00");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblCommitteeMembership)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCommitteeMembership_FK01");

                entity.HasOne(d => d.PositionCodeNavigation)
                    .WithMany(p => p.TblCommitteeMembership)
                    .HasForeignKey(d => d.PositionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCommitteeMembership_FK02");
            });

            modelBuilder.Entity<TblCommitteePositionCodes>(entity =>
            {
                entity.HasKey(e => e.PositionCode)
                    .HasName("aaaaatblCommitteePositionCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblCommitteePositionCodes");

                entity.HasIndex(e => e.PositionDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.HasIndex(e => e.PositionOrder)
                    .HasName("Position Order");

                entity.Property(e => e.PositionCode).HasColumnName("Position Code");

                entity.Property(e => e.PositionDescription)
                    .IsRequired()
                    .HasColumnName("Position Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PositionOrder).HasColumnName("Position Order");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCompanies>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("aaaaatblCompanies_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanies");

                entity.HasIndex(e => e.AddressId)
                    .HasName("Address ID");

                entity.HasIndex(e => e.AlphaIndexName)
                    .HasName("AlphaIndexName");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("Company Name");

                entity.HasIndex(e => e.CompanyType)
                    .HasName("tblCompanyTypestblCompanies");

                entity.HasIndex(e => e.ParentCompanyId)
                    .HasName("Parent Company ID");

                entity.HasIndex(e => e.RefId)
                    .HasName("Ref Code");

                entity.HasIndex(e => e.RepId)
                    .HasName("Rep Id Code");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.AlphaIndexName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasColumnName("CompanyEMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyType).HasColumnName("Company Type");

                entity.Property(e => e.CorporateBilling)
                    .HasColumnName("Corporate Billing")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InternetDomain).HasColumnType("ntext");

                entity.Property(e => e.ParentCompanyId).HasColumnName("Parent Company ID");

                entity.Property(e => e.ParentName)
                    .HasColumnName("Parent Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompanyTypeNavigation)
                    .WithMany(p => p.TblCompanies)
                    .HasForeignKey(d => d.CompanyType)
                    .HasConstraintName("tblCompanies_FK01");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.TblCompanies)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("tblCompanies_FK00");
            });

            modelBuilder.Entity<TblCompanyAddresses>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("aaaaatblCompanyAddresses_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanyAddresses");

                entity.HasIndex(e => e.AddressType)
                    .HasName("tblAddressTypestblCompanyAddresses");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.CountryId)
                    .HasName("tblCountriestblCompanyAddresses");

                entity.HasIndex(e => e.State)
                    .HasName("tblStatestblCompanyAddresses");

                entity.HasIndex(e => e.Zip)
                    .HasName("Zip");

                entity.HasIndex(e => new { e.CompanyId, e.AddressType })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._800)
                    .HasColumnName("800 #")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressTypeNavigation)
                    .WithMany(p => p.TblCompanyAddresses)
                    .HasForeignKey(d => d.AddressType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCompanyAddresses_FK01");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblCompanyAddresses)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCompanyAddresses_FK00");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblCompanyAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("tblCompanyAddresses_FK02");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.TblCompanyAddresses)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("tblCompanyAddresses_FK03");
            });

            modelBuilder.Entity<TblCompanyDirectory>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("aaaaatblCompanyDirectory_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanyDirectory");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("tblCompaniestblCompanyDirectory")
                    .IsUnique();

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("Directory ID")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyDescription)
                    .HasColumnName("Company Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("Directory ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.TblCompanyDirectory)
                    .HasForeignKey<TblCompanyDirectory>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCompanyDirectory_FK00");
            });

            modelBuilder.Entity<TblCompanyEmails>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("aaaaatblCompanyEMails_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanyEMails");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.EmailType)
                    .HasName("tblEMailTypestblCompanyEMails");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMail Address")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.EmailType).HasColumnName("EMail Type");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblCompanyEmails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCompanyEMails_FK00");

                entity.HasOne(d => d.EmailTypeNavigation)
                    .WithMany(p => p.TblCompanyEmails)
                    .HasForeignKey(d => d.EmailType)
                    .HasConstraintName("tblCompanyEMails_FK01");
            });

            modelBuilder.Entity<TblCompanyTypes>(entity =>
            {
                entity.HasKey(e => e.CompanyTypeId)
                    .HasName("aaaaatblCompanyTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanyTypes");

                entity.HasIndex(e => e.CompanyTypeDesc)
                    .HasName("Company Type Desc")
                    .IsUnique();

                entity.Property(e => e.CompanyTypeId).HasColumnName("Company Type ID");

                entity.Property(e => e.CompanyTypeDesc)
                    .IsRequired()
                    .HasColumnName("Company Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCompanyVendor>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("aaaaatblCompanyVendor_PK")
                    .IsClustered(false);

                entity.ToTable("tblCompanyVendor");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("tblCompaniestblCompanyVendor")
                    .IsUnique();

                entity.HasIndex(e => e.TaxId)
                    .HasName("Tax ID");

                entity.HasIndex(e => e.VendorTypeId)
                    .HasName("Vendor Type ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Print1099Forms).HasColumnName("Print 1099 Forms");

                entity.Property(e => e.TaxId)
                    .HasColumnName("Tax ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");

                entity.HasOne(d => d.Company)
                    .WithOne(p => p.TblCompanyVendor)
                    .HasForeignKey<TblCompanyVendor>(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCompanyVendor_FK00");
            });

            modelBuilder.Entity<TblCongress>(entity =>
            {
                entity.HasKey(e => e.RepId)
                    .HasName("aaaaatblCongress_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongress");

                entity.HasIndex(e => e.BldgRoom)
                    .HasName("BldgRoom");

                entity.HasIndex(e => e.CongressState)
                    .HasName("CongressState");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("District ID");

                entity.HasIndex(e => e.FirstName)
                    .HasName("Company Name");

                entity.HasIndex(e => e.GovTypeCode)
                    .HasName("Gov_Type_Code");

                entity.HasIndex(e => e.LastName)
                    .HasName("LastName");

                entity.HasIndex(e => e.Party)
                    .HasName("{A62573A4-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.BldgRoom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CongressCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CongressState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CongressZip)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CongressionalAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CongressionalAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateElected).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("District ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMailAddress)
                    .HasColumnName("E-Mail Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GovTypeCode).HasColumnName("Gov_Type_Code");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.District)
                    .WithMany(p => p.TblCongress)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("tblCongress_FK00");

                entity.HasOne(d => d.GovTypeCodeNavigation)
                    .WithMany(p => p.TblCongress)
                    .HasForeignKey(d => d.GovTypeCode)
                    .HasConstraintName("tblCongress_FK01");

                entity.HasOne(d => d.PartyNavigation)
                    .WithMany(p => p.TblCongress)
                    .HasForeignKey(d => d.Party)
                    .HasConstraintName("tblCongress_FK02");
            });

            modelBuilder.Entity<TblCongressComments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("aaaaatblCongressComments_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongressComments");

                entity.HasIndex(e => e.CommentDate)
                    .HasName("CommentDate");

                entity.HasIndex(e => e.RepId)
                    .HasName("Project_ID");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_Code");

                entity.HasIndex(e => new { e.CommentDate, e.RepId })
                    .HasName("DateRep");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCongressCommitteeAssignments>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Committee })
                    .HasName("aaaaatblCongressCommitteeAssignments_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongressCommitteeAssignments");

                entity.HasIndex(e => e.Committee)
                    .HasName("tblCongressCommitteestblCongressCommitteeAssignments");

                entity.HasIndex(e => e.Position)
                    .HasName("Position");

                entity.HasIndex(e => e.RepId)
                    .HasName("tblCongresstblCongressCommitteeAssignments");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CommitteeNavigation)
                    .WithMany(p => p.TblCongressCommitteeAssignments)
                    .HasForeignKey(d => d.Committee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCongressCommitteeAssig_FK00");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.TblCongressCommitteeAssignments)
                    .HasForeignKey(d => d.RepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCongressCommitteeAssig_FK01");
            });

            modelBuilder.Entity<TblCongressCommittees>(entity =>
            {
                entity.HasKey(e => e.CommitteeId)
                    .HasName("aaaaatblCongressCommittees_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongressCommittees");

                entity.HasIndex(e => e.CommitteeName)
                    .HasName("CommitteeName")
                    .IsUnique();

                entity.Property(e => e.CommitteeId).HasColumnName("CommitteeID");

                entity.Property(e => e.CommitteeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommitteeName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCongressInterests>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.InterestCode })
                    .HasName("aaaaatblCongressInterests_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongressInterests");

                entity.HasIndex(e => e.InterestCode)
                    .HasName("tblInterestCodestblCongressInterests");

                entity.HasIndex(e => e.RepId)
                    .HasName("PersonID");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.InterestCode).HasColumnName("Interest Code");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.InterestCodeNavigation)
                    .WithMany(p => p.TblCongressInterests)
                    .HasForeignKey(d => d.InterestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCongressInterests_FK01");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.TblCongressInterests)
                    .HasForeignKey(d => d.RepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCongressInterests_FK00");
            });

            modelBuilder.Entity<TblCongressionalDistricts>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("aaaaatblCongressionalDistricts_PK")
                    .IsClustered(false);

                entity.ToTable("tblCongressionalDistricts");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("District ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistrictAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictFax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("District Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictPhone1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictPhone2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblContactMethodCodes>(entity =>
            {
                entity.HasKey(e => e.ContactMethodCode)
                    .HasName("aaaaatblContactMethodCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblContactMethodCodes");

                entity.HasIndex(e => e.ContactMethodDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.ContactMethodCode).HasColumnName("Contact Method Code");

                entity.Property(e => e.ContactMethodDescription)
                    .IsRequired()
                    .HasColumnName("Contact Method Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblContactTypeCodes>(entity =>
            {
                entity.HasKey(e => e.ContactTypeCode)
                    .HasName("aaaaatblContactTypeCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblContactTypeCodes");

                entity.HasIndex(e => e.ContactTypeDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.ContactTypeCode).HasColumnName("Contact Type Code");

                entity.Property(e => e.ContactTypeDescription)
                    .IsRequired()
                    .HasColumnName("Contact Type Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblContactTypes>(entity =>
            {
                entity.HasKey(e => e.ContactTypeId)
                    .HasName("aaaaatblContactTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblContactTypes");

                entity.HasIndex(e => e.ContactTypeDesc)
                    .HasName("IX_tblContactDesc")
                    .IsUnique();

                entity.Property(e => e.ContactTypeId).HasColumnName("Contact Type ID");

                entity.Property(e => e.ContactTypeDesc)
                    .IsRequired()
                    .HasColumnName("Contact Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblContacts>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("aaaaatblContacts_PK")
                    .IsClustered(false);

                entity.ToTable("tblContacts");

                entity.HasIndex(e => e.ContactDate)
                    .HasName("Contact Date");

                entity.HasIndex(e => e.ContactMethodCode)
                    .HasName("Contact Medium Code");

                entity.HasIndex(e => e.ContactTypeCode)
                    .HasName("tblContactTypeCodestblContacts");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Membership ID");

                entity.HasIndex(e => e.RepId)
                    .HasName("Rep ID");

                entity.HasIndex(e => e.StatusId)
                    .HasName("StatusID");

                entity.HasIndex(e => new { e.PersonId, e.MembershipId, e.ContactTypeCode, e.ContactDate })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.ContactId).HasColumnName("Contact ID");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Commitments).HasColumnType("ntext");

                entity.Property(e => e.ContactDate)
                    .HasColumnName("Contact Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactMethodCode).HasColumnName("Contact Method Code");

                entity.Property(e => e.ContactTypeCode).HasColumnName("Contact Type Code");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.MembershipRenewalContact).HasColumnName("Membership Renewal Contact?");

                entity.Property(e => e.NextContactDate).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContactMethodCodeNavigation)
                    .WithMany(p => p.TblContacts)
                    .HasForeignKey(d => d.ContactMethodCode)
                    .HasConstraintName("tblContacts_FK02");

                entity.HasOne(d => d.ContactTypeCodeNavigation)
                    .WithMany(p => p.TblContacts)
                    .HasForeignKey(d => d.ContactTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblContacts_FK03");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.TblContacts)
                    .HasForeignKey(d => d.MembershipId)
                    .HasConstraintName("tblContacts_FK00");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblContacts)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("tblContacts_FK01");
            });

            modelBuilder.Entity<TblCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("aaaaatblCountries_PK")
                    .IsClustered(false);

                entity.ToTable("tblCountries");

                entity.HasIndex(e => e.CountryName)
                    .HasName("IX_tblCountryName")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCreateRenewTokens>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("aaaaatblCreateRenewTokens_PK")
                    .IsClustered(false);

                entity.ToTable("tblCreateRenewTokens");

                entity.HasIndex(e => e.Position)
                    .HasName("NWaiting");

                entity.Property(e => e.TokenId).HasColumnName("Token ID");

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblCreditMemo>(entity =>
            {
                entity.HasKey(e => new { e.CreditMemoId, e.OrderId })
                    .HasName("aaaaatblCreditMemo_PK")
                    .IsClustered(false);

                entity.ToTable("tblCreditMemo");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderId");

                entity.Property(e => e.CreditMemoId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreditDate).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblCreditMemo)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCreditMemo_FK00");
            });

            modelBuilder.Entity<TblCreditMemoLines>(entity =>
            {
                entity.HasKey(e => new { e.CreditMemoId, e.ProductId, e.OrderId })
                    .HasName("aaaaatblCreditMemoLines_PK")
                    .IsClustered(false);

                entity.ToTable("tblCreditMemoLines");

                entity.HasIndex(e => e.CreditMemoId)
                    .HasName("RelIndex");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderId");

                entity.HasIndex(e => new { e.CreditMemoId, e.OrderId })
                    .HasName("{A6257392-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TblCreditMemo)
                    .WithMany(p => p.TblCreditMemoLines)
                    .HasForeignKey(d => new { d.CreditMemoId, d.OrderId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCreditMemoLines_FK00");
            });

            modelBuilder.Entity<TblCreditTypes>(entity =>
            {
                entity.HasKey(e => e.CreditTypeCode)
                    .HasName("aaaaatblCreditTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblCreditTypes");

                entity.HasIndex(e => e.CreditTypeDesc)
                    .HasName("Credit Type Desc")
                    .IsUnique();

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .IsRequired()
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeId)
                    .HasColumnName("Credit Type ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                var creditTypeBuilder = modelBuilder.Entity<TblCreditTypes>();
                creditTypeBuilder.Property(i => i.CreditTypeId).UseIdentityColumn();
                creditTypeBuilder.Property(i => i.CreditTypeId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);


            });

            modelBuilder.Entity<TblDefaultLetterSetup>(entity =>
            {
                entity.HasKey(e => e.LetterTypeId)
                    .HasName("aaaaatblDefaultLetterSetup_PK")
                    .IsClustered(false);

                entity.ToTable("tblDefaultLetterSetup");

                entity.Property(e => e.LetterTypeId)
                    .HasColumnName("Letter Type Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DefaultLetterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDefaultMeetings>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.MeetingCode })
                    .HasName("aaaaatblDefaultMeetings_PK")
                    .IsClustered(false);

                entity.ToTable("tblDefaultMeetings");

                entity.Property(e => e.UserName)
                    .HasColumnName("User Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDefaultRenewalLetterSetup>(entity =>
            {
                entity.HasKey(e => new { e.Reminder, e.MembershipGroup })
                    .HasName("aaaaatblDefaultRenewalLetterSetup_PK")
                    .IsClustered(false);

                entity.ToTable("tblDefaultRenewalLetterSetup");

                entity.HasIndex(e => e.MembershipGroup)
                    .HasName("Membership Group");

                entity.HasIndex(e => e.Reminder)
                    .HasName("Reminder Number From");

                entity.HasIndex(e => e.RenewalSetupId)
                    .HasName("Renewal Setup Id");

                entity.Property(e => e.MembershipGroup).HasColumnName("Membership Group");

                entity.Property(e => e.ChangeOfAddress).HasColumnName("Change of Address");

                entity.Property(e => e.FooterText)
                    .HasColumnName("Footer Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.HeaderText)
                    .HasColumnName("Header Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.RenewalSetupId)
                    .HasColumnName("Renewal Setup Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RenewalTypes).HasColumnName("Renewal Types");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .IsClustered(false);

                entity.ToTable("tblDepartments");

                entity.HasIndex(e => e.DepartmentDesc)
                    .HasName("IX_tblDepartmentDesc")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("Department  ID");

                entity.Property(e => e.DepartmentDesc)
                    .IsRequired()
                    .HasColumnName("Department Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDirectoryInfo>(entity =>
            {
                entity.HasKey(e => e.DirectoryId)
                    .HasName("aaaaatblDirectoryInfo_PK")
                    .IsClustered(false);

                entity.ToTable("tblDirectoryInfo");

                entity.Property(e => e.DirectoryId).HasColumnName("Directory ID");

                entity.Property(e => e.DirectoryDesc).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDupeContacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("tblDupeContacts");

                entity.HasIndex(e => e.ContactDate)
                    .HasName("Contact Date");

                entity.HasIndex(e => e.ContactMethodCode)
                    .HasName("Contact Medium Code");

                entity.HasIndex(e => e.ContactTypeCode)
                    .HasName("tblContactTypeCodestblDupeContacts");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Membership ID");

                entity.HasIndex(e => e.RepId)
                    .HasName("Rep ID");

                entity.HasIndex(e => e.StatusId)
                    .HasName("StatusID");

                entity.HasIndex(e => new { e.PersonId, e.MembershipId, e.ContactTypeCode, e.ContactDate })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.ContactId).HasColumnName("Contact ID");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Commitments).HasColumnType("ntext");

                entity.Property(e => e.ContactDate)
                    .HasColumnName("Contact Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactMethodCode).HasColumnName("Contact Method Code");

                entity.Property(e => e.ContactTypeCode).HasColumnName("Contact Type Code");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.MembershipRenewalContact).HasColumnName("Membership Renewal Contact?");

                entity.Property(e => e.NextContactDate).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDupeMbrPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("tblDupeMbrPayments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Approval)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalErrorMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateProcessed).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("smalldatetime");

                entity.Property(e => e.NameOnCard)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Pnref)
                    .HasColumnName("PNREF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDupeMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .IsClustered(false);

                entity.ToTable("tblDupeMembership");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_tblDupeMembership_CompanyID");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("IX_tblDupeMembership_MembershipTypeCode");

                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_tblDupeMembership_OrderId");

                entity.HasIndex(e => e.ParentMembershipId)
                    .HasName("IX_tblDupeMembership_ParentMembershipID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_tblDupeMembership_PersonID");

                entity.HasIndex(e => e.RefId)
                    .HasName("IX_tblDupeMembership_RefID");

                entity.HasIndex(e => e.RenewalInterval)
                    .HasName("IX_tblDupeMembership_RenewalInterval");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewalLetterSent)
                    .HasColumnName("Date Renewal Letter Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewed)
                    .HasColumnName("Date Renewed")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastRenewalLetterSent).HasColumnName("Last Renewal Letter Sent");

                entity.Property(e => e.MemberSince)
                    .HasColumnName("Member Since")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("Order Id");

                entity.Property(e => e.ParentMembershipId).HasColumnName("Parent Membership ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalInterval).HasColumnName("Renewal Interval");

                entity.Property(e => e.RenewalNoticeSent)
                    .HasColumnName("Renewal Notice Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDupeOrderLines>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.ToTable("tblDupeOrderLines");

                entity.HasIndex(e => e.OrderId)
                    .HasName("RelIndex");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDupeOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tblDupeOrders");

                entity.HasIndex(e => e.AssocMembershipId)
                    .HasName("AssocMembershipID");

                entity.HasIndex(e => e.BillToAddressId)
                    .HasName("BillToAddressID");

                entity.HasIndex(e => e.BillToCompanyId)
                    .HasName("BillToCompanyID");

                entity.HasIndex(e => e.BillToCountryId)
                    .HasName("BillToCountry ID");

                entity.HasIndex(e => e.BillToPersonId)
                    .HasName("BillToPersonID");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("MembershipID");

                entity.HasIndex(e => e.OrderType)
                    .HasName("OrderType");

                entity.HasIndex(e => e.ShipToCompanyId)
                    .HasName("ShipToCompanyID");

                entity.HasIndex(e => e.ShipToCountryId)
                    .HasName("ShipToCountry ID");

                entity.HasIndex(e => e.ShipToPersonId)
                    .HasName("ShipToPersonID");

                entity.HasIndex(e => e.ShiptoAddressId)
                    .HasName("ShiptoAddressID");

                entity.HasIndex(e => e.Source)
                    .HasName("Source");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.AssocMembershipId).HasColumnName("AssocMembershipID");

                entity.Property(e => e.BillToAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressId).HasColumnName("BillToAddressID");

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCompany)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCompanyId).HasColumnName("BillToCompanyID");

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountryId).HasColumnName("BillToCountry ID");

                entity.Property(e => e.BillToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToPersonId).HasColumnName("BillToPersonID");

                entity.Property(e => e.BillToState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePrinted).HasColumnType("datetime");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipBy).HasColumnType("datetime");

                entity.Property(e => e.ShipToAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCompany)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCompanyId).HasColumnName("ShipToCompanyID");

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountry ID");

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPersonId).HasColumnName("ShipToPersonID");

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddressId).HasColumnName("ShiptoAddressID");

                entity.Property(e => e.Terms)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDupeSubscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("aaaaatblDupeSubscriptions_PK")
                    .IsClustered(false);

                entity.ToTable("tblDupeSubscriptions");

                entity.HasIndex(e => e.AddressId)
                    .HasName("AddressID");

                entity.HasIndex(e => e.NumIssues)
                    .HasName("NumIssues");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ProductID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDupeTransactions>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("tblDupeTransactions");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("CompanyID");

                entity.HasIndex(e => e.CreditMemoId)
                    .HasName("CreditMemoId");

                entity.HasIndex(e => e.GlbatchId)
                    .HasName("GLBatchID");

                entity.HasIndex(e => e.GlcreditAccount)
                    .HasName("GLCreditAccount");

                entity.HasIndex(e => e.GlcreditReceipt)
                    .HasName("GLCreditReceipt");

                entity.HasIndex(e => e.GlcreditReceiptDeferred)
                    .HasName("GLCreditReceiptDeferred");

                entity.HasIndex(e => e.GldebitAccount)
                    .HasName("GLDebitAccount");

                entity.HasIndex(e => e.GldebitReceipt)
                    .HasName("GLDebitReceipt");

                entity.HasIndex(e => e.GldebitReceiptDeferred)
                    .HasName("GLDebitReceiptDeferred");

                entity.HasIndex(e => e.InVoiceTransId)
                    .HasName("InVoiceTransID");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("Membership ID");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ProductID");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.AuthorizationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CheckCreditCardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.GlbatchId).HasColumnName("GLBatchID");

                entity.Property(e => e.GlcreditAccount).HasColumnName("GLCreditAccount");

                entity.Property(e => e.GlcreditReceipt)
                    .HasColumnName("GLCreditReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditReceiptDeferred)
                    .HasColumnName("GLCreditReceiptDeferred")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitAccount).HasColumnName("GLDebitAccount");

                entity.Property(e => e.GldebitReceipt)
                    .HasColumnName("GLDebitReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitReceiptDeferred)
                    .HasColumnName("GLDebitReceiptDeferred")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InVoiceTransId).HasColumnName("InVoiceTransID");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.PostedToGl)
                    .HasColumnName("PostedToGL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TransAmount).HasColumnType("money");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEmailTypes>(entity =>
            {
                entity.HasKey(e => e.EmailTypeId)
                    .HasName("aaaaatblEMailTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblEMailTypes");

                entity.HasIndex(e => e.EmailTypeDesc)
                    .HasName("EMail Type Desc")
                    .IsUnique();

                entity.Property(e => e.EmailTypeId).HasColumnName("EMail Type ID");

                entity.Property(e => e.EmailTypeDesc)
                    .IsRequired()
                    .HasColumnName("EMail Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblErrataS0008Sql2005>(entity =>
            {
                entity.ToTable("tblErrata_S0008-SQL2005");

                entity.HasIndex(e => e.ErrorNumber)
                    .HasName("IX_tblErrata")
                    .IsUnique();

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("aaaaatblErrorLog_PK")
                    .IsClustered(false);

                entity.ToTable("tblErrorLog");

                entity.HasIndex(e => e.Category)
                    .HasName("Category");

                entity.HasIndex(e => e.SystemNumber)
                    .HasName("Number");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Procedure)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Process)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvalQuestionBank>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .IsClustered(false);

                entity.ToTable("tblEvalQuestionBank");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Question).HasColumnType("ntext");

                entity.Property(e => e.QuestionTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_tblEvalQuestionsd")
                    .IsClustered(false);

                entity.ToTable("tblEvalQuestions");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Question).HasColumnType("ntext");

                entity.Property(e => e.QuestionTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalResponse>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .IsClustered(false);

                entity.ToTable("tblEvalResponse");

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalResponseChoices>(entity =>
            {
                entity.HasKey(e => new { e.ResponseType, e.ChoiceNumber })
                    .IsClustered(false);

                entity.ToTable("tblEvalResponseChoices");

                entity.Property(e => e.ChoiceDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalResponseDtl>(entity =>
            {
                entity.HasKey(e => e.ResponseDetailId)
                    .IsClustered(false);

                entity.ToTable("tblEvalResponseDtl");

                entity.Property(e => e.ResponseDetailId).HasColumnName("ResponseDetailID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMemo).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalResponseEntry>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .IsClustered(false);

                entity.ToTable("tblEvalResponseEntry");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalResponseTypes>(entity =>
            {
                entity.HasKey(e => e.ResponseType)
                    .IsClustered(false);

                entity.ToTable("tblEvalResponseTypes");

                entity.Property(e => e.ChoiceDisplay).HasColumnType("ntext");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heading).HasColumnType("ntext");

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvalSections>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .IsClustered(false);

                entity.ToTable("tblEvalSections");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.SectionTitle).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvaluation>(entity =>
            {
                entity.HasKey(e => e.EvaluationId)
                    .HasName("PK_tblEvalulation");

                entity.ToTable("tblEvaluation");

                entity.HasIndex(e => e.EvaluationDescription)
                    .HasName("Unique_EvalDesc")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationLongDesc).HasColumnType("text");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.MailinInstructions).HasColumnType("text");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PreEvaluationInstructions).HasColumnType("text");

                entity.Property(e => e.PreEvaluationMailinInstructions).HasColumnType("text");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvaluationOrder>(entity =>
            {
                entity.HasKey(e => e.EvaluationOrderId);

                entity.ToTable("tblEvaluationOrder");

                entity.HasIndex(e => new { e.PersonId, e.EvaluationId })
                    .HasName("IX_tblEvaluationOrder_Unique")
                    .IsUnique();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.EvaluationOrderDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailInPrintDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.TblEvaluationOrder)
                    .HasForeignKey(d => d.EvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationOrder_tblEvaluation");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblEvaluationOrder)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationOrder_tblPeople");
            });

            modelBuilder.Entity<TblEvaluationOrderResponses>(entity =>
            {
                entity.HasKey(e => e.ResponseId);

                entity.ToTable("tblEvaluationOrderResponses");

                entity.HasIndex(e => new { e.EvaluationOrderId, e.EvaluationQuestionId })
                    .HasName("Unique_Evaluation_EvalOrderId_EvalQuestionId")
                    .IsUnique();

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedAnswer).HasColumnType("text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EvaluationOrder)
                    .WithMany(p => p.TblEvaluationOrderResponses)
                    .HasForeignKey(d => d.EvaluationOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationResponses_tblEvaluationOrder");
            });

            modelBuilder.Entity<TblEvaluationQuestionBank>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("tblEvaluationQuestionBank");

                entity.Property(e => e.BankSortOrder).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.QuestionAnswer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblEvaluationQuestionBank)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblEvaluationQuestionBank_tblEvaluationQuestionCategory");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblEvaluationQuestionBank)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_tblEvaluationQuestionBank_tblEvaluationQuestionDisplayType");
            });

            modelBuilder.Entity<TblEvaluationQuestionBankItems>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tblEvaluationQuestionBankItems");

                entity.HasIndex(e => new { e.QuestionId, e.ItemDisplay })
                    .HasName("Unique_Evaluation_QuestionId_ItemDisplay")
                    .IsUnique();

                entity.HasIndex(e => new { e.QuestionId, e.ItemValue })
                    .HasName("Unique_Evaluation_QuestionId_ItemValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.QuestionId, e.QuestionItemText })
                    .HasName("Unique_Evaluation_QuestionID_QuestionItemText")
                    .IsUnique();

                entity.Property(e => e.ItemDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionItemText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TblEvaluationQuestionBankItems)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationQuestionBankItems_tblEvaluationQuestionBank");
            });

            modelBuilder.Entity<TblEvaluationQuestionCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblEvaluationQuestionCategory");

                entity.HasIndex(e => e.CategoryDesc)
                    .HasName("Unique_Evaluation_Evaluation_CategoryDesc")
                    .IsUnique();

                entity.Property(e => e.CategoryDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvaluationQuestionDisplayType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tblEvaluationQuestionDisplayType");

                entity.HasIndex(e => e.TypeDesc)
                    .HasName("Unique_Evaluation_TypeDesc")
                    .IsUnique();

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblEvaluationQuestions>(entity =>
            {
                entity.HasKey(e => e.EvaluationQuestionId);

                entity.ToTable("tblEvaluationQuestions");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblEvaluationQuestions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblEvaluationQuestions_tblEvaluationQuestionCategory");

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.TblEvaluationQuestions)
                    .HasForeignKey(d => d.EvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationQuestions_tblEvaluation");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblEvaluationQuestions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_tblEvaluationQuestions_tblEvaluationQuestionDisplayType");
            });

            modelBuilder.Entity<TblEvaluationQuestionsItems>(entity =>
            {
                entity.HasKey(e => e.QuestionItemId);

                entity.ToTable("tblEvaluationQuestionsItems");

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.ItemDisplay })
                    .HasName("Unique_Evaluation_EvalQuestionId_ItemDisplay")
                    .IsUnique();

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.ItemValue })
                    .HasName("Unique_Evaluation_EvalQuestionId_ItemValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.EvaluationQuestionId, e.QuestionItemText })
                    .HasName("Unique_Evaluation_EvalQuestionID_ItemText")
                    .IsUnique();

                entity.Property(e => e.ItemComment).HasColumnType("text");

                entity.Property(e => e.ItemDisplay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionItemText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EvaluationQuestion)
                    .WithMany(p => p.TblEvaluationQuestionsItems)
                    .HasForeignKey(d => d.EvaluationQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEvaluationQuestionsItems_tblEvaluationQuestions");
            });

            modelBuilder.Entity<TblEvaluations>(entity =>
            {
                entity.HasKey(e => e.EvalId)
                    .IsClustered(false);

                entity.ToTable("tblEvaluations");

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblExhibitors>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MeetingCode })
                    .HasName("aaaaatblExhibitors_PK")
                    .IsClustered(false);

                entity.ToTable("tblExhibitors");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.NumberOfBooths)
                    .HasName("Number of Booths");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceDue).HasColumnName("Balance Due");

                entity.Property(e => e.BoothLoc1)
                    .HasColumnName("Booth Loc 1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc2)
                    .HasColumnName("Booth Loc 2")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc3)
                    .HasColumnName("Booth Loc 3")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc4)
                    .HasColumnName("Booth Loc 4")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostPerBooth).HasColumnName("Cost per Booth");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnName("Deposit Amount");

                entity.Property(e => e.DepositReceived)
                    .HasColumnName("Deposit Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhibitorId)
                    .HasColumnName("exhibitorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NumberOfBooths).HasColumnName("Number of Booths");

                entity.Property(e => e.PacketSent)
                    .HasColumnName("Packet Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Profile).HasColumnType("ntext");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SponsoredEvents)
                    .HasColumnName("Sponsored Events")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblExhibitors)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblExhibitors_FK00");

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblExhibitors)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblExhibitors_FK01");

                var exhibitorsBuilder = modelBuilder.Entity<TblExhibitors>();
                exhibitorsBuilder.Property(i => i.ExhibitorId).UseIdentityColumn();
                exhibitorsBuilder.Property(i => i.ExhibitorId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<TblExpenses>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("aaaaatblExpenses_PK")
                    .IsClustered(false);

                entity.ToTable("tblExpenses");

                entity.HasIndex(e => e.AmountPaid)
                    .HasName("Amount Paid");

                entity.HasIndex(e => e.BudgetCode)
                    .HasName("tblBudgetCodestblExpenses");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("tblServiceCodestblExpenses");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BudgetCodeNavigation)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.BudgetCode)
                    .HasConstraintName("tblExpenses_FK00");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("tblExpenses_FK01");
            });

            modelBuilder.Entity<TblFbItems>(entity =>
            {
                entity.HasKey(e => e.FbId)
                    .HasName("aaaaatblFbItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblFbItems");

                entity.HasIndex(e => e.FbDesc)
                    .HasName("Setup Description")
                    .IsUnique();

                entity.Property(e => e.FbId).HasColumnName("FB ID");

                entity.Property(e => e.FbDesc)
                    .IsRequired()
                    .HasColumnName("FB Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblGovernmentTypes>(entity =>
            {
                entity.HasKey(e => e.GovTypeCode)
                    .HasName("aaaaatblGovernmentTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblGovernmentTypes");

                entity.HasIndex(e => e.GovTypeDesc)
                    .HasName("Gov_Type_Desc")
                    .IsUnique();

                entity.Property(e => e.GovTypeCode).HasColumnName("Gov_Type_Code");

                entity.Property(e => e.GovTypeDesc)
                    .IsRequired()
                    .HasColumnName("Gov_Type_Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblGuaranteeTypes>(entity =>
            {
                entity.HasKey(e => e.GuaranteeTypeId)
                    .HasName("aaaaatblGuaranteeTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblGuaranteeTypes");

                entity.HasIndex(e => e.GuaranteeTypeDesc)
                    .HasName("IX_tblGuaranteeTypeDesc")
                    .IsUnique();

                entity.Property(e => e.GuaranteeTypeId).HasColumnName("Guarantee Type ID");

                entity.Property(e => e.GuaranteeTypeDesc)
                    .IsRequired()
                    .HasColumnName("Guarantee Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblGuestReg>(entity =>
            {
                entity.HasKey(e => e.GuestRegId)
                    .HasName("aaaaatblGuestReg1_PK")
                    .IsClustered(false);

                entity.ToTable("tblGuestReg");

                entity.HasIndex(e => e.GuestPersonId)
                    .HasName("Guest Person ID");

                entity.HasIndex(e => e.GuestType)
                    .HasName("tblGuestTypestblGuestReg");

                entity.HasIndex(e => e.LastName)
                    .HasName("Last Name");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.HasIndex(e => e.RegDate)
                    .HasName("Reg Date");

                entity.HasIndex(e => e.RegId)
                    .HasName("Primary Reg ID");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestPersonId).HasColumnName("Guest Person ID");

                entity.Property(e => e.GuestType).HasColumnName("Guest Type");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.TblGuestReg)
                    .HasForeignKey(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblGuestReg_FK00");
            });

            modelBuilder.Entity<TblGuestTypes>(entity =>
            {
                entity.HasKey(e => e.GuestTypeId)
                    .HasName("aaaaatblGuestTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblGuestTypes");

                entity.HasIndex(e => e.GuestTypeDesc)
                    .HasName("IX_tblGuestTypeDesc")
                    .IsUnique();

                entity.Property(e => e.GuestTypeId).HasColumnName("Guest Type ID");

                entity.Property(e => e.GuestTypeDesc)
                    .IsRequired()
                    .HasColumnName("Guest Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblHotelContacts>(entity =>
            {
                entity.HasKey(e => new { e.HotelId, e.Contact })
                    .HasName("aaaaatblHotelContacts_PK")
                    .IsClustered(false);

                entity.ToTable("tblHotelContacts");

                entity.HasIndex(e => e.HotelId)
                    .HasName("tblHotelstblHotelContacts");

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.TblHotelContacts)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblHotelContacts_FK00");
            });

            modelBuilder.Entity<TblHotelCounts>(entity =>
            {
                entity.HasKey(e => new { e.HotelId, e.RoomType })
                    .HasName("aaaaatblHotelCounts_PK")
                    .IsClustered(false);

                entity.ToTable("tblHotelCounts");

                entity.Property(e => e.HotelId).HasColumnName("Hotel Id");

                entity.Property(e => e.RoomType)
                    .HasColumnName("Room Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblHotelRoomTypes>(entity =>
            {
                entity.HasKey(e => new { e.HotelId, e.RoomType, e.MeetingCode })
                    .HasName("aaaaatblHotelRoomTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblHotelRoomTypes");

                entity.HasIndex(e => e.GlCreditAccountCode)
                    .HasName("GL Credit Account Code");

                entity.HasIndex(e => e.GlDebitAccountCode)
                    .HasName("GL Debit Account Code");

                entity.HasIndex(e => e.GlcreditReceipt)
                    .HasName("GLCreditReceipt");

                entity.HasIndex(e => e.GldebitReceipt)
                    .HasName("GLDebitReceipt");

                entity.HasIndex(e => e.HotelId)
                    .HasName("tblHotelstblHotelRoomTypes");

                entity.HasIndex(e => e.NumAssigned)
                    .HasName("Num Assigned");

                entity.HasIndex(e => e.NumInBlock)
                    .HasName("Num In Block");

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.RoomType)
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlCreditAccountCode)
                    .HasColumnName("GL Credit Account Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlDebitAccountCode)
                    .HasColumnName("GL Debit Account Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditReceipt)
                    .HasColumnName("GLCreditReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitReceipt)
                    .HasColumnName("GLDebitReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumAssigned).HasColumnName("Num Assigned");

                entity.Property(e => e.NumInBlock).HasColumnName("Num In Block");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.TblHotelRoomTypes)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblHotelRoomTypes_FK00");

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblHotelRoomTypes)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblHotelRoomTypes_tblMeetings");
            });

            modelBuilder.Entity<TblHotelTypes>(entity =>
            {
                entity.HasKey(e => e.HotelTypeId)
                    .HasName("aaaaatblHotelTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblHotelTypes");

                entity.HasIndex(e => e.HotelTypeDesc)
                    .HasName("IX_tblHotelTypeDesc")
                    .IsUnique();

                entity.Property(e => e.HotelTypeId).HasColumnName("Hotel Type ID");

                entity.Property(e => e.HotelTypeDesc)
                    .IsRequired()
                    .HasColumnName("Hotel Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblHotels>(entity =>
            {
                entity.HasKey(e => e.HotelId)
                    .HasName("aaaaatblHotels_PK")
                    .IsClustered(false);

                entity.ToTable("tblHotels");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Country ID");

                entity.HasIndex(e => e.HotelName)
                    .HasName("Hotel Name");

                entity.HasIndex(e => e.HotelType)
                    .HasName("tblHotelTypestblHotels");

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HotelNotes)
                    .HasColumnName("Hotel Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelType).HasColumnName("Hotel Type");

                entity.Property(e => e.HotelUrl)
                    .HasColumnName("HotelURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.HotelTypeNavigation)
                    .WithMany(p => p.TblHotels)
                    .HasForeignKey(d => d.HotelType)
                    .HasConstraintName("tblHotels_FK00");
            });

            modelBuilder.Entity<TblHousing>(entity =>
            {
                entity.HasKey(e => e.AccomId)
                    .HasName("aaaaatblHousing1_PK")
                    .IsClustered(false);

                entity.ToTable("tblHousing");

                entity.HasIndex(e => e.ArrivalDate)
                    .HasName("Arrival Date");

                entity.HasIndex(e => e.ChargeType)
                    .HasName("tblChargeTypestblHousing");

                entity.HasIndex(e => e.DepartDate)
                    .HasName("Depart Date");

                entity.HasIndex(e => e.Guarantee)
                    .HasName("tblGuaranteeTypestblHousing");

                entity.HasIndex(e => e.HotelId)
                    .HasName("tblHotelstblHousing");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.HasIndex(e => new { e.HotelId, e.RoomType, e.MeetingCode })
                    .HasName("{A62573C3-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.AccomId).HasColumnName("Accom ID");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType).HasColumnName("Charge Type");

                entity.Property(e => e.DepartDate)
                    .HasColumnName("Depart Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisabledDesc)
                    .HasColumnName("Disabled Desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire Date")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name On Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonSmoking).HasColumnName("Non Smoking");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRequests)
                    .HasColumnName("Special Requests")
                    .HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.TblHousing)
                    .HasForeignKey(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblHousing_FK00");
            });

            modelBuilder.Entity<TblIncome>(entity =>
            {
                entity.HasKey(e => e.IncomeId)
                    .HasName("aaaaatblIncome_PK")
                    .IsClustered(false);

                entity.ToTable("tblIncome");

                entity.HasIndex(e => e.BudgetCode)
                    .HasName("tblBudgetCodestblIncome");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.Property(e => e.IncomeId).HasColumnName("Income ID");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhibitorBudget).HasColumnName("Exhibitor Budget");

                entity.Property(e => e.MeetingBudget).HasColumnName("Meeting Budget");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SystemGenerated).HasColumnName("System Generated");

                entity.Property(e => e.TotalActualAmount).HasColumnName("Total Actual Amount");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BudgetCodeNavigation)
                    .WithMany(p => p.TblIncome)
                    .HasForeignKey(d => d.BudgetCode)
                    .HasConstraintName("tblIncome_FK00");
            });

            modelBuilder.Entity<TblInfoCodes>(entity =>
            {
                entity.HasKey(e => e.InfoCode)
                    .HasName("aaaaatblInfoCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblInfoCodes");

                entity.HasIndex(e => e.InfoDescription)
                    .HasName("Info Description")
                    .IsUnique();

                entity.Property(e => e.InfoCode).HasColumnName("Info Code");

                entity.Property(e => e.InfoDescription)
                    .IsRequired()
                    .HasColumnName("Info Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblInfoRequestItems>(entity =>
            {
                entity.HasKey(e => new { e.InfoRequestId, e.InfoCode })
                    .HasName("aaaaatblInfoRequestItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblInfoRequestItems");

                entity.HasIndex(e => e.InfoCode)
                    .HasName("tblInfoCodestblInfoRequestItems");

                entity.HasIndex(e => e.InfoRequestId)
                    .HasName("Info Request ID");

                entity.Property(e => e.InfoRequestId).HasColumnName("Info Request ID");

                entity.Property(e => e.InfoCode).HasColumnName("Info Code");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.InfoCodeNavigation)
                    .WithMany(p => p.TblInfoRequestItems)
                    .HasForeignKey(d => d.InfoCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInfoRequestItems_FK01");

                entity.HasOne(d => d.InfoRequest)
                    .WithMany(p => p.TblInfoRequestItems)
                    .HasForeignKey(d => d.InfoRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInfoRequestItems_FK00");
            });

            modelBuilder.Entity<TblInformationRequests>(entity =>
            {
                entity.HasKey(e => e.InfoRequestId)
                    .HasName("aaaaatblInformationRequests_PK")
                    .IsClustered(false);

                entity.ToTable("tblInformationRequests");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.HasIndex(e => e.RepId)
                    .HasName("Rep ID");

                entity.HasIndex(e => new { e.PersonId, e.DateRequested })
                    .HasName("DupeCheck");

                entity.Property(e => e.InfoRequestId).HasColumnName("Info Request ID");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateFulfilled)
                    .HasColumnName("Date Fulfilled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRequested)
                    .HasColumnName("Date Requested")
                    .HasColumnType("datetime");

                entity.Property(e => e.LabelPrinted)
                    .HasColumnName("Label Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.NextContactDate)
                    .HasColumnName("Next Contact Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblInformationRequests)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInformationRequests_FK00");
            });

            modelBuilder.Entity<TblInterestCodes>(entity =>
            {
                entity.HasKey(e => e.InterestCode)
                    .HasName("aaaaatblInterestCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblInterestCodes");

                entity.HasIndex(e => e.InterestDescription)
                    .HasName("Interest Description")
                    .IsUnique();

                entity.Property(e => e.InterestCode).HasColumnName("Interest Code");

                entity.Property(e => e.InterestDescription)
                    .IsRequired()
                    .HasColumnName("Interest Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblInterests>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.InterestCode })
                    .HasName("aaaaatblInterests_PK")
                    .IsClustered(false);

                entity.ToTable("tblInterests");

                entity.HasIndex(e => e.InterestCode)
                    .HasName("tblInterestCodestblInterests");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.InterestCode).HasColumnName("Interest Code");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.InterestCodeNavigation)
                    .WithMany(p => p.TblInterests)
                    .HasForeignKey(d => d.InterestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInterests_FK01");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblInterests)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInterests_FK00");
            });

            modelBuilder.Entity<TblItinerary>(entity =>
            {
                entity.HasKey(e => e.ItineraryId)
                    .HasName("aaaaatblItinerary1_PK")
                    .IsClustered(false);

                entity.ToTable("tblItinerary");

                entity.HasIndex(e => e.Airline)
                    .HasName("Airline");

                entity.HasIndex(e => e.FlightDate)
                    .HasName("Flight Date");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.Property(e => e.ItineraryId).HasColumnName("Itinerary ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("Arrival Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelledBy)
                    .HasColumnName("Cancelled By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureTime)
                    .HasColumnName("Departure Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("Flight Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightNumber).HasColumnName("Flight Number");

                entity.Property(e => e.FromCity)
                    .HasColumnName("From City")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.ServiceClass)
                    .HasColumnName("Service Class")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ToCity)
                    .HasColumnName("To City")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.TblItinerary)
                    .HasForeignKey(d => d.RegId)
                    .HasConstraintName("tblItinerary_FK00");
            });

            modelBuilder.Entity<TblLegislation>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("aaaaatblLegislation_PK")
                    .IsClustered(false);

                entity.ToTable("tblLegislation");

                entity.Property(e => e.BillId).HasColumnName("Bill ID");

                entity.Property(e => e.BillDescription)
                    .HasColumnName("Bill Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.BillTitle)
                    .HasColumnName("Bill Title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateVoted).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblLetterSetup>(entity =>
            {
                entity.HasKey(e => new { e.LetterTypeId, e.DupeCheck })
                    .HasName("aaaaatblLetterSetup_PK")
                    .IsClustered(false);

                entity.ToTable("tblLetterSetup");

                entity.HasIndex(e => e.DupeCheck)
                    .HasName("DupeCheck");

                entity.HasIndex(e => e.LetterNoteId)
                    .HasName("LetterNoteId");

                entity.HasIndex(e => e.LetterTypeId)
                    .HasName("Letter Type Id");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.DupeCheck)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DefaultLetterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNoteId).ValueGeneratedOnAdd();

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblLetterSetup)
                    .HasForeignKey(d => d.MeetingCode)
                    .HasConstraintName("tblLetterSetup_FK00");
            });

            modelBuilder.Entity<TblListMembers>(entity =>
            {
                entity.HasKey(e => new { e.ListCode, e.PersonId, e.PersonAddressId })
                    .HasName("aaaaatblListMembers_PK")
                    .IsClustered(false);

                entity.ToTable("tblListMembers");

                entity.HasIndex(e => e.ListCode)
                    .HasName("tblListstblListMembers");

                entity.HasIndex(e => e.PersonAddressId)
                    .HasName("PersonAddressID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.Property(e => e.ListCode)
                    .HasColumnName("List Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.PersonAddressId).HasColumnName("Person Address ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ListCodeNavigation)
                    .WithMany(p => p.TblListMembers)
                    .HasForeignKey(d => d.ListCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblListMembers_FK02");

                entity.HasOne(d => d.PersonAddress)
                    .WithMany(p => p.TblListMembers)
                    .HasForeignKey(d => d.PersonAddressId)
                    .HasConstraintName("tblListMembers_FK01");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblListMembers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblListMembers_FK00");
            });

            modelBuilder.Entity<TblLists>(entity =>
            {
                entity.HasKey(e => e.ListCode)
                    .HasName("aaaaatblLists_PK")
                    .IsClustered(false);

                entity.ToTable("tblLists");

                entity.HasIndex(e => e.ParentList)
                    .HasName("Parent List");

                entity.Property(e => e.ListCode)
                    .HasColumnName("List Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListDescription)
                    .HasColumnName("List Description")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("listId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("List Name")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ParentList)
                    .HasColumnName("Parent List")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                var listsBuilder = modelBuilder.Entity<TblLists>();
                listsBuilder.Property(i => i.ListId).UseIdentityColumn();
                listsBuilder.Property(i => i.ListId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<TblMbrPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("tblMbrPayments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Approval)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalErrorMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateProcessed).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("smalldatetime");

                entity.Property(e => e.NameOnCard)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Pnref)
                    .HasColumnName("PNREF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMeetingCredits>(entity =>
            {
                entity.HasKey(e => new { e.MeetingCode, e.CreditTypeCode })
                    .HasName("aaaaatblMeetingCredits_PK")
                    .IsClustered(false);

                entity.ToTable("tblMeetingCredits");

                entity.HasIndex(e => e.CreditTypeCode)
                    .HasName("tblCreditTypestblMeetingCredits");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("{A625736C-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CreditTypeCodeNavigation)
                    .WithMany(p => p.TblMeetingCredits)
                    .HasForeignKey(d => d.CreditTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblMeetingCredits_FK01");

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblMeetingCredits)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblMeetingCredits_FK00");
            });

            modelBuilder.Entity<TblMeetingCreditsHist>(entity =>
            {
                entity.HasKey(e => new { e.MeetingCode, e.CreditTypeCode })
                    .HasName("aaaaatblMeetingCreditsHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblMeetingCreditsHist");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMeetingTasks>(entity =>
            {
                entity.HasKey(e => e.MeetingTaskId)
                    .IsClustered(false);

                entity.ToTable("tblMeetingTasks");

                entity.Property(e => e.MeetingTaskId).HasColumnName("MeetingTaskID");

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDue)
                    .HasColumnName("Date Due")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaysOut).HasColumnName("Days Out");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Task).HasColumnType("ntext");

                entity.Property(e => e.TemplateId).HasColumnName("Template ID");

                entity.Property(e => e.TimeCompleted)
                    .HasColumnName("Time Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeDue)
                    .HasColumnName("Time Due")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMeetings>(entity =>
            {
                entity.HasKey(e => e.MeetingCode)
                    .HasName("aaaaatblMeetings_PK")
                    .IsClustered(false);

                entity.ToTable("tblMeetings");

                entity.HasIndex(e => e.DefaultRegistrationCode)
                    .HasName("Default Registration Code");

                entity.HasIndex(e => e.ExhBudgetCode)
                    .HasName("Exh Budget Code");

                entity.HasIndex(e => e.NumberAttending)
                    .HasName("Number Attending");

                entity.HasIndex(e => e.RegTypeBudgetCode)
                    .HasName("RegType Budget Code");

                entity.HasIndex(e => e.SessionBudgetCode)
                    .HasName("Budget Code");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtrakMeetingImage)
                    .HasColumnName("etrakMeetingImage")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Gmtoffset).HasColumnName("GMTOffset");

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDetailUrl)
                    .HasColumnName("MeetingDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meetingId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MeetingInstructions).HasColumnType("ntext");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingSubjectAreaId).HasComment("Classroom Management");

                entity.Property(e => e.MeetingTypeId).HasComment("Classroom Management");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMeetingsHist>(entity =>
            {
                entity.HasKey(e => e.MeetingCode)
                    .HasName("aaaaatblMeetingsHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblMeetingsHist");

                entity.HasIndex(e => e.DefaultRegistrationCode)
                    .HasName("Default Registration Code");

                entity.HasIndex(e => e.NumberAttending)
                    .HasName("Number Attending");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .HasName("aaaaatblMembership_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembership");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.LastRenewalLetterSent)
                    .HasName("Last Renewal Letter Sent");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("tblMembershipTypeCodestblMembership");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order Id");

                entity.HasIndex(e => e.ParentMembershipId)
                    .HasName("Parent Membership ID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.HasIndex(e => e.RefId)
                    .HasName("Ref ID");

                entity.HasIndex(e => e.RenewalInterval)
                    .HasName("RenewalTypeCode");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewalLetterSent)
                    .HasColumnName("Date Renewal Letter Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewed)
                    .HasColumnName("Date Renewed")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastRenewalLetterSent).HasColumnName("Last Renewal Letter Sent");

                entity.Property(e => e.MemberSince)
                    .HasColumnName("Member Since")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("Order Id");

                entity.Property(e => e.ParentMembershipId).HasColumnName("Parent Membership ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalInterval).HasColumnName("Renewal Interval");

                entity.Property(e => e.RenewalNoticeSent)
                    .HasColumnName("Renewal Notice Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMembership)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("tblMembership_FK00");

                entity.HasOne(d => d.MembershipTypeCodeNavigation)
                    .WithMany(p => p.TblMembership)
                    .HasForeignKey(d => d.MembershipTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblMembership_FK01");
            });

            modelBuilder.Entity<TblMembershipDirectory>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .HasName("aaaaatblMembershipDirectory_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipDirectory");

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("Directory ID")
                    .IsUnique();

                entity.Property(e => e.MembershipId)
                    .HasColumnName("Membership ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("Directory ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MembershipDesc).HasColumnType("ntext");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMembershipHistory>(entity =>
            {
                entity.HasKey(e => e.MembHistId)
                    .HasName("aaaaatblMembershipHistory_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipHistory");

                entity.HasIndex(e => e.AmountPaid)
                    .HasName("AmountPaid");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.LastRenewalLetterSent)
                    .HasName("Last Renewal Letter Sent");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("Membership ID");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("MembershipTypeCode");

                entity.HasIndex(e => e.ParentMembershipId)
                    .HasName("ParentMembershipID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.Property(e => e.MembHistId).HasColumnName("MembHist ID");

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewalLetterSent)
                    .HasColumnName("Date Renewal Letter Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastRenewalLetterSent).HasColumnName("Last Renewal Letter Sent");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.ParentMembershipId).HasColumnName("ParentMembershipID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.TotalDue).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMembershipList>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.MembershipTypeCode })
                    .HasName("aaaaatblMembershipList_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipList");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMembershipOrganizations>(entity =>
            {
                entity.HasKey(e => e.MembOrgId)
                    .HasName("aaaaatblMembershipOrganizations_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipOrganizations");

                entity.HasIndex(e => e.MembOrgDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.MembOrgId).HasColumnName("MembOrgID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MembOrgDescription)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblMembershipProducts>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("aaaaatblMembershipProducts_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipProducts");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("MembershipTypeCode");

                entity.HasIndex(e => e.ProductId)
                    .HasName("tblProductstblMembershipProducts");

                entity.HasIndex(e => new { e.MembershipTypeCode, e.ProductId })
                    .HasName("tblMembershipTypeCodestblMembershipProducts")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MembershipTypeCodeNavigation)
                    .WithMany(p => p.TblMembershipProducts)
                    .HasForeignKey(d => d.MembershipTypeCode)
                    .HasConstraintName("tblMembershipProducts_FK00");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblMembershipProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("tblMembershipProducts_FK01");
            });

            modelBuilder.Entity<TblMembershipTypeCodes>(entity =>
            {
                entity.HasKey(e => e.MembershipTypeCode)
                    .HasName("aaaaatblMembershipTypeCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblMembershipTypeCodes");

                entity.HasIndex(e => new { e.MembershipTypeDescription, e.MembershipGroup })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.ComplimentaryAssociate).HasColumnName("Complimentary Associate");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipGroup).HasColumnName("Membership Group");

                entity.Property(e => e.MembershipTypeDescription)
                    .IsRequired()
                    .HasColumnName("Membership Type Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNamePrefixes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblNamePrefixes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Prefix).HasMaxLength(20);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblNews>(entity =>
            {
                entity.HasKey(e => e.NewsId)
                    .HasName("aaaaatblNews_PK")
                    .IsClustered(false);

                entity.ToTable("tblNews");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgDetail).HasColumnType("ntext");

                entity.Property(e => e.MsgHeader)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId)
                    .HasName("aaaaatblNotes_PK")
                    .IsClustered(false);

                entity.ToTable("tblNotes");

                entity.HasIndex(e => e.FollowUpDate)
                    .HasName("Follow Up Date");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.NoteDate)
                    .HasName("Note Date");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person Id");

                entity.HasIndex(e => e.PersonResponsible)
                    .HasName("Person Responsible");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg Id");

                entity.Property(e => e.NoteId).HasColumnName("Note ID");

                entity.Property(e => e.CompanyId).HasColumnName("companyId");

                entity.Property(e => e.CompletedBy)
                    .HasColumnName("Completed By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhibitorId).HasColumnName("exhibitorId");

                entity.Property(e => e.FollowUpDate)
                    .HasColumnName("Follow Up Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingId).HasColumnName("meetingId");

                entity.Property(e => e.NoteDate)
                    .HasColumnName("Note Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Topic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblOrderLines>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("aaaaatblOrderLines_PK")
                    .IsClustered(false);

                entity.ToTable("tblOrderLines");

                entity.HasIndex(e => e.OrderId)
                    .HasName("RelIndex");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderLines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrderLines_FK00");
            });

            modelBuilder.Entity<TblOrderTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblOrderTypes");

                entity.Property(e => e.OrderTypeDesc).HasMaxLength(50);

                entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("aaaaatblOrders_PK")
                    .IsClustered(false);

                entity.ToTable("tblOrders");

                entity.HasIndex(e => e.AssocMembershipId)
                    .HasName("AssocMembershipID");

                entity.HasIndex(e => e.BillToAddressId)
                    .HasName("BillToAddressID");

                entity.HasIndex(e => e.BillToCompanyId)
                    .HasName("BillToCompanyID");

                entity.HasIndex(e => e.BillToCountryId)
                    .HasName("BillToCountry ID");

                entity.HasIndex(e => e.BillToPersonId)
                    .HasName("BillToPersonID");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("MembershipID");

                entity.HasIndex(e => e.OrderType)
                    .HasName("OrderType");

                entity.HasIndex(e => e.ShipToCompanyId)
                    .HasName("ShipToCompanyID");

                entity.HasIndex(e => e.ShipToCountryId)
                    .HasName("ShipToCountry ID");

                entity.HasIndex(e => e.ShipToPersonId)
                    .HasName("ShipToPersonID");

                entity.HasIndex(e => e.ShiptoAddressId)
                    .HasName("ShiptoAddressID");

                entity.HasIndex(e => e.Source)
                    .HasName("Source");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.AssocMembershipId).HasColumnName("AssocMembershipID");

                entity.Property(e => e.BillToAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressId).HasColumnName("BillToAddressID");

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCompany)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCompanyId).HasColumnName("BillToCompanyID");

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountryId).HasColumnName("BillToCountry ID");

                entity.Property(e => e.BillToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToPersonId).HasColumnName("BillToPersonID");

                entity.Property(e => e.BillToState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePrinted).HasColumnType("datetime");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipBy).HasColumnType("datetime");

                entity.Property(e => e.ShipToAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCompany)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCompanyId).HasColumnName("ShipToCompanyID");

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountry ID");

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPersonId).HasColumnName("ShipToPersonID");

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddressId).HasColumnName("ShiptoAddressID");

                entity.Property(e => e.Terms)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPartyCodes>(entity =>
            {
                entity.HasKey(e => e.PartyId)
                    .HasName("aaaaatblPartyCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPartyCodes");

                entity.Property(e => e.PartyId).HasColumnName("PartyID");

                entity.Property(e => e.PartyDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartyName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPassword>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK_tblPasswords")
                    .IsClustered(false);

                entity.ToTable("tblPassword");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPaymentMethods>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId)
                    .HasName("aaaaatblPaymentMethods_PK")
                    .IsClustered(false);

                entity.ToTable("tblPaymentMethods");

                entity.HasIndex(e => e.PaymentMethodDesc)
                    .HasName("IX_tblPaymentMethods")
                    .IsUnique();

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method ID");

                entity.Property(e => e.CreditCard).HasColumnName("Credit Card");

                entity.Property(e => e.PaymentMethodDesc)
                    .IsRequired()
                    .HasColumnName("Payment Method Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPaymentNumFormats>(entity =>
            {
                entity.HasKey(e => new { e.PaymentTypeId, e.NumberLength })
                    .HasName("aaaaatblPaymentNumFormats_PK")
                    .IsClustered(false);

                entity.ToTable("tblPaymentNumFormats");

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment Type ID");

                entity.Property(e => e.NumberLength).HasColumnName("Number Length");

                entity.Property(e => e.FormatString)
                    .HasColumnName("Format String")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPaymentTypes>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId)
                    .HasName("aaaaatblPaymentTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPaymentTypes");

                entity.HasIndex(e => e.PaymentTypeDesc)
                    .HasName("Payment Type Desc")
                    .IsUnique();

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment Type ID");

                entity.Property(e => e.PaymentTypeDesc)
                    .IsRequired()
                    .HasColumnName("Payment Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("aaaaatblPayments1_PK")
                    .IsClustered(false);

                entity.ToTable("tblPayments");

                entity.HasIndex(e => e.DateProcessed)
                    .HasName("Date Processed");

                entity.HasIndex(e => e.Number)
                    .HasName("Number");

                entity.HasIndex(e => e.PaymentDate)
                    .HasName("Payment Date");

                entity.HasIndex(e => e.PaymentMethodId)
                    .HasName("Payment Method ID");

                entity.HasIndex(e => e.PaymentTypeId)
                    .HasName("Payment Type ID");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.HasIndex(e => e.WhoPaid)
                    .HasName("WhoPaid");

                entity.Property(e => e.PaymentId).HasColumnName("Payment ID");

                entity.Property(e => e.Approval)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateProcessed)
                    .HasColumnName("Date Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment Type ID");

                entity.Property(e => e.Pnref)
                    .HasColumnName("PNREF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.TblPayments)
                    .HasForeignKey(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPayments_FK00");
            });

            modelBuilder.Entity<TblPaymentsHist>(entity =>
            {
                entity.HasKey(e => new { e.HistId, e.PaymentId, e.RegId })
                    .HasName("aaaaatblPaymentsHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblPaymentsHist");

                entity.HasIndex(e => e.DateProcessed)
                    .HasName("Date Processed");

                entity.HasIndex(e => e.HistId)
                    .HasName("HistId");

                entity.HasIndex(e => e.Number)
                    .HasName("Number");

                entity.HasIndex(e => e.PaymentDate)
                    .HasName("Payment Date");

                entity.HasIndex(e => e.PaymentMethod)
                    .HasName("Payment Method ID");

                entity.HasIndex(e => e.PaymentType)
                    .HasName("Payment Type ID");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.HasIndex(e => new { e.HistId, e.RegId })
                    .HasName("{BF9040B0-E48D-11D3-B352-0000861D42C9}");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("Payment ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.Approval)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateProcessed)
                    .HasColumnName("Date Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("Payment Method")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TblRegHistory)
                    .WithMany(p => p.TblPaymentsHist)
                    .HasForeignKey(d => new { d.HistId, d.RegId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPaymentsHist_FK00");
            });

            modelBuilder.Entity<TblPaytrakConfig>(entity =>
            {
                entity.HasKey(e => e.Unique);

                entity.ToTable("tblPaytrakConfig");

                entity.Property(e => e.Unique).HasMaxLength(1);

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.SjAvsignore).HasColumnName("sjAVSIgnore");

                entity.Property(e => e.SjBatch).HasColumnName("sjBatch");

                entity.Property(e => e.SjDefaultPaymentType).HasColumnName("sjDefaultPaymentType");

                entity.Property(e => e.SjEnableCsc).HasColumnName("sjEnableCSC");

                entity.Property(e => e.SjProduction).HasColumnName("sjProduction");

                entity.Property(e => e.SjRequestFile)
                    .HasColumnName("sjRequestFile")
                    .HasMaxLength(255);

                entity.Property(e => e.SjResponseFile)
                    .HasColumnName("sjResponseFile")
                    .HasMaxLength(255);

                entity.Property(e => e.SjSerialNumber)
                    .HasColumnName("sjSerialNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.SjSsltransport).HasColumnName("sjSSLTransport");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VeriSignEnableCsc).HasColumnName("VeriSignEnableCSC");

                entity.Property(e => e.VeriSignEnableCsctest).HasColumnName("VeriSignEnableCSCTest");

                entity.Property(e => e.VeriSignEncryptCcinserts).HasColumnName("VeriSignEncryptCCInserts");

                entity.Property(e => e.VeriSignEncryptCcinsertsTest).HasColumnName("VeriSignEncryptCCInsertsTest");

                entity.Property(e => e.VeriSignHostAddress).HasMaxLength(100);

                entity.Property(e => e.VeriSignHostAddressTest).HasMaxLength(100);

                entity.Property(e => e.VeriSignLogFile).HasMaxLength(255);

                entity.Property(e => e.VeriSignPartner).HasMaxLength(100);

                entity.Property(e => e.VeriSignPartnerTest).HasMaxLength(100);

                entity.Property(e => e.VeriSignPassword).HasMaxLength(100);

                entity.Property(e => e.VeriSignPasswordTest).HasMaxLength(100);

                entity.Property(e => e.VeriSignUser).HasMaxLength(100);

                entity.Property(e => e.VeriSignUserTest).HasMaxLength(100);

                entity.Property(e => e.VeriSignVendor).HasMaxLength(100);

                entity.Property(e => e.VeriSignVendorTest).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyAddress).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyAddressTest).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyLogon).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyLogonTest).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyPassword).HasMaxLength(100);

                entity.Property(e => e.VerisignOptionalProxyPasswordTest).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPeople>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("aaaaatblPeople_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeople");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company Id");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("Company Name");

                entity.HasIndex(e => e.ContactType)
                    .HasName("tblContactTypestblPeople");

                entity.HasIndex(e => e.FirstName)
                    .HasName("First Name");

                entity.HasIndex(e => e.LastName)
                    .HasName("Last Name");

                entity.HasIndex(e => e.MailPref)
                    .HasName("CommunicationPreference");

                entity.HasIndex(e => e.PeopleType)
                    .HasName("tblPeopleTypestblPeople");

                entity.HasIndex(e => e.RefId)
                    .HasName("Ref ID");

                entity.HasIndex(e => e.SourceId)
                    .HasName("tblSourcestblPeople");

                entity.HasIndex(e => e.SpecialtyId)
                    .HasName("tblSpecialtiestblPeople");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.Advance).HasColumnType("datetime");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Basic).HasColumnType("datetime");

                entity.Property(e => e.Ccedate)
                    .HasColumnName("CCEDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ccmdate)
                    .HasColumnName("CCMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cedpdate)
                    .HasColumnName("CEDPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType).HasColumnName("Contact Type");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisclaimerExpDate)
                    .HasColumnType("datetime")
                    .HasComment("Classroom Management");

                entity.Property(e => e.Distinguished).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Faculty).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormalTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Icmreport)
                    .HasColumnName("ICMReport")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.JudgeId)
                    .HasColumnName("JudgeID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Outstanding).HasColumnType("datetime");

                entity.Property(e => e.Pager)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleSourceCode).HasColumnName("People Source Code");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SctNjc)
                    .HasColumnName("SCtNJC")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("Source ID");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("tblPeople_FK00");

                entity.HasOne(d => d.ContactTypeNavigation)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.ContactType)
                    .HasConstraintName("tblPeople_FK01");

                entity.HasOne(d => d.PeopleTypeNavigation)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.PeopleType)
                    .HasConstraintName("FK_tblPeople_tblPeopleTypes");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("tblPeople_FK03");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("tblPeople_FK04");
            });

            modelBuilder.Entity<TblPeopleAddresses>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("aaaaatblPeopleAddresses_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeopleAddresses");

                entity.HasIndex(e => e.AddressType)
                    .HasName("tblAddressTypestblPeopleAddresses");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company Address ID");

                entity.HasIndex(e => e.CountryId)
                    .HasName("tblCountriestblPeopleAddresses");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.HasIndex(e => e.State)
                    .HasName("tblStatestblPeopleAddresses");

                entity.HasIndex(e => e.Zip)
                    .HasName("Zip");

                entity.HasIndex(e => new { e.PersonId, e.AddressType })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressTypeNavigation)
                    .WithMany(p => p.TblPeopleAddresses)
                    .HasForeignKey(d => d.AddressType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPeopleAddresses_FK01");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblPeopleAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("tblPeopleAddresses_FK02");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblPeopleAddresses)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPeopleAddresses_FK00");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.TblPeopleAddresses)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("tblPeopleAddresses_FK03");
            });

            modelBuilder.Entity<TblPeopleCecredits>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("aaaaatblPeopleCECredits1_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeopleCECredits");

                entity.HasIndex(e => e.CreditDate)
                    .HasName("Credit Date");

                entity.HasIndex(e => e.CreditTypeCode)
                    .HasName("tblCreditTypestblPeopleCECredits");

                entity.HasIndex(e => e.DateCertificatePrinted)
                    .HasName("Date Certificate Printed");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => e.SortDate)
                    .HasName("Sort Date");

                entity.Property(e => e.KeyId).HasColumnName("Key ID");

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeId).HasColumnName("Credit Type ID");

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.DateCertificatePrinted)
                    .HasColumnName("Date Certificate Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SortDate)
                    .HasColumnName("Sort Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestOrderId).HasComment("Classroom Management");

                entity.Property(e => e.Title)
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPeopleCreditTypes>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.CreditTypeCode })
                    .HasName("aaaaatblPeopleCreditTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeopleCreditTypes");

                entity.HasIndex(e => e.CreditTypeCode)
                    .HasName("tblCreditTypestblPeopleCreditTypes");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CreditTypeCodeNavigation)
                    .WithMany(p => p.TblPeopleCreditTypes)
                    .HasForeignKey(d => d.CreditTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPeopleCreditTypes_FK00");
            });

            modelBuilder.Entity<TblPeopleEmails>(entity =>
            {
                //entity.HasKey(e => new { e.PersonId, e.EmailAddress })
                //    .IsClustered(false);

                entity.ToTable("tblPeopleEMails");

                entity.HasIndex(e => e.EmailType)
                    .HasName("tblEMailTypestblPeopleEMails");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMail Address")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.EmailType).HasColumnName("EMail Type");

                entity.HasOne(d => d.EmailTypeNavigation)
                    .WithMany(p => p.TblPeopleEmails)
                    .HasForeignKey(d => d.EmailType)
                    .HasConstraintName("tblPeopleEMails_FK01");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblPeopleEmails)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPeopleEMails_FK00");

                entity.Property(e => e.emailId)
                   .HasColumnName("emailID")
                   .ValueGeneratedOnAdd();

                entity.HasKey(e => e.emailId)
                .HasName("PK__tblPeopl__87355E524BB6DE91")
                .IsClustered(false);

                //var peopleEmailBuilder = modelBuilder.Entity<TblPeopleEmails>();
                //peopleEmailBuilder.Property(i => i.emailId).UseIdentityColumn();
                //peopleEmailBuilder.Property(i => i.emailId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<TblPeopleSourceCodes>(entity =>
            {
                entity.HasKey(e => e.PeopleSourceCode)
                    .HasName("aaaaatblPeopleSourceCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeopleSourceCodes");

                entity.HasIndex(e => e.PeopleSourceDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.PeopleSourceCode).HasColumnName("People Source Code");

                entity.Property(e => e.PeopleSourceDescription)
                    .IsRequired()
                    .HasColumnName("People Source Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPeopleTypes>(entity =>
            {
                entity.HasKey(e => e.PeopleTypeId)
                    .HasName("aaaaatblPeopleTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPeopleTypes");

                entity.HasIndex(e => e.PeopleTypeDesc)
                    .HasName("IX_tblPeopleTypes")
                    .IsUnique();

                entity.Property(e => e.PeopleTypeId).HasColumnName("People Type ID");

                entity.Property(e => e.PeopleTypeDesc)
                    .IsRequired()
                    .HasColumnName("People Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblPhoneTypes>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId)
                    .HasName("aaaaatblPhoneTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblPhoneTypes");

                entity.HasIndex(e => e.PhoneTypeDescription)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.PhoneTypeId).HasColumnName("Phone Type ID");

                entity.Property(e => e.PhoneTypeDescription)
                    .IsRequired()
                    .HasColumnName("Phone Type Description")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VoiceLine).HasColumnName("Voice Line");
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("aaaaatblProducts_PK")
                    .IsClustered(false);

                entity.ToTable("tblProducts");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                entity.HasIndex(e => e.GlcreditInvoice)
                    .HasName("GLCreditInvoice");

                entity.HasIndex(e => e.GlcreditReceipt)
                    .HasName("GLCreditReceipt");

                entity.HasIndex(e => e.GlcreditReceiptDeferred)
                    .HasName("GLCreditReceiptDeferred");

                entity.HasIndex(e => e.GldebitInvoice)
                    .HasName("GLDebitInvoice");

                entity.HasIndex(e => e.GldebitReceipt)
                    .HasName("GLDebitReceipt");

                entity.HasIndex(e => e.GldebitReceiptDeferred)
                    .HasName("GLDebitReceiptDeferred");

                entity.HasIndex(e => e.MembOrgId)
                    .HasName("MembOrgID");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("MembershipTypeCode");

                entity.HasIndex(e => e.NumIssues)
                    .HasName("NumIssues");

                entity.HasIndex(e => e.VendorId)
                    .HasName("VendorID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditInvoice)
                    .HasColumnName("GLCreditInvoice")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditReceipt)
                    .HasColumnName("GLCreditReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditReceiptDeferred)
                    .HasColumnName("GLCreditReceiptDeferred")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitInvoice)
                    .HasColumnName("GLDebitInvoice")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitReceipt)
                    .HasColumnName("GLDebitReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitReceiptDeferred)
                    .HasColumnName("GLDebitReceiptDeferred")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MembOrgId).HasColumnName("MembOrgID");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TblRegHistory>(entity =>
            {
                entity.HasKey(e => new { e.HistId, e.RegId })
                    .HasName("aaaaatblRegHistory_PK")
                    .IsClustered(false);

                entity.ToTable("tblRegHistory");

                entity.HasIndex(e => e.AddressId)
                    .HasName("Address Id");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("Company Name");

                entity.HasIndex(e => e.ConfirmationDate)
                    .HasName("Confirmation Date");

                entity.HasIndex(e => e.DateBadgePrinted)
                    .HasName("Name Badge Printed");

                entity.HasIndex(e => e.DateCancelled)
                    .HasName("Date Cancelled");

                entity.HasIndex(e => e.HistId)
                    .HasName("HistId");

                entity.HasIndex(e => e.LastName)
                    .HasName("Last Name");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person Id");

                entity.HasIndex(e => e.Phone)
                    .HasName("Phone");

                entity.HasIndex(e => e.PreOrOnSite)
                    .HasName("Pre or On-Site");

                entity.HasIndex(e => e.RegDate)
                    .HasName("Reg Date");

                entity.HasIndex(e => e.RegistrationCode)
                    .HasName("Registration Code");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.NamePrefix, e.PersonId, e.MeetingCode })
                    .HasName("Unique Reg")
                    .IsUnique();

                entity.Property(e => e.HistId).ValueGeneratedOnAdd();

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceDue).HasColumnName("Balance Due");

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFees).HasColumnName("Total Fees");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblRegHistory)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRegHistory_FK00");
            });

            modelBuilder.Entity<TblRegTypes>(entity =>
            {
                entity.HasKey(e => new { e.MeetingCode, e.RegCode })
                    .HasName("aaaaatblRegTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblRegTypes");

                entity.HasIndex(e => e.BudgetCode)
                    .HasName("Budget Code");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("tblMeetingstblRegTypes");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedRegCount).HasColumnName("Expected Reg Count");

                entity.Property(e => e.LateFeeDate)
                    .HasColumnName("Late Fee Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateRegFee).HasColumnName("Late Reg Fee");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationFee).HasColumnName("Registration Fee");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblRegTypes)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRegTypes_FK00");
            });

            modelBuilder.Entity<TblRegTypesHist>(entity =>
            {
                entity.HasKey(e => new { e.MeetingCode, e.RegCode })
                    .HasName("aaaaatblRegTypesHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblRegTypesHist");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.RegCode)
                    .HasName("Reg Code");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateFeeDate)
                    .HasColumnName("Late Fee Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateRegFee).HasColumnName("Late Reg Fee");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationFee).HasColumnName("Registration Fee");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblRegTypesHist)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRegTypesHist_FK00");
            });

            modelBuilder.Entity<TblRegistration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("aaaaatblRegistration1_PK")
                    .IsClustered(false);

                entity.ToTable("tblRegistration");

                entity.HasIndex(e => e.AddressId)
                    .HasName("Address Id");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("Company ID");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("Company Name");

                entity.HasIndex(e => e.ConfirmationDate)
                    .HasName("Confirmation Date");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Country ID");

                entity.HasIndex(e => e.DateBadgePrinted)
                    .HasName("Name Badge Printed");

                entity.HasIndex(e => e.DateCancelled)
                    .HasName("Date Cancelled");

                entity.HasIndex(e => e.LastName)
                    .HasName("Last Name");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("tblMeetingstblRegistration");

                entity.HasIndex(e => e.PeopleType)
                    .HasName("People Type");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person Id");

                entity.HasIndex(e => e.Phone)
                    .HasName("Phone");

                entity.HasIndex(e => e.PreOrOnSite)
                    .HasName("Pre or On-Site");

                entity.HasIndex(e => e.RegDate)
                    .HasName("Reg Date");

                entity.HasIndex(e => e.RegistrationCode)
                    .HasName("Registration Code");

                entity.HasIndex(e => e.Source)
                    .HasName("tblSourcestblRegistration");

                entity.HasIndex(e => e.SpecialtyId)
                    .HasName("Specialty ID");

                entity.HasIndex(e => e.Ssn)
                    .HasName("SSN");

                entity.HasIndex(e => new { e.MeetingCode, e.RegistrationCode })
                    .HasName("{A62573C6-0ABB-11D2-BC20-444553540000}");

                entity.HasIndex(e => new { e.Ssn, e.MeetingCode })
                    .HasName("UniqueKey");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendanceTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormalTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseFormalTitle).HasColumnName("Use Formal Title");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.TblRegTypes)
                    .WithMany(p => p.TblRegistration)
                    .HasForeignKey(d => new { d.MeetingCode, d.RegistrationCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRegistration_tblRegTypes");
            });

            modelBuilder.Entity<TblRenewalLetterSetup>(entity =>
            {
                entity.HasKey(e => new { e.MembershipTypeCode, e.Reminder })
                    .HasName("aaaaatblRenewalLetterSetup_PK")
                    .IsClustered(false);

                entity.ToTable("tblRenewalLetterSetup");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("Membership Type");

                entity.Property(e => e.ChangeOfAddress).HasColumnName("Change of Address");

                entity.Property(e => e.FooterText)
                    .HasColumnName("Footer Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.HeaderText)
                    .HasColumnName("Header Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.RenewalTypes).HasColumnName("Renewal Types");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MembershipTypeCodeNavigation)
                    .WithMany(p => p.TblRenewalLetterSetup)
                    .HasForeignKey(d => d.MembershipTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRenewalLetterSetup_FK00");
            });

            modelBuilder.Entity<TblRenewalTypes>(entity =>
            {
                entity.HasKey(e => new { e.MembershipTypeCode, e.RenewalTypeCode })
                    .HasName("aaaaatblRenewalTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblRenewalTypes");

                entity.HasIndex(e => e.MembershipTypeCode)
                    .HasName("MembershipTypeCode");

                entity.HasIndex(e => e.RenewalTypeCode)
                    .HasName("RenewalTypeCode");

                entity.Property(e => e.RenewalPrice).HasColumnType("money");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MembershipTypeCodeNavigation)
                    .WithMany(p => p.TblRenewalTypesMembershipTypeCodeNavigation)
                    .HasForeignKey(d => d.MembershipTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRenewalTypes_FK00");

                entity.HasOne(d => d.RenewalTypeCodeNavigation)
                    .WithMany(p => p.TblRenewalTypesRenewalTypeCodeNavigation)
                    .HasForeignKey(d => d.RenewalTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRenewalTypes_FK01");
            });

            modelBuilder.Entity<TblReports>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => e.ReportID)
                    .HasName("PK__tblRepor__D5BD48E5FC05183B")
                    .IsClustered(false);

                entity.ToTable("tblReports");

                entity.Property(e => e.ReportGroup).HasMaxLength(50);

                entity.Property(e => e.ReportLink).HasMaxLength(250);

                entity.Property(e => e.ReportName).HasMaxLength(150);

                //var reportBuilder = modelBuilder.Entity<TblReports>();
                //reportBuilder.Property(i => i.ReportID).UseSqlServerIdentityColumn();
                //reportBuilder.Property(i => i.ReportID).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<TblReps>(entity =>
            {
                entity.HasKey(e => e.RepId)
                    .HasName("aaaaatblReps_PK")
                    .IsClustered(false);

                entity.ToTable("tblReps");

                entity.HasIndex(e => new { e.RepFirstName, e.RepLastName })
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.RepFirstName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RepLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblRoomSetups>(entity =>
            {
                entity.HasKey(e => e.SetupId)
                    .HasName("aaaaatblRoomSetups_PK")
                    .IsClustered(false);

                entity.ToTable("tblRoomSetups");

                entity.HasIndex(e => e.SetupDesc)
                    .HasName("Setup Description")
                    .IsUnique();

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupDesc)
                    .IsRequired()
                    .HasColumnName("Setup Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblRoommates>(entity =>
            {
                entity.HasKey(e => e.RoommateId)
                    .HasName("aaaaatblRoommates1_PK")
                    .IsClustered(false);

                entity.ToTable("tblRoommates");

                entity.HasIndex(e => e.AccomId)
                    .HasName("Reg ID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("Person ID");

                entity.Property(e => e.RoommateId).HasColumnName("Roommate ID");

                entity.Property(e => e.AccomId).HasColumnName("Accom ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Accom)
                    .WithMany(p => p.TblRoommates)
                    .HasForeignKey(d => d.AccomId)
                    .HasConstraintName("tblRoommates_FK00");
            });

            modelBuilder.Entity<TblServiceCodes>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("aaaaatblServiceCodes_PK")
                    .IsClustered(false);

                entity.ToTable("tblServiceCodes");

                entity.HasIndex(e => e.ServiceCode)
                    .HasName("Service Code");

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDesc)
                    .HasColumnName("Service Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxA).HasColumnName("Tax A");

                entity.Property(e => e.TaxB).HasColumnName("Tax B");

                entity.Property(e => e.TaxC).HasColumnName("Tax C");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSessReg>(entity =>
            {
                entity.HasKey(e => e.SessRegId)
                    .HasName("aaaaatblSessReg_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessReg");

                entity.HasIndex(e => e.GuestRegId)
                    .HasName("Guest ID");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.PrimaryRegId)
                    .HasName("Primary Reg ID");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("{A62573B7-0ABB-11D2-BC20-444553540000}");

                entity.HasIndex(e => new { e.RegId, e.GuestRegId, e.SessionCode, e.MeetingCode })
                    .HasName("Unique Reg")
                    .IsUnique();

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.AttendanceTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TblSessions)
                    .WithMany(p => p.TblSessReg)
                    .HasForeignKey(d => new { d.SessionCode, d.MeetingCode })
                    .HasConstraintName("tblSessReg_FK01");
            });

            modelBuilder.Entity<TblSessRegHist>(entity =>
            {
                entity.HasKey(e => e.SessRegHistId)
                    .IsClustered(false);

                entity.ToTable("tblSessRegHist");

                entity.HasIndex(e => e.GuestRegId)
                    .HasName("Guest ID");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.PrimaryRegId)
                    .HasName("Primary Reg ID");

                entity.HasIndex(e => e.RegId)
                    .HasName("Reg ID");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("Unique Reg");

                entity.Property(e => e.SessRegHistId).HasColumnName("SessRegHistID");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.HistId).HasColumnName("HistID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSessionAvItems>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode, e.AvItemId })
                    .HasName("aaaaatblSessionAvItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionAvItems");

                entity.HasIndex(e => e.AvItemId)
                    .HasName("tblAvItemstblSessionAvItems");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.ProvidedBy)
                    .HasName("Provided By");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("{A6257365-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AvItemId).HasColumnName("AV Item ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AvItem)
                    .WithMany(p => p.TblSessionAvItems)
                    .HasForeignKey(d => d.AvItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionAvItems_FK01");

                entity.HasOne(d => d.TblSessions)
                    .WithMany(p => p.TblSessionAvItems)
                    .HasForeignKey(d => new { d.SessionCode, d.MeetingCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionAvItems_FK00");
            });

            modelBuilder.Entity<TblSessionCredits>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode, e.CreditTypeCode })
                    .HasName("aaaaatblSessionCredits_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionCredits");

                entity.HasIndex(e => e.CreditTypeCode)
                    .HasName("tblCreditTypestblSessionCredits");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("{A625736B-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CreditTypeCodeNavigation)
                    .WithMany(p => p.TblSessionCredits)
                    .HasForeignKey(d => d.CreditTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionCredits_FK01");

                entity.HasOne(d => d.TblSessions)
                    .WithMany(p => p.TblSessionCredits)
                    .HasForeignKey(d => new { d.SessionCode, d.MeetingCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionCredits_FK00");
            });

            modelBuilder.Entity<TblSessionCreditsHist>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode, e.CreditTypeCode })
                    .HasName("aaaaatblSessionCreditsHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionCreditsHist");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSessionDefaults>(entity =>
            {
                entity.HasKey(e => new { e.MeetingCode, e.RegCode, e.SessionCode })
                    .IsClustered(false);

                entity.ToTable("tblSessionDefaults");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSessionFbItems>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode, e.FbItemId })
                    .HasName("aaaaatblSessionFbItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionFbItems");

                entity.HasIndex(e => e.FbItemId)
                    .HasName("tblFbItemstblSessionFbItems");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("{A6257366-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FbItemId).HasColumnName("FB Item ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FbItem)
                    .WithMany(p => p.TblSessionFbItems)
                    .HasForeignKey(d => d.FbItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionFbItems_FK01");

                entity.HasOne(d => d.TblSessions)
                    .WithMany(p => p.TblSessionFbItems)
                    .HasForeignKey(d => new { d.SessionCode, d.MeetingCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionFbItems_FK00");
            });

            modelBuilder.Entity<TblSessionSetupItems>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode, e.SetupItemId })
                    .HasName("aaaaatblSessionSetupItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionSetupItems");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => e.SetupItemId)
                    .HasName("tblSetupItemstblSessionSetupItems");

                entity.HasIndex(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("{A62573BC-0ABB-11D2-BC20-444553540000}");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SetupItemId).HasColumnName("Setup Item ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.SetupItem)
                    .WithMany(p => p.TblSessionSetupItems)
                    .HasForeignKey(d => d.SetupItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionSetupItems_FK01");

                entity.HasOne(d => d.TblSessions)
                    .WithMany(p => p.TblSessionSetupItems)
                    .HasForeignKey(d => new { d.SessionCode, d.MeetingCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionSetupItems_FK00");
            });

            modelBuilder.Entity<TblSessionWaitList>(entity =>
            {
                entity.HasKey(e => e.WaitListId)
                    .IsClustered(false);

                entity.ToTable("tblSessionWaitList");

                entity.Property(e => e.WaitListId).HasColumnName("WaitListID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId).HasColumnName("PrimaryID");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAdded).HasColumnType("datetime");

                entity.Property(e => e.UpsiteTs)
                    .HasColumnName("upsite_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSessions>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("aaaaatblSessions_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessions");

                entity.HasIndex(e => e.BudgetCode)
                    .HasName("Budget Code");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("tblMeetingstblSessions");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => e.SetupId)
                    .HasName("tblRoomSetupstblSessions");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDetailUrl)
                    .HasColumnName("SessionDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblSessions)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessions_FK00");

                entity.HasOne(d => d.Setup)
                    .WithMany(p => p.TblSessions)
                    .HasForeignKey(d => d.SetupId)
                    .HasConstraintName("tblSessions_FK01");
            });

            modelBuilder.Entity<TblSessionsHist>(entity =>
            {
                entity.HasKey(e => new { e.SessionCode, e.MeetingCode })
                    .HasName("aaaaatblSessionsHist_PK")
                    .IsClustered(false);

                entity.ToTable("tblSessionsHist");

                entity.HasIndex(e => e.BudgetCode)
                    .HasName("Budget Code");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => e.SetupId)
                    .HasName("Setup ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MeetingCodeNavigation)
                    .WithMany(p => p.TblSessionsHist)
                    .HasForeignKey(d => d.MeetingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSessionsHist_FK00");
            });

            modelBuilder.Entity<TblSetupItems>(entity =>
            {
                entity.HasKey(e => e.SetupId)
                    .HasName("aaaaatblSetupItems_PK")
                    .IsClustered(false);

                entity.ToTable("tblSetupItems");

                entity.HasIndex(e => e.SetupDesc)
                    .HasName("Setup Description")
                    .IsUnique();

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupDesc)
                    .IsRequired()
                    .HasColumnName("Setup Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblShippingMethods>(entity =>
            {
                entity.HasKey(e => e.ShippingId)
                    .HasName("aaaaatblShippingMethods_PK")
                    .IsClustered(false);

                entity.ToTable("tblShippingMethods");

                entity.HasIndex(e => e.Description)
                    .HasName("Description")
                    .IsUnique();

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSources>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("aaaaatblSources_PK")
                    .IsClustered(false);

                entity.ToTable("tblSources");

                entity.HasIndex(e => e.SourceDesc)
                    .HasName("Source Desc")
                    .IsUnique();

                entity.Property(e => e.SourceId).HasColumnName("Source ID");

                entity.Property(e => e.SourceDate).HasColumnType("datetime");

                entity.Property(e => e.SourceDesc)
                    .IsRequired()
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSpeakerTypes>(entity =>
            {
                entity.HasKey(e => e.SpeakerTypeId)
                    .HasName("aaaaatblSpeakerTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblSpeakerTypes");

                entity.HasIndex(e => e.SpeakerTypeDesc)
                    .HasName("Speaker Type Desc")
                    .IsUnique();

                entity.Property(e => e.SpeakerTypeId).HasColumnName("Speaker Type Id");

                entity.Property(e => e.SpeakerTypeDesc)
                    .IsRequired()
                    .HasColumnName("Speaker Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSpeakers>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.MeetingCode, e.SessionCode })
                    .HasName("aaaaatblSpeakers_PK")
                    .IsClustered(false);

                entity.ToTable("tblSpeakers");

                entity.HasIndex(e => e.MeetingCode)
                    .HasName("Meeting Code");

                entity.HasIndex(e => e.NumberCopies)
                    .HasName("Number Copies");

                entity.HasIndex(e => e.PersonId)
                    .HasName("{A625739C-0ABB-11D2-BC20-444553540000}");

                entity.HasIndex(e => e.SessionCode)
                    .HasName("Session Code");

                entity.HasIndex(e => e.SpeakerType)
                    .HasName("tblSpeakerTypestblSpeakers");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AVNeeds)
                    .HasColumnName("A/V Needs")
                    .HasColumnType("ntext");

                entity.Property(e => e.AcceptanceReceived)
                    .HasColumnName("Acceptance Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCopies).HasColumnName("Number Copies");

                entity.Property(e => e.SpeakerType).HasColumnName("Speaker Type");

                entity.Property(e => e.SubjectArea)
                    .HasColumnName("Subject Area")
                    .HasColumnType("ntext");

                entity.Property(e => e.TitleOfTalk)
                    .HasColumnName("Title of Talk")
                    .HasColumnType("ntext");

                entity.Property(e => e.TravelAllowance).HasColumnName("Travel Allowance");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TblSpeakers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSpeakers_FK00");

                entity.HasOne(d => d.SpeakerTypeNavigation)
                    .WithMany(p => p.TblSpeakers)
                    .HasForeignKey(d => d.SpeakerType)
                    .HasConstraintName("tblSpeakers_FK02");
            });

            modelBuilder.Entity<TblSpecialties>(entity =>
            {
                entity.HasKey(e => e.SpecialtyId)
                    .HasName("aaaaatblSpecialties_PK")
                    .IsClustered(false);

                entity.ToTable("tblSpecialties");

                entity.HasIndex(e => e.Description)
                    .HasName("Description")
                    .IsUnique();

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblStates>(entity =>
            {
                entity.HasKey(e => e.StateCode)
                    .HasName("aaaaatblStates_PK")
                    .IsClustered(false);

                entity.ToTable("tblStates");

                entity.HasIndex(e => e.StateName)
                    .HasName("DupeCheck")
                    .IsUnique();

                entity.Property(e => e.StateCode)
                    .HasColumnName("State Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateId)
                    .HasColumnName("stateId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnName("State Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ZipFrom)
                    .HasColumnName("Zip From")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipTo)
                    .HasColumnName("Zip To")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                var statesBuilder = modelBuilder.Entity<TblStates>();
                statesBuilder.Property(i => i.StateId).UseIdentityColumn();
                statesBuilder.Property(i => i.StateId).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<TblSubscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("aaaaatblSubscriptions_PK")
                    .IsClustered(false);

                entity.ToTable("tblSubscriptions");

                entity.HasIndex(e => e.AddressId)
                    .HasName("AddressID");

                entity.HasIndex(e => e.NumIssues)
                    .HasName("NumIssues");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ProductID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblSubscriptions)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("tblSubscriptions_FK00");
            });

            modelBuilder.Entity<TblSystemDefaults>(entity =>
            {
                entity.HasKey(e => e.CompanyName)
                    .HasName("aaaaatblSystemDefaults_PK")
                    .IsClustered(false);

                entity.ToTable("tblSystemDefaults");

                entity.HasIndex(e => e.CtctdeveloperApiKey);

                entity.HasIndex(e => e.Ctctpassword);

                entity.HasIndex(e => e.CtctuserName);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AmexMerchNo)
                    .HasColumnName("AMEX Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualEnd)
                    .HasColumnName("Annual End")
                    .HasColumnType("datetime");

                entity.Property(e => e.AnnualStart)
                    .HasColumnName("Annual Start")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankAcctNo)
                    .HasColumnName("Bank Acct No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CetrakVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("cetrak");

                entity.Property(e => e.CtctapiUrl)
                    .HasColumnName("CTCTApiURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtctdeveloperApiKey)
                    .HasColumnName("CTCTDeveloperApiKey")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CtctloginUrl)
                    .HasColumnName("CTCTLoginURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ctctpassword)
                    .HasColumnName("CTCTPassword")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CtctuserName)
                    .HasColumnName("CTCTUserName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultEffectiveDate)
                    .HasColumnName("Default Effective Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultExpireDate)
                    .HasColumnName("Default Expire Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultPaymentMethod).HasColumnName("Default Payment Method");

                entity.Property(e => e.Department)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DinersClubMerchNo)
                    .HasColumnName("Diners Club Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscoverMerchNo)
                    .HasColumnName("Discover Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnableCetrak).HasComment("cetrak");

                entity.Property(e => e.GracePeriod).HasColumnName("Grace Period");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.MasterCardMerchNo)
                    .HasColumnName("MasterCard Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipCycle).HasColumnName("Membership Cycle");

                entity.Property(e => e.MembershipProcessing).HasColumnName("Membership Processing");

                entity.Property(e => e.ServerRefTablesUpdated).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VisaMerchNo)
                    .HasColumnName("VISA Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTasksTemplatesDtl>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .IsClustered(false);

                entity.ToTable("tblTasksTemplatesDtl");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DaysOut).HasColumnName("Days Out");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Task).HasColumnType("ntext");

                entity.Property(e => e.TemplateId).HasColumnName("Template ID");
            });

            modelBuilder.Entity<TblTasksTemplatesHdr>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .IsClustered(false);

                entity.ToTable("tblTasksTemplatesHdr");

                entity.Property(e => e.TemplateId).HasColumnName("Template ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransactions>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("aaaaatblTransactions_PK")
                    .IsClustered(false);

                entity.ToTable("tblTransactions");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("CompanyID");

                entity.HasIndex(e => e.CreditMemoId)
                    .HasName("CreditMemoId");

                entity.HasIndex(e => e.GlbatchId)
                    .HasName("GLBatchID");

                entity.HasIndex(e => e.GlcreditAccount)
                    .HasName("GLCreditAccount");

                entity.HasIndex(e => e.GlcreditReceipt)
                    .HasName("GLCreditReceipt");

                entity.HasIndex(e => e.GlcreditReceiptDeferred)
                    .HasName("GLCreditReceiptDeferred");

                entity.HasIndex(e => e.GldebitAccount)
                    .HasName("GLDebitAccount");

                entity.HasIndex(e => e.GldebitReceipt)
                    .HasName("GLDebitReceipt");

                entity.HasIndex(e => e.GldebitReceiptDeferred)
                    .HasName("GLDebitReceiptDeferred");

                entity.HasIndex(e => e.InVoiceTransId)
                    .HasName("InVoiceTransID");

                entity.HasIndex(e => e.MembershipId)
                    .HasName("Membership ID");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PersonID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ProductID");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.AuthorizationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CheckCreditCardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.GlbatchId).HasColumnName("GLBatchID");

                entity.Property(e => e.GlcreditAccount).HasColumnName("GLCreditAccount");

                entity.Property(e => e.GlcreditReceipt)
                    .HasColumnName("GLCreditReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GlcreditReceiptDeferred)
                    .HasColumnName("GLCreditReceiptDeferred")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitAccount).HasColumnName("GLDebitAccount");

                entity.Property(e => e.GldebitReceipt)
                    .HasColumnName("GLDebitReceipt")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GldebitReceiptDeferred)
                    .HasColumnName("GLDebitReceiptDeferred")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InVoiceTransId).HasColumnName("InVoiceTransID");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.PostedToGl)
                    .HasColumnName("PostedToGL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TransAmount).HasColumnType("money");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblUserDefaults>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("aaaaatblUserDefaults_PK")
                    .IsClustered(false);

                entity.ToTable("tblUserDefaults");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblUserFields>(entity =>
            {
                entity.HasKey(e => e.UserFieldId)
                    .IsClustered(false);

                entity.ToTable("tblUserFields");

                entity.Property(e => e.UserFieldId).HasColumnName("UserFieldID");

                entity.Property(e => e.Choices)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.FieldGroup)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LabelCaption)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorInvoices>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.InvoiceNumber })
                    .HasName("aaaaatblVendorInvoices_PK")
                    .IsClustered(false);

                entity.ToTable("tblVendorInvoices");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("CompanyID");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("Invoice");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.Terms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblVendorPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("aaaaatblVendorPayments_PK")
                    .IsClustered(false);

                entity.ToTable("tblVendorPayments");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("CompanyID");

                entity.HasIndex(e => e.PaymentTypeId)
                    .HasName("PaymentTypeID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblVendorTypes>(entity =>
            {
                entity.HasKey(e => e.VendorTypeId)
                    .HasName("aaaaatblVendorTypes_PK")
                    .IsClustered(false);

                entity.ToTable("tblVendorTypes");

                entity.HasIndex(e => e.Description)
                    .HasName("IX_tblVendorTypeDesc")
                    .IsUnique();

                entity.HasIndex(e => e.VendorType)
                    .HasName("VendorType");

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVotingRecord>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.BillId })
                    .HasName("aaaaatblVotingRecord_PK")
                    .IsClustered(false);

                entity.ToTable("tblVotingRecord");

                entity.HasIndex(e => e.BillId)
                    .HasName("Bill ID");

                entity.HasIndex(e => e.RepId)
                    .HasName("Rep ID");

                entity.HasIndex(e => e.Vote)
                    .HasName("Vote");

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.BillId).HasColumnName("Bill ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vote)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.TblVotingRecord)
                    .HasForeignKey(d => d.RepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVotingRecord_FK00");
            });

            modelBuilder.Entity<TblgtpConfig>(entity =>
            {
                entity.HasKey(e => e.Unique);

                entity.ToTable("tblgtpConfig");

                entity.Property(e => e.Unique)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TempPeopleCecredits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempPeopleCECredits");

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreditTypeId).HasColumnName("Credit Type ID");

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.KeyId).HasColumnName("Key ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SortDate)
                    .HasColumnName("Sort Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.User)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TmpCompanyPaymentsDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpCompanyPaymentsDtl");

                entity.Property(e => e.BalanceDue).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidToDate).HasColumnType("money");

                entity.Property(e => e.PaymentAmt).HasColumnType("money");

                entity.Property(e => e.RegCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.TotalAmtDue).HasColumnType("money");
            });

            modelBuilder.Entity<ViewCtctpeopleAddressPrimary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCTCTPeopleAddressPrimary");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId)
                    .HasColumnName("Address ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCtctpeopleCriteria>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCTCTPeopleCriteria");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField1)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCtctregistrationCriteria>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCTCTRegistrationCriteria");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField1)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDupeProcessing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewDupeProcessing");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewfrmCompanyMembership>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmCompanyMembership");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewalLetterSent)
                    .HasColumnName("Date Renewal Letter Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewed)
                    .HasColumnName("Date Renewed")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastRenewalLetterSent).HasColumnName("Last Renewal Letter Sent");

                entity.Property(e => e.MemberSince)
                    .HasColumnName("Member Since")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.MembershipTypeDescription)
                    .HasColumnName("Membership Type Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMembershipId).HasColumnName("Parent Membership ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RenewalInterval).HasColumnName("Renewal Interval");

                entity.Property(e => e.RenewalNoticeSent)
                    .HasColumnName("Renewal Notice Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewfrmGuestSessRegSubform>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmGuestSessRegSubform");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewfrmMembership>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmMembership");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewalLetterSent)
                    .HasColumnName("Date Renewal Letter Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRenewed)
                    .HasColumnName("Date Renewed")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastRenewalLetterSent).HasColumnName("Last Renewal Letter Sent");

                entity.Property(e => e.MemberSince)
                    .HasColumnName("Member Since")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembershipGroup).HasColumnName("Membership Group");

                entity.Property(e => e.MembershipId).HasColumnName("Membership ID");

                entity.Property(e => e.MembershipTypeCode).HasColumnName("Membership Type Code");

                entity.Property(e => e.MembershipTypeDescription)
                    .HasColumnName("Membership Type Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("Order Id");

                entity.Property(e => e.ParentMembershipCompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMembershipId).HasColumnName("Parent Membership ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalInterval).HasColumnName("Renewal Interval");

                entity.Property(e => e.RenewalNoticeSent)
                    .HasColumnName("Renewal Notice Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewfrmRegFinancialSubform>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmRegFinancialSubform");

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCharges).HasColumnName("Housing Charges");

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId)
                    .HasColumnName("Reg ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegistrationFee).HasColumnName("Registration Fee");

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");
            });

            modelBuilder.Entity<ViewfrmSessRegSubform1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmSessRegSubform1");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewfrmSubscriptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewfrmSubscriptions");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.BillToCompanyId).HasColumnName("BillToCompanyID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ShipToCompanyId).HasColumnName("ShipToCompanyID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptBadges>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptBadges");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptBadgesGuest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptBadges_Guest");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCertificateMeetingCreditsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_MeetingCreditsSub");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .IsRequired()
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");
            });

            modelBuilder.Entity<ViewrptCertificateMeetingNotesSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_MeetingNotesSub");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");
            });

            modelBuilder.Entity<ViewrptCertificateMeetings>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_Meetings");

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId).HasColumnName("Key ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(4096)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCertificateSessionCreditsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_SessionCreditsSub");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .IsRequired()
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCertificateSessionNotesSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_SessionNotesSub");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCertificateSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCertificate_Sessions");

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .IsRequired()
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId).HasColumnName("Key ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(4096)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptCompany");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.AddressTypeDesc)
                    .HasColumnName("Address Type Desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AlphaIndexName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");

                entity.Property(e => e.CompanyEmail)
                    .HasColumnName("CompanyEMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyType).HasColumnName("Company Type");

                entity.Property(e => e.CompanyTypeDesc)
                    .HasColumnName("Company Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateBilling)
                    .HasColumnName("Corporate Billing")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InternetDomain).HasColumnType("ntext");

                entity.Property(e => e.ParentCompanyId).HasColumnName("Parent Company ID");

                entity.Property(e => e.ParentName)
                    .HasColumnName("Parent Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RepId).HasColumnName("Rep ID");

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasColumnName("State Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._800)
                    .HasColumnName("800 #")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptCompanyPeopleCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptCompany_PeopleCount");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");
            });

            modelBuilder.Entity<ViewrptCreditStatsUnionMeetings>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptCreditStats_UnionMeetings");

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptDefaultReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptDefaultReg");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedRegCount).HasColumnName("Expected Reg Count");

                entity.Property(e => e.LateFeeDate)
                    .HasColumnName("Late Fee Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateRegFee).HasColumnName("Late Reg Fee");

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationFee).HasColumnName("Registration Fee");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptDefaultRegSess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptDefaultRegSess");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDetailUrl)
                    .HasColumnName("SessionDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptEvalResponses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptEvalResponses");

                entity.Property(e => e.EvalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            });

            modelBuilder.Entity<ViewrptEvalsEvaluationsEvaluationQuestions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptEvalsEvaluations_EvaluationQuestions");

                entity.Property(e => e.EvaluationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNumberDisplay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptEvaluations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptEvaluations");

                entity.Property(e => e.ChoiceDisplay).HasColumnType("ntext");

                entity.Property(e => e.EvalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.Question).HasColumnType("ntext");

                entity.Property(e => e.QuestionTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SectionTitle).HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptExhibitorAddresses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptExhibitor_Addresses");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceDue).HasColumnName("Balance Due");

                entity.Property(e => e.BoothLoc1)
                    .HasColumnName("Booth Loc 1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc2)
                    .HasColumnName("Booth Loc 2")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc3)
                    .HasColumnName("Booth Loc 3")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc4)
                    .HasColumnName("Booth Loc 4")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostPerBooth).HasColumnName("Cost per Booth");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepositAmount).HasColumnName("Deposit Amount");

                entity.Property(e => e.DepositReceived)
                    .HasColumnName("Deposit Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfBooths).HasColumnName("Number of Booths");

                entity.Property(e => e.PacketSent)
                    .HasColumnName("Packet Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.PersonRegId).HasColumnName("PersonRegID");

                entity.Property(e => e.Profile).HasColumnType("ntext");

                entity.Property(e => e.SponsoredEvents)
                    .HasColumnName("Sponsored Events")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptExhibitorLetters>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptExhibitor_Letters");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceDue).HasColumnName("Balance Due");

                entity.Property(e => e.BoothLoc1)
                    .HasColumnName("Booth Loc 1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc2)
                    .HasColumnName("Booth Loc 2")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc3)
                    .HasColumnName("Booth Loc 3")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc4)
                    .HasColumnName("Booth Loc 4")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostPerBooth).HasColumnName("Cost per Booth");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnName("Deposit Amount");

                entity.Property(e => e.DepositReceived)
                    .HasColumnName("Deposit Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewRegId).HasColumnName("NewRegID");

                entity.Property(e => e.NumberOfBooths).HasColumnName("Number of Booths");

                entity.Property(e => e.PacketSent)
                    .HasColumnName("Packet Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Profile).HasColumnType("ntext");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SponsoredEvents)
                    .HasColumnName("Sponsored Events")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptExhibitors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptExhibitors");

                entity.Property(e => e.BalanceDue).HasColumnName("Balance Due");

                entity.Property(e => e.BoothLoc1)
                    .HasColumnName("Booth Loc 1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc2)
                    .HasColumnName("Booth Loc 2")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc3)
                    .HasColumnName("Booth Loc 3")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoothLoc4)
                    .HasColumnName("Booth Loc 4")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostPerBooth).HasColumnName("Cost per Booth");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnName("Deposit Amount");

                entity.Property(e => e.DepositReceived)
                    .HasColumnName("Deposit Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfBooths).HasColumnName("Number of Booths");

                entity.Property(e => e.PacketSent)
                    .HasColumnName("Packet Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Profile).HasColumnType("ntext");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SponsoredEvents)
                    .HasColumnName("Sponsored Events")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptFinancial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptFinancial");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptGuestReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptGuestReg");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestPersonId).HasColumnName("Guest Person ID");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.GuestType).HasColumnName("Guest Type");

                entity.Property(e => e.GuestTypeDesc)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptGuests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptGuests");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestPersonId).HasColumnName("Guest Person ID");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.GuestType).HasColumnName("Guest Type");

                entity.Property(e => e.GuestTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegMiddle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegNamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegNameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptGuestsSessionCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptGuests_SessionCount");

                entity.Property(e => e.GuestRegId).HasColumnName("GuestRegID");
            });

            modelBuilder.Entity<ViewrptHistoryLabels>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptHistory_Labels");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptHistoryParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptHistory_Participant");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.TotalFees).HasColumnName("Total Fees");
            });

            modelBuilder.Entity<ViewrptHistoryParticipantSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptHistory_ParticipantSub");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.HistId).HasColumnName("HistID");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessRegHistId).HasColumnName("SessRegHistID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptHotels>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptHotels");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HotelNotes)
                    .HasColumnName("Hotel Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelType).HasColumnName("Hotel Type");

                entity.Property(e => e.HotelTypeDesc)
                    .HasColumnName("Hotel Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptHousing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptHousing");

                entity.Property(e => e.AccomId).HasColumnName("Accom ID");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType).HasColumnName("Charge Type");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartDate)
                    .HasColumnName("Depart Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisabledDesc)
                    .HasColumnName("Disabled Desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire Date")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.HotelName)
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name On Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonSmoking).HasColumnName("Non Smoking");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRequests)
                    .HasColumnName("Special Requests")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptHousingRegByMeetingwHotel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptHousing_RegByMeetingwHotel");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartDate)
                    .HasColumnName("Depart Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptHousingRoomingList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptHousing_RoomingList");

                entity.Property(e => e.AccomId).HasColumnName("Accom ID");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType).HasColumnName("Charge Type");

                entity.Property(e => e.ChargeTypeDesc)
                    .HasColumnName("Charge Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartDate)
                    .HasColumnName("Depart Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisabledDesc)
                    .HasColumnName("Disabled Desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire Date")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuaranteeTypeDesc)
                    .HasColumnName("Guarantee Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.HotelName)
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name On Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonSmoking).HasColumnName("Non Smoking");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRequests)
                    .HasColumnName("Special Requests")
                    .HasColumnType("ntext");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptHousingRoommates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptHousing_Roommates");

                entity.Property(e => e.AccomId).HasColumnName("Accom ID");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType).HasColumnName("Charge Type");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartDate)
                    .HasColumnName("Depart Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisabledDesc)
                    .HasColumnName("Disabled Desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire Date")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HotelId).HasColumnName("Hotel ID");

                entity.Property(e => e.HotelName)
                    .HasColumnName("Hotel Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name On Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonSmoking).HasColumnName("Non Smoking");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("Room Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRequests)
                    .HasColumnName("Special Requests")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptIncomeExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDesc)
                    .HasColumnName("Service Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");
            });

            modelBuilder.Entity<ViewrptIncomeExpenseGratuity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_Gratuity");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");
            });

            modelBuilder.Entity<ViewrptIncomeExpensePlmeetingExpenseSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_PLMeetingExpenseSub");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDesc)
                    .HasColumnName("Service Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptIncomeExpensePlmeetingIncomeSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_PLMeetingIncomeSub");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhibitorBudget).HasColumnName("Exhibitor Budget");

                entity.Property(e => e.IncomeId).HasColumnName("Income ID");

                entity.Property(e => e.MeetingBudget).HasColumnName("Meeting Budget");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SystemGenerated).HasColumnName("System Generated");

                entity.Property(e => e.TotalActualAmount).HasColumnName("Total Actual Amount");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptIncomeExpensePlmeetings>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_PLMeetings");

                entity.Property(e => e.CalendarMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Gmtoffset).HasColumnName("GMTOffset");

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDetailUrl)
                    .HasColumnName("MeetingDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingSubjectAreaId).HasComment("cetrak");

                entity.Property(e => e.MeetingTypeId).HasComment("cetrak");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptIncomeExpensePlsessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_PLSessions");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptIncomeExpenseSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_Sessions");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");
            });

            modelBuilder.Entity<ViewrptIncomeExpenseTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_Tax");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");
            });

            modelBuilder.Entity<ViewrptIncomeExpenseVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptIncomeExpense_Vendor");

                entity.Property(e => e.ActualAmount).HasColumnName("Actual Amount");

                entity.Property(e => e.ActualGratuityAmt).HasColumnName("Actual Gratuity Amt");

                entity.Property(e => e.ActualQty).HasColumnName("Actual Qty");

                entity.Property(e => e.AmountPaid).HasColumnName("Amount Paid");

                entity.Property(e => e.BudgetAmount).HasColumnName("Budget Amount");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("Budget Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetGratuityAmt).HasColumnName("Budget Gratuity Amt");

                entity.Property(e => e.BudgetQty).HasColumnName("Budget Qty");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDesc)
                    .HasColumnName("Expense Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpenseId).HasColumnName("Expense ID");

                entity.Property(e => e.GratuityRate).HasColumnName("Gratuity Rate");

                entity.Property(e => e.LinkToReg).HasColumnName("Link to Reg");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("long:Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription2)
                    .HasColumnName("Long:Description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasColumnName("Service Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDesc)
                    .HasColumnName("Service Desc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnName("Tax Rate");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeId).HasColumnName("Vendor Type ID");
            });

            modelBuilder.Entity<ViewrptItineraryArrival>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptItinerary_Arrival");

                entity.Property(e => e.Airline)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("Arrival Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("Flight Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightNumber).HasColumnName("Flight Number");

                entity.Property(e => e.FrmCity)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ItineraryId).HasColumnName("Itinerary ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.ToCity)
                    .HasColumnName("To City")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptItineraryDeparture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptItinerary_Departure");

                entity.Property(e => e.Airline)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureTime)
                    .HasColumnName("Departure Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("Flight Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightNumber).HasColumnName("Flight Number");

                entity.Property(e => e.FrmCity)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ItineraryId).HasColumnName("Itinerary ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.ToCity)
                    .HasColumnName("To City")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptLettersMeetingCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptLettersMeetingCode");

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DefaultLetterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DupeCheck)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNoteId).ValueGeneratedOnAdd();

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptLettersRegCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptLettersRegCode");

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DefaultLetterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DupeCheck)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNoteId).ValueGeneratedOnAdd();

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptMeetingSetupAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptMeetingSetup_Audit");

                entity.Property(e => e.CalendarMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Gmtoffset).HasColumnName("GMTOffset");

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDetailUrl)
                    .HasColumnName("MeetingDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptMeetingSetupAuditAttendeesSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptMeetingSetup_AuditAttendeesSub");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptMeetingSetupAuditCancellationsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptMeetingSetup_AuditCancellationsSub");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptMeetingSetupAuditOtherSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptMeetingSetup_AuditOtherSub");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptMeetingSetupLetterText>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptMeetingSetup_LetterText");

                entity.Property(e => e.CalendarMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Gmtoffset).HasColumnName("GMTOffset");

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDetailUrl)
                    .HasColumnName("MeetingDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptMeetingSetupRegTypeLetterText>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptMeetingSetup_RegTypeLetterText");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedRegCount).HasColumnName("Expected Reg Count");

                entity.Property(e => e.LateFeeDate)
                    .HasColumnName("Late Fee Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateRegFee).HasColumnName("Late Reg Fee");

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationFee).HasColumnName("Registration Fee");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptMeetingSetupSessionCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptMeetingSetup_SessionCodes");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDetailUrl)
                    .HasColumnName("SessionDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptNotesContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptNotes_Contacts");

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.CompletedBy)
                    .HasColumnName("Completed By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate)
                    .HasColumnName("Follow Up Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoteId).HasColumnName("Note ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PeopleTypeDesc)
                    .HasColumnName("People Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");
            });

            modelBuilder.Entity<ViewrptNotesMeeting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptNotes_Meeting");

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.CompletedBy)
                    .HasColumnName("Completed By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate)
                    .HasColumnName("Follow Up Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoteId).HasColumnName("Note ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PeopleTypeDesc)
                    .HasColumnName("People Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleTypeId).HasColumnName("People Type ID");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");
            });

            modelBuilder.Entity<ViewrptNotesPeople>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptNotes_People");

                entity.Property(e => e.CompletedBy)
                    .HasColumnName("Completed By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate)
                    .HasColumnName("Follow Up Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDate)
                    .HasColumnName("Note Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoteId).HasColumnName("Note ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptOpenendedResponses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptOpenendedResponses");

                entity.Property(e => e.EvalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.Question).HasColumnType("ntext");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMemo).HasColumnType("ntext");

                entity.Property(e => e.SectionTitle).HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptOrigPaymentInfoSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptOrigPaymentInfoSub");

                entity.Property(e => e.Approval)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateProcessed)
                    .HasColumnName("Date Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("Payment ID");

                entity.Property(e => e.PaymentMethodDesc)
                    .IsRequired()
                    .HasColumnName("Payment Method Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method ID");

                entity.Property(e => e.PaymentTypeDesc)
                    .IsRequired()
                    .HasColumnName("Payment Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment Type ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptPayments");

                entity.Property(e => e.AmexMerchNo)
                    .HasColumnName("AMEX Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Approval)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAcctNo)
                    .HasColumnName("Bank Acct No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCard).HasColumnName("Credit Card");

                entity.Property(e => e.DateProcessed)
                    .HasColumnName("Date Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DinersClubMerchNo)
                    .HasColumnName("Diners Club Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscoverMerchNo)
                    .HasColumnName("Discover Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MasterCardMerchNo)
                    .HasColumnName("MasterCard Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("Payment ID");

                entity.Property(e => e.PaymentMethodDesc)
                    .IsRequired()
                    .HasColumnName("Payment Method Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method ID");

                entity.Property(e => e.PaymentTypeDesc)
                    .IsRequired()
                    .HasColumnName("Payment Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment Type ID");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Pnref)
                    .HasColumnName("PNREF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.VisaMerchNo)
                    .HasColumnName("VISA Merch No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WhoPaidName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptPeople>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptPeople");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.AddressTypeDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType).HasColumnName("Contact Type");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pager)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PeopleTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("Source ID");

                entity.Property(e => e.SpecialtyDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasColumnName("State Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRefundsDue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRefundsDue");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRegLettersSessionRegAttendee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegLetters_SessionRegAttendee");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewrptRegLettersSessionRegGuest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegLetters_SessionRegGuest");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRegistrationAttendeeListFalse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistrationAttendeeListFalse");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRegistrationAttendeeListTrue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistrationAttendeeListTrue");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRegistrationCancelled>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistrationCancelled");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFee).HasColumnName("Cancellation Fee");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("Confirmation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("Country ID");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBadgePrinted)
                    .HasColumnName("Date Badge Printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancellationProcessed)
                    .HasColumnName("Date Cancellation Processed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePostedToHistory)
                    .HasColumnName("Date Posted To History")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRefundProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.GuestSessionFees).HasColumnName("Guest Session Fees");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.McFooter)
                    .HasColumnName("MC_Footer")
                    .HasColumnType("ntext");

                entity.Property(e => e.McHeader)
                    .HasColumnName("MC_Header")
                    .HasColumnType("ntext");

                entity.Property(e => e.McLetterType).HasColumnName("MC_LetterType");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreOrOnSite)
                    .HasColumnName("Pre or On-Site")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RcFooter)
                    .HasColumnName("RC_Footer")
                    .HasColumnType("ntext");

                entity.Property(e => e.RcHeader)
                    .HasColumnName("RC_Header")
                    .HasColumnType("ntext");

                entity.Property(e => e.RcLetterType).HasColumnName("RC_LetterType");

                entity.Property(e => e.RefundAmount).HasColumnName("Refund Amount");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFee).HasColumnName("Reg Fee");

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UseCompanyName).HasColumnName("Use Company Name");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptRegistrationGuestFees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration_GuestFees");

                entity.Property(e => e.GuestFees).HasColumnName("Guest Fees");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");
            });

            modelBuilder.Entity<ViewrptRegistrationGuestSessionFees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration_GuestSessionFees");

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");
            });

            modelBuilder.Entity<ViewrptRegistrationHousingCosts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration_HousingCosts");

                entity.Property(e => e.HousingCosts).HasColumnName("Housing Costs");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RoomRate).HasColumnName("Room Rate");
            });

            modelBuilder.Entity<ViewrptRegistrationPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration_Payments");

                entity.Property(e => e.PaymentAmt).HasColumnName("Payment Amt");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");
            });

            modelBuilder.Entity<ViewrptRegistrationSessionFees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptRegistration_SessionFees");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessionFees).HasColumnName("Session Fees");
            });

            modelBuilder.Entity<ViewrptResponseStatistics>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptResponseStatistics");

                entity.Property(e => e.EvalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.Question).HasColumnType("ntext");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMemo).HasColumnType("ntext");

                entity.Property(e => e.SectionTitle).HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptSessWaitList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptSessWaitList");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.GuestLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryId).HasColumnName("PrimaryID");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WaitListId).HasColumnName("WaitListID");
            });

            modelBuilder.Entity<ViewrptSessionAvitemsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_AVItemsSub");

                entity.Property(e => e.AvDesc)
                    .IsRequired()
                    .HasColumnName("Av Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AvItemId).HasColumnName("AV Item ID");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptSessionFbitemsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_FBItemsSub");

                entity.Property(e => e.FbDesc)
                    .IsRequired()
                    .HasColumnName("FB Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FbItemId).HasColumnName("FB Item ID");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptSessionInfoAndStats>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_InfoAndStats");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDetailUrl)
                    .HasColumnName("SessionDetailURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetupDesc)
                    .HasColumnName("Setup Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User6)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptSessionReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptSessionReg");

                entity.Property(e => e.DateCreditsPosted)
                    .HasColumnName("Date Credits Posted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptSessionRoster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_Roster");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.GuestRegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.GuestRegLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingComments).HasColumnType("ntext");

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingLongDesc).HasColumnType("ntext");

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegMiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionComments).HasColumnType("ntext");

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionLongDesc).HasColumnType("ntext");

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");
            });

            modelBuilder.Entity<ViewrptSessionSetupItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_SetupItems");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.RoomSetupSetupDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessSetupMeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessSetupSessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetupDesc)
                    .HasColumnName("Setup Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SetupItemId).HasColumnName("Setup Item ID");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewrptSessionSetupItemsSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_SetupItemsSub");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ProvidedBy).HasColumnName("Provided By");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SetupDesc)
                    .IsRequired()
                    .HasColumnName("Setup Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SetupItemId).HasColumnName("Setup Item ID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptSessionSignIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptSession_SignIn");

                entity.Property(e => e.AttendeeList).HasColumnName("Attendee List");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExhBudgetCode)
                    .HasColumnName("Exh Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GratuityPct).HasColumnName("Gratuity Pct");

                entity.Property(e => e.GuestRegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.GuestRegLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingComments).HasColumnType("ntext");

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingLongDesc).HasColumnType("ntext");

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegMiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegTypeBudgetCode)
                    .HasColumnName("RegType Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionBudgetCode)
                    .HasColumnName("Session Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionComments).HasColumnType("ntext");

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionLongDesc).HasColumnType("ntext");

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.SetupNotes)
                    .HasColumnName("Setup Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxPct).HasColumnName("Tax Pct");

                entity.Property(e => e.UseHousingCosts).HasColumnName("Use Housing Costs");

                entity.Property(e => e.UseItineraryCosts).HasColumnName("Use Itinerary Costs");
            });

            modelBuilder.Entity<ViewrptSessionSpeakersSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSession_SpeakersSub");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOfTalk)
                    .HasColumnName("Title of Talk")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptSpeaker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSpeaker");

                entity.Property(e => e.AVNeeds)
                    .HasColumnName("A/V Needs")
                    .HasColumnType("ntext");

                entity.Property(e => e.AcceptanceReceived)
                    .HasColumnName("Acceptance Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactType).HasColumnName("Contact Type");

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCopies).HasColumnName("Number Copies");

                entity.Property(e => e.Pager)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Session)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("Source ID");

                entity.Property(e => e.SpeakerType).HasColumnName("Speaker Type");

                entity.Property(e => e.SpeakerTypeDesc)
                    .HasColumnName("Speaker Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectArea)
                    .HasColumnName("Subject Area")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOfTalk)
                    .HasColumnName("Title of Talk")
                    .HasColumnType("ntext");

                entity.Property(e => e.TravelAllowance).HasColumnName("Travel Allowance");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptSpeakerLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSpeaker_Letter");

                entity.Property(e => e.AVNeeds)
                    .HasColumnName("A/V Needs")
                    .HasColumnType("ntext");

                entity.Property(e => e.AcceptanceReceived)
                    .HasColumnName("Acceptance Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.BadgeName)
                    .HasColumnName("Badge Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConfFooterNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfHeaderNotes).HasColumnType("ntext");

                entity.Property(e => e.ConfirmationSent)
                    .HasColumnName("Confirmation Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactType).HasColumnName("Contact Type");

                entity.Property(e => e.CountryId).HasColumnName("Country Id");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LetterTypeId).HasColumnName("Letter Type Id");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MailPref)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCopies).HasColumnName("Number Copies");

                entity.Property(e => e.Pager)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.RefId)
                    .HasColumnName("Ref ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Session)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("Source ID");

                entity.Property(e => e.SpeakerType).HasColumnName("Speaker Type");

                entity.Property(e => e.SpeakerTypeDesc)
                    .HasColumnName("Speaker Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectArea)
                    .HasColumnName("Subject Area")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOfTalk)
                    .HasColumnName("Title of Talk")
                    .HasColumnType("ntext");

                entity.Property(e => e.TravelAllowance).HasColumnName("Travel Allowance");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("Valid From")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("Valid To")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptSpeakerLetterSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptSpeaker_LetterSub");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpeakerTypeDesc)
                    .HasColumnName("Speaker Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubjectArea)
                    .HasColumnName("Subject Area")
                    .HasColumnType("ntext");

                entity.Property(e => e.TitleOfTalk)
                    .HasColumnName("Title of Talk")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewrptSponsorPrimaryContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptSponsorPrimaryContact");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptSponsors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptSponsors");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("Address Id");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompId).HasColumnName("CompID");

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCompanyId).HasColumnName("Parent Company ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContact).HasColumnName("Primary Contact");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._800Number)
                    .HasColumnName("800 Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptStatistics>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptStatistics");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person Id");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg Id");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("Source Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasColumnName("State Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptTasks>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptTasks");

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("Date Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDue)
                    .HasColumnName("Date Due")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaysOut).HasColumnName("Days Out");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("Long Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingEndTime)
                    .HasColumnName("Meeting End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("Meeting Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingTaskId).HasColumnName("MeetingTaskID");

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Task).HasColumnType("ntext");

                entity.Property(e => e.TemplateId).HasColumnName("Template ID");

                entity.Property(e => e.TimeCompleted)
                    .HasColumnName("Time Completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeDue)
                    .HasColumnName("Time Due")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewrptTicketsAttendee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptTickets_Attendee");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasColumnName("Registration Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewrptTicketsGuests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewrptTickets_Guests");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled)
                    .HasColumnName("Date Cancelled")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuestRegId).HasColumnName("Guest Reg ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRegId).HasColumnName("Primary Reg ID");

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegDesc)
                    .HasColumnName("Reg Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg ID");

                entity.Property(e => e.RegLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegMiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegNamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegNameSuffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SessRegId).HasColumnName("SessReg ID");

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptTranscript>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptTranscript");

                entity.Property(e => e.AddressId).HasColumnName("Address ID");

                entity.Property(e => e.AddressType).HasColumnName("Address Type");

                entity.Property(e => e.Company)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeDesc)
                    .IsRequired()
                    .HasColumnName("Credit Type Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeId).HasColumnName("Credit Type ID");

                entity.Property(e => e.CreditUnits).HasColumnName("Credit Units");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId).HasColumnName("Key ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleType).HasColumnName("People Type");

                entity.Property(e => e.PeopleTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleTypeId).HasColumnName("People Type ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.RegCode)
                    .HasColumnName("Reg Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptTranscriptMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptTranscript_Main");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreditDate)
                    .HasColumnName("Credit Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditTypeCode)
                    .IsRequired()
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name Prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name Suffix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SessionCode)
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4096)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptTranscriptSelection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptTranscript_Selection");

                entity.Property(e => e.AddressTypeDesc)
                    .HasColumnName("Address Type Desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddressTypeId).HasColumnName("Address Type ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeCode)
                    .HasColumnName("Credit Type Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleTypeDesc)
                    .HasColumnName("People Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleTypeId).HasColumnName("People Type ID");

                entity.Property(e => e.PersonId).HasColumnName("Person ID");

                entity.Property(e => e.SpecialtyId).HasColumnName("Specialty ID");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptUnionMeetings>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptUnionMeetings");

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultRegistrationCode)
                    .HasColumnName("Default Registration Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyCancellationAmt).HasColumnName("Early Cancellation Amt");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateCancellationAmt).HasColumnName("Late Cancellation Amt");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingEndDate)
                    .HasColumnName("Meeting End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingLocation)
                    .HasColumnName("Meeting Location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingStartDate)
                    .HasColumnName("Meeting Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberAttending).HasColumnName("Number Attending");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptUnionSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptUnionSessions");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("Budget Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ceu).HasColumnName("CEU");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("Date Entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("Entered By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasColumnName("Meeting Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsible)
                    .HasColumnName("Person Responsible")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCode)
                    .IsRequired()
                    .HasColumnName("Session Code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate)
                    .HasColumnName("Session Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetupId).HasColumnName("Setup ID");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated By")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptVendor1099>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_1099");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Print1099Forms).HasColumnName("Print 1099 Forms");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasColumnName("Tax ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptVendorInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_Invoice");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Terms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptVendorInvoiceSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_InvoiceSub");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptVendorInvoicerptSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_InvoicerptSub");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentTypeDesc)
                    .IsRequired()
                    .HasColumnName("Payment Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptVendorListing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_Listing");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Print1099Forms).HasColumnName("Print 1099 Forms");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasColumnName("Tax ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotes)
                    .HasColumnName("Vendor Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewrptVendorPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptVendor_Payments");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company Name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentTypeDesc)
                    .IsRequired()
                    .HasColumnName("Payment Type Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ViewrptsubResponseHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewrptsubResponseHeader");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EvalId).HasColumnName("EvalID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDesc)
                    .HasColumnName("Meeting Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Middle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.SessionCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            });

            modelBuilder.Entity<ZzzMsysObjTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzzMSysObjTypes");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzzNotes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzzNotes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ZzzRelationTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzzRelationTypes");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HowUsed).HasColumnType("ntext");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ZzzRelations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzzRelations");

                entity.Property(e => e.Ccolumn).HasColumnName("ccolumn");

                entity.Property(e => e.Icolumn).HasColumnName("icolumn");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.SzColumn)
                    .HasColumnName("szColumn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SzObject)
                    .HasColumnName("szObject")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SzReferencedColumn)
                    .HasColumnName("szReferencedColumn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SzReferencedObject)
                    .HasColumnName("szReferencedObject")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SzRelationship)
                    .HasColumnName("szRelationship")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzzTempEdith>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzzTempEdith");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person ID")
                    .HasColumnType("numeric(10, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
