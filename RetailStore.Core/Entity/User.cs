using System.ComponentModel.DataAnnotations.Schema;

namespace RetailStore.Core.Entity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } 
        [ForeignKey("RoleID")]
        public Role Role { get; set; }
        public int RoleID { get; set; }
    }
}
