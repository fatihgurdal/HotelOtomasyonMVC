using ProjectTemplate.Core.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Reflection;
using System.Web;

namespace ProjectTemplate.Core.EF
{
    public class ProjectTemplateConfiguration : DbMigrationsConfiguration<ProjectTemplateContext>
    {
        public ProjectTemplateConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }


    public class DbInitializer : CreateDatabaseIfNotExists<ProjectTemplateContext>
    {
         
        protected override void Seed(ProjectTemplateContext context)
        {
            #region <-- Departmanlar -->
            Departments departments1 = new Departments()
            {
                Id = 1,
                Name = "Yönetici"
            };
            Departments departments2 = new Departments()
            {
                Id = 2,
                Name = "Hizmet"
            };
            Departments departments3 = new Departments()
            {
                Id = 3,
                Name = "Servis"
            };
            Departments departments4 = new Departments()
            {
                Id = 4,
                Name = "Mutfak"
            };
            context.Departments.Add(departments1);
            context.Departments.Add(departments2);
            context.Departments.Add(departments3);
            context.Departments.Add(departments4);
            context.SaveChanges();

            #endregion

            #region <-- Personel Grupları -->

            GroupsOfEmployee groupsOfEmployee1 = new GroupsOfEmployee()
            {
                Name = "Müdür",
                DepartmentId = departments1.Id,
                Department = departments1

            };
            GroupsOfEmployee groupsOfEmployee2 = new GroupsOfEmployee()
            {
                Name = "İnsan Kaynakları",
                DepartmentId = departments1.Id,
                Department = departments1

            };
            GroupsOfEmployee groupsOfEmployee3 = new GroupsOfEmployee()
            {
                Name = "Muhasebe",
                DepartmentId = departments1.Id,
                Department = departments1

            };
            GroupsOfEmployee groupsOfEmployee4 = new GroupsOfEmployee()
            {
                Name = "Aşçı",
                DepartmentId = departments4.Id,
                Department = departments4

            };

            GroupsOfEmployee groupsOfEmployee5 = new GroupsOfEmployee()
            {
                Name = "Resepsiyon",
                DepartmentId = departments3.Id,
                Department = departments3

            };

            GroupsOfEmployee groupsOfEmployee6 = new GroupsOfEmployee()
            {
                Name = "Oda Servisi",
                DepartmentId = departments2.Id,
                Department = departments2

            };
            GroupsOfEmployee groupsOfEmployee7 = new GroupsOfEmployee()
            {
                Name = "Güvenlik",
                DepartmentId = departments2.Id,
                Department = departments2

            };
            context.GroupsOfEmployee.Add(groupsOfEmployee1);
            context.GroupsOfEmployee.Add(groupsOfEmployee2);
            context.GroupsOfEmployee.Add(groupsOfEmployee3);
            context.GroupsOfEmployee.Add(groupsOfEmployee4);
            context.GroupsOfEmployee.Add(groupsOfEmployee5);
            context.GroupsOfEmployee.Add(groupsOfEmployee6);
            context.GroupsOfEmployee.Add(groupsOfEmployee7);
            context.SaveChanges();
            #endregion


            #region <-- Personeller -->


            Employees employees1 = new Employees()
            {
                Address = "Karaköprü mah. merve sokak torunoğlu apartmanı",
                DateOfBirth = new DateTime(1992, 8, 30),
                BloodGroup = "B RH-",
                DateOfEntry = new DateTime(2015, 01, 01),
                DepartureDate =  new DateTime(2015, 02, 02),
                Description = "İlk Personel ve en üst kıdemli kişidir.",
                EmailAddress = "f.gurdal@hotmail.com.tr",
                GroupsOfEmployeeId = groupsOfEmployee1.Id,
                GroupsOfEmployee = groupsOfEmployee1,
                IsMale = true,
                IsMonthlyWage = true,
                Name = "Fatih",
                IsWorked = true,
                PhoneNumber = "05075243492",
                PlaceOfBirth = "Kocaeli",
                RegistrationNumber = "SGK123456",
                IdentificationNumber = "14235678963",
                Salary = 7500,
                Surname = "GÜRDAL",
                IsActive = true
            };

            Employees employees2 = new Employees()
            {
                Address = "Emek mah. Kuzey sokak no:13",
                DateOfBirth = new DateTime(1989, 6, 10),
                BloodGroup = "B RH+",
                DateOfEntry = new DateTime(2010, 01, 01),
                DepartureDate = new DateTime(2015, 02, 02),
                Description = "İkinci Personel ve insan Kaynaklarında kıdemli kişidir.",
                EmailAddress = "firdevs.ekrem@hotmail.com.tr",
                GroupsOfEmployeeId = groupsOfEmployee2.Id,
                GroupsOfEmployee = groupsOfEmployee2,
                IsMale = false,
                IsMonthlyWage = true,
                Name = "Firdevs",
                IsWorked = true,
                PhoneNumber = "05075589492",
                PlaceOfBirth = "Kocaeli",
                RegistrationNumber = "SGK123789",
                IdentificationNumber = "14235674563",
                Salary = 4500,
                Surname = "Ekrem",
                IsActive = true
            };

            Employees employees3 = new Employees()
            {
                Address = "Fatih mah. güney sokak no:1",
                DateOfBirth = new DateTime(1988, 10, 10),
                BloodGroup = "AB RH+",
                DateOfEntry = new DateTime(2005, 01, 01),
                Description = "insan Kaynaklarında kıdemli kişiydi .",
                EmailAddress = "fatma.yildiz@hotmail.com.tr",
                GroupsOfEmployeeId = groupsOfEmployee2.Id,
                GroupsOfEmployee = groupsOfEmployee2,
                IsMale = true,
                IsMonthlyWage = true,
                Name = "Fatma",
                IsWorked = false,
                DepartureDate = new DateTime(2009, 12, 30),
                PhoneNumber = "05075589492",
                PlaceOfBirth = "Kocaeli",
                RegistrationNumber = "SGK123789",
                IdentificationNumber = "14235674563",
                Salary = 4000,
                Surname = "Yıldız",
                IsActive = true
            };

            Employees employees4 = new Employees()
            {
                Address = "fetih mah. 678 sokak no:10",
                DateOfBirth = new DateTime(1990, 02, 20),
                BloodGroup = "0 RH+",
                DateOfEntry = new DateTime(2015, 01, 01),
                DepartureDate = new DateTime(2015, 02, 02),
                EmailAddress = "zeynep.ulusoy@hotmail.com.tr",
                GroupsOfEmployeeId = groupsOfEmployee2.Id,
                GroupsOfEmployee = groupsOfEmployee2,
                IsMale = true,
                IsMonthlyWage = true,
                Name = "Zeynep",
                IsWorked = false,
                PhoneNumber = "05075589430",
                PlaceOfBirth = "Kocaeli",
                RegistrationNumber = "SGK123009",
                IdentificationNumber = "12335674563",
                Salary = 4000,
                Surname = "Ulusoy",
                IsActive = true
            };

            Employees employees5 = new Employees()
            {
                Address = "yalı mah. deniz sokak no:3",
                DateOfBirth = new DateTime(1990, 10, 12),
                BloodGroup = "0 RH-",
                DateOfEntry = new DateTime(2014, 01, 01),
                DepartureDate = new DateTime(2015, 02, 02),
                EmailAddress = "ahmet.ay@hotmail.com.tr",
                GroupsOfEmployeeId = groupsOfEmployee6.Id,
                GroupsOfEmployee = groupsOfEmployee6,
                IsMale = false,
                IsMonthlyWage = false,
                Name = "Ahmet",
                IsWorked = true,
                PhoneNumber = "05075589112",
                PlaceOfBirth = "İstanbul",
                RegistrationNumber = "SGK123855",
                IdentificationNumber = "74235674563",
                Salary = 20,
                Surname = "Ay",
                IsActive = true
            };

           
            context.Employees.Add(employees1);
            context.Employees.Add(employees2);
          
            context.Employees.Add(employees3);
            context.Employees.Add(employees4);
            context.Employees.Add(employees5);


            context.SaveChanges();
            #endregion

            #region <-- Kullanıcılar -->
            Users users1 = new Users()
            {
                Id = 1,
                UserName = "fatihgurdal",
                Password = "14451445"
            };

            Users users2 = new Users()
            {
                Id = 2,
                UserName = "firdevsekrem",
                Password = "123456"
            };
            context.Users.Add(users1);
            context.Users.Add(users2);
            employees1.Users.Add(users1);
            employees2.Users.Add(users2);
            context.SaveChanges();
            #endregion


            #region <-- Yetkiler -->

            Authorities sale1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Satış Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(sale1);
            context.SaveChanges();

            Authorities sale2 = new Authorities {  ControllerName = string.Empty, ActionName = string.Empty, Name = "Satış İşlemleri", FaIconCode = string.Empty, SubAuthorityId=sale1.Id };

            context.Authoritys.Add(sale2);
            context.SaveChanges();

            Authorities sale3 = new Authorities {  ControllerName = "Sale", ActionName = "OpenSale", Name = "Hesap Aç", FaIconCode = string.Empty, SubAuthorityId=sale2.Id };

            
            context.Authoritys.Add(sale3);
            context.SaveChanges();


            Authorities sale5 = new Authorities {  ControllerName = "Sale", ActionName = "RoomSalesList", Name = "Rezerve Listesi", FaIconCode = string.Empty, SubAuthorityId = sale2.Id };

            context.Authoritys.Add(sale5);
            context.SaveChanges();

            Authorities sale6 = new Authorities { ControllerName = "Sale", ActionName = "SalesInsert", Name = "Hesap Kes", FaIconCode = string.Empty, SubAuthorityId = sale2.Id };

            context.Authoritys.Add(sale6);
            context.SaveChanges();
            
            Authorities sale7 = new Authorities { ControllerName = "Sale", ActionName = "SalesList", Name = "Hesap Listesi", FaIconCode = string.Empty, SubAuthorityId = sale2.Id };

            context.Authoritys.Add(sale7);
            context.SaveChanges();

            Authorities sale8 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Ekstra Harcama İşlemleri", FaIconCode = string.Empty, SubAuthorityId = sale1.Id };

            context.Authoritys.Add(sale8);
            context.SaveChanges();

            Authorities sale9 = new Authorities {  ControllerName = "Sale", ActionName = "SaleExtrasInsert", Name = "Ekstra Harcama Ekle", FaIconCode = string.Empty, SubAuthorityId = sale8.Id };

            context.Authoritys.Add(sale9);
            context.SaveChanges();

            Authorities sale10 = new Authorities {  ControllerName = "Sale", ActionName = "SaleExtrasList", Name = "Ekstra Harcama Listesi", FaIconCode = string.Empty, SubAuthorityId = sale8.Id };


            context.Authoritys.Add(sale10);
            context.SaveChanges();
            
            
            
            Authorities customer1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Müşteri Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(customer1);
            context.SaveChanges();

            Authorities customer2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Müşteri İşlemleri", FaIconCode = string.Empty, SubAuthorityId=customer1.Id };

            context.Authoritys.Add(customer2);
            context.SaveChanges();

            Authorities customer3 = new Authorities { ControllerName = "Customer", ActionName = "CustomerInsert", Name = "Müşteri Ekle", FaIconCode = string.Empty, SubAuthorityId=customer2.Id };

            context.Authoritys.Add(customer3);
            context.SaveChanges();

            Authorities customer4 = new Authorities { ControllerName = "Customer", ActionName = "CustomerList", Name = "Müşteri Listesi", FaIconCode = string.Empty, SubAuthorityId=customer2.Id };

            context.Authoritys.Add(customer4);
            context.SaveChanges();

            Authorities customer5 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Günlük Müşteri İşlemleri", FaIconCode = string.Empty, SubAuthorityId=customer1.Id };

            context.Authoritys.Add(customer5);
            context.SaveChanges();

            Authorities customer6 = new Authorities { ControllerName = "Customer", ActionName = "CustomersArrivingTodayList", Name = "Bugün Giriş Yapanlar", FaIconCode = string.Empty, SubAuthorityId=customer5.Id };

            context.Authoritys.Add(customer6);
            context.SaveChanges();

            Authorities customer7 = new Authorities { ControllerName = "Customer", ActionName = "CustomersWillLeaveTodayList", Name = "Bugün Çıkış Yapacaklar", FaIconCode = string.Empty, SubAuthorityId = customer5.Id };

            context.Authoritys.Add(customer7);
            context.SaveChanges();

            Authorities customer8 = new Authorities { ControllerName = "Customer", ActionName = "CustomersStayingInTheHotelTodayList", Name = "Otelde Kalan Müşteriler", FaIconCode = string.Empty, SubAuthorityId = customer5.Id };

            context.Authoritys.Add(customer8);
            context.SaveChanges();

            Authorities customer9 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Uyruk İşlemleri", FaIconCode = string.Empty, SubAuthorityId=customer1.Id };

            context.Authoritys.Add(customer9);

            context.SaveChanges();

            Authorities customer10 = new Authorities { ControllerName = "Customer", ActionName = "NationalityInsert", Name = "Uyruk Ekle", FaIconCode = string.Empty, SubAuthorityId=customer9.Id };

            context.Authoritys.Add(customer10);

            context.SaveChanges();

            Authorities customer11 = new Authorities { ControllerName = "Customer", ActionName = "NationalityList", Name = "Uyruk Listesi", FaIconCode = string.Empty, SubAuthorityId = customer9.Id };

            context.Authoritys.Add(customer11);

            context.SaveChanges();

            
           
          
            Authorities room1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Oda Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(room1);
            context.SaveChanges();

            Authorities room2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Oda İşlemleri", FaIconCode = string.Empty, SubAuthorityId=room1.Id };

            context.Authoritys.Add(room2);
            context.SaveChanges();

            Authorities room3 = new Authorities { ControllerName = "Room", ActionName = "RoomInsert", Name = "Oda Ekle", FaIconCode = string.Empty, SubAuthorityId=room2.Id };

            context.Authoritys.Add(room3);
            context.SaveChanges();

            Authorities room4 = new Authorities { ControllerName = "Room", ActionName = "RoomList", Name = "Oda Listesi", FaIconCode = string.Empty, SubAuthorityId = room2.Id };

            context.Authoritys.Add(room4);
            context.SaveChanges();

            Authorities room5 = new Authorities { ControllerName = "Room", ActionName = "RoomByRoomStatus", Name = "Duruma Göre Odalar", FaIconCode = string.Empty, SubAuthorityId = room2.Id };

            context.Authoritys.Add(room5);
            context.SaveChanges();

            Authorities room6 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Durum İşlemleri", FaIconCode = string.Empty, SubAuthorityId = room1.Id };

            context.Authoritys.Add(room6);
            context.SaveChanges();

            Authorities room7 = new Authorities { ControllerName = "Room", ActionName = "RoomStatusInsert", Name = "Oda Durum Ekle", FaIconCode = string.Empty, SubAuthorityId=room6.Id };

            context.Authoritys.Add(room7);
            context.SaveChanges();

            Authorities room8 = new Authorities { ControllerName = "Room", ActionName = "RoomStatusList", Name = "Oda Durum Listesi", FaIconCode = string.Empty, SubAuthorityId = room6.Id };

            context.Authoritys.Add(room8);
            context.SaveChanges();

            Authorities room9 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Otel İşlemleri", FaIconCode = string.Empty, SubAuthorityId = room1.Id };

            context.Authoritys.Add(room9);
            context.SaveChanges();

            Authorities room10 = new Authorities { ControllerName = "Room", ActionName = "FloorInsert", Name = "Kat Ekle", FaIconCode = string.Empty, SubAuthorityId = room9.Id };

            context.Authoritys.Add(room10);
            context.SaveChanges();

            Authorities room11 = new Authorities { ControllerName = "Room", ActionName = "FloorList", Name = "Kat Listesi", FaIconCode = string.Empty, SubAuthorityId = room9.Id };

            context.Authoritys.Add(room11);
            context.SaveChanges();

            Authorities room12 = new Authorities { ControllerName = "Room", ActionName = "BlockInsert", Name = "Blok Ekle", FaIconCode = string.Empty, SubAuthorityId = room9.Id };

            context.Authoritys.Add(room12);
            context.SaveChanges();

            Authorities room13 = new Authorities { ControllerName = "Room", ActionName = "BlockList", Name = "Blok Listesi", FaIconCode = string.Empty, SubAuthorityId = room9.Id };

            context.Authoritys.Add(room13);
            context.SaveChanges();

            Authorities room14 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Oda Özellikleri", FaIconCode = string.Empty, SubAuthorityId = room1.Id };

            context.Authoritys.Add(room14);
            context.SaveChanges();

            Authorities room15 = new Authorities { ControllerName = "Room", ActionName = "RoomFeatureInsert", Name = "Oda Özellik Ekle", FaIconCode = string.Empty, SubAuthorityId = room14.Id };

            context.Authoritys.Add(room15);
            context.SaveChanges();

            Authorities room16 = new Authorities { ControllerName = "Room", ActionName = "RoomFeatureList", Name = "Oda Özellik Listesi", FaIconCode = string.Empty, SubAuthorityId = room14.Id };

            context.Authoritys.Add(room16);
            context.SaveChanges();
            
            

            Authorities employee1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Personel Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(employee1);
            context.SaveChanges();

            Authorities employee2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Personel İşlemleri", FaIconCode = string.Empty, SubAuthorityId=employee1.Id };

            context.Authoritys.Add(employee2);
            context.SaveChanges();

            Authorities employee3 = new Authorities { ControllerName = "Employee", ActionName = "EmployeeInsert", Name = "Personel Ekle", FaIconCode = string.Empty, SubAuthorityId=employee2.Id };

            context.Authoritys.Add(employee3);
            context.SaveChanges();

            Authorities employee4 = new Authorities { ControllerName = "Employee", ActionName = "EmployeeList", Name = "Personel Listesi", FaIconCode = string.Empty, SubAuthorityId = employee2.Id };

            context.Authoritys.Add(employee4);
            context.SaveChanges();

            Authorities employee5 = new Authorities { ControllerName = "Employee", ActionName = "AdjustShift", Name = "Vardiya Ayarla", FaIconCode = string.Empty, SubAuthorityId = employee2.Id };

            context.Authoritys.Add(employee5);
            context.SaveChanges();

            Authorities employee6 = new Authorities { ControllerName = "Employee", ActionName = "AdjustPermit", Name = "İzin Ayarla", FaIconCode = string.Empty, SubAuthorityId = employee2.Id };

            context.Authoritys.Add(employee6);
            context.SaveChanges();

            Authorities employee7 = new Authorities { ControllerName = "Employee", ActionName = "AdjustAuthority", Name = "Yetki Ayarla", FaIconCode = string.Empty, SubAuthorityId = employee2.Id };

            context.Authoritys.Add(employee7);
            context.SaveChanges();

            Authorities employee8 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "İzin İşlemleri", FaIconCode = string.Empty, SubAuthorityId = employee1.Id };

            context.Authoritys.Add(employee8);
            context.SaveChanges();

            Authorities employee9 = new Authorities { ControllerName = "Employee", ActionName = "PermitInsert", Name = "İzin Ekle", FaIconCode = string.Empty, SubAuthorityId = employee8.Id };

            context.Authoritys.Add(employee9);
            context.SaveChanges();

            Authorities employee10 = new Authorities { ControllerName = "Employee", ActionName = "PermitList", Name = "İzin Listesi", FaIconCode = string.Empty, SubAuthorityId = employee8.Id };

            context.Authoritys.Add(employee10);
            context.SaveChanges();

            
            

            Authorities package1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Paket ve İndirim Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(package1);
            context.SaveChanges();

            Authorities package2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Paket İşlemleri", FaIconCode = string.Empty, SubAuthorityId=package1.Id };

            context.Authoritys.Add(package2);
            context.SaveChanges();

            Authorities package3 = new Authorities { ControllerName = "PacketDiscount", ActionName = "PacketInsert", Name = "Paket Ekle", FaIconCode = string.Empty, SubAuthorityId = package2.Id };

            context.Authoritys.Add(package3);
            context.SaveChanges();

            Authorities package4 = new Authorities { ControllerName = "PacketDiscount", ActionName = "PacketList", Name = "Paket Listesi", FaIconCode = string.Empty, SubAuthorityId = package2.Id };

            context.Authoritys.Add(package4);
            context.SaveChanges();

            Authorities package5 = new Authorities { ControllerName = "PacketDiscount", ActionName = "PacketCategoryInsert", Name = "Pakete Kategori Ekle", FaIconCode = string.Empty, SubAuthorityId = package2.Id };

            context.Authoritys.Add(package5);
            context.SaveChanges();

            Authorities package6 = new Authorities { ControllerName = "PacketDiscount", ActionName = "PacketCategoryList", Name = "Paketteki Kategori Listesi", FaIconCode = string.Empty, SubAuthorityId = package2.Id };

            context.Authoritys.Add(package6);
            context.SaveChanges();

            Authorities package7 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "İndirim İşlemleri", FaIconCode = string.Empty, SubAuthorityId = package1.Id };

            context.Authoritys.Add(package7);
            context.SaveChanges();

            Authorities package8 = new Authorities { ControllerName = "PacketDiscount", ActionName = "DiscountInsert", Name = "İndirim Ekle", FaIconCode = string.Empty, SubAuthorityId = package7.Id };

            context.Authoritys.Add(package8);
            context.SaveChanges();

            Authorities package9 = new Authorities { ControllerName = "PacketDiscount", ActionName = "DiscountList", Name = "İndirim Listesi", FaIconCode = string.Empty, SubAuthorityId = package7.Id };

            context.Authoritys.Add(package9);
            context.SaveChanges();

            
           
            Authorities product1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Ürün Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(product1);
            context.SaveChanges();

            Authorities product2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Ürün İşlemleri", FaIconCode = string.Empty, SubAuthorityId= product1.Id };

            context.Authoritys.Add(product2);
            context.SaveChanges();

            Authorities product3 = new Authorities { ControllerName = "Product", ActionName = "ProductInsert", Name = "Ürün Ekle", FaIconCode = string.Empty, SubAuthorityId = product2.Id };

            context.Authoritys.Add(product3);
            context.SaveChanges();

            Authorities product4 = new Authorities { ControllerName = "Product", ActionName = "ProductList", Name = "Ürün Listesi", FaIconCode = string.Empty, SubAuthorityId = product2.Id };

            context.Authoritys.Add(product4);
            context.SaveChanges();

            Authorities product5 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Kategori İşlemleri", FaIconCode = string.Empty, SubAuthorityId= product1.Id };

            context.Authoritys.Add(product5);
            context.SaveChanges();

            Authorities product6 = new Authorities { ControllerName = "Product", ActionName = "CategoryInsert", Name = "Kategori Ekle", FaIconCode = string.Empty, SubAuthorityId = product5.Id };

            context.Authoritys.Add(product6);
            context.SaveChanges();

            Authorities product7 = new Authorities { ControllerName = "Product", ActionName = "CategoryList", Name = "Kategori Listesi", FaIconCode = string.Empty, SubAuthorityId = product5.Id };

            context.Authoritys.Add(product7);
            context.SaveChanges();
           
            

            Authorities department1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Departman ve Vardiya Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(department1);
            context.SaveChanges();

            Authorities department2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Departman İşlemleri", FaIconCode = string.Empty , SubAuthorityId= department1.Id};

            context.Authoritys.Add(department2);
            context.SaveChanges();

            Authorities department3 = new Authorities { ControllerName = "DepartmanShift", ActionName = "DepartmentInsert", Name = "Departman Ekle", FaIconCode = string.Empty, SubAuthorityId = department2.Id };

            context.Authoritys.Add(department3);
            context.SaveChanges();

            Authorities department4 = new Authorities { ControllerName = "DepartmanShift", ActionName = "DepartmentList", Name = "Departman Listesi", FaIconCode = string.Empty, SubAuthorityId = department2.Id };

            context.Authoritys.Add(department4);
            context.SaveChanges();

            Authorities department5 = new Authorities { ControllerName = "DepartmanShift", ActionName = "GroupInsert", Name = "Personel Grubu Ekle", FaIconCode = string.Empty, SubAuthorityId = department2.Id };

            context.Authoritys.Add(department5);
            context.SaveChanges();

            Authorities department6 = new Authorities { ControllerName = "DepartmanShift", ActionName = "GroupList", Name = "Personel Grubu Listesi", FaIconCode = string.Empty, SubAuthorityId = department2.Id };

            context.Authoritys.Add(department6);
            context.SaveChanges();

            Authorities department7 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Vardiya İşlemleri", FaIconCode = string.Empty, SubAuthorityId = department1.Id };

            context.Authoritys.Add(department7);
            context.SaveChanges();

            Authorities department8 = new Authorities { ControllerName = "DepartmanShift", ActionName = "ShiftInsert", Name = "Vardiya Ekle", FaIconCode = string.Empty, SubAuthorityId = department7.Id };

            context.Authoritys.Add(department8);
            context.SaveChanges();

            Authorities department9 = new Authorities { ControllerName = "DepartmanShift", ActionName = "ShiftList", Name = "Vardiya Listesi", FaIconCode = string.Empty, SubAuthorityId = department7.Id };

            context.Authoritys.Add(department9);
            context.SaveChanges();
            
          

            Authorities hotel1 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Otel Yönetimi", FaIconCode = string.Empty };

            context.Authoritys.Add(hotel1);
            context.SaveChanges();

            Authorities hotel2 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Otel Özellikleri", FaIconCode = string.Empty, SubAuthorityId = hotel1.Id };

            context.Authoritys.Add(hotel2);
            context.SaveChanges();

            Authorities hotel3 = new Authorities { ControllerName = "Hotel", ActionName = "HotelFeatureInsert", Name = "Otel Özelliği Ekle", FaIconCode = string.Empty, SubAuthorityId = hotel2.Id };

            context.Authoritys.Add(hotel3);
            context.SaveChanges();

            Authorities hotel4 = new Authorities { ControllerName = "Hotel", ActionName = "HotelFeatureList", Name = "Otel Özellik Listesi", FaIconCode = string.Empty, SubAuthorityId = hotel2.Id };

            context.Authoritys.Add(hotel4);
            context.SaveChanges();

            Authorities hotel5 = new Authorities { ControllerName = string.Empty, ActionName = string.Empty, Name = "Ödeme Şekli", FaIconCode = string.Empty, SubAuthorityId = hotel1.Id };

            context.Authoritys.Add(hotel5);
            context.SaveChanges();

            Authorities hotel6 = new Authorities { ControllerName = "Hotel", ActionName = "PaymentMethodInsert", Name = "Ödeme Ekle", FaIconCode = string.Empty, SubAuthorityId = hotel5.Id };

            context.Authoritys.Add(hotel6);
            context.SaveChanges();

            Authorities hotel7 = new Authorities { ControllerName = "Hotel", ActionName = "PaymentMethodList", Name = "Ödeme Listesi", FaIconCode = string.Empty, SubAuthorityId = hotel5.Id };

            context.Authoritys.Add(hotel7);
            context.SaveChanges();
            
         

            Authorities report1 = new Authorities { Id = 59, ControllerName = string.Empty, ActionName = string.Empty, Name = "Raporlar", FaIconCode = string.Empty };

            context.Authoritys.Add(report1);
            context.SaveChanges();
            #endregion

            #region <--  Kullanıcıya yetki atama -->

            UserAuthorities userAuthorities1 = new UserAuthorities
            {
                Id = 1,
                UserId = users1.Id,
                AuthorityId = report1.Id
            };
            UserAuthorities userAuthorities2 = new UserAuthorities
            {
                Id = 2,
                UserId = users1.Id,
                AuthorityId = hotel1.Id
            };
            UserAuthorities userAuthorities3 = new UserAuthorities
            {
                Id = 3,
                UserId = users1.Id,
                AuthorityId = hotel2.Id
            };
            UserAuthorities userAuthorities4 = new UserAuthorities
            {
                Id = 4,
                UserId = users1.Id,
                AuthorityId = hotel3.Id
            };
            UserAuthorities userAuthorities5 = new UserAuthorities
            {
                Id = 5,
                UserId = users1.Id,
                AuthorityId = hotel4.Id
            };

            UserAuthorities userAuthorities6 = new UserAuthorities
            {
                Id = 6,
                UserId = users1.Id,
                AuthorityId = hotel5.Id
            };

            UserAuthorities userAuthorities7 = new UserAuthorities
            {
                Id = 7,
                UserId = users1.Id,
                AuthorityId = hotel6.Id
            };
            UserAuthorities userAuthorities8 = new UserAuthorities
            {
                Id = 8,
                UserId = users1.Id,
                AuthorityId = hotel7.Id
            };

            UserAuthorities userAuthorities9 = new UserAuthorities
            {
                Id = 9,
                UserId = users1.Id,
                AuthorityId = department1.Id
            };
            UserAuthorities userAuthorities10 = new UserAuthorities
            {
                Id = 10,
                UserId = users1.Id,
                AuthorityId = department2.Id
            };
            UserAuthorities userAuthorities11 = new UserAuthorities
            {
                Id = 11,
                UserId = users1.Id,
                AuthorityId = department3.Id
            };
            UserAuthorities userAuthorities12 = new UserAuthorities
            {
                Id = 12,
                UserId = users1.Id,
                AuthorityId = department4.Id
            };
            UserAuthorities userAuthorities13 = new UserAuthorities
            {
                Id = 13,
                UserId = users1.Id,
                AuthorityId = department5.Id
            };

            UserAuthorities userAuthorities14 = new UserAuthorities
            {
                Id = 14,
                UserId = users1.Id,
                AuthorityId = department6.Id
            };

            UserAuthorities userAuthorities15 = new UserAuthorities
            {
                Id = 15,
                UserId = users1.Id,
                AuthorityId = department7.Id
            };
            UserAuthorities userAuthorities16 = new UserAuthorities
            {
                Id = 16,
                UserId = users1.Id,
                AuthorityId = department8.Id
            };
            UserAuthorities userAuthorities17 = new UserAuthorities
            {
                Id = 17,
                UserId = users1.Id,
                AuthorityId = department9.Id
            };

            UserAuthorities userAuthorities18 = new UserAuthorities
            {
                Id = 18,
                UserId = users1.Id,
                AuthorityId = product1.Id
            };

            UserAuthorities userAuthorities19 = new UserAuthorities
            {
                Id = 19,
                UserId = users1.Id,
                AuthorityId = product2.Id
            };

            UserAuthorities userAuthorities20 = new UserAuthorities
            {
                Id = 20,
                UserId = users1.Id,
                AuthorityId = product3.Id
            };
            UserAuthorities userAuthorities21 = new UserAuthorities
            {
                Id = 21,
                UserId = users1.Id,
                AuthorityId = product4.Id
            };
            UserAuthorities userAuthorities22 = new UserAuthorities
            {
                Id = 22,
                UserId = users1.Id,
                AuthorityId = product5.Id
            };

            UserAuthorities userAuthorities23 = new UserAuthorities
            {
                Id = 23,
                UserId = users1.Id,
                AuthorityId = package1.Id
            };

            UserAuthorities userAuthorities24 = new UserAuthorities
            {
                Id = 24,
                UserId = users1.Id,
                AuthorityId = package2.Id
            };
            UserAuthorities userAuthorities25 = new UserAuthorities
            {
                Id = 25,
                UserId = users1.Id,
                AuthorityId = package3.Id
            };
            UserAuthorities userAuthorities26 = new UserAuthorities
            {
                Id = 26,
                UserId = users1.Id,
                AuthorityId = package4.Id
            };

            UserAuthorities userAuthorities27 = new UserAuthorities
            {
                Id = 27,
                UserId = users1.Id,
                AuthorityId = package5.Id
            };

            UserAuthorities userAuthorities28 = new UserAuthorities
            {
                Id = 28,
                UserId = users1.Id,
                AuthorityId = package6.Id
            };

            UserAuthorities userAuthorities29 = new UserAuthorities
            {
                Id = 29,
                UserId = users1.Id,
                AuthorityId = package7.Id
            };
            UserAuthorities userAuthorities30 = new UserAuthorities
            {
                Id = 30,
                UserId = users1.Id,
                AuthorityId = package8.Id
            };
            UserAuthorities userAuthorities31 = new UserAuthorities
            {
                Id = 31,
                UserId = users1.Id,
                AuthorityId = package9.Id
            };

            UserAuthorities userAuthorities32 = new UserAuthorities
            {
                Id = 32,
                UserId = users1.Id,
                AuthorityId = employee1.Id
            };
            UserAuthorities userAuthorities33 = new UserAuthorities
            {
                Id = 33,
                UserId = users1.Id,
                AuthorityId = employee2.Id
            };

            UserAuthorities userAuthorities34 = new UserAuthorities
            {
                Id = 34,
                UserId = users1.Id,
                AuthorityId = employee3.Id
            };

            UserAuthorities userAuthorities35 = new UserAuthorities
            {
                Id = 35,
                UserId = users1.Id,
                AuthorityId = employee4.Id
            };

            UserAuthorities userAuthorities36 = new UserAuthorities
            {
                Id = 36,
                UserId = users1.Id,
                AuthorityId = employee5.Id
            };
            UserAuthorities userAuthorities37 = new UserAuthorities
            {
                Id = 37,
                UserId = users1.Id,
                AuthorityId = employee6.Id
            };
            UserAuthorities userAuthorities38 = new UserAuthorities
            {
                Id = 38,
                UserId = users1.Id,
                AuthorityId = employee7.Id
            };
            UserAuthorities userAuthorities39 = new UserAuthorities
            {
                Id = 39,
                UserId = users1.Id,
                AuthorityId = room1.Id
            };
            UserAuthorities userAuthorities40 = new UserAuthorities
            {
                Id = 40,
                UserId = users1.Id,
                AuthorityId = room2.Id
            };
            UserAuthorities userAuthorities41 = new UserAuthorities
            {
                Id = 41,
                UserId = users1.Id,
                AuthorityId = room3.Id
            };
            UserAuthorities userAuthorities42 = new UserAuthorities
            {
                Id = 42,
                UserId = users1.Id,
                AuthorityId = room4.Id
            };
            UserAuthorities userAuthorities43 = new UserAuthorities
            {
                Id = 43,
                UserId = users1.Id,
                AuthorityId = room5.Id
            };
            UserAuthorities userAuthorities44 = new UserAuthorities
            {
                Id = 44,
                UserId = users1.Id,
                AuthorityId = room6.Id
            };
            UserAuthorities userAuthorities45 = new UserAuthorities
            {
                Id = 45,
                UserId = users1.Id,
                AuthorityId = room7.Id
            };
            UserAuthorities userAuthorities46 = new UserAuthorities
            {
                Id = 46,
                UserId = users1.Id,
                AuthorityId = room8.Id
            };
            UserAuthorities userAuthorities47 = new UserAuthorities
            {
                Id = 47,
                UserId = users1.Id,
                AuthorityId = room9.Id
            };
            UserAuthorities userAuthorities48 = new UserAuthorities
            {
                Id = 48,
                UserId = users1.Id,
                AuthorityId = room10.Id
            };
            UserAuthorities userAuthorities49 = new UserAuthorities
            {
                Id = 49,
                UserId = users1.Id,
                AuthorityId = room11.Id
            };
            UserAuthorities userAuthorities50 = new UserAuthorities
            {
                Id = 50,
                UserId = users1.Id,
                AuthorityId = customer1.Id
            };
            UserAuthorities userAuthorities51 = new UserAuthorities
            {
                Id = 51,
                UserId = users1.Id,
                AuthorityId = customer2.Id
            };
            UserAuthorities userAuthorities52 = new UserAuthorities
            {
                Id = 52,
                UserId = users1.Id,
                AuthorityId = customer3.Id
            };
            UserAuthorities userAuthorities53 = new UserAuthorities
            {
                Id = 53,
                UserId = users1.Id,
                AuthorityId = customer4.Id
            };
            UserAuthorities userAuthorities54 = new UserAuthorities
            {
                Id = 54,
                UserId = users1.Id,
                AuthorityId = sale1.Id
            };
            UserAuthorities userAuthorities55 = new UserAuthorities
            {
                Id = 55,
                UserId = users1.Id,
                AuthorityId = sale2.Id
            };
            UserAuthorities userAuthorities56 = new UserAuthorities
            {
                Id = 56,
                UserId = users1.Id,
                AuthorityId = sale3.Id
            };
         
            UserAuthorities userAuthorities58 = new UserAuthorities
            {
                Id = 58,
                UserId = users1.Id,
                AuthorityId = sale5.Id
            };
            UserAuthorities userAuthorities59 = new UserAuthorities
            {
                Id = 59,
                UserId = users1.Id,
                AuthorityId = sale6.Id
            };

            UserAuthorities userAuthorities60 = new UserAuthorities
            {
                Id = 60,
                UserId = users1.Id,
                AuthorityId = employee8.Id
            };

            UserAuthorities userAuthorities61 = new UserAuthorities
            {
                Id = 61,
                UserId = users1.Id,
                AuthorityId = employee9.Id
            };

            UserAuthorities userAuthorities62 = new UserAuthorities
            {
                Id = 62,
                UserId = users1.Id,
                AuthorityId = customer5.Id
            };

            UserAuthorities userAuthorities63 = new UserAuthorities
            {
                Id = 63,
                UserId = users1.Id,
                AuthorityId = customer6.Id
            };

            UserAuthorities userAuthorities64 = new UserAuthorities
            {
                Id = 64,
                UserId = users1.Id,
                AuthorityId = customer7.Id
            };

            UserAuthorities userAuthorities65 = new UserAuthorities
            {
                Id = 65,
                UserId = users1.Id,
                AuthorityId = room12.Id
            };

            UserAuthorities userAuthorities66 = new UserAuthorities
            {
                Id = 66,
                UserId = users1.Id,
                AuthorityId = room13.Id
            };


            UserAuthorities userAuthorities67 = new UserAuthorities
            {
                Id = 67,
                UserId = users1.Id,
                AuthorityId = room14.Id
            };

            UserAuthorities userAuthorities68 = new UserAuthorities
            {
                Id = 68,
                UserId = users1.Id,
                AuthorityId = room15.Id
            };

            UserAuthorities userAuthorities69 = new UserAuthorities
            {
                Id = 69,
                UserId = users1.Id,
                AuthorityId = sale7.Id
            };

            UserAuthorities userAuthorities70 = new UserAuthorities
            {
                Id = 70,
                UserId = users1.Id,
                AuthorityId = sale8.Id
            };

            UserAuthorities userAuthorities71 = new UserAuthorities
            {
                Id = 71,
                UserId = users1.Id,
                AuthorityId = sale9.Id
            };

            UserAuthorities userAuthorities72 = new UserAuthorities
            {
                Id = 72,
                UserId = users1.Id,
                AuthorityId = sale10.Id
            };

            UserAuthorities userAuthorities73 = new UserAuthorities
            {
                Id = 73,
                UserId = users1.Id,
                AuthorityId = customer8.Id
            };

            UserAuthorities userAuthorities74 = new UserAuthorities
            {
                Id = 74,
                UserId = users1.Id,
                AuthorityId = customer9.Id
            };

            UserAuthorities userAuthorities75 = new UserAuthorities
            {
                Id = 75,
                UserId = users1.Id,
                AuthorityId = room16.Id
            };

            UserAuthorities userAuthorities76 = new UserAuthorities
            {
                Id = 76,
                UserId = users1.Id,
                AuthorityId = employee10.Id
            };

            UserAuthorities userAuthorities77 = new UserAuthorities
            {
                Id = 77,
                UserId = users1.Id,
                AuthorityId = product6.Id
            };

            UserAuthorities userAuthorities78 = new UserAuthorities
            {
                Id = 78,
                UserId = users1.Id,
                AuthorityId = product7.Id
            };

            UserAuthorities userAuthorities79 = new UserAuthorities
            {
                Id = 79,
                UserId = users1.Id,
                AuthorityId = customer10.Id
            };
            UserAuthorities userAuthorities80 = new UserAuthorities
            {
                Id = 80,
                UserId = users1.Id,
                AuthorityId = customer11.Id
            };

            context.UserAuthoritys.Add(userAuthorities1);
            context.UserAuthoritys.Add(userAuthorities2);
            context.UserAuthoritys.Add(userAuthorities3);
            context.UserAuthoritys.Add(userAuthorities4);
            context.UserAuthoritys.Add(userAuthorities5);
            context.UserAuthoritys.Add(userAuthorities6);
            context.UserAuthoritys.Add(userAuthorities7);
            context.UserAuthoritys.Add(userAuthorities8);
            context.UserAuthoritys.Add(userAuthorities9);
            context.UserAuthoritys.Add(userAuthorities10);
            context.UserAuthoritys.Add(userAuthorities11);
            context.UserAuthoritys.Add(userAuthorities12);
            context.UserAuthoritys.Add(userAuthorities13);
            context.UserAuthoritys.Add(userAuthorities14);
            context.UserAuthoritys.Add(userAuthorities15);
            context.UserAuthoritys.Add(userAuthorities16);
            context.UserAuthoritys.Add(userAuthorities17);
            context.UserAuthoritys.Add(userAuthorities18);
            context.UserAuthoritys.Add(userAuthorities19);
            context.UserAuthoritys.Add(userAuthorities20);
            context.UserAuthoritys.Add(userAuthorities21);
            context.UserAuthoritys.Add(userAuthorities22);
            context.UserAuthoritys.Add(userAuthorities23);
            context.UserAuthoritys.Add(userAuthorities24);
            context.UserAuthoritys.Add(userAuthorities25);
            context.UserAuthoritys.Add(userAuthorities26);
            context.UserAuthoritys.Add(userAuthorities27);
            context.UserAuthoritys.Add(userAuthorities28);
            context.UserAuthoritys.Add(userAuthorities29);
            context.UserAuthoritys.Add(userAuthorities30);
            context.UserAuthoritys.Add(userAuthorities31);
            context.UserAuthoritys.Add(userAuthorities32);
            context.UserAuthoritys.Add(userAuthorities33);
            context.UserAuthoritys.Add(userAuthorities34);
            context.UserAuthoritys.Add(userAuthorities35);
            context.UserAuthoritys.Add(userAuthorities36);
            context.UserAuthoritys.Add(userAuthorities37);
            context.UserAuthoritys.Add(userAuthorities38);
            context.UserAuthoritys.Add(userAuthorities39);
            context.UserAuthoritys.Add(userAuthorities40);
            context.UserAuthoritys.Add(userAuthorities41);
            context.UserAuthoritys.Add(userAuthorities42);
            context.UserAuthoritys.Add(userAuthorities43);
            context.UserAuthoritys.Add(userAuthorities44);
            context.UserAuthoritys.Add(userAuthorities45);
            context.UserAuthoritys.Add(userAuthorities46);
            context.UserAuthoritys.Add(userAuthorities47);
            context.UserAuthoritys.Add(userAuthorities48); 
            context.UserAuthoritys.Add(userAuthorities49);
            context.UserAuthoritys.Add(userAuthorities50);
            context.UserAuthoritys.Add(userAuthorities51);
            context.UserAuthoritys.Add(userAuthorities52);
            context.UserAuthoritys.Add(userAuthorities53);
            context.UserAuthoritys.Add(userAuthorities54);
            context.UserAuthoritys.Add(userAuthorities55);
            context.UserAuthoritys.Add(userAuthorities56);
            context.UserAuthoritys.Add(userAuthorities58);
            context.UserAuthoritys.Add(userAuthorities59);
            context.UserAuthoritys.Add(userAuthorities60);
            context.UserAuthoritys.Add(userAuthorities61);
            context.UserAuthoritys.Add(userAuthorities62);
            context.UserAuthoritys.Add(userAuthorities63);
            context.UserAuthoritys.Add(userAuthorities64);
            context.UserAuthoritys.Add(userAuthorities65);
            context.UserAuthoritys.Add(userAuthorities66);
            context.UserAuthoritys.Add(userAuthorities67);
            context.UserAuthoritys.Add(userAuthorities68);
            context.UserAuthoritys.Add(userAuthorities69);
            context.UserAuthoritys.Add(userAuthorities70);
            context.UserAuthoritys.Add(userAuthorities71);
            context.UserAuthoritys.Add(userAuthorities72);
            context.UserAuthoritys.Add(userAuthorities73);
            context.UserAuthoritys.Add(userAuthorities74);
            context.UserAuthoritys.Add(userAuthorities75);
            context.UserAuthoritys.Add(userAuthorities76);
            context.UserAuthoritys.Add(userAuthorities77);
            context.UserAuthoritys.Add(userAuthorities78);
            context.UserAuthoritys.Add(userAuthorities79);
            context.UserAuthoritys.Add(userAuthorities80);

            users1.UserAuthorities.Add(userAuthorities80);
            users1.UserAuthorities.Add(userAuthorities79);
            users1.UserAuthorities.Add(userAuthorities78);
            users1.UserAuthorities.Add(userAuthorities77);
            users1.UserAuthorities.Add(userAuthorities76);
            users1.UserAuthorities.Add(userAuthorities75);
            users1.UserAuthorities.Add(userAuthorities74);
            users1.UserAuthorities.Add(userAuthorities73);
            users1.UserAuthorities.Add(userAuthorities72);
            users1.UserAuthorities.Add(userAuthorities71);
            users1.UserAuthorities.Add(userAuthorities70);
            users1.UserAuthorities.Add(userAuthorities69);
            users1.UserAuthorities.Add(userAuthorities68);
            users1.UserAuthorities.Add(userAuthorities67);
            users1.UserAuthorities.Add(userAuthorities66);
            users1.UserAuthorities.Add(userAuthorities65);
            users1.UserAuthorities.Add(userAuthorities64);
            users1.UserAuthorities.Add(userAuthorities63);
            users1.UserAuthorities.Add(userAuthorities62);
            users1.UserAuthorities.Add(userAuthorities61);
            users1.UserAuthorities.Add(userAuthorities60);
            users1.UserAuthorities.Add(userAuthorities59);
            users1.UserAuthorities.Add(userAuthorities58);
            users1.UserAuthorities.Add(userAuthorities56);
            users1.UserAuthorities.Add(userAuthorities55);
            users1.UserAuthorities.Add(userAuthorities54);
            users1.UserAuthorities.Add(userAuthorities53);
            users1.UserAuthorities.Add(userAuthorities52);
            users1.UserAuthorities.Add(userAuthorities51);
            users1.UserAuthorities.Add(userAuthorities50);
            users1.UserAuthorities.Add(userAuthorities49);
            users1.UserAuthorities.Add(userAuthorities48);
            users1.UserAuthorities.Add(userAuthorities47);
            users1.UserAuthorities.Add(userAuthorities46);
            users1.UserAuthorities.Add(userAuthorities45);
            users1.UserAuthorities.Add(userAuthorities44);
            users1.UserAuthorities.Add(userAuthorities43);
            users1.UserAuthorities.Add(userAuthorities42);
            users1.UserAuthorities.Add(userAuthorities41);
            users1.UserAuthorities.Add(userAuthorities40);
            users1.UserAuthorities.Add(userAuthorities39);
            users1.UserAuthorities.Add(userAuthorities38);
            users1.UserAuthorities.Add(userAuthorities37);
            users1.UserAuthorities.Add(userAuthorities36);
            users1.UserAuthorities.Add(userAuthorities35);
            users1.UserAuthorities.Add(userAuthorities34);
            users1.UserAuthorities.Add(userAuthorities33);
            users1.UserAuthorities.Add(userAuthorities32);
            users1.UserAuthorities.Add(userAuthorities31);
            users1.UserAuthorities.Add(userAuthorities30);
            users1.UserAuthorities.Add(userAuthorities29);
            users1.UserAuthorities.Add(userAuthorities28);
            users1.UserAuthorities.Add(userAuthorities27);
            users1.UserAuthorities.Add(userAuthorities26);
            users1.UserAuthorities.Add(userAuthorities25);
            users1.UserAuthorities.Add(userAuthorities24);
            users1.UserAuthorities.Add(userAuthorities23);
            users1.UserAuthorities.Add(userAuthorities22);
            users1.UserAuthorities.Add(userAuthorities21);
            users1.UserAuthorities.Add(userAuthorities20);
            users1.UserAuthorities.Add(userAuthorities19);
            users1.UserAuthorities.Add(userAuthorities18);
            users1.UserAuthorities.Add(userAuthorities17);
            users1.UserAuthorities.Add(userAuthorities16);
            users1.UserAuthorities.Add(userAuthorities15);
            users1.UserAuthorities.Add(userAuthorities14);
            users1.UserAuthorities.Add(userAuthorities13);
            users1.UserAuthorities.Add(userAuthorities12);
            users1.UserAuthorities.Add(userAuthorities11);
            users1.UserAuthorities.Add(userAuthorities10);
            users1.UserAuthorities.Add(userAuthorities9);
            users1.UserAuthorities.Add(userAuthorities8);
            users1.UserAuthorities.Add(userAuthorities7);
            users1.UserAuthorities.Add(userAuthorities6);
            users1.UserAuthorities.Add(userAuthorities5);
            users1.UserAuthorities.Add(userAuthorities4);
            users1.UserAuthorities.Add(userAuthorities3);
            users1.UserAuthorities.Add(userAuthorities2);
            users1.UserAuthorities.Add(userAuthorities1);

            context.SaveChanges();
            #endregion

            #region <--  Uyruklar -->

            Nationalities nationalities1 = new Nationalities { CountryName = "Türkiye", Name = "TR" };
            context.Nationalities.Add(nationalities1);
            context.SaveChanges();

            Nationalities nationalities2 = new Nationalities { CountryName = "Amerika Birleşik Devletleri", Name = "US" };
            context.Nationalities.Add(nationalities2);
            context.SaveChanges();

            Nationalities nationalities3 = new Nationalities { CountryName = "Almanya", Name = "DE" };
            context.Nationalities.Add(nationalities3);
            context.SaveChanges();

            Nationalities nationalities4 = new Nationalities { CountryName = "Fransa", Name = "FR" };
            context.Nationalities.Add(nationalities4);
            context.SaveChanges();
          
            #endregion

            #region <-- Müşteriler -->

            Customers customers1 = new Customers { Name = "Murat", Surname = "Ekrem", IsMale = true, IsMarried = false, BloodGroup = "BRH+", DateOfBirth = DateTime.Parse("15.07.1992"), EmailAddress = "murat.ekrem@gmail.com", IdentificationNumber = "12345678963", NationalityId = nationalities1.Id, PhoneNumber = "05698654214", Address = "Çayırova Mah. 345 Sokak No:22 " };

            context.Customers.Add(customers1);
            context.SaveChanges();


            Customers customers2 = new Customers { Name = "Muharrem", Surname = "Ekrem", IsMale = true, IsMarried = false, BloodGroup = "BRH+", DateOfBirth = DateTime.Parse("09.08.1989"), EmailAddress = "muharrem.ekrem@gmail.com", IdentificationNumber = "43215678963", NationalityId = nationalities1.Id, PhoneNumber = "05698652355", Address = "Çayırova Mah. 345 Sokak No:22 " };

            context.Customers.Add(customers2);
            context.SaveChanges();
            #endregion

            #region <--Ödeme Şekilleri-->

            PaymentMethods paymentMethods1= new PaymentMethods{ Name="Nakit"};
            context.PaymentMethods.Add(paymentMethods1);
            context.SaveChanges();
            PaymentMethods paymentMethods2= new PaymentMethods{ Name="Kredi Kartı"};
            context.PaymentMethods.Add(paymentMethods2);
            context.SaveChanges();

	#endregion

            #region <--Satışlar-->

            Sales sales1 = new Sales { ReserveDate = DateTime.Parse("05.08.2015"), CustomerId = customers1.Id, EmployeeId = employees1.Id, IsCollect = true, IsSale = true, PaymentMethodId = paymentMethods2.Id, Amount = 500,IsActive = true};

            context.Sales.Add(sales1);
            context.SaveChanges();

            Sales sales2 = new Sales { ReserveDate = DateTime.Parse("20.08.2015"), CustomerId = customers2.Id, EmployeeId = employees2.Id, IsCollect = false, IsSale = true, PaymentMethodId = paymentMethods1.Id, Amount = 300, IsActive = true };

            context.Sales.Add(sales2);
            context.SaveChanges();
            #endregion

            #region <-- İndirimler -->

            Discounts discounts1 = new Discounts { Name = "Bir ay önce yapılan rezervasyonlar için", Rate = 20, StartingDate = DateTime.Parse("01.05.2015"), EndingDate = DateTime.Parse("30.09.2015"), IsActive = true, Description = "Sezonluk kampanya" };

            context.Discounts.Add(discounts1);
            context.SaveChanges();

            Discounts discounts2 = new Discounts { Name = "Üç ay önce yapılan rezervasyonlar için", Rate = 30, StartingDate = DateTime.Parse("01.05.2015"), EndingDate = DateTime.Parse("30.09.2015"), IsActive = true, Description = "Sezonluk kampanya" };

            context.Discounts.Add(discounts2);
            context.SaveChanges();

            #endregion

            #region <-- Paketler-->

            Packets packets1 = new Packets { Name = "Ekonomik", PricePercentage = 40 };
            Packets packets2 = new Packets { Name = "Tam Pansiyon", PricePercentage = 30 };
            Packets packets3 = new Packets { Name = "Yarı Pansiyon", PricePercentage = 20 };

            context.Packets.Add(packets1);
            context.Packets.Add(packets2);
            context.Packets.Add(packets3);
            context.SaveChanges();
            #endregion
            
            #region <-- Oda Tipleri-->
            RoomTypes roomtypes1= new RoomTypes{ Name="Kral Dairesi Çift Kişilik", Amount=500, Quota=2,IsActive = true};
            RoomTypes roomtypes2 = new RoomTypes { Name = "Kral Dairesi Tek Kişilik", Amount = 400, Quota = 1, IsActive = true };
            RoomTypes roomtypes3 = new RoomTypes { Name = "Normal Tek Kişilik", Amount = 50, Quota = 1, IsActive = true };
            RoomTypes roomtypes4 = new RoomTypes { Name = "Normal Çİft Kişilik ", Amount = 100, Quota = 2, IsActive = true };

            context.RoomTypes.Add(roomtypes1);
            context.RoomTypes.Add(roomtypes2);
            context.RoomTypes.Add(roomtypes3);
            context.RoomTypes.Add(roomtypes4);

            context.SaveChanges();
	#endregion

            #region <-- Bloklar -->

                        Blocks blocks1= new Blocks{ BlockName="A Blok"};
                        Blocks blocks2= new Blocks{ BlockName="B Blok"};
                        Blocks blocks3= new Blocks{ BlockName="C Blok"};

            context.Blocks.Add(blocks1);
            context.Blocks.Add(blocks2);
            context.Blocks.Add(blocks3);
            context.SaveChanges();
	            #endregion

            #region <-- Katlar -->
		 
            Floors floors1= new Floors{ Name="1. Kat"};
            Floors floors2= new Floors{ Name="2. Kat"};
            Floors floors3= new Floors{ Name="3. Kat"};

            context.Floors.Add(floors1);
            context.Floors.Add(floors2);
            context.Floors.Add(floors3);
            context.SaveChanges();

	#endregion

            #region <-- Bloğun katları -->

            BlockFloors blockFloors1= new BlockFloors{ Block=blocks1, BlockId=blocks1.Id, Floor=floors1, FloorId=floors1.Id};

            BlockFloors blockFloors2= new BlockFloors{ Block=blocks2, BlockId=blocks2.Id, Floor=floors2, FloorId=floors2.Id};

            BlockFloors blockFloors3= new BlockFloors{ Block=blocks3, BlockId=blocks3.Id, Floor=floors3, FloorId=floors3.Id};

            BlockFloors blockFloors4= new BlockFloors{ Block=blocks1, BlockId=blocks1.Id, Floor=floors2, FloorId=floors2.Id};

            BlockFloors blockFloors5= new BlockFloors{ Block=blocks2, BlockId=blocks2.Id, Floor=floors1, FloorId=floors1.Id};

            BlockFloors blockFloors6= new BlockFloors{ Block=blocks3, BlockId=blocks3.Id, Floor=floors2, FloorId=floors2.Id};

            BlockFloors blockFloors7= new BlockFloors{ Block=blocks1, BlockId=blocks1.Id, Floor=floors3, FloorId=floors3.Id};

            BlockFloors blockFloors8= new BlockFloors{ Block=blocks2, BlockId=blocks2.Id, Floor=floors3, FloorId=floors3.Id};

            BlockFloors blockFloors9= new BlockFloors{ Block=blocks3, BlockId=blocks3.Id, Floor=floors1, FloorId=floors1.Id};

            context.BlockFloors.Add(blockFloors1);
            context.BlockFloors.Add(blockFloors2);
            context.BlockFloors.Add(blockFloors3);
            context.BlockFloors.Add(blockFloors4);
            context.BlockFloors.Add(blockFloors5);
            context.BlockFloors.Add(blockFloors6);
            context.BlockFloors.Add(blockFloors7);
            context.BlockFloors.Add(blockFloors8);
            context.BlockFloors.Add(blockFloors9);

            context.SaveChanges();
		 
	#endregion

            #region <-- Odalar -->

            Rooms rooms1 = new Rooms { Number = "1001", RoomTypeId = roomtypes1.Id, BlockFloor = blockFloors1, BlockFloorId = blockFloors1.Id };
            Rooms rooms2 = new Rooms { Number = "1002", RoomTypeId = roomtypes2.Id, BlockFloor = blockFloors1, BlockFloorId = blockFloors1.Id };
            Rooms rooms3 = new Rooms { Number = "1003",RoomTypeId = roomtypes3.Id, BlockFloor = blockFloors1, BlockFloorId = blockFloors1.Id };
            Rooms rooms4 = new Rooms { Number = "2001", RoomTypeId = roomtypes4.Id, BlockFloor = blockFloors2, BlockFloorId = blockFloors2.Id };
            Rooms rooms5 = new Rooms { Number = "2002", RoomTypeId = roomtypes2.Id, BlockFloor = blockFloors2, BlockFloorId = blockFloors2.Id };
            Rooms rooms6 = new Rooms { Number = "2003",  RoomTypeId = roomtypes3.Id, BlockFloor = blockFloors2, BlockFloorId = blockFloors2.Id };

            context.Rooms.Add(rooms1);
            context.Rooms.Add(rooms2);
            context.Rooms.Add(rooms3);
            context.Rooms.Add(rooms4);
            context.Rooms.Add(rooms5);
            context.Rooms.Add(rooms6);

            context.SaveChanges();

            #endregion

            #region <-- Durumlar-->

            Statuses status1 = new Statuses { Name = "Boş" };
            Statuses status2 = new Statuses { Name = "Dolu" };
            Statuses status3 = new Statuses { Name = "Rezerve" };
            Statuses status4 = new Statuses { Name = "Temizlemede" };
            Statuses status5 = new Statuses { Name = "Tadilatta" };

            context.Statuses.Add(status1);
            context.Statuses.Add(status2);
            context.Statuses.Add(status3);
            context.Statuses.Add(status4);
            context.Statuses.Add(status5);
            context.SaveChanges();

            #endregion

            #region <-- Oda Durumları -->

            RoomStatuses roomstatuses1 = new RoomStatuses { RoomId = rooms1.Id, StatusId = status1.Id };
            RoomStatuses roomstatuses2 = new RoomStatuses { RoomId = rooms2.Id, StatusId = status1.Id };
            RoomStatuses roomstatuses3 = new RoomStatuses { RoomId = rooms3.Id, StatusId = status2.Id };
            RoomStatuses roomstatuses4 = new RoomStatuses { RoomId = rooms4.Id, StatusId = status3.Id };
            RoomStatuses roomstatuses5 = new RoomStatuses { RoomId = rooms5.Id, StatusId = status4.Id };
            RoomStatuses roomstatuses6 = new RoomStatuses { RoomId = rooms6.Id, StatusId = status5.Id };

            context.RoomStatuses.Add(roomstatuses1);
            context.RoomStatuses.Add(roomstatuses2);
            context.RoomStatuses.Add(roomstatuses3);
            context.RoomStatuses.Add(roomstatuses4);
            context.RoomStatuses.Add(roomstatuses5);
            context.RoomStatuses.Add(roomstatuses6);
            context.SaveChanges();
            #endregion

            #region <-- Ekstra Ürün Kategorileri-->
		 
            ExtraProductCategories epc1= new ExtraProductCategories{ Name="Alkollü İçecekler"};
            ExtraProductCategories epc2= new ExtraProductCategories{ Name="Alkolsüz Soğuk İçecekler"};
            ExtraProductCategories epc3= new ExtraProductCategories{ Name="Alkolsüz Sıcak İçecekler"};
            ExtraProductCategories epc4= new ExtraProductCategories{ Name="İnternet"};
            ExtraProductCategories epc5= new ExtraProductCategories{ Name="Normal Kahvaltı"};

            context.ExtraProductCategories.Add(epc1);
            context.ExtraProductCategories.Add(epc2);
            context.ExtraProductCategories.Add(epc3);
            context.ExtraProductCategories.Add(epc4);
            context.ExtraProductCategories.Add(epc5);

            context.SaveChanges();
	        #endregion

            #region <-- Ekstra Ürünler-->

            ExtraProducts ep1 = new ExtraProducts { Name = "Coca Cola", ExtraProductCategoryId = epc2.Id, IsActive = true, Amount = 5 };
            ExtraProducts ep2 = new ExtraProducts { Name = "Yeşil Çay", ExtraProductCategoryId = epc3.Id, IsActive = true, Amount = 5 };
            ExtraProducts ep3 = new ExtraProducts { Name = "Rakı", ExtraProductCategoryId = epc1.Id, IsActive = true, Amount = 10 };
            ExtraProducts ep4 = new ExtraProducts { Name = "Wireless", ExtraProductCategoryId = epc4.Id, IsActive = true, Amount = 10 };
            ExtraProducts ep5 = new ExtraProducts { Name = "Sahanda Yumurta", ExtraProductCategoryId = epc5.Id, IsActive = true, Amount = 5 };
            ExtraProducts ep6 = new ExtraProducts { Name = "Zeytin", ExtraProductCategoryId = epc5.Id, IsActive = true, Amount = 3 };
            ExtraProducts ep7 = new ExtraProducts { Name = "Peynir", ExtraProductCategoryId = epc5.Id, IsActive = true, Amount = 5 };
            ExtraProducts ep8 = new ExtraProducts { Name = "Çay", ExtraProductCategoryId = epc5.Id, IsActive = true, Amount = 5 };

            context.ExtraProducts.Add(ep1);
            context.ExtraProducts.Add(ep2);
            context.ExtraProducts.Add(ep3);
            context.ExtraProducts.Add(ep4);
            context.ExtraProducts.Add(ep5);
            context.ExtraProducts.Add(ep6);
            context.ExtraProducts.Add(ep7);
            context.ExtraProducts.Add(ep8);
            context.SaveChanges();
            #endregion

            #region <-- Pakete Dahil Kategoriler-->

            PacketsExtraProductCategories pepc1 = new PacketsExtraProductCategories { PacketId = packets1.Id, ExtraProductCategoryId = epc2.Id };
            PacketsExtraProductCategories pepc2 = new PacketsExtraProductCategories { PacketId = packets1.Id, ExtraProductCategoryId = epc3.Id };
            PacketsExtraProductCategories pepc3 = new PacketsExtraProductCategories { PacketId = packets1.Id, ExtraProductCategoryId = epc5.Id };
            PacketsExtraProductCategories pepc4 = new PacketsExtraProductCategories { PacketId = packets2.Id, ExtraProductCategoryId = epc1.Id };
            PacketsExtraProductCategories pepc5 = new PacketsExtraProductCategories { PacketId = packets2.Id, ExtraProductCategoryId = epc4.Id };

            context.PacketsExtraProductCategories.Add(pepc1);
            context.PacketsExtraProductCategories.Add(pepc2);
            context.PacketsExtraProductCategories.Add(pepc3);
            context.PacketsExtraProductCategories.Add(pepc4);
            context.PacketsExtraProductCategories.Add(pepc5);
            context.SaveChanges();
            #endregion

            #region <-- ExtraHarcamaToplamFiyatFunction -->

            string path1 = AppDomain.CurrentDomain.BaseDirectory +"Programmability\\Functions\\F_ExtraProductSalesTotal.sql";
            string p1=  path1.Replace("UI\\WebApplication1", "ProjectTemplate.Core");
            context.Database.ExecuteSqlCommand(File.ReadAllText(p1));
            context.SaveChanges();

            #endregion

            #region <-- ExtraUrunlerProcedur -->

            string path2 = AppDomain.CurrentDomain.BaseDirectory + "Programmability\\Stored Procedures\\SP_ExtraProducts.sql";
            string p2 = path2.Replace("UI\\WebApplication1", "ProjectTemplate.Core");
            context.Database.ExecuteSqlCommand(File.ReadAllText(p2));
            context.SaveChanges();

            #endregion

           

        }
    }
}