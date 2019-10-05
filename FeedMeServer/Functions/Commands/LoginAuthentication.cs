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
            //Receive Client Information
            string username = ServerMain.ReceiveData(Client);
            string password = ServerMain.ReceiveData(Client);

            ServerMain.ServerLogger("Requested to Login");

            //Decrypt Password

            //If Login is Correct send back sucess message
            if (CheckUserCredentials(username, password) == true)
            {
                byte[] data = GetUserInfo(username);
                Client.Send(data, 0, data.Length, SocketFlags.None);
                return;
            }

            //Otherwise Return -1 as userID
            byte[] invalidData = InvalidCredentials();
            Client.Send(invalidData, 0, invalidData.Length, SocketFlags.None);
        }

        private static byte[] GetUserInfo(string username)
        {
            UserInfo UserInformation = new UserInfo();
            DataTable userInfoDT = DAL.ExecCommand($"SELECT * FROM users WHERE username = '{username}'");

            UserInformation.UserID = Convert.ToInt32(userInfoDT.Rows[0][0]);
            UserInformation.Username = userInfoDT.Rows[0][1].ToString();
            UserInformation.FirstName = userInfoDT.Rows[0][2].ToString();
            UserInformation.LastName = userInfoDT.Rows[0][3].ToString();
            UserInformation.Email = userInfoDT.Rows[0][4].ToString();

            int TempAdminValue = Convert.ToInt32(userInfoDT.Rows[0][7].ToString());
            if (TempAdminValue == 0)
            {
                UserInformation.Admin = false;
            }
            else
            {
                UserInformation.Admin = true;
            }

            byte[] tempByte = ProtoBufSerialization.ObjectSerialization(UserInformation);

            return tempByte;

        }

        private static byte[] InvalidCredentials()
        {
            UserInfo UserInformation = new UserInfo();

            UserInformation.UserID = -1;

            byte[] tempByte = ProtoBufSerialization.ObjectSerialization(UserInformation);

            return tempByte;
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


            return CheckDetails(username, password);

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
