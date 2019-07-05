using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");

            Id(x => x.CategoryID);

            Map(x => x.CategoryID).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.Description).Column("Description");
            Map(x => x.Picture).Column("Picture");
        }
    }
}
