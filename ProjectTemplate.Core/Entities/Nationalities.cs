using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Nationalities:IEntityKey<int>
    {
        public Nationalities()
        {
            Customers= new HashSet<Customers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
