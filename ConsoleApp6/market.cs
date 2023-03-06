using System.Collections.Specialized;
using Lab2_2;

namespace Lab2_2
{
    internal class market
    {
        static void Main(string[] args)
        {
            List<Product> products = GetProductsFromFile("List.txt");
            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine("{0}:", group.Key);
                foreach (Product product in group)
                {
                    Console.WriteLine("- {0} ₴{1}", product.Name, product.Price);
                }
            }

            static List<Product> GetProductsFromFile(string filePath)
            {
                {
                    List<Product> products = new List<Product>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = reader.ReadLine();
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(';');
                            Product product = new Product
                            {
                                Name = parts[0].Trim(),
                                Category = parts[1].Trim(),
                                Price = int.Parse(parts[2]),
                            };
                            products.Add(product);
                        }
                    }


                    return products;
                }
            }
        }
    }
}