using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class ExtraProductsConvert
    {
        public static ExtraProducts ModelToEnity(this ExtraProductsModel model, bool virtualActive = false)
        {
            ExtraProducts entity = new ExtraProducts()
            {
                 Amount=model.Amount,
                  ExtraProductCategoryId=model.ExtraProductCategoryId,
                   Name=model.Name,
                 
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.ExtraProductCategory = model.ExtraProductCategory;
                entity.SaleExtras = model.SaleExtras;

            }
            return entity;
        }

        public static ExtraProductsModel EntityToModel(this ExtraProducts entity, bool virtualActive = false)
        {
            try
            {
                ExtraProductsModel model = new ExtraProductsModel()
                {
                     Amount=entity.Amount,
                      ExtraProductCategoryId=entity.ExtraProductCategoryId,
                      Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.ExtraProductCategory = entity.ExtraProductCategory;
                    model.SaleExtras = entity.SaleExtras;

                }
                return model;
            }
            catch (Exception)
            {

                return new ExtraProductsModel();
            }


        }

        public static List<ExtraProducts> ModelToEntityList(this IEnumerable<ExtraProductsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemExtraProductsModel => itemExtraProductsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<ExtraProductsModel> EntityToModelList(this IEnumerable<ExtraProducts> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemExtraProductsModel => itemExtraProductsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}