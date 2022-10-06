using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Drives = new HashSet<Drive>();
        }

        public int VehicleId { get; set; }
        public string License { get; set; }
        public int StatusId { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Drive> Drives { get; set; }
    }
}
