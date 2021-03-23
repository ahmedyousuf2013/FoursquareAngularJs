using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAngularJs.Data.Mappers
{
    public class CountriesMapper : EntityTypeConfiguration<Countries>
    {
        public CountriesMapper()
        {
            this.ToTable("Countries");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();
           

        }
    }
}
