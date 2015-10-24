using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class ShiftsConvert
    {
        public static Shifts ModelToEnity(this ShiftsModel model, bool virtualActive = false)
        {
            Shifts entity = new Shifts()
            {
                EndTime = model.EndTime,
                StartTime = model.StartTime,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.EmployeeShifts = model.EmployeeShifts;
            }
            return entity;
        }

        public static ShiftsModel EntityToModel(this Shifts entity, bool virtualActive = false)
        {
            try
            {
                ShiftsModel model = new ShiftsModel()
                {
                     EndTime=entity.EndTime,
                      StartTime=entity.StartTime,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.EmployeeShifts = entity.EmployeeShifts;

                }
                return model;
            }
            catch (Exception)
            {

                return new ShiftsModel();
            }


        }

        public static List<Shifts> ModelToEntityList(this IEnumerable<ShiftsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemShiftsModel => itemShiftsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<ShiftsModel> EntityToModelList(this IEnumerable<Shifts> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemShiftsModel => itemShiftsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}