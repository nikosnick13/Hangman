namespace HangmanForm
{
    partial class HangmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.GuesaALetter = new System.Windows.Forms.Label();
            this.labelSecretWord = new System.Windows.Forms.Label();
            this.textBoxGuessALetter = new System.Windows.Forms.TextBox();
            this.buttonOfGuesses = new System.Windows.Forms.Button();
            this.labelLetters = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HangmanImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdF = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdI = new System.Windows.Forms.Button();
            this.cmdJ = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            this.cmdK = new System.Windows.Forms.Button();
            this.cmdM = new System.Windows.Forms.Button();
            this.cmdN = new System.Windows.Forms.Button();
            this.cmdO = new System.Windows.Forms.Button();
            this.cmdP = new System.Windows.Forms.Button();
            this.cmdQ = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdS = new System.Windows.Forms.Button();
            this.cmdT = new System.Windows.Forms.Button();
            this.cmdU = new System.Windows.Forms.Button();
            this.cmdV = new System.Windows.Forms.Button();
            this.cmdW = new System.Windows.Forms.Button();
            this.cmdX = new System.Windows.Forms.Button();
            this.cmdY = new System.Windows.Forms.Button();
            this.cmdZ = new System.Windows.Forms.Button();
            this.LostMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GuesaALetter
            // 
            this.GuesaALetter.AutoSize = true;
            this.GuesaALetter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuesaALetter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GuesaALetter.Location = new System.Drawing.Point(33, 62);
            this.GuesaALetter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GuesaALetter.Name = "GuesaALetter";
            this.GuesaALetter.Size = new System.Drawing.Size(172, 32);
            this.GuesaALetter.TabIndex = 0;
            this.GuesaALetter.Text = "Guess a letter :";
            this.GuesaALetter.UseWaitCursor = true;
            // 
            // labelSecretWord
            // 
            this.labelSecretWord.AutoSize = true;
            this.labelSecretWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSecretWord.Location = new System.Drawing.Point(33, 199);
            this.labelSecretWord.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSecretWord.Name = "labelSecretWord";
            this.labelSecretWord.Size = new System.Drawing.Size(146, 32);
            this.labelSecretWord.TabIndex = 1;
            this.labelSecretWord.Text = "Secret word:";
            this.labelSecretWord.UseWaitCursor = true;
            this.labelSecretWord.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxGuessALetter
            // 
            this.textBoxGuessALetter.Location = new System.Drawing.Point(223, 59);
            this.textBoxGuessALetter.MaxLength = 1;
            this.textBoxGuessALetter.Name = "textBoxGuessALetter";
            this.textBoxGuessALetter.Size = new System.Drawing.Size(47, 39);
            this.textBoxGuessALetter.TabIndex = 2;
            this.textBoxGuessALetter.UseWaitCursor = true;
            this.textBoxGuessALetter.TextChanged += new System.EventHandler(this.textBoxGuessALetter_TextChanged);
            // 
            // buttonOfGuesses
            // 
            this.buttonOfGuesses.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonOfGuesses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOfGuesses.Location = new System.Drawing.Point(39, 113);
            this.buttonOfGuesses.Name = "buttonOfGuesses";
            this.buttonOfGuesses.Size = new System.Drawing.Size(123, 47);
            this.buttonOfGuesses.TabIndex = 3;
            this.buttonOfGuesses.Text = "Guess";
            this.buttonOfGuesses.UseVisualStyleBackColor = false;
            this.buttonOfGuesses.UseWaitCursor = true;
            this.buttonOfGuesses.Click += new System.EventHandler(this.buttonOfGuesses_Click);
            // 
            // labelLetters
            // 
            this.labelLetters.AutoSize = true;
            this.labelLetters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLetters.Location = new System.Drawing.Point(33, 292);
            this.labelLetters.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLetters.Name = "labelLetters";
            this.labelLetters.Size = new System.Drawing.Size(81, 32);
            this.labelLetters.TabIndex = 4;
            this.labelLetters.Text = "letters";
            this.labelLetters.UseWaitCursor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // HangmanImage
            // 
            this.HangmanImage.ErrorImage = null;
            this.HangmanImage.Image = ((System.Drawing.Image)(resources.GetObject("HangmanImage.Image")));
            this.HangmanImage.InitialImage = null;
            this.HangmanImage.Location = new System.Drawing.Point(367, 21);
            this.HangmanImage.Name = "HangmanImage";
            this.HangmanImage.Size = new System.Drawing.Size(488, 381);
            this.HangmanImage.TabIndex = 5;
            this.HangmanImage.TabStop = false;
            this.HangmanImage.UseWaitCursor = true;
            // 
            // cmdA
            // 
            this.cmdA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdA.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdA.Location = new System.Drawing.Point(39, 493);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(35, 36);
            this.cmdA.TabIndex = 6;
            this.cmdA.Text = "a";
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.UseWaitCursor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdB.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdB.Location = new System.Drawing.Point(80, 493);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(35, 36);
            this.cmdB.TabIndex = 7;
            this.cmdB.Text = "b";
            this.cmdB.UseVisualStyleBackColor = false;
            this.cmdB.UseWaitCursor = true;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdC
            // 
            this.cmdC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdC.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdC.Location = new System.Drawing.Point(121, 493);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(35, 36);
            this.cmdC.TabIndex = 8;
            this.cmdC.Text = "c";
            this.cmdC.UseVisualStyleBackColor = false;
            this.cmdC.UseWaitCursor = true;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdD
            // 
            this.cmdD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdD.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdD.Location = new System.Drawing.Point(162, 493);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(35, 36);
            this.cmdD.TabIndex = 9;
            this.cmdD.Text = "d";
            this.cmdD.UseVisualStyleBackColor = false;
            this.cmdD.UseWaitCursor = true;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdF
            // 
            this.cmdF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdF.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdF.Location = new System.Drawing.Point(244, 493);
            this.cmdF.Name = "cmdF";
            this.cmdF.Size = new System.Drawing.Size(35, 36);
            this.cmdF.TabIndex = 10;
            this.cmdF.Text = "f";
            this.cmdF.UseVisualStyleBackColor = false;
            this.cmdF.UseWaitCursor = true;
            this.cmdF.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdE.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdE.Location = new System.Drawing.Point(203, 493);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(35, 36);
            this.cmdE.TabIndex = 11;
            this.cmdE.Text = "e";
            this.cmdE.UseVisualStyleBackColor = false;
            this.cmdE.UseWaitCursor = true;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdG
            // 
            this.cmdG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdG.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdG.Location = new System.Drawing.Point(285, 493);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(35, 36);
            this.cmdG.TabIndex = 12;
            this.cmdG.Text = "g";
            this.cmdG.UseVisualStyleBackColor = false;
            this.cmdG.UseWaitCursor = true;
            this.cmdG.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdH
            // 
            this.cmdH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdH.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdH.Location = new System.Drawing.Point(326, 493);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(35, 36);
            this.cmdH.TabIndex = 13;
            this.cmdH.Text = "h";
            this.cmdH.UseVisualStyleBackColor = false;
            this.cmdH.UseWaitCursor = true;
            this.cmdH.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdI
            // 
            this.cmdI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdI.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdI.Location = new System.Drawing.Point(367, 493);
            this.cmdI.Name = "cmdI";
            this.cmdI.Size = new System.Drawing.Size(35, 36);
            this.cmdI.TabIndex = 14;
            this.cmdI.Text = "i";
            this.cmdI.UseVisualStyleBackColor = false;
            this.cmdI.UseWaitCursor = true;
            this.cmdI.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdJ
            // 
            this.cmdJ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdJ.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdJ.Location = new System.Drawing.Point(408, 493);
            this.cmdJ.Name = "cmdJ";
            this.cmdJ.Size = new System.Drawing.Size(35, 36);
            this.cmdJ.TabIndex = 15;
            this.cmdJ.Text = "j";
            this.cmdJ.UseVisualStyleBackColor = false;
            this.cmdJ.UseWaitCursor = true;
            this.cmdJ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdL
            // 
            this.cmdL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdL.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdL.Location = new System.Drawing.Point(490, 493);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(35, 36);
            this.cmdL.TabIndex = 16;
            this.cmdL.Text = "l";
            this.cmdL.UseVisualStyleBackColor = false;
            this.cmdL.UseWaitCursor = true;
            this.cmdL.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdK
            // 
            this.cmdK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdK.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdK.Location = new System.Drawing.Point(449, 493);
            this.cmdK.Name = "cmdK";
            this.cmdK.Size = new System.Drawing.Size(35, 36);
            this.cmdK.TabIndex = 17;
            this.cmdK.Text = "k";
            this.cmdK.UseVisualStyleBackColor = false;
            this.cmdK.UseWaitCursor = true;
            this.cmdK.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdM
            // 
            this.cmdM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdM.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdM.Location = new System.Drawing.Point(531, 493);
            this.cmdM.Name = "cmdM";
            this.cmdM.Size = new System.Drawing.Size(35, 36);
            this.cmdM.TabIndex = 18;
            this.cmdM.Text = "m";
            this.cmdM.UseVisualStyleBackColor = false;
            this.cmdM.UseWaitCursor = true;
            this.cmdM.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdN
            // 
            this.cmdN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdN.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdN.Location = new System.Drawing.Point(572, 493);
            this.cmdN.Name = "cmdN";
            this.cmdN.Size = new System.Drawing.Size(35, 36);
            this.cmdN.TabIndex = 19;
            this.cmdN.Text = "n";
            this.cmdN.UseVisualStyleBackColor = false;
            this.cmdN.UseWaitCursor = true;
            this.cmdN.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdO
            // 
            this.cmdO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdO.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdO.Location = new System.Drawing.Point(613, 493);
            this.cmdO.Name = "cmdO";
            this.cmdO.Size = new System.Drawing.Size(35, 36);
            this.cmdO.TabIndex = 20;
            this.cmdO.Text = "o";
            this.cmdO.UseVisualStyleBackColor = false;
            this.cmdO.UseWaitCursor = true;
            this.cmdO.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdP
            // 
            this.cmdP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdP.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdP.Location = new System.Drawing.Point(654, 493);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(35, 36);
            this.cmdP.TabIndex = 21;
            this.cmdP.Text = "p";
            this.cmdP.UseVisualStyleBackColor = false;
            this.cmdP.UseWaitCursor = true;
            this.cmdP.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdQ
            // 
            this.cmdQ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdQ.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdQ.Location = new System.Drawing.Point(695, 493);
            this.cmdQ.Name = "cmdQ";
            this.cmdQ.Size = new System.Drawing.Size(35, 36);
            this.cmdQ.TabIndex = 22;
            this.cmdQ.Text = "q";
            this.cmdQ.UseVisualStyleBackColor = false;
            this.cmdQ.UseWaitCursor = true;
            this.cmdQ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdR
            // 
            this.cmdR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdR.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdR.Location = new System.Drawing.Point(736, 493);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(35, 36);
            this.cmdR.TabIndex = 23;
            this.cmdR.Text = "r";
            this.cmdR.UseVisualStyleBackColor = false;
            this.cmdR.UseWaitCursor = true;
            this.cmdR.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdS
            // 
            this.cmdS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdS.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdS.Location = new System.Drawing.Point(777, 493);
            this.cmdS.Name = "cmdS";
            this.cmdS.Size = new System.Drawing.Size(35, 36);
            this.cmdS.TabIndex = 24;
            this.cmdS.Text = "s";
            this.cmdS.UseVisualStyleBackColor = false;
            this.cmdS.UseWaitCursor = true;
            this.cmdS.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdT
            // 
            this.cmdT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdT.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdT.Location = new System.Drawing.Point(818, 493);
            this.cmdT.Name = "cmdT";
            this.cmdT.Size = new System.Drawing.Size(35, 36);
            this.cmdT.TabIndex = 25;
            this.cmdT.Text = "t";
            this.cmdT.UseVisualStyleBackColor = false;
            this.cmdT.UseWaitCursor = true;
            this.cmdT.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdU
            // 
            this.cmdU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdU.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdU.Location = new System.Drawing.Point(39, 535);
            this.cmdU.Name = "cmdU";
            this.cmdU.Size = new System.Drawing.Size(35, 36);
            this.cmdU.TabIndex = 26;
            this.cmdU.Text = "u";
            this.cmdU.UseVisualStyleBackColor = false;
            this.cmdU.UseWaitCursor = true;
            this.cmdU.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdV
            // 
            this.cmdV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdV.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdV.Location = new System.Drawing.Point(80, 535);
            this.cmdV.Name = "cmdV";
            this.cmdV.Size = new System.Drawing.Size(35, 36);
            this.cmdV.TabIndex = 27;
            this.cmdV.Text = "v";
            this.cmdV.UseVisualStyleBackColor = false;
            this.cmdV.UseWaitCursor = true;
            this.cmdV.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdW
            // 
            this.cmdW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdW.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdW.Location = new System.Drawing.Point(121, 535);
            this.cmdW.Name = "cmdW";
            this.cmdW.Size = new System.Drawing.Size(35, 36);
            this.cmdW.TabIndex = 28;
            this.cmdW.Text = "w";
            this.cmdW.UseVisualStyleBackColor = false;
            this.cmdW.UseWaitCursor = true;
            this.cmdW.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdX
            // 
            this.cmdX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdX.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdX.Location = new System.Drawing.Point(162, 535);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(35, 36);
            this.cmdX.TabIndex = 29;
            this.cmdX.Text = "x";
            this.cmdX.UseVisualStyleBackColor = false;
            this.cmdX.UseWaitCursor = true;
            this.cmdX.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdY
            // 
            this.cmdY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdY.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdY.Location = new System.Drawing.Point(203, 535);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(35, 36);
            this.cmdY.TabIndex = 30;
            this.cmdY.Text = "y";
            this.cmdY.UseVisualStyleBackColor = false;
            this.cmdY.UseWaitCursor = true;
            this.cmdY.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdZ
            // 
            this.cmdZ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdZ.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdZ.Location = new System.Drawing.Point(244, 535);
            this.cmdZ.Name = "cmdZ";
            this.cmdZ.Size = new System.Drawing.Size(35, 36);
            this.cmdZ.TabIndex = 31;
            this.cmdZ.Text = "z";
            this.cmdZ.UseVisualStyleBackColor = false;
            this.cmdZ.UseWaitCursor = true;
            this.cmdZ.Click += new System.EventHandler(this.guessClick);
            // 
            // LostMess
            // 
            this.LostMess.AutoSize = true;
            this.LostMess.Location = new System.Drawing.Point(361, 275);
            this.LostMess.Name = "LostMess";
            this.LostMess.Size = new System.Drawing.Size(0, 32);
            this.LostMess.TabIndex = 32;
            this.LostMess.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(879, 617);
            this.Controls.Add(this.LostMess);
            this.Controls.Add(this.cmdZ);
            this.Controls.Add(this.cmdY);
            this.Controls.Add(this.cmdX);
            this.Controls.Add(this.cmdW);
            this.Controls.Add(this.cmdV);
            this.Controls.Add(this.cmdU);
            this.Controls.Add(this.cmdT);
            this.Controls.Add(this.cmdS);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdQ);
            this.Controls.Add(this.cmdP);
            this.Controls.Add(this.cmdO);
            this.Controls.Add(this.cmdN);
            this.Controls.Add(this.cmdM);
            this.Controls.Add(this.cmdK);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdJ);
            this.Controls.Add(this.cmdI);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdF);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.HangmanImage);
            this.Controls.Add(this.labelLetters);
            this.Controls.Add(this.buttonOfGuesses);
            this.Controls.Add(this.textBoxGuessALetter);
            this.Controls.Add(this.labelSecretWord);
            this.Controls.Add(this.GuesaALetter);
            this.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HangmanForm";
            this.Text = "Hangman ";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangmanImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuesaALetter;
        private System.Windows.Forms.Label labelSecretWord;
        private System.Windows.Forms.TextBox textBoxGuessALetter;
        private System.Windows.Forms.Button buttonOfGuesses;
        private System.Windows.Forms.Label labelLetters;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox HangmanImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdF;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdI;
        private System.Windows.Forms.Button cmdJ;
        private System.Windows.Forms.Button cmdL;
        private System.Windows.Forms.Button cmdK;
        private System.Windows.Forms.Button cmdM;
        private System.Windows.Forms.Button cmdN;
        private System.Windows.Forms.Button cmdO;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.Button cmdQ;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdS;
        private System.Windows.Forms.Button cmdT;
        private System.Windows.Forms.Button cmdU;
        private System.Windows.Forms.Button cmdV;
        private System.Windows.Forms.Button cmdW;
        private System.Windows.Forms.Button cmdX;
        private System.Windows.Forms.Button cmdY;
        private System.Windows.Forms.Button cmdZ;
        private System.Windows.Forms.Label LostMess;
    }
}

