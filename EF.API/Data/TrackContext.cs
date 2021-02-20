using System;
using EF.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.API.Data
{
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options)
        {
        }

        public DbSet<Track> Track { get; set; }
    }
}
