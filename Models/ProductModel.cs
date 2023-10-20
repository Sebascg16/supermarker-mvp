using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket__mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage ="Product name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Product Observation must +" +
            " be bewtween 3 and 50 characters")]

        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product observation must be beetwen 3 and 200 characters")]

        public string Observation { get; set; }
        
        
    }
}
