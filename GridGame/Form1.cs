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
    public partial class GridGame : Form
    {
        Button[,] btn = new Button[5, 5];
        
        public GridGame()
        {
            InitializeComponent();
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(55 * x, 55 * y, 45, 45);
                    btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                }
            }
        }
        
        void BtnEvent_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
