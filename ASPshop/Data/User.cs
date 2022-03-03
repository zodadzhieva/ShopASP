using System.Collections.Generic;

namespace ASPshop.Data
{


    public class User
    {
       // public enum RoleType { admin,user}

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public RoleType Role { get; set; }
        public virtual ICollection<Order> Order { get; set; }

    
    }
}
