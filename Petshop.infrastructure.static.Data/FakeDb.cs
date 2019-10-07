using System;
using System.Collections.Generic;
using System.Text;
using Petshop.Core.Entity;

namespace Petshop.Infrastructure.Static.Data
{
    public class FakeDb
    {
        internal static int OwnerId = 1;
        internal static List<Owner> OwnerTable = new List<Owner>();

        public static int Id = 1;
        public static IEnumerable<Pet> AllPets;

        public static void InitData()
        {
            var listPets = new List<Pet>();

            var dog = new Pet()
            {
                Colour = "black",
                Type = "Dog",
                Price = 1500,
                SoldDate = DateTime.Today,
                BirthDate = DateTime.Now.AddYears(2005).AddMonths(11).AddDays(19),
                Name = "Fifi",
                PreviousOwner = "Lars Larsen",
                Id = 1,

            };
            var lion = new Pet()
            {
                Colour = "Red",
                Type = "Lion",
                Price = 5000,
                Id = 2,
                SoldDate = DateTime.Today,
                BirthDate = DateTime.Now.AddYears(2009).AddMonths(5).AddDays(8),
                Name = "Jack",
                PreviousOwner = "svend ole thorson",
            };
            var shark = new Pet()
            {
                Colour = "White",
                Price = 50000,
                BirthDate = DateTime.Now.AddYears(2016).AddMonths(1).AddDays(1),
                Type = "Shark",
                Name = "Jaws",
                Id = 3,
                SoldDate = DateTime.Now,
                PreviousOwner = "Frank vad",
            };
            var tiger = new Pet()
            {
                Colour = "yellow",
                Id =4, 
                Price = 100000,
                BirthDate = DateTime.Now.AddYears(2004).AddMonths(5).AddDays(8),
                Type = "Tiger",
                Name = "virgil",
                SoldDate = DateTime.Today,
                PreviousOwner = "Arnold Swarzenstegger"
            };

            var aligator = new Pet()
            {
                Id = 5,
                Colour = "Green",
                Price = 250000,
                BirthDate = DateTime.Now.AddYears(2010).AddMonths(7).AddDays(13),
                Type = "Aligator",
                Name = "Killer Croc",
                SoldDate = DateTime.Today,
                PreviousOwner = "Dundee Odriscoll",


            };
            OwnerTable.Add(
                new Owner
                {
                    FirstName = "Ingo",
                    LastName = "Nøffe"
                });
            OwnerTable.Add(
                new Owner
                {
                    FirstName = "Bingo",
                    LastName = "Børgesen"
                });
            listPets.Add(dog);
            listPets.Add(aligator);
            listPets.Add(lion);
            listPets.Add(shark);
            listPets.Add(tiger);
            AllPets = listPets;

        }
    }
}
