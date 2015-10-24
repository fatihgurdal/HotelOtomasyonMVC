using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class CustomersModel
    {
        public int Id { get; set; }

        [DisplayName("Müşteri Adı"), Required]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [DisplayName("Müşteri Soyadı"), Required]
        [StringLength(25, MinimumLength = 2)]
        public string Surname { get; set; }

        [DisplayName("Telefon Numarası"), Required]
        [StringLength(14, MinimumLength = 10)]
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("E-Posta Adresi"), Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayName("İkamet Adresi"),Required]
        [StringLength(500, MinimumLength = 30)]
        public string Address { get; set; }

        [DisplayName("Bay Mı?"), Required]
        public bool IsMale { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Doğum Tarihi"), Required]
        public DateTime DateOfBirth { get; set; }
        //kan grubu enum olabilir

        [DisplayName("Kan Grubu")]
        public string BloodGroup { get; set; }

        [DisplayName("Kimlik Numarası / Pasaport Numarası"), Required]
        [StringLength(11, MinimumLength = 6)]
        public string IdentificationNumber { get; set; }

        [DisplayName("Evli Mi?"), Required]
        public bool IsMarried { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Uyruk Id")]
        public int NationalityId { get; set; }

        [DisplayName("Uyruk")]
        public Nationalities Nationality { get; set; }

        [DisplayName("Satışlar")]
        public ICollection<Sales> Sales { get; set; }
        [DisplayName("Odada Kalanlar")]
        public ICollection<StayingInRoom> StayingInRoom { get; set; }
    }

}