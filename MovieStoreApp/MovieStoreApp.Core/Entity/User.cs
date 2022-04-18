using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieStoreApp.Core.Entity
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "Varchar")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "Varchar")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "Varchar")]
        public string Email { get; set; }
        [MaxLength(150)]
        [Column(TypeName = "Varchar")]
        public string HashedPassword { get; set; }
        [MaxLength(150)]
        [Column(TypeName = "Varchar")]
        public string Salt { get; set; }
        [MaxLength(20)]
        [Column(TypeName = "Varchar")]
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDate { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool IsLocked { get; set; }
        public int AccessFailedCount { get; set; }

    }
}
