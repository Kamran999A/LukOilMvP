using LukoilMVP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukoilMVP.Data
{
    public class PetrolOperationContext : DbContext
    {
        public PetrolOperationContext()
            :base("PetrolOperationDB")
        {
        }

        public DbSet<PetrolPaymentOperation> PetrolPaymentOperations { get; set; }

    }
}
