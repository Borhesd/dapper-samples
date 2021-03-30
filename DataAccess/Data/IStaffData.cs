using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IStaffData
    {
        Task<List<StaffModel>> GetStaff();
        Task AddStaff(StaffModel model);
    }
}