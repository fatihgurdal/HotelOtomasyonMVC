using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class GroupsOfEmployeeConvert
    {
        public static GroupsOfEmployee ModelToEnity(this GroupsOfEmployeeModel model, bool virtualActive = false)
        {
            GroupsOfEmployee entity = new GroupsOfEmployee()
            {
                 DepartmentId=model.DepartmentId,
                  Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Employees = model.Employees;
                entity.Department = model.Department;

            }
            return entity;
        }

        public static GroupsOfEmployeeModel EntityToModel(this GroupsOfEmployee entity, bool virtualActive = false)
        {
            try
            {
                GroupsOfEmployeeModel model = new GroupsOfEmployeeModel()
                {
                     DepartmentId=entity.DepartmentId,
                      Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Department = entity.Department;
                    model.Employees = entity.Employees;

                }
                return model;
            }
            catch (Exception)
            {

                return new GroupsOfEmployeeModel();
            }


        }

        public static List<GroupsOfEmployee> ModelToEntityList(this IEnumerable<GroupsOfEmployeeModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemGroupsOfEmployeeModel => itemGroupsOfEmployeeModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<GroupsOfEmployeeModel> EntityToModelList(this IEnumerable<GroupsOfEmployee> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemGroupsOfEmployeeModel => itemGroupsOfEmployeeModel.EntityToModel(virtualActive)).ToList();
        }
    }
}