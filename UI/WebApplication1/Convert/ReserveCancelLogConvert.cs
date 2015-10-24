using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class ReserveCancelLogConvert
    {
        public static ReserveCancelLog ModelToEnity(this ReserveCancelLogModel model, bool virtualActive = false)
        {
            ReserveCancelLog entity = new ReserveCancelLog()
            {
                AgencyId = model.AgencyId,
                CustomerId = model.CustomerId,
                Description = model.Description,
                ReserveCancelDate = model.ReserveCancelDate,
                ReserveDate = model.ReserveDate,
                SaleId = model.SaleId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {

            }
            return entity;
        }

        public static ReserveCancelLogModel EntityToModel(this ReserveCancelLog entity, bool virtualActive = false)
        {
            try
            {
                ReserveCancelLogModel model = new ReserveCancelLogModel()
                {
                    AgencyId = entity.AgencyId,
                    CustomerId = entity.CustomerId,
                    SaleId = entity.SaleId,
                    Description = entity.Description,
                    ReserveDate = entity.ReserveDate,
                    ReserveCancelDate = entity.ReserveDate,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                }
                return model;
            }
            catch (Exception)
            {

                return new ReserveCancelLogModel();
            }


        }

        public static List<ReserveCancelLog> ModelToEntityList(this IEnumerable<ReserveCancelLogModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemReserveCancelLogModel => itemReserveCancelLogModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<ReserveCancelLogModel> EntityToModelList(this IEnumerable<ReserveCancelLog> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemReserveCancelLogModel => itemReserveCancelLogModel.EntityToModel(virtualActive)).ToList();
        }
    }
}