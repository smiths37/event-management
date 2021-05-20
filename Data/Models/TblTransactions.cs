using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblTransactions
    {
        public int TransId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? CreditMemoId { get; set; }
        public int? PersonId { get; set; }
        public int? CompanyId { get; set; }
        public int? MembershipId { get; set; }
        public short? TransType { get; set; }
        public decimal? TransAmount { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransDesc { get; set; }
        public int? MethodOfPayment { get; set; }
        public string CheckCreditCardNumber { get; set; }
        public DateTime? Expires { get; set; }
        public string CardName { get; set; }
        public string AuthorizationNumber { get; set; }
        public int? GlcreditAccount { get; set; }
        public int? GldebitAccount { get; set; }
        public string GlcreditReceipt { get; set; }
        public string GldebitReceipt { get; set; }
        public string GlcreditReceiptDeferred { get; set; }
        public string GldebitReceiptDeferred { get; set; }
        public DateTime? PostedToGl { get; set; }
        public int? GlbatchId { get; set; }
        public bool OrderVoided { get; set; }
        public int? InVoiceTransId { get; set; }
        public int? PaymentId { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
