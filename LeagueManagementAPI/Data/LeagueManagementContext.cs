using System;
using LeagueManagementAPI.Data.Enttities;
using Microsoft.EntityFrameworkCore;

namespace LeagueManagementAPI.Data
{
    public class LeagueManagementContext : DbContext
    { 
        public LeagueManagementContext(DbContextOptions<LeagueManagementContext> options) : base(options) { }

        public DbSet<login> login { get; set; }
        public DbSet<parent> parent {get; set; }
        public DbSet<address> address { get; set;}
        public DbSet<zip_code> zip_code { get; set; }
        public DbSet<child> child { get; set; }
        public DbSet<parent_child> parent_child { get; set; }
    }   

}
