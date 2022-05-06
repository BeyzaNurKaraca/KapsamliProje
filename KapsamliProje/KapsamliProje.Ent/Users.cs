using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Users
    {
        [Key]
        public string  UserId { get; set; } = null !;
        public byte[] PasswordSalt { get; set; } = null!;
        public byte[]  PasswordHash { get; set; } = null ! ;
        public string Role { get; set; } = null!; 

    }
}
