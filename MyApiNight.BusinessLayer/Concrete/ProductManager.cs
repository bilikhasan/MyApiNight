using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Concrete
{
    internal class ProductManager : IProductService
    {
        private readonly IProductDal _prodcutDal;
        public ProductManager(IProductDal prodcutDal)
        {
            _prodcutDal = prodcutDal;
        }
        public void TDelete(int id)
        {
            _prodcutDal.Delete(id);
        }
        public List<Product> TGetAll()
        {
            return _prodcutDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _prodcutDal.GetById(id);
        }
        public void TInsert(Product entity)
        {
            _prodcutDal.Insert(entity);
        }
        public void TUpdate(Product entity)
        {
            _prodcutDal.Update(entity);
        }
    }
}
