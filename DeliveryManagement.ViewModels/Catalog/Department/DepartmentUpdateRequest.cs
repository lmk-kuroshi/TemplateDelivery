using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManagement.ViewModels.Catalog.Department
{
    public class DepartmentUpdateRequest
    {
        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public int StatusId { get; set; }
    }
}
