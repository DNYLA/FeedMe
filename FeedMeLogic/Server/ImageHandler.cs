using FeedMeNetworking;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeLogic.Server
{
    public class ImageHandler
    {
        private string domain = "https://feedme.sbond.co/";
        public static string GetImage(ImageTypes ImageType, string name)
        {
            string url = "https://feedme.sbond.co/" + "img"; //Cant Use Private string Domain Since function is Static
            
            switch (ImageType)
            {
                case ImageTypes.Avatar:
                    url += "Avatars/";
                    break;
                case ImageTypes.Category:
                    url += "Categories/";
                    break;
                case ImageTypes.Item:
                    url += "Items/";
                    break;
            }

            return url + name;
        }

        //public static string GetAvatar(int UID, bool isVendor)
        //{
        //}

        public static string GetImageName(string uri)
        {
            return Path.GetFileName(new Uri(uri).AbsolutePath);
        }

        /// <summary>
        /// Reduces the need for adding an open file dialog to every form where its needed. Instead i can call this function and it will open a file dialog.
        /// </summary>
        /// <param name="type">Upload Location</param>
        public void CreateFileDialog(ImageTypes type)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                UploadImage(type, ofd.FileName);
            }
        }


        /// <summary>
        /// Uploads image to correct directory. This function can not be accessed outside of this class which prevents any problems.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageLocation"></param>
        private void UploadImage(ImageTypes type, string imageLocation)
        {
            System.Net.WebClient Client = new System.Net.WebClient();



            Client.Headers.Add("Content-Type", "binary/octet-stream");

            string phpfile = "";

            switch (type)
            {
                case ImageTypes.Avatar:
                    phpfile = "upload_avatar.php";
                    break;
                case ImageTypes.Category:
                    phpfile = "upload_Categories.php";
                    break;
                case ImageTypes.Item:
                    phpfile = "upload_items";
                    break;
            }

            string url = domain + phpfile;

            Client.UploadFile(url, "POST", @imageLocation);
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
