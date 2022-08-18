using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode003
{
  internal class Customer
  {
    #region Instance Variables
    public string Number { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    #endregion

    public static List<Customer> GetCustomersFor( string subApp, string jobpartno, string partrev )
    {
      List<Customer> answer = new List<Customer>();
      FacilityDB FDB = new FacilityDB(subApp);
      string strSQL =
        string.Format(@"
SELECT DISTINCT 
       somast.[fcustno]  AS Number
      ,somast.[fcompany] AS CompanyName
      ,somast.[fcity]    AS City
  FROM [M2MDATA60].[dbo].[soitem]
  JOIN [M2MDATA60].[dbo].[somast] ON somast.fsono=soitem.fsono
 WHERE [fpartno] = '{0}'
   AND [fpartrev] = '{1}'
 ORDER BY somast.[fcompany],somast.[fcity]
"
          , jobpartno
          , partrev
);
      string connectionString = FDB.ConnectionString;

      using (SqlConnection conn = new SqlConnection(connectionString))
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        //cmd.CommandType = System.Data.CommandType.StoredProcedure;
        try
        {
          SqlDataReader rdr = cmd.ExecuteReader();
          while (rdr.Read())
          {
            Customer model = new Customer
            {
              Number = (string)rdr["Number"],
              Name = (string)rdr["CompanyName"],
              City = (string)rdr["City"]
            };
            answer.Add(model);
          }
        }
        catch
        {
          return new List<Customer>();
        }
      } //using
      return answer;
    }

    public override string ToString()
    {
      return String.Format("{0}-{1}-{2}", Number.Trim(), Name.Trim(), City.Trim());
    }
  }
}
