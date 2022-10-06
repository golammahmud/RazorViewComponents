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

        public Employee GetEmployeeById(int Id)
        {
            return GetRowData<Employee>($"EXEC spGetEmployeeById {Id}");
        }

        public IList<GroupByAddressDTO> GetGroupByAddressEmployeesNumber()
        {
            return GetListData<GroupByAddressDTO>($"EXEC spGetEmployeeByAddress");
        }

        public IList<TableRowCountDTO> GetTotalTableRowCount()
        {
            return GetListData<TableRowCountDTO>($" Exec spGetAllTableEntryNumbers");
        }
    }
}
