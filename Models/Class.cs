using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        public string Location { get; set; }
        
        public string FavLanguage { get; set; }
        public string Comment { get; set; } 
    }
}
