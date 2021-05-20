using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDepartments
    {
        public int DepartmentId { get; set; }
        public string DepartmentDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
