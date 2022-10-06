using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class DepartmentStatus
    {
        public DepartmentStatus()
        {
            Departments = new HashSet<Department>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
