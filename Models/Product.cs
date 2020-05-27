using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Image { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Unit { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        public decimal? Price { get; set; }

        public long? CategoryID { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
