using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class SalesConvert
    {
        public static Sales ModelToEnity(this SalesModel model, bool virtualActive = false)
        {
            Sales entity = new Sales()
            {
                AgenciesComission = model.AgenciesComission,
                Amount = model.Amount,
                BilgeTourCommission = model.BilgeTourCommission,
                CustomerId = model.CustomerId,
                EmployeeId = model.EmployeeId,
                IsCollect = model.IsCollect,
                IsSale = model.IsSale,
                PaymentMethodId = model.PaymentMethodId,
                ReserveDate = model.ReserveDate,
                SaleAgencyId = model.SaleAgencyId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.PaymentMethod = model.PaymentMethod;
                entity.Customer = model.Customer;
                entity.Employee = model.Employee;
                entity.RoomSales = model.RoomSales;
            }
            return entity;
        }

        public static SalesModel EntityToModel(this Sales entity, bool virtualActive = false)
        {
            try
            {
                SalesModel model = new SalesModel()
                {

                    AgenciesComission = entity.AgenciesComission,
                    BilgeTourCommission = entity.BilgeTourCommission,
                    Amount = entity.Amount,
                    CustomerId = entity.CustomerId,
                    EmployeeId = entity.EmployeeId,
                    IsCollect = entity.IsCollect,
                    IsSale = entity.IsSale,
                    PaymentMethodId = entity.PaymentMethodId,
                    SaleAgencyId = entity.SaleAgencyId,
                    IsActive = entity.IsActive,
                    Id = entity.Id,
                    ReserveDate =System.Convert.ToDateTime(entity.ReserveDate)
                };
                if (virtualActive)
                {
                    model.Customer = entity.Customer;
                    model.Employee = entity.Employee;
                    model.PaymentMethod = entity.PaymentMethod;
                    model.RoomSales = entity.RoomSales;
                }
                return model;
            }
            catch (Exception)
            {

                return new SalesModel();
            }


        }

        public static List<Sales> ModelToEntityList(this IEnumerable<SalesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemSalesModel => itemSalesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<SalesModel> EntityToModelList(this IEnumerable<Sales> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemSalesModel => itemSalesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}