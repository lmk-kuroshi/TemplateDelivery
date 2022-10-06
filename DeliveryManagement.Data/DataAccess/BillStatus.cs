using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class BillStatus
    {
        public BillStatus()
        {
            Bills = new HashSet<Bill>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
