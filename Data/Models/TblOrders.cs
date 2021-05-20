using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblOrders
    {
        public TblOrders()
        {
            TblCreditMemo = new HashSet<TblCreditMemo>();
            TblOrderLines = new HashSet<TblOrderLines>();
            TblSubscriptions = new HashSet<TblSubscriptions>();
        }

        public int OrderId { get; set; }
        public string PoNumber { get; set; }
        public string Terms { get; set; }
        public int? MembershipId { get; set; }
        public int? AssocMembershipId { get; set; }
        public short? OrderType { get; set; }
        public int? BillToPersonId { get; set; }
        public int? BillToCompanyId { get; set; }
        public int? BillToAddressId { get; set; }
        public string BillToName { get; set; }
        public string BillToCompany { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZip { get; set; }
        public int? BillToCountryId { get; set; }
        public string BillToCountry { get; set; }
        public int? ShipToPersonId { get; set; }
        public int? ShipToCompanyId { get; set; }
        public int? ShiptoAddressId { get; set; }
        public string ShipToName { get; set; }
        public string ShipToCompany { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public int? ShipToCountryId { get; set; }
        public string ShipToCountry { get; set; }
        public int? ShipVia { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipBy { get; set; }
        public string Comments { get; set; }
        public bool Void { get; set; }
        public bool CreditMemo { get; set; }
        public DateTime? InvoicePrinted { get; set; }
        public bool PrintComments { get; set; }
        public double? TaxRate { get; set; }
        public int? Source { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCreditMemo> TblCreditMemo { get; set; }
        public virtual ICollection<TblOrderLines> TblOrderLines { get; set; }
        public virtual ICollection<TblSubscriptions> TblSubscriptions { get; set; }
    }
}
