using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Employee
    {
        public Employee()
        {
            Bills = new HashSet<Bill>();
            Drives = new HashSet<Drive>();
        }

        public int EmployeeId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }

        public virtual UserStatus Status { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Drive> Drives { get; set; }
    }
}
