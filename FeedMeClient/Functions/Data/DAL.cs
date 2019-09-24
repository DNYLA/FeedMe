using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FeedMeClient.Functions.Data
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
            //string myConString = "server=77.102.93.95; port=3306; uid=feedme_user; pwd=mi63b2; database=feedme; persistsecurityinfo=True; SSL Mode=None";
            //string myConString = "server=77.102.93.95; port=3306; uid=feedme_user; pwd=mi63b2; database=feedme; persistsecurityinfo=True; SSL Mode=None";
            //string myConString = "server=77.102.93.95; port=3307; uid=dan; pwd=5OPE54; database=feedme;";
            string myConString = "server=77.102.93.95; port=3307; uid=Bob; pwd=1234; database=feedme;";
            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter;
            DataTable myTable = new DataTable();


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
            }
            finally
            {
                conn.Close();
            }

            return myTable;
        }
    }
}
