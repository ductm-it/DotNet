using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Fullname { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Role { get; set; }// ADMIN || CUSTOMER

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
