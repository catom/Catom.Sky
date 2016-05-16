using System.Collections.Generic;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Catom.Sky.Component.Data.Repo
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private IUnitOfWork UnitOfWork { set; get; }

        protected BaseRepository(IUnitOfWork uw)
        {
            UnitOfWork = uw;
        }

        public virtual T Get(long id)
        {
            return UnitOfWork.Connection.Get<T>(id);
        }

        public virtual IEnumerable<T> Get(string where = "", string orderby = "", string limit = " limit 10")
        {
            return UnitOfWork.Connection.Get<T>(where, orderby, limit);
        }

        public virtual long Insert(T entity)
        {
            return UnitOfWork.Connection.Insert(entity);
        }
        
        public virtual bool Update(T entity)
        {
            return UnitOfWork.Connection.Update(entity);
        }
        
        /// <summary>
        ///  eg. Delete(new Entity{Id = 1})
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Delete(T entity)
        {
            return UnitOfWork.Connection.Delete(entity);
        }

        /// <summary>
        ///  批量按主键删除。
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public virtual bool DeleteSome(IEnumerable<long> ids)
        {
            return UnitOfWork.Connection.Delete<T>(ids) > 0;
        }
        
        protected int Execute(string sql, object obj)
        {
            return UnitOfWork.Connection.Execute(sql, obj);
        }

        protected long ExecuteScalar(string sql, object obj)
        {
            return UnitOfWork.Connection.ExecuteScalar<long>(sql, obj);
        }
    }
}
