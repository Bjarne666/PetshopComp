using System;
using System.Collections.Generic;
using System.Text;
using Petshop.Core.Entity;

namespace Petshop.Core
{
   public interface IOwnerService
    {
        // new owner
        Owner NewOwner(string firstName, string lastName, string address);

        //Create // Post
        Owner Add(Owner owner);
        // read get

        List<Owner> FindAll();
        Owner FindSingle(int Id);

        //update // put
        Owner UpdateOwner(Owner ownerUpdate);

        // delete // Delete
        Owner Delete(Owner owner);

       

    }
}
