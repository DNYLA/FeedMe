using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using FeedMeServer.Functions.Data;
using FeedMeServer.Models;
using System;
using System.Data;
using System.Net.Sockets;
using System.Threading;

namespace FeedMeServer.Functions.Commands
{
    internal class LoginAuthentication
    {
        public static void LoginHandler(Socket Client, ref Client clientM)
        {
            ServerMain.ServerLogger("Requested to Login", "Client");

            //Receive Login Type (Customer || Vendor)
            int LoginType = Convert.ToInt32(Receive.ReceiveMessage(Client));

            Thread.Sleep(300);

            string username = Receive.ReceiveMessage(Client);

            Send.SendMessage(Client, GetUserSalt(username, LoginType));

            string clientHashedPassword = Receive.ReceiveMessage(Client);

            //If Login is Correct send back sucess message
            if (CheckUserCredentials(username, clientHashedPassword, LoginType) == true)
            {
                clientM.SToken = ServerMain.GenerateSessiontoken();
                ServerMain.sessionTokens.Add(clientM.SToken);
                Send.SendMessage(Client, clientM.SToken);
                if (LoginType == 0)
                {
                    Send.SendUserInfo(Client, GetUserInfo(username, clientM));
                    return;
                }
                Send.SendVendorInfo(Client, GetVendorInfo(username, clientM));
                return;
            }

            //Otherwise Return -1 as userID
            Send.SendUserInfo(Client, InvalidCredentials());
        }

        private static String GetUserSalt(string username, int LoginType)
        {
            string Query = ($"SELECT SALT FROM users WHERE Username = '{username}'");
            if (LoginType == 1)
            {
                Query = ($"SELECT SALT FROM vendors WHERE Name = '{username}'");
            }

            DataTable DataResult = DAL.ExecCommand(Query);

            try
            {
                Console.WriteLine("Continuing");
                return DataResult.Rows[0][0].ToString();
            }
            catch
            {
                Console.WriteLine("Invalid");
                return "-1";
            }
        }

        private static UserInfo GetUserInfo(string username, Client clientM)
        {
            UserInfo UserInformation = new UserInfo();
            Console.WriteLine("Valid Username");
            DataTable userInfoDT = DAL.ExecCommand($"SELECT * FROM users WHERE username = '{username}'");

            UserInformation.UserID = Convert.ToInt32(userInfoDT.Rows[0][0]);
            UserInformation.Username = userInfoDT.Rows[0][1].ToString();
            UserInformation.FirstName = userInfoDT.Rows[0][2].ToString();
            UserInformation.LastName = userInfoDT.Rows[0][3].ToString();
            UserInformation.Email = userInfoDT.Rows[0][4].ToString();
            UserInformation.avatarName = userInfoDT.Rows[0][10].ToString();

            string TempAdminValue = userInfoDT.Rows[0][7].ToString();

            if (TempAdminValue == "0")
            {
                UserInformation.Admin = false;
            }
            else
            {
                UserInformation.Admin = true;
            }

            clientM.ClientID = UserInformation.UserID;
            clientM.IsVendor = false;


            return UserInformation;
        }

        private static VendorInfo GetVendorInfo(string username, Client clientM)
        {
            VendorInfo BussinessInfo = new VendorInfo();
            Console.WriteLine("Valid Username");
            DataTable vendorInfoDT = DAL.ExecCommand($"SELECT * FROM vendors WHERE Name = '{username}'");

            BussinessInfo.VendorID = Convert.ToInt32(vendorInfoDT.Rows[0][0]);
            BussinessInfo.Name = vendorInfoDT.Rows[0][1].ToString();
            BussinessInfo.Description = vendorInfoDT.Rows[0][2].ToString();
            BussinessInfo.Address = vendorInfoDT.Rows[0][3].ToString();
            BussinessInfo.Email = vendorInfoDT.Rows[0][4].ToString();
            BussinessInfo.Postcode = vendorInfoDT.Rows[0][5].ToString();
            BussinessInfo.PhoneNo = vendorInfoDT.Rows[0][6].ToString();
            BussinessInfo.Rating = Convert.ToInt32(vendorInfoDT.Rows[0][7].ToString());
            BussinessInfo.Password = vendorInfoDT.Rows[0][8].ToString();
            BussinessInfo.Salt = vendorInfoDT.Rows[0][9].ToString();
            BussinessInfo.avatarName = vendorInfoDT.Rows[0][10].ToString();

            clientM.ClientID = BussinessInfo.VendorID;
            clientM.IsVendor = true;

            return BussinessInfo;
        }

        private static UserInfo InvalidCredentials()
        {
            UserInfo UserInformation = new UserInfo();

            UserInformation.UserID = -1;

            return UserInformation;
        }


        private static bool CheckUserCredentials(string username, string password, int LoginType)
        {
            string[] HashData = GetHashData(username, LoginType); //This Gets The Hash Stored in the Database

            string[] serverHashData = HashPass.HashPassword(password);

            if (HashData[0] == "-1")
            {
                return false;
            }

            string CurrentHash = HashPass.ConfirmHash(password, HashData[1]);

            if (serverHashData[0] != HashData[0])
            {
                return false;
            }

            return CheckDetails(username, serverHashData[0], LoginType);
        }

        private static bool CheckDetails(string username, string password, int LoginType)
        {
            DataTable LoginDataTable = new DataTable();
            string SQLQuery = ($"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'");
            if (LoginType == 1)
            {
                SQLQuery = ($"SELECT * FROM vendors WHERE Name = '{username}' AND password = '{password}'");
            }
            LoginDataTable = DAL.ExecCommand(SQLQuery);

            if (LoginDataTable.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        private static string[] GetHashData(string username, int LoginType)
        {
            string SQLQuery = ($"SELECT password, salt FROM users WHERE username = '{username}'");
            if (LoginType == 1)
            {
                SQLQuery = ($"SELECT password, salt FROM vendors WHERE Name = '{username}'");
            }

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