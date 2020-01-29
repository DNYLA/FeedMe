using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands
{
    class CustomerHandler
    {
        internal static void GetCustomerInfo(Socket clientSocket)
        {
            string userID = Receive.ReceiveMessage(clientSocket);
            string query = $"SELECT userID, username, firstname, lastname, Postcode, Address, email, admin FROM users WHERE userID = {userID};";
            DataTable res = DAL.ExecCommand(query);

            UserInfo UI = new UserInfo();

            if (res.Rows.Count == 0)
            {
                Send.SendUserInfo(clientSocket, UI); //Row Count should never be 0 but added check just to precvent errors
            }

            UI.UserID = Convert.ToInt32(res.Rows[0][0]);
            UI.Username = res.Rows[0][1].ToString();
            UI.FirstName = res.Rows[0][2].ToString();
            UI.LastName = res.Rows[0][3].ToString();
            UI.Email = res.Rows[0][4].ToString();
            UI.Postcode = res.Rows[0][5].ToString();
            UI.Address = res.Rows[0][6].ToString();

            if (res.Rows[0][7].ToString() == "0")
            {
                UI.Admin = false;
            }
            else
            {
                UI.Admin = true;
            }

            Send.SendUserInfo(clientSocket, UI);
        }

        internal static void UpdateUserInfo(Socket clientSocket)
        {
            UserInfo UI = Receive.ReceiveUserInfo(clientSocket);
            string query = $@"UPDATE users
                              SET firstname = '{UI.FirstName}', lastname = '{UI.LastName}', Postcode = '{UI.Postcode}', Address = '{UI.Address}', email = '{UI.Email}'
                              WHERE userID = {UI.UserID};";
            DAL.ExecCommand(query);
        }
    }
}
