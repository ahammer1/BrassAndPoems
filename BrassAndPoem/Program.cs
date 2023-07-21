
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

using System.Runtime.CompilerServices;

public class ProgramMain
{
    private static object productList;
    private object products;

    public static void Main()
    {

        List<ProductType> productType = new()
        {
             new ProductType()
            {
             Title = "Brass",
                 Id = 1
            },
            new ProductType()
            {
            Title = "Poem",
            Id = 2
            }
         };

        List<Product> products = new()
        {
            new Product()
            {
              Name = "Tuba",
              Price =  999.99m,
              ProductTypeId =  1
            },
            new Product()
            {
              Name = "The Road not Taken",
              Price =  19.99m,
              ProductTypeId = 2
            },
            new Product()
            {
              Name = "French Horn",
              Price = 799.99m,
              ProductTypeId = 1
            },
            new Product()
            {
              Name = "Shall I compare thee ",
              Price =  39.99m,
              ProductTypeId = 2
            },
            new Product()
            {
             Name = "Trumpet",
             Price =  299.99m,
             ProductTypeId = 1
            }
        };


        //put your greeting here
        string greeting = @"Welcome to the Poem and Brass Shop";

        Console.WriteLine(greeting);


        string? choice = null;
        //implement your loop here
        while (choice != "5")
        {
            DisplayMenu();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayAllProducts(products, productType);
                Console.WriteLine("Display all products");
            }
            else if (choice == "2")
            {
                DeleteProduct(products, productType);
                Console.WriteLine("Delete a product");
            }
            else if (choice == "3")
            {
                AddProduct(products, productType);
                Console.WriteLine("Add a new product");
            }
            else if (choice == "4")
            {
                UpdateProduct(products, productType);
                Console.WriteLine("Update product properties");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exit");
            }
            else
            {
                Console.WriteLine("Do Better");
            }
        }
        void DisplayMenu()
        {
            Console.WriteLine(@"
                1. Display all products
                2. Delete a product
                3. Add a new product
                4. Update product properties
                5. Exit");

        }

        static void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
        {
            // Iterate over the products and display each product's name, price, and product type title
            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                string productTypeName = GetProductTypeName(product.ProductTypeId, productTypes);
                Console.WriteLine($"{i + 1}. {product.Name} - ${product.Price} - {productTypeName}");
            }
        }

        static string GetProductTypeName(int productTypeId, List<ProductType> productTypes)
        {
            ProductType productType = productTypes.FirstOrDefault(pt => pt.Id == productTypeId);
            return productType != null ? productType.Name : "Unknown Product Type";
        }

        static void DeleteProduct(List<Product> products, List<ProductType> productTypes)
        {
            DisplayAllProducts(products, productTypes);

            if (products.Count == 0)
            {
                Console.WriteLine("No products to delete.");
                return;
            }

            Console.Write("Enter the index of the product you want to delete: ");
            if (int.TryParse(Console.ReadLine(), out int indexToDelete) && indexToDelete >= 1 && indexToDelete <= products.Count)
            {
                Product productToDelete = products[indexToDelete - 1];
                products.Remove(productToDelete);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index. Product deletion canceled.");
            }
        }


        static void AddProduct(List<Product> products, List<ProductType> productTypes)
        {
            Console.Write("Enter the name of the new product: ");
            string productName = Console.ReadLine();

            decimal productPrice;
            Console.Write("Enter the price of the new product: ");
            while (!decimal.TryParse(Console.ReadLine(), out productPrice) || productPrice <= 0)
            {
                Console.WriteLine("Invalid price. Please enter a valid positive number.");
                Console.Write("Enter the price of the new product: ");
            }

            Console.WriteLine("Product Types:");
            DisplayProductTypes(products, productTypes);

            int productTypeId;
            Console.Write("Enter the product type ID for the new product: ");
            while (!int.TryParse(Console.ReadLine(), out productTypeId) || !productTypes.Any(pt => pt.Id == productTypeId))
            {
                Console.WriteLine("Invalid product type ID. Please choose from the available product types.");
                Console.Write("Enter the product type ID for the new product: ");
            }

            Product newProduct = new Product()
            {
                Name = productName,
                Price = productPrice,
                ProductTypeId = productTypeId
            };
            products.Add(newProduct);

            Console.WriteLine("New product added successfully.");
        }
        static void DisplayProductTypes(List<Product> products, List<ProductType> productTypes)
        {
            foreach (ProductType productType in productTypes)
            {
                Console.WriteLine($"ID: {productType.Id} - {productType.Name}");
            }
        }

        static void UpdateProduct(List<Product> products, List<ProductType> productTypes)
        {
            DisplayAllProducts(products, productTypes);

            if (products.Count == 0)
            {
                Console.WriteLine("No products to update.");
                return;
            }

            Console.Write("Enter the index of the product you want to update: ");
            if (int.TryParse(Console.ReadLine(), out int indexToUpdate) && indexToUpdate >= 1 && indexToUpdate <= products.Count)
            {
                Product productToUpdate = products[indexToUpdate - 1];

                Console.Write($"Enter the updated name for {productToUpdate.Name} (press enter to leave unchanged): ");
                string updatedName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(updatedName))
                {
                    productToUpdate.Name = updatedName;
                }

                Console.Write($"Enter the updated price for {productToUpdate.Name} (press enter to leave unchanged): ");
                string priceInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(priceInput) && decimal.TryParse(priceInput, out decimal updatedPrice) && updatedPrice > 0)
                {
                    productToUpdate.Price = updatedPrice;
                }

                Console.WriteLine("Product Types:");
                DisplayProductTypes(products, productTypes);

                Console.Write($"Enter the updated product type ID for {productToUpdate.Name} (press enter to leave unchanged): ");
                string productTypeInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(productTypeInput) && int.TryParse(productTypeInput, out int updatedProductTypeId) && productTypes.Any(pt => pt.Id == updatedProductTypeId))
                {
                    productToUpdate.ProductTypeId = updatedProductTypeId;
                }

                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index. Product update canceled.");
            }
        }
    }

    // don't move or change this!
    public partial class Program { }
}