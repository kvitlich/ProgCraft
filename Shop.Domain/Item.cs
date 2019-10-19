using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
  public class Item : Entity
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public string Discription { get; set; }
    public Guid CategoryId { get; set; }

    public override object GetProperty(string a)
    {
      switch (a)
      {
        case nameof(Name):
          return Name;
        case nameof(Price):
          return Price;
        case nameof(Discription):
          return Discription;
        case nameof(CategoryId):
          return CategoryId;
      }
      return NonExistException_;
    }
  }
}
