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

        private Button[,] btn;
        private int lives = 3;
        private int score = 0;
        
        public GridGame()
        {
            InitializeComponent();
        }
       
        void LoadGrid(object sender, EventArgs e)
        {
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(50 * x, 50 * y, 50, 50);
                    //btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                }
            }

            Random rnd = new Random();
            Button b = (Button)sender;
            switch (b.Text) {
                case "Easy":
                    btn = new Button[4, 4];
                    //Colours
                    Color[] colours = new Color[4];

                    colours[0] = Color.Goldenrod;
                    colours[1] = Color.MediumOrchid;
                    colours[2] = Color.CornflowerBlue;
                    colours[3] = Color.Coral;
                    for (int x = 0; x < btn.GetLength(0); x++)
                    {
                        for (int y = 0; y<btn.GetLength(1); y++)
                        {
                            btn[x, y].BackColor = colours[rnd.Next(0, 4)];
                        }
                    }
                    break;
                case "Medium":
                    btn = new Button[6, 6];
                    //Images
                    break;
                case "Expert":
                    btn = new Button[10, 10];
                    //Numbers
                    break;
                default:
                    //should not run
                    Console.WriteLine("somehow nothing was passed");
                    break;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
