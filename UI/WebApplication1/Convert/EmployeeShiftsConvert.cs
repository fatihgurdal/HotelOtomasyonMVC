using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class EmployeeShiftsConvert
    {
        public static EmployeeShifts ModelToEnity(this EmployeeShiftsModel model, bool virtualActive = false)
        {
            EmployeeShifts entity = new EmployeeShifts()
            {
                DailyWages = model.DailyWages,
                EmployeeId = model.EmployeeId,
                ShiftId = model.ShiftId,

                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Employee = model.Employee.ModelToEntity();
                entity.Shift = model.Shift.ModelToEnity();

            }
            return entity;
        }

        public static EmployeeShiftsModel EntityToModel(this EmployeeShifts entity, bool virtualActive = false)
        {
            try
            {
                EmployeeShiftsModel model = new EmployeeShiftsModel()
                {
                    DailyWages = entity.DailyWages,
                    EmployeeId = entity.EmployeeId,
                    ShiftId = entity.ShiftId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Shift = entity.Shift.EntityToModel();
                    model.Employee = entity.Employee.EntityToModel();

                }
                return model;
            }
            catch (Exception)
            {

                return new EmployeeShiftsModel();
            }


        }

        public static List<EmployeeShifts> ModelToEntityList(this IEnumerable<EmployeeShiftsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemEmployeeShiftsModel => itemEmployeeShiftsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<EmployeeShiftsModel> EntityToModelList(this IEnumerable<EmployeeShifts> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemEmployeeShiftsModel => itemEmployeeShiftsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}