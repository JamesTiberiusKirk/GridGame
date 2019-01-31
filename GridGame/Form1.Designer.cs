namespace GridGame
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
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(12, 399);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(88, 39);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblLivesTitle
            // 
            this.LblLivesTitle.AutoSize = true;
            this.LblLivesTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivesTitle.Location = new System.Drawing.Point(517, 9);
            this.LblLivesTitle.Name = "LblLivesTitle";
            this.LblLivesTitle.Size = new System.Drawing.Size(70, 19);
            this.LblLivesTitle.TabIndex = 1;
            this.LblLivesTitle.Text = "LIVES:";
            // 
            // LblLivesCounter
            // 
            this.LblLivesCounter.AutoSize = true;
            this.LblLivesCounter.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivesCounter.Location = new System.Drawing.Point(593, 9);
            this.LblLivesCounter.Name = "LblLivesCounter";
            this.LblLivesCounter.Size = new System.Drawing.Size(21, 19);
            this.LblLivesCounter.TabIndex = 2;
            this.LblLivesCounter.Text = "3";
            // 
            // LblScoreTitle
            // 
            this.LblScoreTitle.AutoSize = true;
            this.LblScoreTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreTitle.Location = new System.Drawing.Point(632, 9);
            this.LblScoreTitle.Name = "LblScoreTitle";
            this.LblScoreTitle.Size = new System.Drawing.Size(82, 19);
            this.LblScoreTitle.TabIndex = 3;
            this.LblScoreTitle.Text = "SCORE:";
            // 
            // LblScoreCounter
            // 
            this.LblScoreCounter.AutoSize = true;
            this.LblScoreCounter.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreCounter.Location = new System.Drawing.Point(720, 9);
            this.LblScoreCounter.Name = "LblScoreCounter";
            this.LblScoreCounter.Size = new System.Drawing.Size(21, 19);
            this.LblScoreCounter.TabIndex = 4;
            this.LblScoreCounter.Text = "0";
            // 
            // GridGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblScoreCounter);
            this.Controls.Add(this.LblScoreTitle);
            this.Controls.Add(this.LblLivesCounter);
            this.Controls.Add(this.LblLivesTitle);
            this.Controls.Add(this.BtnExit);
            this.Name = "GridGame";
            this.Text = "GridGame";
            this.Load += new System.EventHandler(this.GridGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblLivesTitle;
        private System.Windows.Forms.Label LblLivesCounter;
        private System.Windows.Forms.Label LblScoreTitle;
        private System.Windows.Forms.Label LblScoreCounter;
    }
}

