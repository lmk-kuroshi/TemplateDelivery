using DeliveryManagement.ViewModels.Catalog.Department;
using DeliveryManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManagement.Application.Catalog.Department
{
    public interface IManageDepartmentService
    {
        Task<string> Create(DepartmentCreateRequest request);
        Task<int> Update(DepartmentUpdateRequest request);
        Task<int> Delete(string departmentId);
        /*Task<PagedResult<DepartmentViewModel>> GetAllPagingWithKeyWord(string keyword, PagingRequestBase request);*/
        Task<PagedResult<DepartmentViewModel>> GetAllPaging(PagingRequestBase request);
        Task<DepartmentViewModel> GetById(string DepartmentId);

    }
}
