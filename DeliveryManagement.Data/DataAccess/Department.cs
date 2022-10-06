using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Department
    {
        public Department()
        {
            BillCurrentDepartments = new HashSet<Bill>();
            BillEndDepartments = new HashSet<Bill>();
            BillStartDepartmnts = new HashSet<Bill>();
            RouteEndDepartments = new HashSet<Route>();
            RouteStartDepartments = new HashSet<Route>();
        }

        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public int StatusId { get; set; }

        public virtual DepartmentStatus Status { get; set; }
        public virtual ICollection<Bill> BillCurrentDepartments { get; set; }
        public virtual ICollection<Bill> BillEndDepartments { get; set; }
        public virtual ICollection<Bill> BillStartDepartmnts { get; set; }
        public virtual ICollection<Route> RouteEndDepartments { get; set; }
        public virtual ICollection<Route> RouteStartDepartments { get; set; }
    }
}
