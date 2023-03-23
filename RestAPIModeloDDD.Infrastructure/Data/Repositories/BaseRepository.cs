﻿using Microsoft.EntityFrameworkCore;
using RestAPIModeloDDD.Domain.Core.Interface.Repositories;

namespace RestAPIModeloDDD.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {

                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();

            }catch (Exception ex)
            {
                throw ex;
            }            
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {

                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.Set<TEntity>().Update(obj);
                sqlContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
