using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class PacketsConvert
    {
        public static Packets ModelToEnity(this PacketsModel model, bool virtualActive = false)
        {
            Packets entity = new Packets()
            {
                Description = model.Description,
                Name = model.Name,
                PricePercentage = model.PricePercentage,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomSales = model.RoomSales;
                entity.PacketsExtraProductCategories = model.PacketsExtraProductCategories;

            }
            return entity;
        }

        public static PacketsModel EntityToModel(this Packets entity, bool virtualActive = false)
        {
            try
            {
                PacketsModel model = new PacketsModel()
                {
                    Description = entity.Description,
                    Name = entity.Name,
                    IsActive = entity.IsActive,
                    PricePercentage = entity.PricePercentage,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomSales = entity.RoomSales;
                    model.PacketsExtraProductCategories = entity.PacketsExtraProductCategories;

                }
                return model;
            }
            catch (Exception)
            {

                return new PacketsModel();
            }


        }

        public static List<Packets> ModelToEntityList(this IEnumerable<PacketsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPacketsModel => itemPacketsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<PacketsModel> EntityToModelList(this IEnumerable<Packets> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPacketsModel => itemPacketsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}