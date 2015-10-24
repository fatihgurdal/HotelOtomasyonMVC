using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
   public class EmployeesModel
   {
       [DisplayName("Çalışan Adı")]
        public int Id { get; set; }
       [DisplayName("Sicil Numarası")]
        public string RegistrationNumber { get; set; }
       [DisplayName("Personel Adı")]
        public string Name { get; set; }
       [DisplayName("Personel Soyadı")]
        public string Surname { get; set; }

        [DisplayName("Doğum Tarihi"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime DateOfBirth { get; set; }

       [DisplayName("Doğum Yeri")]
        public string PlaceOfBirth { get; set; }
       [DisplayName("Bay Mı?")]
        public bool IsMale { get; set; }
       [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [DisplayName("Kimlik Numarası")]
       public string IdentificationNumber { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Eposta Adresi")]
        public string EmailAddress { get; set; }
       [DisplayName("İkamet Adresi")]
        public string Address { get; set; }
       [DisplayName("Aylık Ücret Mi?")]
        public bool IsMonthlyWage { get; set; }
       [DisplayName("Maaş")]
        public decimal Salary { get; set; }

       [DisplayName("İşe Başlama Tarihi"), DataType(DataType.Date)]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
       [Required]
        public DateTime DateOfEntry { get; set; }
      
       [DisplayName("İşten Ayrılış Tarihi"), DataType(DataType.Date)]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
       [Required]
        public DateTime? DepartureDate { get; set; }
       [DisplayName("Çalışıyor Mu?")]
        public bool IsWorked { get; set; }
       [DisplayName("Açıklama")]
        public string Description { get; set; }
       [DisplayName("Kan Grubu")]
        public string BloodGroup { get; set; }
       [DisplayName("Personel Grup Id")]
        public int GroupsOfEmployeeId { get; set; }
       [DisplayName("Personel Grubu")]
        public GroupsOfEmployee GroupsOfEmployee { get; set; }
       [DisplayName("Personel Vardiyaları")]
        public ICollection<EmployeeShifts> EmployeeShifts { get; set; }
       [DisplayName("İzinler")]
        public ICollection<Permits> Permits { get; set; }

        [DisplayName("Satışlar")]
        public ICollection<Sales> Sales { get; set; }
        [DisplayName("Kullanıcılar")]
       public ICollection<Users> Users { get; set; }


    }
}
