using System;
using System.Collections.Generic;
using System.Text;
using Petshop.Core.Entity;

namespace Petshop.Core.Domainservice
{
    public interface IPetRepository
    {
        // Create a pet
        Pet CreatePet(Pet newPet);
        // read data 
        Pet ReadById(int id);
        IEnumerable<Pet> GetAllPets();
        // update pet
        Pet UpdatePet(Pet petUpdate);
        // delete pet
        Pet DeletePet(int id);
    }
}
