using System.ComponentModel.DataAnnotations;

namespace GeoSys_backend.Models
{
    public class UserModel
    {
        [Key]public string id { get; set; }
        [Required] public string uniqueUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
       /* public string _password { get; set; }//will need to encrypt at some point*/
        

        public UserModel()
        {
            id = Guid.NewGuid().ToString("N")/*to remove dashes*/.Substring(0, 8);
            
        }
    }
}
