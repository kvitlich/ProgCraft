using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
  public class User : Entity
  {
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string VerificationCode { get; set; }
    public string Address { get; set; }

    public override object GetProperty(string a)
    {
      switch (a)
      {
        case nameof(PhoneNumber):
          return PhoneNumber;
        case nameof(Email):
          return Email;
        case nameof(Password):
          return Password;
        case nameof(VerificationCode):
          return VerificationCode;
        case nameof(Address):
          return Address;
      }
      return NonExistException_;
    }
    
    //Покупки, коментарии, рейтинги и т.д.
  }
}
