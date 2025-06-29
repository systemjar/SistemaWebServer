using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extension.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}