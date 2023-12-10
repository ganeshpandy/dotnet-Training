namespace Product
{
     class Program
    {
        static void Main(string[] args)
        {
            ProductDetails _details = new ProductDetails();
            IEnumerable<ProductDetails> _productDetails = ProductDetails.LoadProduct();

            foreach (var product in _productDetails)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, ProductModel: {product.ProductModel}");
            }
        }
    }
}
