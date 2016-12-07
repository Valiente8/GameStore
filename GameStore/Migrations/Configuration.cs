namespace GameStore.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameStore.DAL.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameStore.DAL.GameContext";
        }

        protected override void Seed(GameStore.DAL.GameContext context)
        {


            var generos = new List<Genero>
            {
                new Genero {Nombre="Aventura"},
                new Genero {Nombre="Acción"},
                new Genero  {Nombre="Carreras"},
                new Genero {Nombre="Deportes"},
                new Genero  {Nombre="FPS"},
                new Genero  {Nombre="MMO"},
                new Genero  {Nombre="RPG"},
            };

            generos.ForEach(c => context.Generos.AddOrUpdate(p => p.Nombre, c));
            context.SaveChanges();




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
