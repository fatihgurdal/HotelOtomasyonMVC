using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class StayingInRoomConvert
    {
        public static StayingInRoom ModelToEnity(this StayingInRoomModel model, bool virtualActive = false)
        {
            StayingInRoom entity = new StayingInRoom()
            {
                 CustomerId=model.CustomerId,
                  RoomSaleId=model.RoomSale_Id,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomSale = model.RoomSale;
                entity.Customer = model.Customer;

            }
            return entity;
        }

        public static StayingInRoomModel EntityToModel(this StayingInRoom entity, bool virtualActive = false)
        {
            try
            {
                StayingInRoomModel model = new StayingInRoomModel()
                {
                     CustomerId=entity.CustomerId,
                      RoomSale_Id=entity.RoomSaleId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomSale = entity.RoomSale;
                    model.Customer = entity.Customer;

                }
                return model;
            }
            catch (Exception)
            {

                return new StayingInRoomModel();
            }


        }

        public static List<StayingInRoom> ModelToEntityList(this IEnumerable<StayingInRoomModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemStayingInRoomModel => itemStayingInRoomModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<StayingInRoomModel> EntityToModelList(this IEnumerable<StayingInRoom> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemStayingInRoomModel => itemStayingInRoomModel.EntityToModel(virtualActive)).ToList();
        }
    }
}