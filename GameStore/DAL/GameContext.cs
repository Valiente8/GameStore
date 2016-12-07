using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameStore.DAL
{
    public class GameContext : DbContext
    {
        public DbSet<Videojuego> Videojuegos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

    }
}