using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core.Entity;

namespace Petshop.infrastructure.SQL
{
  public  class PetshopContext: DbContext
  {
      public PetshopContext(DbContextOptions opt): base(opt)
      {

      }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
