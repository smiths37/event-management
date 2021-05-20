using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipTypeCodes
    {
        public TblMembershipTypeCodes()
        {
            TblMembership = new HashSet<TblMembership>();
            TblMembershipProducts = new HashSet<TblMembershipProducts>();
            TblRenewalLetterSetup = new HashSet<TblRenewalLetterSetup>();
            TblRenewalTypesMembershipTypeCodeNavigation = new HashSet<TblRenewalTypes>();
            TblRenewalTypesRenewalTypeCodeNavigation = new HashSet<TblRenewalTypes>();
        }

        public int MembershipTypeCode { get; set; }
        public string MembershipTypeDescription { get; set; }
        public short? Term { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public short? MembershipGroup { get; set; }
        public short? AssociateMembers { get; set; }
        public bool ComplimentaryAssociate { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool? AllowOnWeb { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblMembership> TblMembership { get; set; }
        public virtual ICollection<TblMembershipProducts> TblMembershipProducts { get; set; }
        public virtual ICollection<TblRenewalLetterSetup> TblRenewalLetterSetup { get; set; }
        public virtual ICollection<TblRenewalTypes> TblRenewalTypesMembershipTypeCodeNavigation { get; set; }
        public virtual ICollection<TblRenewalTypes> TblRenewalTypesRenewalTypeCodeNavigation { get; set; }
    }
}
