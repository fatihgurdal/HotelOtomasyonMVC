using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class PermitsConvert
    {
        public static Permits ModelToEnity(this PermitsModel model, bool virtualActive = false)
        {
            Permits entity = new Permits()
            {
                EmployeeId = model.EmployeeId,
                EndDate = model.EndDate,
                PermitTypeId = model.PermitTypeId,
                StartingDate = model.StartingDate,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Employee = model.Employee;
                entity.PermitType = model.PermitType;

            }
            return entity;
        }

        public static PermitsModel EntityToModel(this Permits entity, bool virtualActive = false)
        {
            try
            {
                PermitsModel model = new PermitsModel()
                {
                    EmployeeId = entity.EmployeeId,
                    EndDate = entity.EndDate,
                    PermitTypeId = entity.PermitTypeId,
                    StartingDate = entity.StartingDate,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.PermitType = entity.PermitType;
                    model.Employee = entity.Employee;

                }
                return model;
            }
            catch (Exception)
            {

                return new PermitsModel();
            }


        }

        public static List<Permits> ModelToEntityList(this IEnumerable<PermitsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPermitsModel => itemPermitsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<PermitsModel> EntityToModelList(this IEnumerable<Permits> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPermitsModel => itemPermitsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}