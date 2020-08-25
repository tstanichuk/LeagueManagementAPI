using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class login
    {
        [Key]
        public int login_id { get; set; }

        [Required]
        public string username { get; set; }

        public string password_hash { get; set; }

        public string password_salt { get; set; }

        public string password_hash_algorithm { get; set; }   

        public int parent_id { get; set;}

        [Required]
        public DateTime last_update { get; set; }    
    }
}
