using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Route
    {
        public int RouteId { get; set; }
        public int StartDepartmentId { get; set; }
        public int EndDepartmentId { get; set; }
        public int Price { get; set; }
        public int StatusId { get; set; }

        public virtual Department EndDepartment { get; set; }
        public virtual Department StartDepartment { get; set; }
        public virtual RouteStatus Status { get; set; }
    }
}
