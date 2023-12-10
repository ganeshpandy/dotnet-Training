using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ProductDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public int Amount { get; set; }

        public static  IEnumerable<ProductDetails> LoadProduct()
        {
            List<ProductDetails> productName = new List<ProductDetails>()
            {
                new ProductDetails() { ProductId = 1, ProductName = "Mobile"} ,
                new ProductDetails() { ProductId = 2, ProductName = "Laptop" } ,
                new ProductDetails() { ProductId = 3, ProductName = "TV" } ,
                new ProductDetails() { ProductId = 4, ProductName = "AC"  },
                new ProductDetails() { ProductId = 5, ProductName = "FRIDGE"  }
            };

            List<ProductDetails> productModel = new List<ProductDetails>()
            {
                new ProductDetails() { ProductId = 1, ProductModel = "Samsung M31", Amount = 15000 } ,
                new ProductDetails() { ProductId = 1, ProductModel = "Nokia A45", Amount = 25000 } ,
                new ProductDetails() { ProductId = 2, ProductModel = "Dell Intel Core",  Amount = 25000 } ,
                new ProductDetails() { ProductId = 3, ProductModel = "Sony Bravia",  Amount = 35000 } ,
                new ProductDetails() { ProductId = 4, ProductModel = "Carrier" , Amount = 34000 },
                new ProductDetails() { ProductId = 7, ProductModel = "HairTrimmer" , Amount = 3000 },
                new ProductDetails() { ProductId = 11, ProductModel = "Boat Airpods" , Amount = 1500 }
            };
                     
            Console.WriteLine("================Union===================");
            var unionResult = productName.Union(productModel, new ProductCombine());            
            foreach (var data in unionResult)
            {
                yield return data;
            }
            Console.WriteLine();

            Console.WriteLine("===============Intersect================");
            var intersectResult = productName.Intersect(productModel, new ProductCombine());            
            foreach (var data in intersectResult)
            {
                yield return data;
            }
            Console.WriteLine();

            Console.WriteLine("===============Except================");
            var exceptResult = productName.Except(productModel, new ProductCombine());            
            foreach (var data in exceptResult)
            {
                yield return data;
            }
            Console.WriteLine();

            Console.WriteLine("===============Distinct================");
            var distinctResult = productModel.Distinct(new ProductCombine());
            PrintProducts(distinctResult);
            foreach (var data in distinctResult)
            {
                yield return data;
            }
            Console.WriteLine();
        }

        public static void PrintProducts(IEnumerable<ProductDetails> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, ProductModel: {product.ProductModel}");
            }
            Console.WriteLine();
        }

        public class ProductCombine : IEqualityComparer<ProductDetails>
        {
            public bool Equals(ProductDetails x, ProductDetails y)
            {
                if (x.ProductId == y.ProductId)
                    return true;

                return false;
            }

            public int GetHashCode(ProductDetails obj)
            {
                return obj.ProductId.GetHashCode();
            }
        }
    }
}
