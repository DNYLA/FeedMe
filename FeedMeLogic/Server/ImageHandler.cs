using FeedMeNetworking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeLogic.Server
{
    public class ImageHandler
    {
        public static string GetImage(ImageTypes ImageType)
        {
            string imgDir = "https://p.sbond.co/dansite/img/";
            switch (ImageType)
            {
                case ImageTypes.Avatar:
                    imgDir += "Avatars";
                    break;
                case ImageTypes.Category:
                    imgDir += "Categories";
                    break;
                case ImageTypes.Item:
                    imgDir += "Items";
                    break;
            }
            return "N";
        }

        //public static string GetAvatar(int UID, bool isVendor)
        //{
        //}

    }

    public enum ImageTypes
    {
        Avatar, Item, Category
    }
}
