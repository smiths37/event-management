using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassParticipation
    {
        public TblClassParticipation()
        {
            TblClassEvaluationOrder = new HashSet<TblClassEvaluationOrder>();
            TblClassTestOrder = new HashSet<TblClassTestOrder>();
        }

        public int ParticipantId { get; set; }
        public int PersonId { get; set; }
        public int ClassId { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DateMaterialsReviewed { get; set; }
        public string Comments { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Dept { get; set; }
        public string BadgeName { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public int? AddressId { get; set; }
        public string AddressType { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClass Class { get; set; }
        public virtual TblPeople Person { get; set; }
        public virtual ICollection<TblClassEvaluationOrder> TblClassEvaluationOrder { get; set; }
        public virtual ICollection<TblClassTestOrder> TblClassTestOrder { get; set; }
    }
}
