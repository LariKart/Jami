namespace MatchingGame
{
    partial class Scoreboard
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.clickLabel = new System.Windows.Forms.Label();
            this.attemptLabel = new System.Windows.Forms.Label();
            this.pairLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(78, 126);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(119, 30);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "High Score";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(203, 126);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(119, 30);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Best Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clickLabel
            // 
            this.clickLabel.Location = new System.Drawing.Point(328, 126);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(119, 30);
            this.clickLabel.TabIndex = 2;
            this.clickLabel.Text = "Clicks";
            this.clickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attemptLabel
            // 
            this.attemptLabel.Location = new System.Drawing.Point(453, 126);
            this.attemptLabel.Name = "attemptLabel";
            this.attemptLabel.Size = new System.Drawing.Size(119, 30);
            this.attemptLabel.TabIndex = 3;
            this.attemptLabel.Text = "Attempts";
            this.attemptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pairLabel
            // 
            this.pairLabel.Location = new System.Drawing.Point(578, 126);
            this.pairLabel.Name = "pairLabel";
            this.pairLabel.Size = new System.Drawing.Size(119, 30);
            this.pairLabel.TabIndex = 4;
            this.pairLabel.Text = "Pairs";
            this.pairLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(203, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 116);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(328, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 116);
            this.label3.TabIndex = 7;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(453, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 116);
            this.label4.TabIndex = 8;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(578, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 116);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(656, 393);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(132, 45);
            this.menuButton.TabIndex = 11;
            this.menuButton.Text = "Back to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(78, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 116);
            this.label1.TabIndex = 12;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pairLabel);
            this.Controls.Add(this.attemptLabel);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label clickLabel;
        private System.Windows.Forms.Label attemptLabel;
        private System.Windows.Forms.Label pairLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label1;
    }
}