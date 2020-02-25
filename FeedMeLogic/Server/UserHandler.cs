using FeedMeNetworking;
using FeedMeNetworking.Serialization;

namespace FeedMeLogic.Server
{
    public class UserHandler
    {
        /// <summary>
        /// Gets UserInformation based on a UserID
        /// </summary>
        /// <param name="userID">UserID to retreive the data of</param>
        /// <returns>UserInfo Object with information about the requested user</returns>
        public static UserInfo GetUserInfo(int userID)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "GetUserInfo");
            Send.SendMessage(ServerConnection.ServerSock, userID.ToString());

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }
        
        /// <summary>
        /// Updates UserInfo based on UserInfo Object
        /// </summary>
        /// <param name="UI">Userinfo Object with new information</param>
        public static void UpdateUserInfo(UserInfo UI)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "UpdateUserInfo");
            Send.SendUserInfo(ServerConnection.ServerSock, UI);
        }
    }
}
