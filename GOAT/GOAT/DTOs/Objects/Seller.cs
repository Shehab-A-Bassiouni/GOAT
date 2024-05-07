using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Seller:BaseEntity
    {
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required Role Role { get; set; }
    }
}
