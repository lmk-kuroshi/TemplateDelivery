using DeliveryManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManagement.ViewModels.Catalog.Department
{
    public class GetDepartmentPagingRequest : PagingRequestBase
    {
        public string DepartmentId { get; set; }
    }
}
