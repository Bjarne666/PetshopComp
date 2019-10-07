using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Petshop.Core.Entity;

namespace Petshop.Core.Appservice.IMPL
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepo;

        public OwnerService(IOwnerRepository ownerRepo)
        {
            _ownerRepo = ownerRepo;
        }

        public List<Owner> FindAll()
        {
            return _ownerRepo.ReadAll();
        }

        public Owner FindSingle(int id)
        {
            return _ownerRepo.ReadAll().FirstOrDefault(owner => Owner.Id == id);
        }

        public Owner UpdateOwner(Owner ownerUpdate)
        {
            return _ownerRepo.Update(ownerUpdate);
        }

        public Owner Add(Owner owner)
        {
            return _ownerRepo.Create(owner);
        }

        public Owner Delete(Owner owner)
        {
            return _ownerRepo.Delete(Owner.Id);
        }

        public Owner NewOwner(string FirstName, string LastName, string Address)
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                throw new InvalidDataException("invalid first name");
            }

            if (string.IsNullOrEmpty(LastName))
            {
                throw new InvalidDataException("invalid last name");
            }

            if (string.IsNullOrEmpty(Address))
            {
                throw new InvalidDataException("invalid address");
            }

         

            var owner = new Owner()
            {
                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
            };
            return owner;
        }
    }
}