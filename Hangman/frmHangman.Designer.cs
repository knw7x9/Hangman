namespace Hangman {
    partial class frmHangman {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            this.lblWordFile = new System.Windows.Forms.Label();
            this.txtInputWordFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbHowManyLetters = new System.Windows.Forms.ComboBox();
            this.cmbLetters = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblOutputSayings = new System.Windows.Forms.Label();
            this.lbGuessedLetters = new System.Windows.Forms.ListBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbLeftArm = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbRightArm = new System.Windows.Forms.PictureBox();
            this.pbRightLeg = new System.Windows.Forms.PictureBox();
            this.pbLeftLeg = new System.Windows.Forms.PictureBox();
            this.pbNoose = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbVertical = new System.Windows.Forms.PictureBox();
            this.pbStandLeft = new System.Windows.Forms.PictureBox();
            this.pbStandMiddle = new System.Windows.Forms.PictureBox();
            this.pbStandRight = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbDiagonal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordFile
            // 
            this.lblWordFile.AutoSize = true;
            this.lblWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordFile.Location = new System.Drawing.Point(12, 9);
            this.lblWordFile.Name = "lblWordFile";
            this.lblWordFile.Size = new System.Drawing.Size(69, 16);
            this.lblWordFile.TabIndex = 0;
            this.lblWordFile.Text = "Word File:";
            // 
            // txtInputWordFile
            // 
            this.txtInputWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWordFile.Location = new System.Drawing.Point(87, 6);
            this.txtInputWordFile.Name = "txtInputWordFile";
            this.txtInputWordFile.Size = new System.Drawing.Size(200, 22);
            this.txtInputWordFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(293, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbHowManyLetters
            // 
            this.cmbHowManyLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHowManyLetters.FormattingEnabled = true;
            this.cmbHowManyLetters.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbHowManyLetters.Location = new System.Drawing.Point(15, 42);
            this.cmbHowManyLetters.Name = "cmbHowManyLetters";
            this.cmbHowManyLetters.Size = new System.Drawing.Size(121, 24);
            this.cmbHowManyLetters.TabIndex = 3;
            // 
            // cmbLetters
            // 
            this.cmbLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLetters.FormattingEnabled = true;
            this.cmbLetters.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.cmbLetters.Location = new System.Drawing.Point(15, 82);
            this.cmbLetters.Name = "cmbLetters";
            this.cmbLetters.Size = new System.Drawing.Size(121, 24);
            this.cmbLetters.TabIndex = 4;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(142, 42);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(85, 25);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(142, 82);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(85, 25);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(15, 122);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(212, 22);
            this.txtWord.TabIndex = 7;
            // 
            // lblOutputSayings
            // 
            this.lblOutputSayings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputSayings.Location = new System.Drawing.Point(12, 163);
            this.lblOutputSayings.Name = "lblOutputSayings";
            this.lblOutputSayings.Size = new System.Drawing.Size(215, 25);
            this.lblOutputSayings.TabIndex = 8;
            this.lblOutputSayings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGuessedLetters
            // 
            this.lbGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuessedLetters.FormattingEnabled = true;
            this.lbGuessedLetters.ItemHeight = 16;
            this.lbGuessedLetters.Location = new System.Drawing.Point(247, 42);
            this.lbGuessedLetters.Name = "lbGuessedLetters";
            this.lbGuessedLetters.Size = new System.Drawing.Size(131, 244);
            this.lbGuessedLetters.TabIndex = 9;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(15, 202);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(212, 25);
            this.lblWord.TabIndex = 10;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(393, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(494, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbHead
            // 
            this.pbHead.BackColor = System.Drawing.Color.White;
            this.pbHead.Image = ((System.Drawing.Image)(resources.GetObject("pbHead.Image")));
            this.pbHead.Location = new System.Drawing.Point(418, 103);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(33, 38);
            this.pbHead.TabIndex = 13;
            this.pbHead.TabStop = false;
            this.pbHead.Visible = false;
            // 
            // pbLeftArm
            // 
            this.pbLeftArm.BackColor = System.Drawing.Color.White;
            this.pbLeftArm.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftArm.Image")));
            this.pbLeftArm.Location = new System.Drawing.Point(416, 140);
            this.pbLeftArm.Name = "pbLeftArm";
            this.pbLeftArm.Size = new System.Drawing.Size(29, 53);
            this.pbLeftArm.TabIndex = 14;
            this.pbLeftArm.TabStop = false;
            this.pbLeftArm.Visible = false;
            // 
            // pbBody
            // 
            this.pbBody.BackColor = System.Drawing.Color.White;
            this.pbBody.Image = ((System.Drawing.Image)(resources.GetObject("pbBody.Image")));
            this.pbBody.Location = new System.Drawing.Point(438, 136);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(28, 66);
            this.pbBody.TabIndex = 15;
            this.pbBody.TabStop = false;
            this.pbBody.Visible = false;
            // 
            // pbRightArm
            // 
            this.pbRightArm.BackColor = System.Drawing.Color.White;
            this.pbRightArm.Image = ((System.Drawing.Image)(resources.GetObject("pbRightArm.Image")));
            this.pbRightArm.Location = new System.Drawing.Point(464, 137);
            this.pbRightArm.Name = "pbRightArm";
            this.pbRightArm.Size = new System.Drawing.Size(22, 62);
            this.pbRightArm.TabIndex = 16;
            this.pbRightArm.TabStop = false;
            this.pbRightArm.Visible = false;
            // 
            // pbRightLeg
            // 
            this.pbRightLeg.BackColor = System.Drawing.Color.White;
            this.pbRightLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbRightLeg.Image")));
            this.pbRightLeg.Location = new System.Drawing.Point(450, 198);
            this.pbRightLeg.Name = "pbRightLeg";
            this.pbRightLeg.Size = new System.Drawing.Size(19, 56);
            this.pbRightLeg.TabIndex = 17;
            this.pbRightLeg.TabStop = false;
            this.pbRightLeg.Visible = false;
            // 
            // pbLeftLeg
            // 
            this.pbLeftLeg.BackColor = System.Drawing.Color.White;
            this.pbLeftLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftLeg.Image")));
            this.pbLeftLeg.Location = new System.Drawing.Point(433, 198);
            this.pbLeftLeg.Name = "pbLeftLeg";
            this.pbLeftLeg.Size = new System.Drawing.Size(17, 56);
            this.pbLeftLeg.TabIndex = 18;
            this.pbLeftLeg.TabStop = false;
            this.pbLeftLeg.Visible = false;
            // 
            // pbNoose
            // 
            this.pbNoose.BackColor = System.Drawing.Color.White;
            this.pbNoose.Image = ((System.Drawing.Image)(resources.GetObject("pbNoose.Image")));
            this.pbNoose.Location = new System.Drawing.Point(448, 75);
            this.pbNoose.Name = "pbNoose";
            this.pbNoose.Size = new System.Drawing.Size(12, 75);
            this.pbNoose.TabIndex = 19;
            this.pbNoose.TabStop = false;
            this.pbNoose.Visible = false;
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.White;
            this.pbTop.Image = ((System.Drawing.Image)(resources.GetObject("pbTop.Image")));
            this.pbTop.Location = new System.Drawing.Point(433, 59);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(152, 20);
            this.pbTop.TabIndex = 20;
            this.pbTop.TabStop = false;
            this.pbTop.Visible = false;
            // 
            // pbVertical
            // 
            this.pbVertical.BackColor = System.Drawing.Color.White;
            this.pbVertical.Image = ((System.Drawing.Image)(resources.GetObject("pbVertical.Image")));
            this.pbVertical.Location = new System.Drawing.Point(568, 75);
            this.pbVertical.Name = "pbVertical";
            this.pbVertical.Size = new System.Drawing.Size(18, 140);
            this.pbVertical.TabIndex = 21;
            this.pbVertical.TabStop = false;
            this.pbVertical.Visible = false;
            // 
            // pbStandLeft
            // 
            this.pbStandLeft.BackColor = System.Drawing.Color.White;
            this.pbStandLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbStandLeft.Image")));
            this.pbStandLeft.Location = new System.Drawing.Point(546, 205);
            this.pbStandLeft.Name = "pbStandLeft";
            this.pbStandLeft.Size = new System.Drawing.Size(27, 62);
            this.pbStandLeft.TabIndex = 22;
            this.pbStandLeft.TabStop = false;
            this.pbStandLeft.Visible = false;
            // 
            // pbStandMiddle
            // 
            this.pbStandMiddle.BackColor = System.Drawing.Color.White;
            this.pbStandMiddle.Image = ((System.Drawing.Image)(resources.GetObject("pbStandMiddle.Image")));
            this.pbStandMiddle.Location = new System.Drawing.Point(568, 208);
            this.pbStandMiddle.Name = "pbStandMiddle";
            this.pbStandMiddle.Size = new System.Drawing.Size(20, 61);
            this.pbStandMiddle.TabIndex = 23;
            this.pbStandMiddle.TabStop = false;
            this.pbStandMiddle.Visible = false;
            // 
            // pbStandRight
            // 
            this.pbStandRight.BackColor = System.Drawing.Color.White;
            this.pbStandRight.Image = ((System.Drawing.Image)(resources.GetObject("pbStandRight.Image")));
            this.pbStandRight.Location = new System.Drawing.Point(582, 207);
            this.pbStandRight.Name = "pbStandRight";
            this.pbStandRight.Size = new System.Drawing.Size(30, 63);
            this.pbStandRight.TabIndex = 24;
            this.pbStandRight.TabStop = false;
            this.pbStandRight.Visible = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.White;
            this.pbBackground.Location = new System.Drawing.Point(388, 42);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(243, 244);
            this.pbBackground.TabIndex = 25;
            this.pbBackground.TabStop = false;
            // 
            // pbDiagonal
            // 
            this.pbDiagonal.BackColor = System.Drawing.Color.White;
            this.pbDiagonal.Image = ((System.Drawing.Image)(resources.GetObject("pbDiagonal.Image")));
            this.pbDiagonal.Location = new System.Drawing.Point(501, 75);
            this.pbDiagonal.Name = "pbDiagonal";
            this.pbDiagonal.Size = new System.Drawing.Size(69, 64);
            this.pbDiagonal.TabIndex = 26;
            this.pbDiagonal.TabStop = false;
            this.pbDiagonal.Visible = false;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 295);
            this.Controls.Add(this.pbDiagonal);
            this.Controls.Add(this.pbLeftLeg);
            this.Controls.Add(this.pbRightLeg);
            this.Controls.Add(this.pbBody);
            this.Controls.Add(this.pbNoose);
            this.Controls.Add(this.pbStandRight);
            this.Controls.Add(this.pbStandMiddle);
            this.Controls.Add(this.pbVertical);
            this.Controls.Add(this.pbStandLeft);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbRightArm);
            this.Controls.Add(this.pbLeftArm);
            this.Controls.Add(this.pbHead);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lbGuessedLetters);
            this.Controls.Add(this.lblOutputSayings);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.cmbLetters);
            this.Controls.Add(this.cmbHowManyLetters);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtInputWordFile);
            this.Controls.Add(this.lblWordFile);
            this.Controls.Add(this.pbBackground);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordFile;
        private System.Windows.Forms.TextBox txtInputWordFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbHowManyLetters;
        private System.Windows.Forms.ComboBox cmbLetters;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblOutputSayings;
        private System.Windows.Forms.ListBox lbGuessedLetters;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbLeftArm;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbRightArm;
        private System.Windows.Forms.PictureBox pbRightLeg;
        private System.Windows.Forms.PictureBox pbLeftLeg;
        private System.Windows.Forms.PictureBox pbNoose;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbVertical;
        private System.Windows.Forms.PictureBox pbStandLeft;
        private System.Windows.Forms.PictureBox pbStandMiddle;
        private System.Windows.Forms.PictureBox pbStandRight;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbDiagonal;
    }
}

