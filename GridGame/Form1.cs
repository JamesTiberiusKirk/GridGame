﻿using System;
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
        public GridGame()
        {
            InitializeComponent();

            Button[,] btnGrid = new Button[4,4];

            foreach (Button tmpBtn in btnGrid)
            {
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
