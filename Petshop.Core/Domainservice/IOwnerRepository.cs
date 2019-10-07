using System;
using System.Collections.Generic;
using System.Text;
using Petshop.Core.Entity;

namespace Petshop.Core
{
   public interface IOwnerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // I Wanna be Able to Read All Customers
        List<Owner> ReadAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        // I Wanna be Able to Create a new Customer
        Owner Create(Owner customer);

        Owner Delete(int id);

        Owner Update(Owner ownerUpdate);
    }
}
