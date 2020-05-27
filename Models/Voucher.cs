using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class Voucher
    {
        [Key]
        public int VoucherId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string VoucherCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public decimal? Money { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Status { get; set; }// VALID || INVALID

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
