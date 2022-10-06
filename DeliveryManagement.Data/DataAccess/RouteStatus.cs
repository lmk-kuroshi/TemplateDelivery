using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class RouteStatus
    {
        public RouteStatus()
        {
            Routes = new HashSet<Route>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}
