
using DAL;
using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{
    public class EntityRepository: IRepository<BaseEntity>
    {
        private readonly DALContext _dalContext = new DALContext();
        public void Add(BaseEntity entity)
        {
            _dalContext.Add(entity);
            _dalContext.SaveChanges();
        }

    public void Update(BaseEntity entity)  
        {
            _dalContext.Update(entity);
            _dalContext.SaveChanges();

        }

        public void Delete(BaseEntity entity) { 
            _dalContext.Remove(entity);
            _dalContext.SaveChanges();

        }

        public BaseEntity Get(BaseEntity entity)
        {
           return _dalContext.Find<BaseEntity>(entity)??new BaseEntity();
        }

    }
}
