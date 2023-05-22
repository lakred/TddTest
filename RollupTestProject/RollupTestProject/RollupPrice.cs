using RollupTestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollupTestProject
{
    public class RollupPrice
    {
        private readonly List<Product> _products;

        public RollupPrice(List<Product> products)
        {
            _products = products;
        }
        public Dictionary<string, decimal> GetLowestPrices()
        {
            var lowestPrices = new Dictionary<string, decimal>();
            var productGroups = _products.GroupBy(p => p.ProductName);
                foreach (var productGroup in productGroups)
                  {
                     var lowestProductPrice = productGroup.Min(p => p.Price);
                        if (lowestProductPrice.HasValue)
                         {
                             lowestPrices.Add(productGroup.Key, lowestProductPrice.Value);
                         }
                     var variantGroups = productGroup.GroupBy(p => p.Variant);
                      foreach (var variantGroup in variantGroups)
                         {
                            var lowestVariantPrice = variantGroup.Min(p => p.Price);
                                 if (lowestVariantPrice.HasValue && lowestVariantPrice.Value > lowestProductPrice.Value)
                                 {
                                    lowestPrices.Add(variantGroup.Key, lowestVariantPrice.Value);
                                 }
                             foreach (var product in variantGroup)
                             {
                                 if (product.Price.HasValue && product.Price.Value > lowestVariantPrice.Value)
                                 {
                                 lowestPrices.Add(product.GTIN, product.Price.Value);
                                  }
                             }
                        }
                  }

            return lowestPrices;
        }
    }
}


