using FeedMeNetworking;
using FeedMeSerialization;
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
    class LoginAuthentication
    {
        public static void LoginHandler(Socket Client)
        {
            ServerMain.ServerLogger("Requested to Login", "Client");

            //Receive Client Information
            string username = Receive.ReceiveMessage(Client);
            string password = Receive.ReceiveMessage(Client);

            //If Login is Correct send back sucess message
            if (CheckUserCredentials(username, password) == true)
            {
                Send.SendUserInfo(Client, GetUserInfo(username));
                return;
            }

            //Otherwise Return -1 as userID
            Send.SendUserInfo(Client, InvalidCredentials());
        }

        private static UserInfo GetUserInfo(string username)
        {
            UserInfo UserInformation = new UserInfo();
            DataTable userInfoDT = DAL.ExecCommand($"SELECT * FROM users WHERE username = '{username}'");

            UserInformation.UserID = Convert.ToInt32(userInfoDT.Rows[0][0]);
            UserInformation.Username = userInfoDT.Rows[0][1].ToString();
            UserInformation.FirstName = userInfoDT.Rows[0][2].ToString();
            UserInformation.LastName = userInfoDT.Rows[0][3].ToString();
            UserInformation.Email = userInfoDT.Rows[0][4].ToString();

            string TempAdminValue = userInfoDT.Rows[0][7].ToString();

            if (TempAdminValue == "0")
            {
                UserInformation.Admin = false;
            }
            else
            {
                UserInformation.Admin = true;
            }

            return UserInformation;

        }

        private static UserInfo InvalidCredentials()
        {
            UserInfo UserInformation = new UserInfo();

            UserInformation.UserID = -1;

            return UserInformation;
        }

        private static bool CheckUserCredentials(string username, string password)
        {
            string[] HashData = GetHashData(username);

            if (HashData[0] == "-1")
            {
                return false;
            }

            string CurrentHash = HashPass.ConfirmHash(password, HashData[1]);

            if (CurrentHash != HashData[0])
            {
                return false;
            }

            return CheckDetails(username, CurrentHash);

        }

        private static bool CheckDetails(string username, string password)
        {
            DataTable dt = new DataTable();
            string SQLQuery = ($"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'");
            dt = DAL.ExecCommand(SQLQuery);

            if (dt.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        private static string[] GetHashData(string username)
        {
            string SQLQuery = ($"SELECT * FROM users WHERE username = '{username}'");
            using (DataTable SQLResults = DAL.ExecCommand(SQLQuery))
            {
                string[] HashData = new string[2];
                HashData[0] = "-1";
                HashData[1] = "Invalid";
                if (SQLResults.Rows.Count > 0)
                {
                    HashData[0] = SQLResults.Rows[0]["password"].ToString();
                    HashData[1] = SQLResults.Rows[0]["salt"].ToString();
                }
                return HashData;
            }
        }
    }
}
