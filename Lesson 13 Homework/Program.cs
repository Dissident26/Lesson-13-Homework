using ProductClass;

var products = new ProductList();
products.AddProducts(new[]
{
    new Product("product 1", "shop #1"),
    new Product("product 1", "shop #2"),
    new Product("product 2", "shop #1"),
    new Product("product 2", "shop #2"),
    new Product("product 1", "shop #3"),
});

products.SortByRetailerName();
GetProductListByShopName();

void GetProductListByShopName()
{
    string shopName = Console.ReadLine();

    if(shopName != null)
    {
        var filteredList = products?.FilterByRetailerName(shopName);

        foreach (var item in filteredList)
        {
            Console.WriteLine(item.Name);
        }
    }
}