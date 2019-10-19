using System;
using System.Collections.Generic;
using System.Text;
using static BCrypt.Net.BCrypt;
using Shop.ServicesAbstract;

namespace Shop.Services
{
  class BCryptHasher : ICryptoService
  {
    public string EncryptPassword(string password)
    {
      return HashPassword(password);
    }

    public bool VerifyPassword(string password, string passwordCondidate)
    {
      return Verify(passwordCondidate, password);
    }
  }
}
