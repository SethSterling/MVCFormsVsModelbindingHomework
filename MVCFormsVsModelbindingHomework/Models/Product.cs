using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormsVsModelbindingHomework.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }
    }
}
