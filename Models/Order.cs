using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class Order
    {
        // OrderId là key unique tự sinh ra
        [Key]
        public int OrderId { get; set; }

        // idOrder để nhóm các order detail cùng 1 order lại
        public string IdOrder { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Original money")]
        public decimal OriginalMoney { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Total money")]
        public decimal TotalMoney { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Discount money")]
        public decimal DiscountMoney { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Status { get; set; }// PAID || UNPAID

        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Fullname { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Phone { get; set; }

        public long ProductId { get; set; }

        public int ProductAmount { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
