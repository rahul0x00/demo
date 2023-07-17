using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConString = @"data source=localhost\SQLEXPRESS; Initial Catalog=master;Integrated Security=True";

                SqlConnection connection = new SqlConnection(ConString);
                
                    SqlDataAdapter da = new SqlDataAdapter("select * from student", connection);
                    //Using Data Table
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //The following things are done by the Fill method
                    //1. Open the connection
                    //2. Execute Command
                    //3. Retrieve the Result
                    //4. Fill/Store the Retrieve Result in the Data table
                    //5. Close the connection
                    Console.WriteLine("Using Data Table");
                    //Active and Open connection is not required
                    //dt.Rows: Gets the collection of rows that belong to this table
                    //DataRow: Represents a row of data in a DataTable.
                    foreach (DataRow row in dt.Rows)
                    {
                        //Accessing using string Key Name
                        Console.WriteLine(row["rollno"] + ",  " + row["name"] + ",  " + row["address"]);
                        //Accessing using integer index position
                        //Console.WriteLine(row[0] + ",  " + row[1] + ",  " + row[2]);
                    }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            Console.ReadKey();

        }
    }
}
