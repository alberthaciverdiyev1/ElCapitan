using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.EntityLayer
{
    public class AppUser:IdentityUser<int>
    {
        [StringLength(50)]   
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Surname { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
