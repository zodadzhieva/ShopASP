using ASPshop.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPshop.Models
{
    public class UsersVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="This field is required")]

        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public string Password{ get; set; }
        [Required(ErrorMessage = "This field is required")]

        public string FullName { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public string Email { get; set; }
      
        [Required(ErrorMessage = "This field is required")]  
        [EnumDataType(typeof(RoleType))]
        public RoleType Role{ get; set; }
        
        [NotMapped]
        public List<SelectListItem> Orders { get; set; }
       // public RoleType RoleType { get; internal set; }
    }
}
