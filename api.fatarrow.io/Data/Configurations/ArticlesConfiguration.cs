using api.fatarrow.io.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.fatarrow.io.Data.Configurations
{
    public class ArticlesConfiguration : EntityTypeConfiguration<Article>
    {
        public ArticlesConfiguration()
        {
            HasKey(a => a.id);
        }
    }
}
