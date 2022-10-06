using BasicRazorViewComponents.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BasicRazorViewComponents.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContexts _AppDbContexts;
        public IndexModel(ILogger<IndexModel> logger , ApplicationDbContexts AppDbContexts)
        {
            this._logger = logger;
            this._AppDbContexts = AppDbContexts;
        }

        public IList<UserDetails> Employees { get; set; }
        public void OnGet()
        {
            Employees = new List<UserDetails>();
            Employees =(from em in _AppDbContexts.Employee
                        join dep in _AppDbContexts.Department
                        on em.DepartmentId equals dep.DepartmentId
                        select new UserDetails()
                        {
                            Id = em.EmployeeId,
                            EmployeeName = em.Name,
                            DepartmentName = dep.Name
                        }).ToList();

        }
    }
}