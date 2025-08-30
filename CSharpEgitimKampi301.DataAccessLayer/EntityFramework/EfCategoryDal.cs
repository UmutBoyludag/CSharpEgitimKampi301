using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    //    public void Insert(T entity)
    //    {
    //        using (var context = new Context()) // Context senin DbContext sınıfın
    //        {
    //            context.Set<T>().Add(entity);
    //            context.SaveChanges(); // ÖNEMLİ!!!
    //        }
    //    }
    //}
}
}
