using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSAttackDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // New Column
        // Drop Column
        //public DateTime BirthDate { get; set; }

        public virtual ICollection<Role> UserRoles { get; set; }
    }
}