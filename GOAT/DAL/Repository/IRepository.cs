﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<BaseEntity>
    {
        public void Add(BaseEntity entity);
        public void Update(BaseEntity entity);
        public void Delete(BaseEntity entity);
        public BaseEntity Get(BaseEntity entity);
        public List<BaseEntity> GetAll(Type entityType);
    }
}
