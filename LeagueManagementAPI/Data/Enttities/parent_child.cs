using System;
using System.ComponentModel.DataAnnotations;

namespace LeagueManagementAPI.Data.Enttities
{
    public class parent_child
    {
        [Required]
        public int parent_id { get; set; }

        [Required]
        public int child_id { get; set; }

        [Required]
        public DateTime last_update { get; set; }    
    }
}
