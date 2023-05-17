namespace windowsformsfinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DialogueBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.SchoolTeacher = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ChestSprite = new System.Windows.Forms.PictureBox();
            this.KeySprite = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftLocChange = new System.Windows.Forms.PictureBox();
            this.RightLocChange = new System.Windows.Forms.PictureBox();
            this.DownLocChange = new System.Windows.Forms.PictureBox();
            this.UpLocChange = new System.Windows.Forms.PictureBox();
            this.CrystallBall3 = new System.Windows.Forms.PictureBox();
            this.CrystallBall1 = new System.Windows.Forms.PictureBox();
            this.CrystallBall2 = new System.Windows.Forms.PictureBox();
            this.BeastObstacle = new System.Windows.Forms.PictureBox();
            this.Berries = new System.Windows.Forms.PictureBox();
            this.BackToMenu = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DialogueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeySprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLocChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLocChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLocChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLocChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeastObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Berries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogueBox
            // 
            this.DialogueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.DialogueBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DialogueBox.BackgroundImage")));
            this.DialogueBox.Location = new System.Drawing.Point(90, 561);
            this.DialogueBox.Name = "DialogueBox";
            this.DialogueBox.Size = new System.Drawing.Size(960, 175);
            this.DialogueBox.TabIndex = 0;
            this.DialogueBox.TabStop = false;
            this.DialogueBox.Visible = false;
            this.DialogueBox.Click += new System.EventHandler(this.DialogueBox_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(452, 314);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(88, 110);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            this.Player.Visible = false;
            // 
            // SchoolTeacher
            // 
            this.SchoolTeacher.BackColor = System.Drawing.Color.Transparent;
            this.SchoolTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SchoolTeacher.Image = ((System.Drawing.Image)(resources.GetObject("SchoolTeacher.Image")));
            this.SchoolTeacher.Location = new System.Drawing.Point(562, 245);
            this.SchoolTeacher.Name = "SchoolTeacher";
            this.SchoolTeacher.Size = new System.Drawing.Size(88, 110);
            this.SchoolTeacher.TabIndex = 2;
            this.SchoolTeacher.TabStop = false;
            this.SchoolTeacher.Tag = "NPC";
            this.SchoolTeacher.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Location = new System.Drawing.Point(719, 260);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(307, 69);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Black;
            this.QuitButton.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuitButton.Location = new System.Drawing.Point(719, 363);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(307, 69);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Visible = false;
            this.QuitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChestSprite
            // 
            this.ChestSprite.BackColor = System.Drawing.Color.Transparent;
            this.ChestSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChestSprite.Location = new System.Drawing.Point(239, 99);
            this.ChestSprite.Name = "ChestSprite";
            this.ChestSprite.Size = new System.Drawing.Size(700, 400);
            this.ChestSprite.TabIndex = 5;
            this.ChestSprite.TabStop = false;
            this.ChestSprite.Tag = "player";
            this.ChestSprite.Visible = false;
            this.ChestSprite.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // KeySprite
            // 
            this.KeySprite.BackColor = System.Drawing.Color.Transparent;
            this.KeySprite.Image = ((System.Drawing.Image)(resources.GetObject("KeySprite.Image")));
            this.KeySprite.Location = new System.Drawing.Point(1085, 646);
            this.KeySprite.Name = "KeySprite";
            this.KeySprite.Size = new System.Drawing.Size(90, 90);
            this.KeySprite.TabIndex = 7;
            this.KeySprite.TabStop = false;
            this.KeySprite.Visible = false;
            this.KeySprite.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label1.Font = new System.Drawing.Font("Bryndan Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "dd";
            this.label1.Visible = false;
            // 
            // LeftLocChange
            // 
            this.LeftLocChange.BackColor = System.Drawing.Color.Transparent;
            this.LeftLocChange.Location = new System.Drawing.Point(8, 12);
            this.LeftLocChange.Name = "LeftLocChange";
            this.LeftLocChange.Size = new System.Drawing.Size(10, 724);
            this.LeftLocChange.TabIndex = 9;
            this.LeftLocChange.TabStop = false;
            this.LeftLocChange.Tag = "left";
            // 
            // RightLocChange
            // 
            this.RightLocChange.BackColor = System.Drawing.Color.Transparent;
            this.RightLocChange.Location = new System.Drawing.Point(1174, 12);
            this.RightLocChange.Name = "RightLocChange";
            this.RightLocChange.Size = new System.Drawing.Size(10, 724);
            this.RightLocChange.TabIndex = 10;
            this.RightLocChange.TabStop = false;
            this.RightLocChange.Tag = "right";
            // 
            // DownLocChange
            // 
            this.DownLocChange.BackColor = System.Drawing.Color.Transparent;
            this.DownLocChange.Location = new System.Drawing.Point(34, 752);
            this.DownLocChange.Name = "DownLocChange";
            this.DownLocChange.Size = new System.Drawing.Size(1118, 10);
            this.DownLocChange.TabIndex = 11;
            this.DownLocChange.TabStop = false;
            this.DownLocChange.Tag = "down";
            // 
            // UpLocChange
            // 
            this.UpLocChange.BackColor = System.Drawing.Color.Transparent;
            this.UpLocChange.Location = new System.Drawing.Point(34, 3);
            this.UpLocChange.Name = "UpLocChange";
            this.UpLocChange.Size = new System.Drawing.Size(1118, 10);
            this.UpLocChange.TabIndex = 12;
            this.UpLocChange.TabStop = false;
            this.UpLocChange.Tag = "up";
            // 
            // CrystallBall3
            // 
            this.CrystallBall3.BackColor = System.Drawing.Color.Transparent;
            this.CrystallBall3.Image = ((System.Drawing.Image)(resources.GetObject("CrystallBall3.Image")));
            this.CrystallBall3.Location = new System.Drawing.Point(608, 482);
            this.CrystallBall3.Name = "CrystallBall3";
            this.CrystallBall3.Size = new System.Drawing.Size(42, 68);
            this.CrystallBall3.TabIndex = 13;
            this.CrystallBall3.TabStop = false;
            this.CrystallBall3.Tag = "crystallball";
            this.CrystallBall3.Visible = false;
            // 
            // CrystallBall1
            // 
            this.CrystallBall1.BackColor = System.Drawing.Color.Transparent;
            this.CrystallBall1.Image = ((System.Drawing.Image)(resources.GetObject("CrystallBall1.Image")));
            this.CrystallBall1.Location = new System.Drawing.Point(318, 457);
            this.CrystallBall1.Name = "CrystallBall1";
            this.CrystallBall1.Size = new System.Drawing.Size(62, 61);
            this.CrystallBall1.TabIndex = 14;
            this.CrystallBall1.TabStop = false;
            this.CrystallBall1.Tag = "crystallball";
            this.CrystallBall1.Visible = false;
            // 
            // CrystallBall2
            // 
            this.CrystallBall2.BackColor = System.Drawing.Color.Transparent;
            this.CrystallBall2.Image = ((System.Drawing.Image)(resources.GetObject("CrystallBall2.Image")));
            this.CrystallBall2.Location = new System.Drawing.Point(797, 482);
            this.CrystallBall2.Name = "CrystallBall2";
            this.CrystallBall2.Size = new System.Drawing.Size(74, 73);
            this.CrystallBall2.TabIndex = 15;
            this.CrystallBall2.TabStop = false;
            this.CrystallBall2.Tag = "crystallball";
            this.CrystallBall2.Visible = false;
            // 
            // BeastObstacle
            // 
            this.BeastObstacle.BackColor = System.Drawing.Color.Transparent;
            this.BeastObstacle.Location = new System.Drawing.Point(216, 19);
            this.BeastObstacle.Name = "BeastObstacle";
            this.BeastObstacle.Size = new System.Drawing.Size(47, 717);
            this.BeastObstacle.TabIndex = 16;
            this.BeastObstacle.TabStop = false;
            this.BeastObstacle.Tag = "beast";
            this.BeastObstacle.Visible = false;
            // 
            // Berries
            // 
            this.Berries.BackColor = System.Drawing.Color.Transparent;
            this.Berries.Location = new System.Drawing.Point(850, 276);
            this.Berries.Name = "Berries";
            this.Berries.Size = new System.Drawing.Size(108, 104);
            this.Berries.TabIndex = 17;
            this.Berries.TabStop = false;
            this.Berries.Tag = "berries";
            this.Berries.Visible = false;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.BackToMenu.Image = ((System.Drawing.Image)(resources.GetObject("BackToMenu.Image")));
            this.BackToMenu.Location = new System.Drawing.Point(1085, 526);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(90, 90);
            this.BackToMenu.TabIndex = 18;
            this.BackToMenu.TabStop = false;
            this.BackToMenu.Visible = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Bryndan Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(61, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Use arrows to walk";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bryndan Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(61, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Click the X to return to menu";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.DialogueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ChestSprite);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Berries);
            this.Controls.Add(this.BeastObstacle);
            this.Controls.Add(this.CrystallBall2);
            this.Controls.Add(this.CrystallBall1);
            this.Controls.Add(this.CrystallBall3);
            this.Controls.Add(this.UpLocChange);
            this.Controls.Add(this.DownLocChange);
            this.Controls.Add(this.RightLocChange);
            this.Controls.Add(this.LeftLocChange);
            this.Controls.Add(this.KeySprite);
            this.Controls.Add(this.SchoolTeacher);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Lost Key";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DialogueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeySprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLocChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLocChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLocChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLocChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystallBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeastObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Berries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Button QuitButton;
        public System.Windows.Forms.PictureBox DialogueBox;
        public System.Windows.Forms.PictureBox Player;
        public System.Windows.Forms.PictureBox SchoolTeacher;
        public System.Windows.Forms.PictureBox ChestSprite;
        public System.Windows.Forms.PictureBox KeySprite;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox UpLocChange;
        public System.Windows.Forms.PictureBox LeftLocChange;
        public System.Windows.Forms.PictureBox RightLocChange;
        public System.Windows.Forms.PictureBox DownLocChange;
        public System.Windows.Forms.PictureBox CrystallBall3;
        public System.Windows.Forms.PictureBox CrystallBall1;
        public System.Windows.Forms.PictureBox CrystallBall2;
        public System.Windows.Forms.PictureBox BeastObstacle;
        public System.Windows.Forms.PictureBox Berries;
        public System.Windows.Forms.PictureBox BackToMenu;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
    }
}

