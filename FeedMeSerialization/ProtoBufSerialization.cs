using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using ProtoBuf.Data;

namespace FeedMeSerialization
{
    public class ProtoBufSerialization
    {
        #region Object Serializing 

        #region Serializing
        public static byte[] ObjectSerialization(object obj)
        {
            if (obj == null)
            {
                return null; //If Object empty return nothing
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Serializer.Serialize(ms, obj);
                    return ms.ToArray();
                }
            }
            catch
            {
                throw; //Add Error Handling later
            }
        }
        #endregion

        #region De-Serializing

        public static object ObjectDeserializing(byte[] data)
        {
            if (data == null)
            {
                return null; //If Data Empty return nothing
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Serializer.Deserialize(typeof(UserInfo), ms);
                }
            }
            catch
            {
                throw; //Add Error Handling Later on
            }
        }

        #endregion

        #endregion

        #region Data Serialization

        #region Serializing
        public static byte[] DataSerialization(DataTable dt)
        {
            if (dt == null)
            {
                return null; //If Data Table is null return Null
            }

            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    using (IDataReader dr = dt.CreateDataReader())
                    {
                        DataSerializer.Serialize(ms, dr); //Stream & Dataset 
                    }
                    return ms.ToArray(); //Converts it to ByteArray
                }
            }
            catch
            {
                throw; //Add Error Handling Later on
            }
        }

        #endregion

        #region De-Serializing
        public static DataTable DataDeserializing(byte[] data)
        {
            if (data == null)
            {
                return null; //If Data is empty return nothing
            }

            using (MemoryStream ms = new MemoryStream(data))
            {
                using (IDataReader dr = DataSerializer.Deserialize(ms))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                    catch
                    {
                        throw; //Add Error Handling Later
                    }

                }
            }
        }

        #endregion

        #endregion
    }

    #region User Object

    //Password & Salt Values will only ever Be Received by the server when registering every other time it will be Blank
    [ProtoContract]
    public class UserInfo
    {
        [ProtoMember(1)]
        public int UserID { get; set; }
        [ProtoMember(2)]
        public string Username { get; set; }
        [ProtoMember(3)]
        public string FirstName { get; set; }
        [ProtoMember(4)]
        public string LastName { get; set; }
        [ProtoMember(5)]
        public string Email { get; set; }
        [ProtoMember(6)]
        public string Password { get; set; }
        [ProtoMember(7)]
        public string Salt { get; set; }
        [ProtoMember(8)]
        public bool Admin { get; set; }
    }


    #endregion

}
