using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
  public class Category : Entity
  {
    public string Name { get; set; }

    public override object GetProperty(string a)
    {
      switch(a)
      {
        case nameof(Name):
          return Name;
      }
      return Name;
    }



    // Опциональная коллекция товаров
  }
}
