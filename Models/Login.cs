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
        [Required(ErrorMessage = "User Name is Mandatory")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$",ErrorMessage ="Wrong Email format")]
        public string UserName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Password is Mandatory")]
        public string Passcode { get; set; }
    }
}
