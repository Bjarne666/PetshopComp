using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core;
using Petshop.Core.Entity;

namespace Petshop.infrastructure.SQL.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly PetshopContext _Context;

        public OwnerRepository(PetshopContext context)
        {
            _Context = context;
        }


        public List<Owner> ReadAll()
        {
            return _Context.Owners.ToList();
        }
        
        public Owner Create(Owner owner)
        {
            _Context.Attach(owner).State = EntityState.Added;
            _Context.SaveChanges();
            return owner;
        }

        public Owner Delete(int id)
        {
            var owner = new Owner();
            Owner.Id = id;
            var ownerRemoved = _Context.Remove(owner).Entity;
            _Context.SaveChanges();
            return ownerRemoved;
        }
    }
}
