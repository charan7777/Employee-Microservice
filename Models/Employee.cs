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
        public string EmpName { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Passcode { get; set; }
        [StringLength(50)]
        public string WorkLocation { get; set; }
        public long? ContactNumber { get; set; }
        public int? Adminflag { get; set; }

        [InverseProperty(nameof(Education.Emp))]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
