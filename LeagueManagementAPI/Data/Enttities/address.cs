using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class address
    {
        [Key]
        public int address_id { get; set; }

        [Required]
        public string street { get; set; }

        public string apartment_number { get; set; }

        [Required]
        public int zip_code_id { get; set;}

        [Required]
        public DateTime last_update { get; set; }    
    }
}
