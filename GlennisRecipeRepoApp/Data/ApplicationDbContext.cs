using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GlennisRecipeRepoApp.Models;

namespace GlennisRecipeRepoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GlennisRecipeRepoApp.Models.Recipe> Recipe { get; set; }
        public DbSet<GlennisRecipeRepoApp.Models.Feedback> Feedback { get; set; }
    }
}
