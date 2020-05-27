using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [Column(TypeName = "varchar(250)")]
        [DisplayName("Category thumbnail")]
        public string Image { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
