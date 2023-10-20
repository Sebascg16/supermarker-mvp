using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket__mvp.Models
{
    internal class ModelCategorie
    {

        [DisplayName("Categorie Id")]
        public int Id { get; set; }

        [DisplayName("Categorie name")]
        [Required(ErrorMessage = "Categorie name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categorie name must be beetwen 3 and 50 characters")]

        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Categorie mode observation is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categorie observation must be beetwen 3 and 200 characters")]

        public string Observation { get; set; }
    }
}
