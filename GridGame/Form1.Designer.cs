﻿namespace GridGame
{
    partial class GridGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblLivesTitle = new System.Windows.Forms.Label();
            this.LblLivesCounter = new System.Windows.Forms.Label();
            this.LblScoreTitle = new System.Windows.Forms.Label();
            this.LblScoreCounter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(22, 737);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(161, 72);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblLivesTitle
            // 
            this.LblLivesTitle.AutoSize = true;
            this.LblLivesTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivesTitle.Location = new System.Drawing.Point(953, 49);
            this.LblLivesTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblLivesTitle.Name = "LblLivesTitle";
            this.LblLivesTitle.Size = new System.Drawing.Size(123, 34);
            this.LblLivesTitle.TabIndex = 1;
            this.LblLivesTitle.Text = "LIVES:";
            // 
            // LblLivesCounter
            // 
            this.LblLivesCounter.AutoSize = true;
            this.LblLivesCounter.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivesCounter.Location = new System.Drawing.Point(1093, 49);
            this.LblLivesCounter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblLivesCounter.Name = "LblLivesCounter";
            this.LblLivesCounter.Size = new System.Drawing.Size(36, 34);
            this.LblLivesCounter.TabIndex = 2;
            this.LblLivesCounter.Text = "3";
            // 
            // LblScoreTitle
            // 
            this.LblScoreTitle.AutoSize = true;
            this.LblScoreTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreTitle.Location = new System.Drawing.Point(1164, 49);
            this.LblScoreTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblScoreTitle.Name = "LblScoreTitle";
            this.LblScoreTitle.Size = new System.Drawing.Size(144, 34);
            this.LblScoreTitle.TabIndex = 3;
            this.LblScoreTitle.Text = "SCORE:";
            // 
            // LblScoreCounter
            // 
            this.LblScoreCounter.AutoSize = true;
            this.LblScoreCounter.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreCounter.Location = new System.Drawing.Point(1325, 49);
            this.LblScoreCounter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblScoreCounter.Name = "LblScoreCounter";
            this.LblScoreCounter.Size = new System.Drawing.Size(36, 34);
            this.LblScoreCounter.TabIndex = 4;
            this.LblScoreCounter.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1467, 38);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(79, 34);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.LoadGrid);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.LoadGrid);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GridGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 830);
            this.Controls.Add(this.LblScoreCounter);
            this.Controls.Add(this.LblScoreTitle);
            this.Controls.Add(this.LblLivesCounter);
            this.Controls.Add(this.LblLivesTitle);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GridGame";
            this.Text = "GridGame";
            this.Load += new System.EventHandler(this.GridGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblLivesTitle;
        private System.Windows.Forms.Label LblLivesCounter;
        private System.Windows.Forms.Label LblScoreTitle;
        private System.Windows.Forms.Label LblScoreCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
    }
}

