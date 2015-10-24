using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class EmployeesConvert
    {
        //benim derken kimi kastettin kardeş?
        public static string EkleBenimSonumaASDF(this string x/*işte bunu kastettim*/) {
            return x + "ASDF";
        }

        public static Employees ModelToEntity(this EmployeesModel model, bool virtualActive = false)
        {
            Employees entity = new Employees()
            {
                Address = model.Address,
                BloodGroup = model.BloodGroup,
                DateOfBirth = model.DateOfBirth,
                DateOfEntry = model.DateOfEntry,
                DepartureDate = model.DepartureDate,
                Description = model.Description,
                EmailAddress = model.EmailAddress,
                GroupsOfEmployeeId = model.GroupsOfEmployeeId,
                IsMale = model.IsMale,
                IsMonthlyWage = model.IsMonthlyWage,
                IsWorked = model.IsWorked,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                PlaceOfBirth = model.PlaceOfBirth,
                RegistrationNumber = model.RegistrationNumber,
                Salary = model.Salary,
                Surname = model.Surname,
                IdentificationNumber = model.IdentificationNumber,
                IsActive = model.IsActive,
                Id = model.Id,

            };
            if (virtualActive)
            {
                entity.GroupsOfEmployee = model.GroupsOfEmployee;
                entity.Sales = model.Sales;
                entity.Users = model.Users;
                entity.Permits = model.Permits;
                entity.EmployeeShifts = model.EmployeeShifts;

            }
            return entity;
        }

        public static EmployeesModel EntityToModel(this Employees entity, bool virtualActive = false)
        {
            try
            {
                EmployeesModel model = new EmployeesModel()
                {

                    Address = entity.Address,
                    BloodGroup = entity.BloodGroup,
                    DateOfBirth = (DateTime)entity.DateOfBirth,
                    DateOfEntry = entity.DateOfEntry,
                    DepartureDate = (DateTime)entity.DepartureDate,
                    Description = entity.Description,
                    EmailAddress = entity.EmailAddress,
                    GroupsOfEmployeeId = entity.GroupsOfEmployeeId,
                    IdentificationNumber = entity.IdentificationNumber,
                    IsMale = entity.IsMale,
                    IsMonthlyWage = entity.IsMonthlyWage,
                    IsWorked = entity.IsWorked,
                    Name = entity.Name,
                    PhoneNumber = entity.PhoneNumber,
                    PlaceOfBirth = entity.PlaceOfBirth,
                    RegistrationNumber = entity.RegistrationNumber,
                    Salary = entity.Salary,
                    Surname = entity.Surname,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.EmployeeShifts = entity.EmployeeShifts;
                    model.GroupsOfEmployee = entity.GroupsOfEmployee;
                    model.Sales = entity.Sales;
                    model.Users = entity.Users;
                    model.Permits = entity.Permits;
                }
                return model;
            }
            catch (Exception)
            {

                return new EmployeesModel();
            }


        }

        public static List<Employees> ModelToEntityList(this IEnumerable<EmployeesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemEmployeesModel => itemEmployeesModel.ModelToEntity(virtualActive)).ToList();
        }

        public static List<EmployeesModel> EntityToModelList(this IEnumerable<Employees> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemEmployeesModel => itemEmployeesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}