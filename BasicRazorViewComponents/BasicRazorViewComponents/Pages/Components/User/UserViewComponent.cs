using BasicRazorViewComponents.Models;
using BasicRazorViewComponents.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BasicRazorViewComponents.Components.User
{
    public class UserViewComponent : ViewComponent
    {
       
        private readonly IEmployee m_Employee;
        private ApplicationDbContexts _AppDbContexts;

        public UserViewComponent(ApplicationDbContexts _applicationDbContexts , IEmployee employeemngr)
        {
            this.m_Employee = employeemngr;
          
            this._AppDbContexts = _applicationDbContexts;
        }
        public IViewComponentResult Invoke()
        {
            var result = m_Employee.GetAllEmployees();
            var address=m_Employee.GetGroupByAddressEmployeesNumber();
           ViewBag.Address = address;
            return View(result);
        }
    }
}
