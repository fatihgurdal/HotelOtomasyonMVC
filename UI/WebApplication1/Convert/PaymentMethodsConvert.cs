using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class PaymentMethodsConvert
    {
        public static PaymentMethods ModelToEnity(this PaymentMethodsModel model, bool virtualActive = false)
        {
            PaymentMethods entity = new PaymentMethods()
            {
                 Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Sales = model.Sales;

            }
            return entity;
        }

        public static PaymentMethodsModel EntityToModel(this PaymentMethods entity, bool virtualActive = false)
        {
            try
            {
                PaymentMethodsModel model = new PaymentMethodsModel()
                {
                    Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Sales = entity.Sales;

                }
                return model;
            }
            catch (Exception)
            {

                return new PaymentMethodsModel();
            }


        }

        public static List<PaymentMethods> ModelToEntityList(this IEnumerable<PaymentMethodsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPaymentMethodsModel => itemPaymentMethodsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<PaymentMethodsModel> EntityToModelList(this IEnumerable<PaymentMethods> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemPaymentMethodsModel => itemPaymentMethodsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}