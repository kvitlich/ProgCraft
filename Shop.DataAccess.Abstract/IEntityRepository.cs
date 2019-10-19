using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DataAccess.Abstract
{
  public interface IEntityRepository
  {
    void Add(Entity entity);
    ICollection<Entity> GetAll(Entity type);
    void Uppdate(Entity entity);
    void Delete(Entity entity);
  }
}
