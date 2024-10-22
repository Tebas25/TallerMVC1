using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMVC1.Models;

    public class EquiposLigaProEcuadorContext : DbContext
    {
        public EquiposLigaProEcuadorContext (DbContextOptions<EquiposLigaProEcuadorContext> options)
            : base(options)
        {
        }

        public DbSet<TallerMVC1.Models.Jugador> Jugador { get; set; } = default!;

public DbSet<TallerMVC1.Models.Equipos> Equipos { get; set; } = default!;

public DbSet<TallerMVC1.Models.Estadios> Estadios { get; set; } = default!;
    }
