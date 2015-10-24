using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class PacketsExtraProductCategoriesConvert
    {
        public static PacketsExtraProductCategories ModelToEnity(this PacketsExtraProductCategoriesModel model, bool virtualActive = false)
        {
            PacketsExtraProductCategories entity = new PacketsExtraProductCategories()
            {
                ExtraProductCategoryId = model.ExtraProductCategoryId,
                PacketId = model.PacketId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Packet = model.Packet;
                entity.ExtraProductCategory = model.ExtraProductCategory;

            }
            return entity;
        }

        public static PacketsExtraProductCategoriesModel EntityToModel(this PacketsExtraProductCategories entity, bool virtualActive = false)
        {
            try
            {
                PacketsExtraProductCategoriesModel model = new PacketsExtraProductCategoriesModel()
                {
                    ExtraProductCategoryId = entity.ExtraProductCategoryId,
                    PacketId = entity.PacketId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Packet = entity.Packet;
                    model.ExtraProductCategory = entity.ExtraProductCategory;

                }
                return model;
            }
            catch (Exception)
            {

                return new PacketsExtraProductCategoriesModel();
            }


        }

        public static List<PacketsExtraProductCategories> ModelToEntityList(this IEnumerable<PacketsExtraProductCategoriesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPacketsExtraProductCategoriesModel => itemPacketsExtraProductCategoriesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<PacketsExtraProductCategoriesModel> EntityToModelList(this IEnumerable<PacketsExtraProductCategories> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPacketsExtraProductCategoriesModel => itemPacketsExtraProductCategoriesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}