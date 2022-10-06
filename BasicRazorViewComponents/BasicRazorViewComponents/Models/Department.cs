using System.ComponentModel.DataAnnotations;

namespace BasicRazorViewComponents.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string DepartmentStatus { get; set; }
        public DateTime? DepartmentDate { get; set; } = DateTime.Now;

        //Navigation properties
        public IList<Employee> Employees { get; set; }
    }
}
