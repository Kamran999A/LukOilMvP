using LukOilMVP.Models;
using System.Data.Entity;

namespace LukOilMVP.Data
{
    public class PetrolOperationContext : DbContext
    {
        public PetrolOperationContext()
            : base("PetrolOperationDB")
        {
        }
        public DbSet<PetrolPaymentOperation> PetrolPaymentOperations { get; set; }

    }
}
