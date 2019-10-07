using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core.Domainservice;
using Petshop.Core.Entity;

namespace Petshop.infrastructure.SQL.Repository
{
   public class PetRepository: IPetRepository
   {
       private readonly PetshopContext _context;

       public PetRepository(PetshopContext context)
       {
           _context = context;
       }
        public Pet CreatePet(Pet newPet)
        {
            _context.Attach(newPet).State = EntityState.Added;
            _context.SaveChanges();
            return newPet;
        }

        public Pet ReadById(int id)
        {
            return _context.Pets
                .Include(pet => pet.Name)
                .ThenInclude(pet => pet)
                .FirstOrDefault(pet => pet.Id == id);
        }

        public IEnumerable<Pet> GetAllPets()
        {
            throw new NotImplementedException();
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            throw new NotImplementedException();
        }

        public Pet DeletePet(int id)
        {
            var removed = _context.Remove(new Pet { Id = id }).Entity;
            _context.SaveChanges();
            return removed;
        }
   }
}
