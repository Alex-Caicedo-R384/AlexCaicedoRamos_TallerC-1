using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlexCaicedoRamos_TallerC_1.Models;

namespace AlexCaicedoRamos_TallerC_1.Data
{
    public class AlexCaicedoRamos_TallerC_1Context : DbContext
    {
        public AlexCaicedoRamos_TallerC_1Context (DbContextOptions<AlexCaicedoRamos_TallerC_1Context> options)
            : base(options)
        {
        }

        public DbSet<AlexCaicedoRamos_TallerC_1.Models.Burger> Burger { get; set; } = default!;

        public DbSet<AlexCaicedoRamos_TallerC_1.Models.Promo>? Promo { get; set; }
    }
}
