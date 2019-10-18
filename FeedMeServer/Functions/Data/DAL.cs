using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Data
{
    class DAL
    {
        //Declaring This Variable Now so i remember to Add Error Handling Later on (This will probably be Done On The Server)
        public static int ErrorCode;

        /* When Using This im not sure how variables will get passed through so you will have to reference them using this.
        // One Problem with this Function is that it executes Non-Paraterized queries which could be a problem with SQL Injections. This should be updated
        // to allow paraterized queries. */



        public static DataTable ExecCommand(string command)
        {
            string myConString = "server=213.48.11.122; port=3307; uid=FeedMe_User; pwd=2En6vo; database=feedme; persistsecurityinfo=True;";

            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter;
            DataTable myTable = new DataTable();

            ErrorCode = -1; //Normal State // No Error

            try
            {
                conn.ConnectionString = myConString;
                conn.Open();

                adapter = new MySqlDataAdapter(command, conn);
                adapter.Fill(myTable);
            }
            catch (MySqlException ex)
            {
                //Debugging Tools
                Console.WriteLine(ex.Number);
                Console.WriteLine(ex.Message);
                //Add Error Handling In Below
                ErrorCode = ex.Number;

                /* Errors Are handled Directly by the Method acessing this method (This makes it easier to network the error Message)
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Undiagnosed Error Occured");
                        break;
                    case 1062:
                        Console.WriteLine("Duplicate user!");
                        break;
                }
                */
            }
            finally
            {
                conn.Close();
            }

            return myTable;
        }
    }
}
