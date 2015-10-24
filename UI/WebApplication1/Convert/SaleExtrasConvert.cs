using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class SaleExtrasConvert
    {
        public static SaleExtras ModelToEnity(this SaleExtrasModel model, bool virtualActive = false)
        {
            SaleExtras entity = new SaleExtras()
            {
                 ExtraProductId=model.ExtraProductId,
                  ProductAmount=model.ProductAmount,
                   ProductUnit=model.ProductUnit,
                    RoomSaleId=model.RoomSaleId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomSale = model.RoomSale;
                entity.ExtraProduct = model.ExtraProduct;

            }
            return entity;
        }

        public static SaleExtrasModel EntityToModel(this SaleExtras entity, bool virtualActive = false)
        {
            try
            {
                SaleExtrasModel model = new SaleExtrasModel()
                {
                    ExtraProductId = entity.ExtraProductId,
                    ProductAmount = entity.ProductAmount,
                    ProductUnit = entity.ProductUnit,
                    RoomSaleId = entity.RoomSaleId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomSale = entity.RoomSale;
                    model.ExtraProduct = entity.ExtraProduct;

                }
                return model;
            }
            catch (Exception)
            {

                return new SaleExtrasModel();
            }


        }

        public static List<SaleExtras> ModelToEntityList(this IEnumerable<SaleExtrasModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemSaleExtrasModel => itemSaleExtrasModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<SaleExtrasModel> EntityToModelList(this IEnumerable<SaleExtras> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemSaleExtrasModel => itemSaleExtrasModel.EntityToModel(virtualActive)).ToList();
        }
    }
}