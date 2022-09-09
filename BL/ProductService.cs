using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DomainModel;
using ViewModel;

namespace BL
{
    public class ProductService
    {
        public void Create(ProductVM model)
        {
            /*
             * validation
             * duplicate
             * tejari
             */
            

            var product = new Product { 
                Name = model.Name,
                Description = model.Description,
                Id = model.Id
            };

            //AutoMapper
            //https://automapper.org/

            var repo = new ProductRepo();
            repo.Create(product);

        }
    }
}
