using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Interfaces
{
    public interface IGenericRepository<TContext,TEntity>
        where TContext:DbContext, new() 
        where TEntity : class,new()
    {
        List<TEntity> GetAll(TContext context,Expression<Func<TEntity,bool>> filter=null);//filtre null ise tüm listeyi getir değilsede filtreler
        TEntity GetByFilter(TContext context,Expression<Func<TEntity,bool>> filter=null);//Tek Kayıt Getirir.
        TEntity GetById(TContext context,int? id);
        void InsertorUpdate(TContext context,TEntity entity);
        void Delete(TContext context,Expression<Func<TEntity,bool>> filter=null);
        void Save(TContext context);
    }
}
