using eShop.UseCases.PluginInterfaces.DataStore;
using eShope.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct
    {
        private readonly IProductRepository productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return productRepository.GetProducts(filter);
        }
    }
}
