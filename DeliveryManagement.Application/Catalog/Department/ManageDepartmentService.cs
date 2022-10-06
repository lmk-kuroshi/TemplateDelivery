using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryManagement.Data.DataAccess;
using DeliveryManagement.ViewModels.Catalog.Department;
using DeliveryManagement.Ultilities.Exceptions;
using DeliveryManagement.ViewModels.Common;

namespace DeliveryManagement.Application.Catalog.Department
{
    public class ManageDepartmentService : IManageDepartmentService
    {
        private readonly DeliveryManagementContext _context;
        public ManageDepartmentService(DeliveryManagementContext context)
        {
            _context = context;
        }
        public async Task<string> Create(DepartmentCreateRequest request)
        {
            var Department = new DeliveryManagement.Data.DataAccess.Department()
            {
                DepartmentId = Int32.Parse( "" + new StringBuilder().Append(DateTime.Now.ToString("MMddyyHHmmss")) + Environment.TickCount),
                Address = request.Address,
                StatusId = 1,
            };
            _context.Departments.Add(Department);
            await _context.SaveChangesAsync();
            return Department.DepartmentId.ToString();
        }

        public async Task<int> Delete(string DepartmentId)
        {
            var Department = _context.Departments.Find(DepartmentId);

            if (Department == null) throw new DeliveryManagementException("Cannot find Department: " + DepartmentId);

            Department.StatusId = 0;

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<DepartmentViewModel>> GetAllPaging(GetDepartmentPagingRequest request)
        {
            var query = from p in _context.Departments
                        select new { p };
            
            //paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).
                Take(request.PageSize).
                Select(x => new DepartmentViewModel()
                {
                    DepartmentId = x.p.DepartmentId,
                    Address= x.p.Address,
                    StatusId = x.p.StatusId,
                }).ToListAsync();
            //select and projection
            var pageResult = new PagedResult<DepartmentViewModel>()
            {
                TotalRecord = totalRow,
                Items = (List<DepartmentViewModel>)data
            };
            return pageResult;
        }

        public async Task<int> Update(DepartmentUpdateRequest request)
        {
            var Department = _context.Departments.Find(request.DepartmentId);

            if (Department == null) throw new DeliveryManagementException("Cannot find Department: " + request.DepartmentId);

            Department.Address = request.Address;
            Department.StatusId = request.StatusId;

            return await _context.SaveChangesAsync();

        }

        public async Task<DepartmentViewModel> GetById(string depId)
        {
            var department = await _context.Departments.FindAsync(depId);
            //filter

            var data = new DepartmentViewModel()
            {
                DepartmentId= department.DepartmentId,
                Address = department.Address,
                StatusId = department.StatusId,
            };
            if (data == null) throw new DeliveryManagementException("Cannot find pet: " + depId);
            return data;
        }
    }
}
