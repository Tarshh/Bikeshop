using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bikeshop.Models
{
    public class Customer : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public List<ShoppingBag> Bags { get; set; }
    }
}
