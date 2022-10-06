using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Drive
    {
        public Drive()
        {
            Bills = new HashSet<Bill>();
        }

        public int DriveId { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsNorthToSouth { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
