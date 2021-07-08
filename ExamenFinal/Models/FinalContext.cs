using ExamenFinal.Models.Maps;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ExamenFinal.Models
{
    public interface IFinalContext
    {
         DbSet<Usuario> Usuarios { get; set; }
         DbSet<Nota> Notas { get; set; }
         DbSet<NotaUsuario> NotaUsuario { get; set; }
         DbSet<Tag> Tags { get; set; }
         DbSet<NotaTag> NotaTags { get; set; }
         int SaveChanges();
         EntityEntry<TEntity> Add<TEntity>([NotNull] TEntity entity) where TEntity : class;
         EntityEntry<TEntity> Update<TEntity>([NotNull] TEntity entity) where TEntity : class;
    }


    public class FinalContext : DbContext, IFinalContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<NotaUsuario> NotaUsuario { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NotaTag> NotaTags { get; set; }


        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Esto se hace por cada tabla de base de datos
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new NotaUsuarioMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new NotaTagMap());
        //    modelBuilder.ApplyConfiguration(new PersonMap());
        //    modelBuilder.ApplyConfiguration(new CityMap());
        //    modelBuilder.ApplyConfiguration(new TypeMap());
        //    modelBuilder.ApplyConfiguration(new UserMap());
        //    modelBuilder.ApplyConfiguration(new TransactionMap());
        //    modelBuilder.ApplyConfiguration(new FileMap());
        }




    }
}
