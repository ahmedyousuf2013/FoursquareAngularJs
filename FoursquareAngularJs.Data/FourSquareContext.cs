using FoursquareAngularJs.Data.Entities;
using FoursquareAngularJs.Data.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAngularJs.Data
{
    public class FourSquareContext :DbContext
    {
        public FourSquareContext() :
            base("DBConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FourSquareContext, FourSquareContextMigrationConfiguration>());
        }

        public DbSet<BookmarkedPlace> BookmarkedPlaces { get; set; }


        public DbSet<Countries>  Countries { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountriesMapper());
            modelBuilder.Configurations.Add(new BookmarkedPlaceMapper());
            modelBuilder.Configurations.Add(new UserMapper());
 

            base.OnModelCreating(modelBuilder);
        }
    }
}
