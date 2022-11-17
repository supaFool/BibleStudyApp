using BibleBuddy.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBuddy.AppCore
{
    public class Core
    {
        private User _user;
        public Core()
        {
            if (_user == null)
            {
                _user = new User()
                {
                    Name = "Temp User",
                    Email = "fakemail.xyz.com",
                    Id = 0
                };
                Console.WriteLine("Created Temp User");
            }
        }
    }
}
