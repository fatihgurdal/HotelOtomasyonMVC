using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Employees:IEntityKey<int>
   {
       public Employees()
       {
           EmployeeShifts=new HashSet<EmployeeShifts>();
           Permits= new HashSet<Permits>();
           Sales= new HashSet<Sales>();
           Users= new HashSet<Users>();
       }
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentificationNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsMale { get; set; }
       
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public bool IsMonthlyWage { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime? DepartureDate { get; set; }
        public bool IsWorked { get; set; }
        public string Description { get; set; }
        public string BloodGroup { get; set; }

        public int GroupsOfEmployeeId { get; set; }

        public virtual GroupsOfEmployee GroupsOfEmployee { get; set; }
        public virtual ICollection<EmployeeShifts> EmployeeShifts { get; set; }
        public virtual ICollection<Permits> Permits { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }

       public virtual ICollection<Users> Users { get; set; }
    }
}
