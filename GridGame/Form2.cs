using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridGame
{
    public partial class textBoxForm : Form
    {
        //public string userName;
        public textBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridGame.userName = inpBox.Text;
            this.Close();
        }
        private void FormClose(object sender, FormClosedEventArgs e)
        {
            GridGame.WriteScoreToFile();
        }
    }
}
