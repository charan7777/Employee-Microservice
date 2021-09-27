using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Employee_Microservice.Models
{
    [Table("employees")]
    public partial class Employee
    {
        public Employee()
        {
            Educations = new HashSet<Education>();
        }
      
        [Key]
        public int EmpId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage ="Employee Name is Mandatory")]
        public string EmpName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "User Name is Mandatory")]
        public string UserName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Password is Mandatory")]
        public string Passcode { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Work Location is Mandatory")]
        public string WorkLocation { get; set; }
        [Required(ErrorMessage = "Contact number is Mandatory")]
        public long? ContactNumber { get; set; }
        [Required(ErrorMessage = "Admin flag is Mandatory")]
        [RegularExpression("^[0-1]*$",ErrorMessage = "Wrong format")]
        public int? Adminflag { get; set; }

        [InverseProperty(nameof(Education.Emp))]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
