using FeedMeNetworking;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
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

        public void UploadImage()
        {

            string url = "https://p.sbond.co/dansite/upload.php";
            string pagesource = string.Empty;
            using (WebClient client = new WebClient())
            {
                try
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                        { "destfile", "destfile" },  //order: {"parameter name", "parameter value"}
                    };

                    // client.UploadValues returns page's source as byte array (byte[])
                    // so it must be transformed into a string
                    client.UploadValues(url, postData);

                    Console.WriteLine(pagesource);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable To Connect to Server...");
                }
            }
        }

        private void UploadImage2(object sender, EventArgs e)
        {
            System.Net.WebClient Client = new System.Net.WebClient();

            Client.Headers.Add("Content-Type", "binary/octet-stream");

            Client.UploadString("https://p.sbond.co/dansite/test.php", "POST",
                                              @"Test");

            byte[] result = Client.UploadFile("https://p.sbond.co/dansite/test.php", "POST",
                                              @"maxresdefault.jpg");

            string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
            Console.WriteLine(s);
        }

        private void UploadImage3(object sender, EventArgs e)
        {
            try
            {
                //create WebClient object
                WebClient client = new WebClient();
                string myFile = @"maxresdefault.jpg";
                client.Credentials = CredentialCache.DefaultCredentials;
                client.UploadFile(@"https://p.sbond.co/dansite/images/", "PUT", myFile);
                client.Dispose();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

    }

    public enum ImageTypes
    {
        Avatar, Item, Category
    }
}
