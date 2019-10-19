using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
  public class NonExistException : Exception
  {
    public NonExistException(string message)
        : base(message)
    { }
  }

  public abstract class Entity
  {
    public static NonExistException NonExistException_ = new NonExistException("This property does not exists!");
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public DateTime? DeletedDate { get; set; }

    abstract public object GetProperty(string a);  
  }
}
