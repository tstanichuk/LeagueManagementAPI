using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class zip_code
    {
        [Key]
        public int zip_code_id { get; set; }

        [Required]
        public string postal_code { get; set; }

        [Required]
        public string city { get; set; }

        public string county_name { get; set; }

        [Required]
        public string state_id { get; set;}

        [Required]
        public string state_name { get; set; }

        public string timezone { get; set; }

        public int latitude { get; set; }

        public int longitude { get; set; }

        public int population { get; set; }

        [Required]
        public DateTime last_update { get; set; }    
    }
}
