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

        private Random rnd = new Random();
        private Button[,] btn;
        private int lives = 3;
        private int score = 0;

        //difficulty int and game state
        //  0 = easy
        //  1 = medium
        //  2 = hard
        //  3 = game not running (in the timer)
        //  4 = before the grid was initialised (no grid)
        private int diff = 4;
        

        public GridGame()
        {
            InitializeComponent();
        }
       
        void LoadGrid(object sender, EventArgs e)
        {
            //TODO: if for is the game is already running
            if (diff!=4){
                if (MessageBox.Show("A Game is alreaady Running. Restart?", "Confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cleanGrid();
                }
                else
                {
                    return;
                }
            }
            //diff = 3; //when game isnt running before the timer

            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            switch (b.Text) {
                case "Easy":
                    loadEasy();
                    break;
                case "Medium":
                    loadMedium(); 
                    //Images
                    break;
                case "Hard":
                    loadHard();
                    //Numbers
                    break;
                default:
                    //should not run
                    Console.WriteLine("somehow nothing was passed");
                    break;
            }
            
            
        }

        void cleanGrid(){
            //MessageBox.Show("Cleaning Grid");
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x,y].Location = new Point(-100,-100);
                }
            }
        }

        void loadEasy(){
            diff = 0;
            //Colours
            Color[] colours = new Color[4];
            colours[0] = Color.Goldenrod;
            colours[1] = Color.MediumOrchid;
            colours[2] = Color.CornflowerBlue;
            colours[3] = Color.Coral;
            btn = new Button[4,4];
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(50+100 * x, 50+100 * y, 100, 100);
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x, y].BackColor = colours[rnd.Next(0, 4)];
                }
            }
        }

        void loadMedium(){
            diff = 1;

            btn = new Button[6, 6];
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(50+75 * x, 50+75 * y, 75, 75);
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                    btn[x, y].FlatStyle = FlatStyle.Flat;

                    btn[x, y].Text = rnd.Next(10, 99).ToString();
                }
            }
        }

        void loadHard(){
            diff = 2;
            btn = new Button[9, 9];
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(50+50 * x, 50+50 * y, 50, 50);
                    btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                    Controls.Add(btn[x, y]);
                    btn[x, y].FlatStyle = FlatStyle.Flat;

                    btn[x, y].Text = rnd.Next(100, 999).ToString();
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


        //Any button click (Fron the grid)
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

        //The event handler for the correct button click
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

            /*switch (diff)
            {
                case 0: //easy
                    break;
                case 1: //medium
                    break;
                case 2: //hard
                    break;
                case 3: //waiting period
                    break;
            }*/



    }
}
