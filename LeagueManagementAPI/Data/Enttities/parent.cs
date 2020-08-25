using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class parent
    {
        [Key]
        public int parent_id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public int address_id { get; set; }

        [Required]
        public string phone { get; set; }   

        [Required]
        public string email { get; set;}

        [Required]
        public DateTime last_update { get; set; }    
    }
}
