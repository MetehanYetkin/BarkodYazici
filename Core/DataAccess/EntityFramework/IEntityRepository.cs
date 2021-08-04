using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntitiyRepository<T> where T : class, new() //T bir refeans tip olmalı ve ya IEntitiy ya da IEntitiyden referans bir tip olabilir.

    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); //T döndüren Get operasyonu
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

    }
}
