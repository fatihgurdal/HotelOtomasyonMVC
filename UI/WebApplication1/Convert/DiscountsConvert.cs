using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class DiscountsConvert
    {
        public static Discounts ModelToEnity(this DiscountsModel model, bool virtualActive = false)
        {
            Discounts entity = new Discounts()
            {
                Description=model.Description,
                EndingDate=model.EndingDate,
                Name=model.Name,
                Rate=model.Rate,
                StartingDate=model.StartingDate,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomSales = model.RoomSales;
            }
            return entity;
        }

        public static DiscountsModel EntityToModel(this Discounts entity, bool virtualActive = false)
        {
            try
            {
                DiscountsModel model = new DiscountsModel()
                {
                    Description = entity.Description,
                    Name = entity.Name,
                    EndingDate=entity.EndingDate,
                    Rate=entity.Rate,
                    StartingDate=entity.StartingDate,
                    IsActive=entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomSales= entity.RoomSales;
                    
                }
                return model;
            }
            catch (Exception)
            {

                return new DiscountsModel();
            }


        }

        public static List<Discounts> ModelToEntityList(this IEnumerable<DiscountsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemDiscountsModel => itemDiscountsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<DiscountsModel> EntityToModelList(this IEnumerable<Discounts> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemDiscountsModel => itemDiscountsModel.EntityToModel(virtualActive)).ToList();
        } 
    }
}