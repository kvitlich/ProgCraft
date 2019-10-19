using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Shop.DataAccess
{
  public class EntityRepository : IEntityRepository, IDisposable
  {
    private static string ConnectionString = ConfigurationManager.ConnectionStrings["Connection_String_01"].ConnectionString;
    private static SqlConnection connection = new SqlConnection(ConnectionString);
    private static SqlCommand command = new SqlCommand("", connection);
    private readonly DbProviderFactory providerFactory;

    public EntityRepository(/*string DbConnectionString, string ProviderName*/)
    {
      //ProviderFactory = DbProviderFactories.TryGetFactory(); //Проинициализировать ConnectionString
      //providerFactory = DbProviderFactories.GetFactory(ProviderName);
      //connection = providerFactory.CreateConnection();
      //connection.ConnectionString = DbConnectionString;
      //
      //connection.Open();
    }

    private static string GetStringProperiesForQuery(Entity entity)
    {
      string result = "";
      Type entityType = entity.GetType();
      var entityMembers = entityType.GetProperties();
      Type[] MembersTypes = new Type[entityMembers.Length];
      int TempLenght = MembersTypes.Length;
      for (int i = 0; i < TempLenght; i++)
      {
        MembersTypes[i] = entityMembers[i].MemberType.GetType();
      }
      for (int i = 0; i < TempLenght; i++)
      {
        if (i != TempLenght - 3)
          result += entityMembers[i].Name;
        if (i != TempLenght - 1 && i != TempLenght - 3)
          result += ", ";
      }
      return result;
    }

    private static void PrepareExecuteQuery(string query)
    {
      connection.Open();
      command.CommandText = query;
    }

    public void Add(Entity entity)
    {

      Console.WriteLine(GetStringProperiesForQuery(entity));

    }

    public void Delete(Entity entity)
    {
      Console.WriteLine(GetStringProperiesForQuery(entity));

    }

    public ICollection<Entity> GetAll(Entity type)
    {
      List<Entity> selectResult = new List<Entity>();

      return selectResult;
    }

    public void Uppdate(Entity entity)
    {
      Console.WriteLine(GetStringProperiesForQuery(entity));

    }

    public void Dispose()
    {
      connection.Close();
    }
  }
}
