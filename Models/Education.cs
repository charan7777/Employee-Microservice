using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Employee_Microservice.Models
{
    [Table("Education")]
    public partial class Education
    {
        [Key]
        public int EdId { get; set; }
        public int? EmpId { get; set; }
        [Column("SSC")]
        public double? Ssc { get; set; }
        [Column("PUC")]
        public double? Puc { get; set; }
        public double? Graduation { get; set; }

        [ForeignKey(nameof(EmpId))]
        [InverseProperty(nameof(Employee.Educations))]
        public virtual Employee Emp { get; set; }
    }
}
