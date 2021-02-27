using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        //Range 1 will be the minimun value acceptable and int.maxValue will be the maximum value
        [Range(1, int.MaxValue, ErrorMessage = "Display Order must be grater than 0")]
        public int DisplayOrder { get; set; }
    }
}
