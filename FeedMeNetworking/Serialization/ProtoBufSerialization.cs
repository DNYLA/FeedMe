using FeedMeNetworking.Models;
using ProtoBuf;
using ProtoBuf.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeNetworking.Serialization
{
    public class ProtoBufSerialization
    {
        public enum ObjectType
        {
            VendorObject, UserObject, OrderObject
        }
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

        public static object ObjectDeserializing(byte[] data, ObjectType oType)
        {
            if (data == null)
            {
                return null; //If Data Empty return nothing
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    switch (oType)
                    {
                        default:
                            return string.Empty;
                        case ObjectType.UserObject:
                            return Serializer.Deserialize(typeof(UserInfo), ms);
                        case ObjectType.VendorObject:
                            return Serializer.Deserialize(typeof(VendorInfo), ms);
                        case ObjectType.OrderObject:
                            return Serializer.Deserialize(typeof(OrderInfo), ms);
                    }
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
    //If More Objects are created move this to its own class.
    //Password & Salt Values will only ever Be Received by the server when registering every other time it will be Blank.
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

    #region Vendor Object
    [ProtoContract]
    public class VendorInfo
    {
        [ProtoMember(1)]
        public int VendorID { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public string Description { get; set; }
        [ProtoMember(4)]
        public string Address { get; set; }
        [ProtoMember(5)]
        public string Email { get; set; }
        [ProtoMember(6)]
        public string Postcode { get; set; }
        [ProtoMember(7)]
        public string PhoneNo { get; set; }
        [ProtoMember(8)]
        public int Rating { get; set; }
        [ProtoMember(9)]
        public string Password { get; set; }
        [ProtoMember(10)]
        public string Salt { get; set; }
    }


    #endregion

    #region OrderInfo
    [ProtoContract]
    public class OrderInfo
    {
        [ProtoMember(1)]
        public CardModel Card { get; set; }
        [ProtoMember(2)]
        public List<ItemModel> Items { get; set; }
        [ProtoMember(3)]
        public Decimal TotalPrice { get; set; }
        [ProtoMember(4)]
        public int VendorID { get; set; }
    }
    #endregion
}
