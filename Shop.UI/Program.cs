/*
  1.Регистрация и вход (СМС код / email код)
  2.История покупок
  3.Категории и товары (Картинка в файловой системе)
  4.Покупка (корзина), оплата и доставка (PayPal/Qiwi/etc)
  5.Комментарии и рейтинги
  6.Поиск (пагинация)

  Подключенный, Автономный, EF
 */

using Shop.DataAccess;
using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Shop.UI
{
  class Program
  {
    static void Main(string[] args)
    {
     // var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);


      EntityRepository a = new EntityRepository();
      Category b = new Category();
      Item c = new Item();
      
      b.Name = "lol";
      a.Add(b);
      a.Add(c);
      Console.ReadLine();

    }
  }
}
