using System.ComponentModel.DataAnnotations;

namespace CRM_Project.DAL.Entity
{
    public class Login
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}