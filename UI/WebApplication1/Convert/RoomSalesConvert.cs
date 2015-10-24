using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomSalesConvert
    {
        public static RoomSales ModelToEnity(this RoomSalesModel model, bool virtualActive = false)
        {
            RoomSales entity = new RoomSales()
            {
                 Amount=model.Amount,
                  DiscountsId=model.DiscountsId,
                   LoginDate=model.LoginDate,
                    LogoutDate=model.LogoutDate,
                     PacketId=model.PacketId,
                      RoomId=model.RoomId,
                       SalesId=model.SalesId,
                       
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Discount = model.Discount;
                entity.Packet = model.Packet;
                entity.Room = model.Room;
                entity.Sale = model.Sale;
                entity.SaleExtras = model.SaleExtras;
                entity.StayingInRooms = model.StayingInRooms;

            }
            return entity;
        }

        public static RoomSalesModel EntityToModel(this RoomSales entity, bool virtualActive = false)
        {
            try
            {
                RoomSalesModel model = new RoomSalesModel()
                {
                    Amount = entity.Amount,
                    DiscountsId = entity.DiscountsId,
                    LoginDate = entity.LoginDate,
                    LogoutDate = entity.LogoutDate,
                    PacketId = entity.PacketId,
                    RoomId = entity.RoomId,
                    SalesId = entity.SalesId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Discount = entity.Discount;
                    model.Packet = entity.Packet;
                    model.Room = entity.Room;
                    model.Sale = entity.Sale;
                    model.SaleExtras = entity.SaleExtras;
                    model.StayingInRooms = entity.StayingInRooms;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomSalesModel();
            }


        }

        public static List<RoomSales> ModelToEntityList(this IEnumerable<RoomSalesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomSalesModel => itemRoomSalesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomSalesModel> EntityToModelList(this IEnumerable<RoomSales> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomSalesModel => itemRoomSalesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}