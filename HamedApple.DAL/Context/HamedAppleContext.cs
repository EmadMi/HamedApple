using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.DAL.Context
{
    class HamedAppleContext : DbContext
    {
        public HamedAppleContext() : base("name=ConString")
        {

        }
    }
}
