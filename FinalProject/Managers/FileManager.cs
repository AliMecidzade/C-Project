using FinalProject.Roles;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalProject.Managers
{
    class FileManager
    {




        private Bitmap _myImage;
        private Random _numberGenerator;

        public FileManager()
        {
            _numberGenerator = new Random();

        }
        
        public void ShowMyImage(string fileToDisplay, int xSize, int ySize, PictureBox pictureBox)
        {
            // Sets up an image object to be displayed.
            if (_myImage != null)
            {
                _myImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _myImage = new Bitmap(fileToDisplay);
            pictureBox.ClientSize = new Size(xSize, ySize);
            pictureBox.Image = _myImage;
        }
        public string GetPath(string Folder, string fileName)
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            return $"{path}/{Folder}/{fileName}";
        }

        public void WriteLog(string user, LogStatus logStatus, string path)
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
        public string CopyFile(string folder, string sourceFile)
        {
           
            string img_path = GetPath(folder, GetNewFileName(sourceFile));
            File.Copy(sourceFile, img_path);
            return img_path;
        }
        private string GetNewFileName(string sourceFile)
        {
            return $"pic_{_numberGenerator.Next()}{sourceFile.Substring(sourceFile.LastIndexOf("."))}";
        }
    }
}


