using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Employee_Microservice.Models
{
    [Table("Login")]
    public partial class Login
    {
        [Key]
        public int Lid { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Passcode { get; set; }
    }
}
