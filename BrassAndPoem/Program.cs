
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

public class ProgramMain
{
    public static void Main()
    {
        List<ProductType> productTypes = new List<ProductType>
        {
            new ProductType("Brass", 1),
            new ProductType("Poem", 2)
        };

        List<Product> products = new List<Product>
        {
            new Product("Tuba", 999.99m, 1),
            new Product("The Road not Taken", 19.99m, 2),
            new Product("French Horn", 799.99m, 1),
            new Product("Shall I compare thee ", 39.99m, 2),
            new Product("Trumpet", 299.99m, 1)
        };

        //put your greeting here
        string greeting = @"Welcome to the Poem and Brass Shop";

        Console.WriteLine(greeting);


        string? choice = null;
        //implement your loop here
        while (choice != "1")
        {
            Console.WriteLine(@"Choose the following options:
            1. Display all products
            2. Delete a product
            3. Add a new product
            4. Update product properties
            5. Exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Display all products");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Delete a product");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Add a new product");
            }
            else if (choice == "4")
            {
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
            throw new NotImplementedException();
        }

        void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
        {
            throw new NotImplementedException();
        }

        void DeleteProduct(List<Product> products, List<ProductType> productTypes)
        {
            throw new NotImplementedException();
        }

        void AddProduct(List<Product> products, List<ProductType> productTypes)
        {
            throw new NotImplementedException();
        }

        void UpdateProduct(List<Product> products, List<ProductType> productTypes)
        {
            throw new NotImplementedException();
        }
    }
    // don't move or change this!
    public partial class Program { }
}