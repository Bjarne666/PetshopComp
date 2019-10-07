using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Petshop.Core;
using Petshop.Core.Entity;

namespace Petshop.Infrastructure.Static.Data.Repository
{
    public class CustomerRepository : IOwnerRepository
    {
        public List<Owner> ReadAll()
        {
            return FakeDb.OwnerTable;
        }

        public Owner Create(Owner owner)
        {
            Owner.Id = FakeDb.OwnerId++;
            FakeDb.OwnerTable.Add(owner);    
            return owner;
        }

        public Owner Delete(int id)
        {
            var toRemove = FakeDb.OwnerTable.FirstOrDefault(owner => Owner.Id == id);
            FakeDb.OwnerTable.Remove(toRemove);
            return toRemove;
        }
    }
}
