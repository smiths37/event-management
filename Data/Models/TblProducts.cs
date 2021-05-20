using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblProducts
    {
        public TblProducts()
        {
            TblMembershipProducts = new HashSet<TblMembershipProducts>();
        }

        public int ProductId { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public bool MaintainInventory { get; set; }
        public int? QtyOnHand { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public bool Periodical { get; set; }
        public short? YearlyIssues { get; set; }
        public double? NumIssues { get; set; }
        public string PartNumber { get; set; }
        public bool Taxable { get; set; }
        public int? VendorId { get; set; }
        public bool Giveaway { get; set; }
        public int? MembOrgId { get; set; }
        public int? MembershipTypeCode { get; set; }
        public string GlcreditInvoice { get; set; }
        public string GldebitInvoice { get; set; }
        public string GlcreditReceipt { get; set; }
        public string GldebitReceipt { get; set; }
        public string GlcreditReceiptDeferred { get; set; }
        public string GldebitReceiptDeferred { get; set; }
        public bool AllowDelete { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblMembershipProducts> TblMembershipProducts { get; set; }
    }
}
