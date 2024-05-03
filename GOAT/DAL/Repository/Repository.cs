using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository : IRepository<BaseEntity>
    {
        private readonly GoatContext goatContext = new();
        public void Add(BaseEntity entity)
        {
            goatContext.Add<BaseEntity>(entity);
        }

        public void Delete(BaseEntity entity)
        {
            var data = goatContext.Find<BaseEntity>(entity);
            if(data is not null) data.IsExist = false;
        }

        public BaseEntity Get(BaseEntity entity)
        {
            var data = goatContext.Find<BaseEntity>(entity);
            if (data is not null) return data;
            return new BaseEntity();
        }

        public List<BaseEntity> GetAll(Type entityType)
        {
            return goatContext.Set<BaseEntity>().ToList();
        }

        public void Update(BaseEntity entity)
        {
            goatContext.Update<BaseEntity>(entity);
        }
    }
}
