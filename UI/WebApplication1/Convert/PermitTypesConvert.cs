using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class PermitTypesConvert
    {
        public static PermitTypes ModelToEnity(this PermitTypesModel model, bool virtualActive = false)
        {
            PermitTypes entity = new PermitTypes()
            {
                 Description=model.Description,
                  IsPaid=model.IsPaid,
                   Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Permits = model.Permits;

            }
            return entity;
        }

        public static PermitTypesModel EntityToModel(this PermitTypes entity, bool virtualActive = false)
        {
            try
            {
                PermitTypesModel model = new PermitTypesModel()
                {
                     Description=entity.Description,
                      IsPaid=entity.IsPaid,
                       Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Permits = entity.Permits;

                }
                return model;
            }
            catch (Exception)
            {

                return new PermitTypesModel();
            }


        }

        public static List<PermitTypes> ModelToEntityList(this IEnumerable<PermitTypesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPermitTypesModel => itemPermitTypesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<PermitTypesModel> EntityToModelList(this IEnumerable<PermitTypes> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPermitTypesModel => itemPermitTypesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}