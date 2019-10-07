using Petshop.Core.Entity;

namespace Petshop.infrastructure.SQL
{
    public class DBInitializer
    {
        public static void Initdata(PetshopContext _context)
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _context.Owners.Add(new Owner()
            {
                FirstName = "John",
                LastName = "Doe"
            });

            _context.Owners.Add(new Owner()
            {
                FirstName = "jane",
                LastName = "Doe"
            });
            _context.SaveChanges();
        }
    }
}