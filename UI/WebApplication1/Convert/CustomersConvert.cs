using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectTemplate.Core.Entities;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class CustomersConvert
    {
        public static Customers ModelToEnity(this CustomersModel model,bool virtualActive=false)
        {
            Customers entity = new Customers()
            {
                Address              =model.Address,
                Name                 =model.Name,
                BloodGroup           =model.BloodGroup,
                DateOfBirth          =model.DateOfBirth,
                Description          =model.Description,
                EmailAddress         =model.EmailAddress,
                IdentificationNumber =model.IdentificationNumber,
                IsMale               =model.IsMale,
                IsMarried            =model.IsMarried,
                PhoneNumber          =model.PhoneNumber,
                Surname              =model.Surname,
                NationalityId        =model.NationalityId,
                Id                   =model.Id,
                IsActive             =model.IsActive
            };
            if (virtualActive)
            {
                entity.Nationality = model.Nationality;
                entity.Sales = model.Sales;
                entity.StayingInRoom = model.StayingInRoom;
            }
            return entity;
        }

        public static CustomersModel EntityToModel(this Customers entity, bool virtualActive = false)
        {
            try
            {
                CustomersModel model = new CustomersModel()
                {
                    Description          = entity.Description,
                    Name                 = entity.Name,
                    BloodGroup           = entity.BloodGroup,
                    DateOfBirth          = entity.DateOfBirth,
                    EmailAddress         = entity.EmailAddress,
                    IdentificationNumber = entity.IdentificationNumber,
                    Address              = entity.Address,
                    IsMale               = entity.IsMale,
                    IsMarried            = entity.IsMale,
                    NationalityId        = entity.NationalityId,
                    PhoneNumber          = entity.PhoneNumber,
                    Surname              = entity.Surname,
                    Id                   = entity.Id
                };
                if (virtualActive)
                {
                    model.Nationality = entity.Nationality;
                    model.Sales = entity.Sales;
                    model.StayingInRoom = entity.StayingInRoom;
                }
                return model;
            }
            catch (Exception)
            {
                
                return new CustomersModel();
            }

            
        }

        public static List<Customers> ModelToEntityList(this IEnumerable<CustomersModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemCustomersModel => itemCustomersModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<CustomersModel> EntityToModelList(this IEnumerable<Customers> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemCustomersModel => itemCustomersModel.EntityToModel(virtualActive)).ToList();
        } 
    }
}