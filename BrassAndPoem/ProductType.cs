//create your ProductType class here

public class ProductType
{
    public string Title { get; set; }
    public int Id { get; set; }
    public string Name { get; internal set; }

    public ProductType(string title, int id)
    {
        Title = title;
        Id = id;
    }
}