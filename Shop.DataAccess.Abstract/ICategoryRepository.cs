using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DataAccess.Abstract
{
  public interface ICategoryRepository
  {
    void Add(Category category);
    void Delete(Guid id);
    void Uppdate(Category category);
    ICollection<Category> GetAll();
  }
}
