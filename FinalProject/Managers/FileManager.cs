using FinalProject.Roles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Managers
{
    class FileManager
    {
      



        private Bitmap MyImage;
        public void ShowMyImage(string fileToDisplay, int xSize, int ySize, PictureBox pictureBox)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox.ClientSize = new Size(xSize, ySize);
            pictureBox.Image = MyImage;
        }
            public string GetPath(string Folder, string fileName)
            {
                string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
                return $"{path}/{Folder}/{fileName}";
            }

        public void  WriteLog(string user, LogStatus logStatus , string path)
        {
        
       
            string time = DateTime.Now.ToString();
            string logMessage = $"{user} {logStatus} {time}\n";
           
            if (File.Exists(path))
            {
                File.AppendAllText(path, logMessage);
            }
            else
            {
                File.WriteAllText(path, logMessage);
            }

        }
    }
}
    

