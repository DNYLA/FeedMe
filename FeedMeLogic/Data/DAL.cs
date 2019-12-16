using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FeedMeLogic.Data
{
    public class DAL
    {
        //Declaring This Variable Now so i remember to Add Error Handling Later on (This will probably be Done On The Server)
        public static int ErrorCode;

        /* When Using This im not sure how variables will get passed through so you will have to reference them using this.
        // One Problem with this Function is that it executes Non-Paraterized queries which could be a problem with SQL Injections. This should be updated
        // to allow paraterized queries. */


        [Obsolete("Not Used Anymore As Everything is done Server Side Now")]
        public static DataTable ExecCommand(string command)
        {
            //string myConString = "server=77.102.93.95; port=3307; uid=root; pwd=blopdop; database=feedme; persistsecurityinfo=True;";
            string myConString = "server=213.48.11.122; port=3307; uid=FeedMe_User; pwd=2En6vo; database=feedme; persistsecurityinfo=True;";
            // 

            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter;
            DataTable myTable = new DataTable();

            try
            {
                conn.ConnectionString = myConString;
                conn.Open();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command, conn);
                adapter = mySqlDataAdapter;
                adapter.Fill(myTable);
            }
            catch (MySqlException ex)
            {
                //Debugging Tools
                Console.WriteLine(ex.Number);
                Console.WriteLine(ex.Message);
                //Add Error Handling In Below
            }
            finally
            {
                conn.Close();
            }

            return myTable;
        }
    }
}
