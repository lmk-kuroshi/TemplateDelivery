using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
