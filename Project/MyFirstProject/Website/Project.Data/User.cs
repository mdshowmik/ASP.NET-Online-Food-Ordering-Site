using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime LastOnline { get; set; }
        public string DateOfBirth { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
