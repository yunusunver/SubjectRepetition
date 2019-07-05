using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x=>x.CategoryID);

            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.Picture).HasColumnName("Picture");
        }
    }
}
