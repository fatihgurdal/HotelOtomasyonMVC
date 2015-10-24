using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceRooms : ServiceBase<Rooms>,IServiceRooms

    {
        private readonly IBusinessRooms _businessRooms;
        public ServiceRooms(IBusinessBase<Rooms> business, IBusinessRooms businessRooms)
            : base(business)
        {
            _businessRooms = businessRooms;
        }
        /// <summary>
        /// Tarih bilgilerine göre müsait odaları getirme methodu
        /// </summary>
        /// <param name="startDateTime">Giriş tarihi</param>
        /// <param name="endDateTime">Çıkış Tarihi</param>
        /// <param name="thisId">Eğer güncelleme yapıyorsanız. Aktif olan Oda Id</param>
        /// <returns>Geriye seçilmesi müsait olan odaların listesini döner</returns>
        public IEnumerable<Rooms> GetDateRooms(DateTime startDateTime, DateTime endDateTime, int thisId = 0)
        {
            return _businessRooms.GetDateRooms(startDateTime, endDateTime,thisId);
        }
        /// <summary>
        /// Bir oda tipine ait odalar
        /// </summary>
        /// <param name="typeId">Oda tip Id</param>
        /// <returns>Geriye seçilmesi müsait olan odaların listesini döner</returns>
        public IEnumerable<Rooms> GetTypeRooms(int typeId)
        {
            return _businessRooms.GetTypeRooms(typeId);
        }
        /// <summary>
        /// Giriş tarihi, çıkış tarihi ve oda tipine göre müsait oları getiren methodtur.
        /// </summary>
        /// <param name="startDateTime">Giriş Tarihi</param>
        /// <param name="endDateTime">Çıkış Tarihi</param>
        /// <param name="typeId">İstenilen oda tip Id</param>
        /// <param name="thisId">Eğer güncelleme yapıyorsanız aktif odanın Id sini giriniz</param>
        /// <returns>Geriye seçilmesi müsait olan odaların listesini döner</returns>
        public IEnumerable<Rooms> GetTypeAndDateRooms(DateTime startDateTime, DateTime endDateTime, int typeId, int thisId = 0)
        {
            return _businessRooms.GetTypeAndDateRooms(startDateTime, endDateTime, typeId,thisId);
        }
    }
}
