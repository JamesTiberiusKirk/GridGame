using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GridGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void readFile()
        {
            string filename = GridGame.scoreFile;
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if ( Environment.OSVersion.Version.Major >= 6 ) 
                path = Directory.GetParent(path).ToString();
            
            string completePath = path + "\\Documents\\" + filename;
            FileStream fs = new FileStream(completePath, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string line = String.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    scoreBox.Items.Add(line);
                }
            }
            fs.Close();
        }
    }
}
