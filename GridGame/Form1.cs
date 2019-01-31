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
        int lives = 3;
        int score = 0;
        
        public GridGame()
        {
            InitializeComponent();
        }
        
        void LoadGrid()
        {
            Color[] colors = new Color[4];
            Random rnd = new Random();

            colors[0] = Color.Goldenrod;
            colors[1] = Color.MediumOrchid;
            colors[2] = Color.CornflowerBlue;
            colors[3] = Color.Coral;

            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(50 * x, 50 * y, 50, 50);
                    btn[x, y].BackColor = colors[rnd.Next(0, 4)];
                    //btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                }
            }
        }

        void RandButton()
        {
            int x = 0;
            int y = 0;
            Random randX = new Random();
            Random randY = new Random();

            x = randX.Next(1, btn.GetLength(0));
            y = randY.Next(1, btn.GetLength(1));

            btn[x, y].BackColor = Color.Black;

            btn[x, y].Click += new EventHandler(this.RandButton_Click);
        }

        void BtnEvent_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            lives--;
            LblLivesCounter.Text = lives.ToString();

            if (lives == 0)
            {
                MessageBox.Show("GAME OVER");
                Close();
            }
        }

        void RandButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightGreen;
            score++;
            lives++;
            LblScoreCounter.Text = score.ToString();
            LblLivesCounter.Text = lives.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridGame_Load(object sender, EventArgs e)
        {
            LoadGrid();
            RandButton();
        }

    }
}
