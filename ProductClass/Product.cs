namespace ProductClass
{
    public class Product: IComparable
    {
        public string Name;
        public string RetailerName;
        public Product(string name, string retailerName)
        {
            Name = name;
            RetailerName = retailerName;
         }

        public int CompareTo(Product? obj)
        {
            return RetailerName.CompareTo(obj?.RetailerName);
        }

        public int CompareTo(object? obj)
        {
            return Name.CompareTo(obj);
        }
    }

    public class ProductList
    {
        public List<Product> Products = new();

        public void SortByRetailerName()
        {
            Products?.Sort((x, y) => x.CompareTo(y));
        }
        public List<Product>? FilterByRetailerName(string retailerName)
        {
            var result = Products?.FindAll(x => x.RetailerName == retailerName);
            if(result?.Count == 0)
            {
                throw new ArgumentException($"Shop '{retailerName}' do not exist in list!");
            }

            return result;
        }

        public void AddProducts(Product[] products)
        {
            foreach (var item in products)
            {
                Products.Add(item);
            }
        }
    }
}