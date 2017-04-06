using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XSSAttackDemo.Models
{
    public class Role
    {
        public int Id { get; set; }
        [AllowHtml]
        public string RoleName { get; set; }

        public virtual ICollection<User> RoleUsers { get; set; }

    }
}