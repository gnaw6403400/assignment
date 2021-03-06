using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models
{
    public class MovieCastModel
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int CastId { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(450)]
        public string Character { get; set; }

        public virtual MovieResponseModel Movie { get; set; } // virtual properties help in lazy loading
        public virtual CastModel Cast { get; set; }
    }
}
