using System.Collections.Generic;

namespace ASPshop.Data
{
    
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TypeType Type { get; set; }
        public virtual ICollection<Order> Order{ get; set; }
    }
}
