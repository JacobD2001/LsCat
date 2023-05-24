using System;
using System.Collections.Generic;
using LsCat.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LsCat.Models
{
    public partial class LsCatContext : IdentityDbContext<LsCatUser>
    {
        public LsCatContext()
        {

        }

        public LsCatContext(DbContextOptions<LsCatContext> options)
       : base(options)
        {
        }
        
        public virtual DbSet<SearchHistory> SearchHistory { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }

    }
}
