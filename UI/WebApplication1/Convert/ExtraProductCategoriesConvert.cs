using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class ExtraProductCategoriesConvert
    {
        public static ExtraProductCategories ModelToEnity(this ExtraProductCategoriesModel model, bool virtualActive = false)
        {
            ExtraProductCategories entity = new ExtraProductCategories()
            {
                Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.ExtraProducts = model.ExtraProducts;
                entity.PacketsExtraProductCategories = model.PacketsExtraProductCategories;

            }
            return entity;
        }

        public static ExtraProductCategoriesModel EntityToModel(this ExtraProductCategories entity, bool virtualActive = false)
        {
            try
            {
                ExtraProductCategoriesModel model = new ExtraProductCategoriesModel()
                {
                    Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.PacketsExtraProductCategories = entity.PacketsExtraProductCategories;
                    model.ExtraProducts = entity.ExtraProducts;

                }
                return model;
            }
            catch (Exception)
            {

                return new ExtraProductCategoriesModel();
            }


        }

        public static List<ExtraProductCategories> ModelToEntityList(this IEnumerable<ExtraProductCategoriesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemExtraProductCategoriesModel => itemExtraProductCategoriesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<ExtraProductCategoriesModel> EntityToModelList(this IEnumerable<ExtraProductCategories> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemExtraProductCategoriesModel => itemExtraProductCategoriesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}