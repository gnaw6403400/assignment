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
        public string Name { get; set; }

        public int Gender { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        public string TmdbUrl { get; set; }
        [MaxLength(130)]
        [Column(TypeName = "Varchar")]
        public string ProfilePath { get; set; }

        public virtual ICollection<MovieCastModel> MovieCasts { get; set; }
    }
}
