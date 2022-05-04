
namespace ToDoList.Models
{
  public class Item
  {
    public int Id { get; set; }
    public string Description { get; set; }

    public Item(int id, string description)
    {
      Description = description;
      Id = id;
    }

    public override string ToString()
    {
      
      return $"{Id}. {Description}";
    }
  }
}


