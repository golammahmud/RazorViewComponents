using BasicRazorViewComponents.Models;
using BasicRazorViewComponents.Pages;
using BeratenKatuwahDataAccess;

namespace BasicRazorViewComponents.Services
{
    public class EmployeeManager : BaseDataManager, IEmployee
    {
        public EmployeeManager(ILogger<IndexModel> logger, ApplicationDbContexts model) : base(logger, model)
        {
        }

        public IList<UserDetails> GetAllEmployees()
        {
            return GetListData<UserDetails>($"EXEC spGetAllEmployeesWithDepartmentNames");
        }

        public IList<GroupByAddressDTO> GetGroupByAddressEmployeesNumber()
        {
            return GetListData<GroupByAddressDTO>($"EXEC spGetEmployeeByAddress");
        }
    }
}
