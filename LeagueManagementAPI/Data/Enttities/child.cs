using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class child
    {
        [Key]
        public int child_id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        [Required]
        public string gender { get; set; }   

        [Required]
        public DateTime last_update { get; set; }    
    }
}
