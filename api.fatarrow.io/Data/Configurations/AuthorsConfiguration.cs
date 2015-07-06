using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using api.fatarrow.io.Models;

namespace api.fatarrow.io.Data.Configurations
{
    public class AuthorsConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorsConfiguration()
        {
            HasKey(a => a.id);

            Property(a => a.firstName).HasMaxLength(30);
            Property(a => a.lastName).HasMaxLength(30);
            Property(a => a.twitter).HasMaxLength(30);
            Property(a => a.website).HasMaxLength(255);
        }
    }
}
