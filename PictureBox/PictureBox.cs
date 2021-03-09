using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace PictureBox
{
    public partial class PictureBox : Form
    {

        public static string filekeepPath =
           Path.Combine
              (Environment.CurrentDirectory, "filekeepPath.txt");
      

        public PictureBox()
        {

            InitializeComponent();

            if (File.Exists(filekeepPath))

            {
                var serializer = new XmlSerializer(typeof(string));
                using (var streamReader = new StreamReader(filekeepPath))

                {
                    var filePath = (string)serializer.Deserialize(streamReader);
                    ShowMyImage(filePath);
                    streamReader.Close();
            
                }

            }
            else
          
                OpenFileEmpty();
  
        }


        private void btChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
      
        public void ShowMyImage(string fileToDisplay)
        {
           
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(fileToDisplay);
            pictureBox1.BackgroundImage = pictureBox1.Image;
            pictureBox1.Refresh();

        }


        public void OpenFile()
        {

           
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = " jpg files (*.jpg)|*.jpg|bnp files (*.bnp)|*.bnp|cng files (*.cng)|*.cng";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                var filePath = openFile.FileName;
                ShowMyImage(filePath);

                var serializer = new XmlSerializer(typeof(string));
                using (var streamWriter = new StreamWriter(filekeepPath))

                {
                    serializer.Serialize(streamWriter, filePath);
                    streamWriter.Close();
                }
            }
            
        }

        public void OpenFileEmpty()
        {
          
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = " jpg files (*.jpg)|*.jpg|bnp files (*.bnp)|*.bnp|cng files (*.cng)|*.cng";
            openFile.RestoreDirectory = true;
        
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
               var filePath = openFile.FileName;
                ShowMyImage(filePath);
                
                var serializer = new XmlSerializer(typeof(string));
                using (var streamWriter = new StreamWriter(filekeepPath))

                {
                    serializer.Serialize(streamWriter, filePath);
                    streamWriter.Close();
                   
                }
            }
        }

        private void btClearImage_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Hide();
           
        }
    }
}
    



