using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class UsersConvert
    {
        public static Users ModelToEnity(this UsersModel model, bool virtualActive = false)
        {
            Users entity = new Users()
            {
                Employee = model.Employee,
                EmployeeId = model.EmployeeId,
                Id = model.Id,
                Password = model.Password,
                UserName = model.UserName
            };
            return entity;
        }

        public static UsersModel EntityToModel(this Users entity, bool virtualActive = false)
        {
            try
            {
                UsersModel model = new UsersModel()
                {
                    Employee = entity.Employee,
                    EmployeeId = entity.EmployeeId,
                    Id = entity.Id,
                    Password = entity.Password,
                    UserName = entity.UserName
                };
                return model;
            }
            catch (Exception)
            {

                return new UsersModel();
            }


        }
    }
}