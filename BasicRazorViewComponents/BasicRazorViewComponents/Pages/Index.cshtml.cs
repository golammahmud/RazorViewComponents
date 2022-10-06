using BasicRazorViewComponents.Models;
using BasicRazorViewComponents.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BasicRazorViewComponents.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployee m_Employee;
        private ApplicationDbContexts _AppDbContexts;
        public IndexModel(ApplicationDbContexts _applicationDbContexts, IEmployee employeemngr)
        {
            this.m_Employee = employeemngr;

            this._AppDbContexts = _applicationDbContexts;
        }
        public Employee Employee { get; set; }
        public IList<UserDetails> Employees { get; set; }
        public void OnGet(int Id)
        {
            Employees = new List<UserDetails>();
            Employees = (from em in _AppDbContexts.Employee
                         join dep in _AppDbContexts.Department
                         on em.DepartmentId equals dep.DepartmentId
                         select new UserDetails()
                         {
                             Id = em.EmployeeId,
                             EmployeeName = em.Name,
                             DepartmentName = dep.Name
                         }).ToList();
            Employee = new Employee();
            if (Id > 0)
            {
                Employee = m_Employee.GetEmployeeById(Id);
            }
            else
            {
                NotFound();
            }


        }
    }
}