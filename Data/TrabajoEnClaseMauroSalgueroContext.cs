using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabajoEnClaseMauroSalguero.Models;

namespace TrabajoEnClaseMauroSalguero.Data
{
    public class TrabajoEnClaseMauroSalgueroContext : DbContext
    {
        public TrabajoEnClaseMauroSalgueroContext (DbContextOptions<TrabajoEnClaseMauroSalgueroContext> options)
            : base(options)
        {
        }

        public DbSet<TrabajoEnClaseMauroSalguero.Models.Burger> Burger { get; set; } = default!;

        public DbSet<TrabajoEnClaseMauroSalguero.Models.Promo>? Promo { get; set; }
    }
}
