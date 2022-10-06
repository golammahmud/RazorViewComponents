using BasicRazorViewComponents.Models;

namespace BasicRazorViewComponents.Services
{
    public interface IEmployee
    {
        IList<UserDetails> GetAllEmployees();

        IList<GroupByAddressDTO> GetGroupByAddressEmployeesNumber();
    }
}
