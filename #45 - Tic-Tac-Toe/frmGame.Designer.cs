namespace _45___Tic_Tac_Toe
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbResetGame = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Location = new System.Drawing.Point(580, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(367, 79);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tic-Tac-Toe";
            // 
            // lbResetGame
            // 
            this.lbResetGame.AutoSize = true;
            this.lbResetGame.BackColor = System.Drawing.Color.Black;
            this.lbResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResetGame.ForeColor = System.Drawing.Color.White;
            this.lbResetGame.Location = new System.Drawing.Point(12, 633);
            this.lbResetGame.Name = "lbResetGame";
            this.lbResetGame.Size = new System.Drawing.Size(365, 69);
            this.lbResetGame.TabIndex = 5;
            this.lbResetGame.Text = "Reset Game";
            this.lbResetGame.Click += new System.EventHandler(this.lbResetGame_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox7.Location = new System.Drawing.Point(486, 536);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 66);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "?";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox8.Location = new System.Drawing.Point(779, 536);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(90, 66);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "?";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox9.Location = new System.Drawing.Point(1072, 536);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(90, 66);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "?";
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurn.Location = new System.Drawing.Point(19, 74);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(153, 69);
            this.lbTurn.TabIndex = 1;
            this.lbTurn.Text = "Turn";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.White;
            this.lbPlayer.Location = new System.Drawing.Point(19, 167);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(249, 69);
            this.lbPlayer.TabIndex = 2;
            this.lbPlayer.Text = "Player 1";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lbWinner.Location = new System.Drawing.Point(19, 325);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(220, 69);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Text = "Winner";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.Black;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Lime;
            this.lbResult.Location = new System.Drawing.Point(19, 433);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(251, 54);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "InPrograss";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox1.Location = new System.Drawing.Point(486, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "?";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox2.Location = new System.Drawing.Point(779, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "?";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox3.Location = new System.Drawing.Point(1072, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "?";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox4.Location = new System.Drawing.Point(486, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "?";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox5.Location = new System.Drawing.Point(779, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "?";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::_45___Tic_Tac_Toe.Properties.Resources._2__question_mark_96;
            this.pictureBox6.Location = new System.Drawing.Point(1072, 353);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 66);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "?";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Timer: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(-1, -3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "How to Play the game";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1388, 739);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbResetGame);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbTitle);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "frmGame";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbResetGame;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

