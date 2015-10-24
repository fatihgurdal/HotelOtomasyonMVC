using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectTemplate.Core.Repository;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace ProjectTemplate.Core.EF
{
    public class EFRepository : IRepository
    {

        //private static readonly ICommandBuilder CommandBuilder = new EntityFrameworkCommandBuilder();
        private readonly DbContext _dbContext;

        //protected readonly IUnitOfWork UnitOfWork;

        public EFRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }


        private DbSet<T> Set<T>() where T : class, new()
        {
            return _dbContext.Set<T>();
        }

        public  int Insert<T>(T entity) where T : class, new()
        {
            //_dbContext.Set<T>().Add(entity);
            return SetState(entity, EntityState.Added);
        }

        public  int Update<T>(T entity) where T : class, new()
        {
            return SetState(entity, EntityState.Modified);
        }

        public  int Delete<T>(T entity) where T : class, new()
        {
            return SetState(entity, EntityState.Deleted);
        }

        public  IQueryable<T> Select<T>() where T : class, new()
        {
            return Set<T>();
        }

        public IList<T> Query<T>(string spNameOrSql, IDictionary<string, object> args = null, bool rawSql = false) where T : class, new()
        {
            //List<ObjectParameter> lists= new List<ObjectParameter>();
            //foreach (var item in args)
            //{
            //    lists.Add(new ObjectParameter(
            //        item.Key,
            //        item.Value
            //    ));
            //}

                        List<SqlParameter> lists= new List<SqlParameter>();
            foreach (var item in args)
            {
                lists.Add(new SqlParameter(
                    item.Key,
                    item.Value
                ));
            }

            return _dbContext.Database.SqlQuery<T>(spNameOrSql, lists.ToArray()).ToList();
            
            //return ((IObjectContextAdapter)_dbContext).ObjectContext
            //    .CreateQuery<T>(
            //        string.Format("{0} {1}", "EXEC",spNameOrSql),lists.ToArray()).ToList();        
        }

        public void NonQuery(string spNameOrSql, IDictionary<string, object> args = null, bool rawSql = false)
        {
            throw new NotImplementedException();
        }

        //public void Flush()
        //{
        //    UnitOfWork.Commit();
        //}


        private int SetState<T>(T entity, EntityState state) where T : class, new()
        {
            var entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                Set<T>().Attach(entity);
            }
            entry.State = state;

            return _dbContext.SaveChanges();
        }
    }
}