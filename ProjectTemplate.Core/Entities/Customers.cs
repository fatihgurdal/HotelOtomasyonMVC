using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Customers:IEntityKey<int>
    {

        public Customers()
        {
            Sales= new HashSet<Sales>();
            StayingInRoom= new HashSet<StayingInRoom>();
        }
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateOfBirth { get; set; }
        //kan grubu enum olabilir
        public string BloodGroup { get; set; }

        public bool IsActive { get; set; }
        public string IdentificationNumber { get; set; }
        public bool IsMarried { get; set; }
        public string Description { get; set; }
        public int NationalityId { get; set; }

        public virtual Nationalities Nationality { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }

        public virtual ICollection<StayingInRoom> StayingInRoom { get; set; }

        
    }
}
