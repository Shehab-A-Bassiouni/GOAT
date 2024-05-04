using DTOs;
using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly GoatContext goatContext = new();
        public void Add(T entity)
        {
            goatContext.Add(entity);
            Save();
        }

        public void DeleteByID(int id)
        {
            var data = goatContext.Set<T>().Find(id);
            if (data is not null) {
                data.IsExist = false;
                Save();
            } 
        }

        public List<T> GetAll()
        {
            List<T> products;
            var set = goatContext.Set<T>();
            if (set is not null) { 
                products= set.ToList();
                foreach (var item in products.ToList())
                {
                    if(item.IsExist == false) products.Remove(item);
                }
                return products;
            }
            return new List<T>();
        }

        public void Update(T entity)
        {
            goatContext.Update(entity);
            Save();
        }

        public void Save() {
            goatContext.SaveChanges();
        }

        public T GetByID(int id) {
            var prod = goatContext.Set<T>().Find(id);
           return prod ;
        }

       
    }
}
