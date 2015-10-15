using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Dapper.Contrib.Extensions;
using Catom.Sky.Component.Data;

namespace Catom.Sky.Component.Repo
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private IUnitOfWork UnitOfWork { set; get; }

        public BaseRepository(IUnitOfWork uw)
        {
            this.UnitOfWork = uw;
        }

        public virtual T Get(long id)
        {
            return this.UnitOfWork.Connection.GetOne<T>(id);
        }

        public virtual IEnumerable<T> GetSome(string where = "", string orderby = "", string limit = " limit 10")
        {
            return this.UnitOfWork.Connection.GetSome<T>(where, orderby, limit);
        }

        public virtual long Create(T entity)
        {
            return this.UnitOfWork.Connection.InsertOne<T>(entity);
        }
        
        public virtual bool Update(T entity)
        {
            return this.UnitOfWork.Connection.Update<T>(entity);
        }
        
        /// <summary>
        ///  eg. Delete(new Entity{Id = 1})
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Delete(T entity)
        {
            return this.UnitOfWork.Connection.DeleteOne<T>(entity);
        }

        /// <summary>
        ///  批量按主键删除。
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public virtual bool DeleteSome(IEnumerable<long> IDs)
        {
            return this.UnitOfWork.Connection.DeleteSome<T>(IDs) > 0;
        }
        
        protected int Execute(string sql, object obj)
        {
            return this.UnitOfWork.Connection.Execute(sql, obj);
        }

        protected long ExecuteScalar(string sql, object obj)
        {
            return this.UnitOfWork.Connection.ExecuteScalar<long>(sql, obj);
        }
    }
}
