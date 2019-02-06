﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
Some Code Sources

https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?redirectedfrom=MSDN&view=netframework-4.7.2
https://stackoverflow.com/questions/6153074/how-do-i-write-data-to-a-text-file-in-c
https://stackoverflow.com/questions/1140383/how-can-i-get-the-current-user-directory
http://www.newthinktank.com/2017/03/c-tutorial-17/
https://stackoverflow.com/questions/24016638/set-form-location-c-sharp
*/


/*
    06/01/19 - KAYLA CHANGES
    -changed all grids to be colours instead of numbers, is more aesthetically pleasing and easier for user 
    -when 'new' button is clicked, new form opens over grid form with blank grid 
        >this will be changed so that it happens for a certain amount of time instead of when the button is clicked (button will be removed)
*/

//TODO: cleanup code
//TODO: cleanup comments
//TODO: Make the timer
//TODO: Make another form to display the scores


namespace GridGame
{
    public partial class GridGame : Form
    {
        public const string scoreFile = "GridGameScore.txt";
        private const int livesC = 3;//when lives reset, 
        //we can just use this constand change this if it needs to be changed in the future

        private textBoxForm userNameForm = new textBoxForm();

        private Random rnd = new Random();
        private Button[,] btn;
        private int lives = livesC;
        private static int score = 0;
        private static string difficulty;
        public static string userName;

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

            this.StartPosition = FormStartPosition.Manual;
            this.Left = 100;
            this.Top = 100;
            
        }
       
        private void LoadGrid(object sender, EventArgs e)
        {

            if (diff!=4){
                if (MessageBox.Show("A Game is alreaady Running. \n Do you want to restart?", "Confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lives = livesC;
                    CleanGrid();
                }
                else
                {
                    return;
                }
            }
            //diff = 3; //when game isnt running before the timer
            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            difficulty = b.Text;
            switch (difficulty) {
                case "Easy":
                    LoadEasy();
                    RandButton();
                    break;
                case "Medium":
                    LoadMedium();
                    RandButton();
                    //Images
                    break;
                case "Hard":
                    LoadHard();
                    RandButton();
                    //Numbers
                    break;
                default:
                    //should not run
                    Console.WriteLine("somehow nothing was passed");
                    break;
            }
            Timer(5);            
        }

        private void Timer(int s){

        }

        private void CleanGrid(){
            //MessageBox.Show("Cleaning Grid");
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y<btn.GetLength(1); y++)
                {
                    //btn[x,y].Location = new Point(-100,-100); // nonononnonononononnonono
                    btn[x,y].Hide();
                }
            }
        }

        private void LoadEasy(){
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

        private void LoadMedium(){
            diff = 1;

            Color[] colours = new Color[5];
            colours[0] = Color.Goldenrod;
            colours[1] = Color.MediumOrchid;
            colours[2] = Color.CornflowerBlue;
            colours[3] = Color.Coral;
            colours[4] = Color.MediumSeaGreen;
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

                    // btn[x, y].Text = rnd.Next(10, 99).ToString();
                    btn[x, y].BackColor = colours[rnd.Next(0, 5)];
                }
            }
        }

        private void LoadHard(){
            diff = 2;

            Color[] colours = new Color[6];
            colours[0] = Color.Goldenrod;
            colours[1] = Color.MediumOrchid;
            colours[2] = Color.CornflowerBlue;
            colours[3] = Color.Coral;
            colours[4] = Color.MediumSeaGreen;
            colours[5] = Color.Firebrick;

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

                    btn[x, y].BackColor = colours[rnd.Next(0, 6)];
                    // btn[x, y].Text = rnd.Next(100, 999).ToString();
                }
            }
        }

        private void RandButton()
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


        //Any button click (From the grid)
        private void BtnEvent_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor==Color.Red){ //if button was already clicked
                return;
            }   
            ((Button)sender).BackColor = Color.Red;
            lives--;
            LblLivesCounter.Text = lives.ToString();

            if (lives == 0)
            {
                MessageBox.Show("GAME OVER");
                AskUserName();
            }
        }

        //The event handler for the correct button click
        private void RandButton_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor==Color.LightGreen){ //if button was already clicked
                return;
            }   
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

        private void AskUserName(){
            userNameForm.Show();
        }

        public static void WriteScoreToFile(){
            string toWrite;
            toWrite = "\n" + userName + " with score " + score.ToString() +
                " on " + difficulty +" difficulty";
            MessageBox.Show(toWrite);
            
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if ( Environment.OSVersion.Version.Major >= 6 ) 
                path = Directory.GetParent(path).ToString();
            
            path += "\\Documents\\" + scoreFile;
            
            FileStream fs;

            if (!File.Exists(path)){
                fs = new FileStream(path, FileMode.Create);
            }else{
                fs = new FileStream(path,FileMode.Append);
            }

            byte[] info = new UTF8Encoding(true).GetBytes(toWrite);
            //byte[] info = Encoding.Default.GetBytes(toWrite);
            fs.Write(info, 0, info.Length);
            /* 
            // writing data in bytes already
            byte[] data = new byte[] { 0x0 };
            fs.Write(data, 0, data.Length);
            */
            fs.Flush();
            fs.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.Width = this.Width;
            newForm.Height = this.Height;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            newForm.ControlBox = false;

            if (diff == 0)
            {
                btn = new Button[4, 4];
                for (int x = 0; x < btn.GetLength(0); x++)
                {
                    for (int y = 0; y < btn.GetLength(1); y++)
                    {
                        btn[x, y] = new Button();
                        btn[x, y].SetBounds(50 + 100 * x, 50 + 100 * y, 100, 100);
                        newForm.Controls.Add(btn[x, y]);
                        btn[x, y].FlatStyle = FlatStyle.Flat;
                        btn[x, y].BackColor = Color.Gray;
                    }
                }
                newForm.ShowDialog();
            }
            else if (diff == 1)
            {
                btn = new Button[6, 6];
                for (int x = 0; x < btn.GetLength(0); x++)
                {
                    for (int y = 0; y < btn.GetLength(1); y++)
                    {
                        btn[x, y] = new Button();
                        btn[x, y].SetBounds(50 + 75 * x, 50 + 75 * y, 75, 75);
                        newForm.Controls.Add(btn[x, y]);
                        btn[x, y].FlatStyle = FlatStyle.Flat;
                        btn[x, y].BackColor = Color.Gray;
                    }
                }
                newForm.ShowDialog();
            }
            else if (diff == 2)
            {
                btn = new Button[9, 9];
                for (int x = 0; x < btn.GetLength(0); x++)
                {
                    for (int y = 0; y < btn.GetLength(1); y++)
                    {
                        btn[x, y] = new Button();
                        btn[x, y].SetBounds(50 + 50 * x, 50 + 50 * y, 50, 50);
                        newForm.Controls.Add(btn[x, y]);
                        btn[x, y].FlatStyle = FlatStyle.Flat;
                        btn[x, y].BackColor = Color.Gray;
                    }
                }
                newForm.ShowDialog();
            }


        }

        //Some code snippiets I was keeping on the sime
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

        /*            if (File.Exists(path))
                    {
                        using (var sw = new StreamWriter(path, true))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(toWrite);
                            fs.Write(info, 0, info.Length);

                            // writing data in bytes already
                            byte[] data = new byte[] { 0x0 };
                            fs.Write(data, 0, data.Length);
                        }
                    }
                    else
                    { 
                        using (FileStream fs = File.Create(path))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(toWrite);
                            fs.Write(info, 0, info.Length);

                            // writing data in bytes already
                            byte[] data = new byte[] { 0x0 };
                            fs.Write(data, 0, data.Length);
                        }
                    }
        */



    }

 
}
