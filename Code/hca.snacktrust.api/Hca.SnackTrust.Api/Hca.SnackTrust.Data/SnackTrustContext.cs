using Hca.SnackTrust.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.
using System;
using System.Collections.Generic;
using System.Text;

namespace Hca.SnackTrust.Data
{
    public class SnackTrustContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.
        }



    }
}
