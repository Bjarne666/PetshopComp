using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Petshop.Core.Entity
{
    public class Owner
    {
        public static int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
