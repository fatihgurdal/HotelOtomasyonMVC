using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Core.Repository
{
    /// <summary>
    /// The repository interface
    /// </summary>
    public interface IRepository
    {


        int Insert<T>(T entity) where T : class, new();
        int Update<T>(T entity) where T : class, new();
        int Delete<T>(T entity) where T : class, new();
        IQueryable<T> Select<T>() where T : class, new();

        IList<T> Query<T>(string spNameOrSql, IDictionary<string, object> args = null, bool rawSql = false) where T : class, new();
        void NonQuery(string spNameOrSql, IDictionary<string, object> args = null, bool rawSql = false);

        //void Flush();


        /*
        /// <summary>
        /// Inserts or updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Save<T>(T entity) where T : class, new();

        /// <summary>
        /// Selects the given entity table as IQueryable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> Get<T>() where T : class, new();
        T Get<T>(object id) where T : class, new();

        /// <summary>
        /// Inserts or updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Merge<T>(T entity) where T : class, new();

        /// <summary>
        /// Updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Update<T>(T entity) where T : class, new();

        /// <summary>
        /// Deletes the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Delete<T>(T entity) where T : class, new();
        void Delete<T>(object id) where T : class, new();
        */

        /* /// <summary>
        /// Inserts or updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Save<T>(T entity) where T : class, new();

        /// <summary>
        /// Selects the given entity table as IQueryable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> Select<T>() where T : class, new();

   
        /// <summary>
        /// Inserts the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Insert<T>(T entity) where T : class, new();

        /// <summary>
        /// Inserts or updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Merge<T>(T entity) where T : class, new();

        /// <summary>
        /// Updates the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Update<T>(T entity) where T : class, new();

        /// <summary>
        /// Deletes the given entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Delete<T>(T entity) where T : class, new();
*/
    }
}
