using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAutoMapper_0.DomainEntities
{
    public class Category
    {
        public Category()
        {
            CreatedDate = DateTime.Now;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
