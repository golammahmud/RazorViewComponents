using System.ComponentModel.DataAnnotations;

namespace BasicRazorViewComponents.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        //Navigation properties
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
