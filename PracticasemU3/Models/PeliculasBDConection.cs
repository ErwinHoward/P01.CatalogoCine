using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PracticasemU3.Models
{
    public class PeliculasBDConection:DbContext
    {

        public PeliculasBDConection():base("Pelicula")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public object Pelicula { get; internal set; }
    }
}