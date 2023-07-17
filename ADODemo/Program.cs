using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    public class Program
    {
        public static void Main()
        {
            string ConString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();

            System.Console.ReadKey();

            string querystring2 = "delete from Student where rollno=2";
            SqlCommand cmd2 = new SqlCommand(querystring2, con);
            int val = cmd2.ExecuteNonQuery();
            Console.WriteLine("Number of record effected = "+val);
            System.Console.ReadKey();
            con.Close();
        }
    }
}
