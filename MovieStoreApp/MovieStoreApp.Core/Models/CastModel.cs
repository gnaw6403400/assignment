using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Models
{
    public class CastModel
    {

        public int Id { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage ="Cast Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender is Required")]
        public int Gender { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Tmdb Url is Required")]
        [DataType(DataType.Url)]
        public string TmdbUrl { get; set; }
        [MaxLength(130)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "ProfilePath is Required")]
        [DataType(DataType.Url)]
        public string ProfilePath { get; set; }

        public virtual ICollection<MovieCastModel> MovieCasts { get; set; }
    }
}
