using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace VictoriaITELEC1C.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
