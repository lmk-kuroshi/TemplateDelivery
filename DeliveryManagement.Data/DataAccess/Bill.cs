using System;
using System.Collections.Generic;

#nullable disable

namespace DeliveryManagement.Data.DataAccess
{
    public partial class Bill
    {
        public string BillId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string PickupLocation { get; set; }
        public string DeliverLocation { get; set; }
        public int StartDepartmntId { get; set; }
        public int EndDepartmentId { get; set; }
        public int CurrentDepartmentId { get; set; }
        public int DriveId { get; set; }
        public int StatusId { get; set; }

        public virtual Department CurrentDepartment { get; set; }
        public virtual Drive Drive { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department EndDepartment { get; set; }
        public virtual Department StartDepartmnt { get; set; }
        public virtual BillStatus Status { get; set; }
        public virtual Customer User { get; set; }
    }
}
