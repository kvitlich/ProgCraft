using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Shop.DataAccess
{
  public class CategoryRepository : ICategoryRepository
  {
    private static string ConnectionString = ConfigurationManager.ConnectionStrings["Connection_String_01"].ConnectionString;

    private SqlConnection con = new SqlConnection(ConnectionString);
    private void ExecuteCommandsSqlTransactions(params SqlCommand[] commands)
    {
      using (SqlTransaction transaction = con.BeginTransaction())
      {
        try
        {
          foreach (var command in commands)
          {
            command.Transaction = transaction;
            command.ExecuteNonQuery();
          }
          transaction.Commit();
        }
        catch
        {
          transaction.Rollback();
        }
      }
    }
    private int ExecuteQuery(string query/*, SqlParameter[]  parametrs*/)
    {
      int CountUsed = 0;
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        using (SqlCommand com = con.CreateCommand())
        {
          //com.Parameters.AddRange(parametrs);
          com.CommandText = query;
          CountUsed = com.ExecuteNonQuery();
        
        }
        con.Close();
      }
      return CountUsed;
    }
    public void Add(Category category)
    {
      this.ExecuteQuery($@" INSERT INTO Categories VALUES ({category.CreationDate}, {category.DeletedDate}, {category.Name})");
    }
    public ICollection<Category> GetAll()
    {
      List<Category> result = new List<Category>();
      {
        con.Open();
        string query = "Select * FROM Categories";
        using (SqlCommand com = con.CreateCommand())
        {
          com.CommandText = query;
          using (SqlDataReader read = com.ExecuteReader())
          {
            while (read.Read())
            {
              Category temp_reading = new Category
              {
                Id = Guid.Parse(read.GetString(0).ToString()),
                CreationDate = DateTime.Parse(read.GetString(1).ToString()),
                DeletedDate = DateTime.Parse(read.GetString(2).ToString()),
                Name = read.GetString(3).ToString()
              };
              result.Add(temp_reading);
            }
          }
        }
        con.Close();
      }
      return result;
    }

    public void Uppdate(Category category)
    {
      throw new NotImplementedException();
    }

    void ICategoryRepository.Delete(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}