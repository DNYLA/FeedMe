using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands
{
    internal class RegisterAuthentication
    {
        public static void RegistrationHandler(Socket Client)
        {
            Console.WriteLine("Client Requested Register"); //Update Interface with new Request
            string regType = Receive.ReceiveMessage(Client); // RegType User || Vendor
            string registerValue;


            if (regType == "User")
            {
                //Starts Customer Registration Process
                UserInfo UserInformation = Receive.ReceiveUserInfo(Client);
                UserInformation = HashPassword(UserInformation);
                object userObj = UserInformation;
                registerValue = RegisterClient(userObj, 1).ToString();
            }
            else if (regType == "Vendor")
            {
                //Starts Vendor Registration Process
                VendorInfo VendorInformation = Receive.ReceiveVendorInfo(Client);
                VendorInformation = HashPassword(VendorInformation);
                object venObj = VendorInformation;
                registerValue = RegisterClient(venObj, 2).ToString();
            }
            else
            {
                return; //Invalid Message Received
            }

            Send.SendMessage(Client, registerValue);
        }

        private static int RegisterClient(object ClientInformation, int clientType)
        {
            //CI = HashPassword(CI);

            string sqlQuery;
            
            //Get Correct Query
            if (clientType == 1)
            {
                UserInfo userInfo = (UserInfo)ClientInformation;
                sqlQuery = ($@"INSERT INTO users (username, firstname, lastname, email, password, salt)
                                  VALUES ('{userInfo.Username}', '{userInfo.FirstName}', '{userInfo.LastName}', '{userInfo.Email}', '{userInfo.Password}', '{userInfo.Salt}');");
            }
            else
            {
                VendorInfo vendorInfo = (VendorInfo)ClientInformation;
                sqlQuery = ($@"INSERT INTO vendors (`Name`, Description, Address, Email, Postcode, PhoneNo, `Password`, `Salt`)
	                            VALUES ('{vendorInfo.Name}', '{vendorInfo.Description}', '{vendorInfo.Address}', '{vendorInfo.Email}', '{vendorInfo.Postcode}', '{vendorInfo.PhoneNo}', '{vendorInfo.Password}', '{vendorInfo.Salt}');");
            }

            Data.DAL.ExecCommand(sqlQuery); //Execute Query

            if (Data.DAL.ErrorCode == 1062)
            {
                return 0; //Duplicate username
            }
            else if (Data.DAL.ErrorCode == -1)
            {
                return 1; //Successfully Registerd
            }
            else
            {
                return 3; //Undiagnosed Error
            }
        }

        /// <summary>
        /// Gets HashData for Customer
        /// </summary>
        /// <param name="UserInformation">UserInfo Object which is local</param>
        /// <returns>UserInfo Object with Hashed Password</returns>
        private static UserInfo HashPassword(UserInfo UserInformation)
        {
            string[] HashData = Data.HashPass.HashPassword(UserInformation.Password);

            UserInformation.Password = HashData[0];

            return UserInformation;
        }

        /// <summary>
        /// Gets HashData for Customer
        /// </summary>
        /// <param name="VendorInformation">VendorInfo Object which is local</param>
        /// <returns>VendorInfo Object with Hashed Password</returns>
        private static VendorInfo HashPassword(VendorInfo VendorInformation)
        {
            string[] HashData = Data.HashPass.HashPassword(VendorInformation.Password);

            VendorInformation.Password = HashData[0];

            return VendorInformation;
        }
    }
}