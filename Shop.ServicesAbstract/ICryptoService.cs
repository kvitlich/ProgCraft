using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ServicesAbstract
{
  public interface ICryptoService
  {
    string EncryptPassword(string password);
    bool VerifyPassword(string password, string passwordCondidate);
  }
}
