namespace Cathrine_GameTwoUp
{
    partial class FormGameTwoUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameTwoUp));
            this.labelRp = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelDisplayComment = new System.Windows.Forms.Label();
            this.labelDisplayMoney = new System.Windows.Forms.Label();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.groupBoxBet = new System.Windows.Forms.GroupBox();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelBet = new System.Windows.Forms.Label();
            this.buttonStartRestart = new System.Windows.Forms.Button();
            this.labelHeadTail = new System.Windows.Forms.Label();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.labelUrMoney = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonToss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRp
            // 
            this.labelRp.AutoSize = true;
            this.labelRp.BackColor = System.Drawing.Color.Transparent;
            this.labelRp.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRp.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelRp.Location = new System.Drawing.Point(162, 112);
            this.labelRp.Name = "labelRp";
            this.labelRp.Size = new System.Drawing.Size(29, 15);
            this.labelRp.TabIndex = 43;
            this.labelRp.Text = "Rp.";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(339, 573);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 42;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonContinue.Location = new System.Drawing.Point(192, 573);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(83, 23);
            this.buttonContinue.TabIndex = 41;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelDisplayComment
            // 
            this.labelDisplayComment.AutoSize = true;
            this.labelDisplayComment.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayComment.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayComment.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDisplayComment.Location = new System.Drawing.Point(151, 524);
            this.labelDisplayComment.Name = "labelDisplayComment";
            this.labelDisplayComment.Size = new System.Drawing.Size(313, 31);
            this.labelDisplayComment.TabIndex = 33;
            this.labelDisplayComment.Text = "display  comment in here";
            this.labelDisplayComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDisplayMoney
            // 
            this.labelDisplayMoney.AutoSize = true;
            this.labelDisplayMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayMoney.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayMoney.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelDisplayMoney.Location = new System.Drawing.Point(197, 112);
            this.labelDisplayMoney.Name = "labelDisplayMoney";
            this.labelDisplayMoney.Size = new System.Drawing.Size(102, 15);
            this.labelDisplayMoney.TabIndex = 32;
            this.labelDisplayMoney.Text = "display money";
            // 
            // buttonPlace
            // 
            this.buttonPlace.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlace.Location = new System.Drawing.Point(109, 70);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(75, 23);
            this.buttonPlace.TabIndex = 30;
            this.buttonPlace.Text = "Place";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // groupBoxBet
            // 
            this.groupBoxBet.BackColor = System.Drawing.Color.LightCoral;
            this.groupBoxBet.Controls.Add(this.buttonCancel);
            this.groupBoxBet.Controls.Add(this.textBoxBet);
            this.groupBoxBet.Controls.Add(this.labelBet);
            this.groupBoxBet.Controls.Add(this.buttonPlace);
            this.groupBoxBet.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBet.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxBet.Location = new System.Drawing.Point(60, 159);
            this.groupBoxBet.Name = "groupBoxBet";
            this.groupBoxBet.Size = new System.Drawing.Size(381, 113);
            this.groupBoxBet.TabIndex = 29;
            this.groupBoxBet.TabStop = false;
            this.groupBoxBet.Text = "Place your Bet";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBet.Location = new System.Drawing.Point(109, 32);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(185, 22);
            this.textBoxBet.TabIndex = 28;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(15, 35);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(32, 16);
            this.labelBet.TabIndex = 27;
            this.labelBet.Text = "Bet:";
            // 
            // buttonStartRestart
            // 
            this.buttonStartRestart.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartRestart.Location = new System.Drawing.Point(485, 105);
            this.buttonStartRestart.Name = "buttonStartRestart";
            this.buttonStartRestart.Size = new System.Drawing.Size(115, 29);
            this.buttonStartRestart.TabIndex = 26;
            this.buttonStartRestart.Text = "Start/Restart";
            this.buttonStartRestart.UseVisualStyleBackColor = true;
            this.buttonStartRestart.Click += new System.EventHandler(this.buttonStartRestart_Click);
            // 
            // labelHeadTail
            // 
            this.labelHeadTail.AutoSize = true;
            this.labelHeadTail.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadTail.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadTail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeadTail.Location = new System.Drawing.Point(361, 322);
            this.labelHeadTail.Name = "labelHeadTail";
            this.labelHeadTail.Size = new System.Drawing.Size(95, 15);
            this.labelHeadTail.TabIndex = 25;
            this.labelHeadTail.Text = "Head or Tail?";
            // 
            // pictureBoxCoin2
            // 
            this.pictureBoxCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCoin2.Image = global::Cathrine_GameTwoUp.Properties.Resources.QuestionMark;
            this.pictureBoxCoin2.Location = new System.Drawing.Point(339, 343);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(161, 152);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin2.TabIndex = 24;
            this.pictureBoxCoin2.TabStop = false;
            // 
            // labelUrMoney
            // 
            this.labelUrMoney.AutoSize = true;
            this.labelUrMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelUrMoney.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrMoney.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelUrMoney.Location = new System.Drawing.Point(57, 112);
            this.labelUrMoney.Name = "labelUrMoney";
            this.labelUrMoney.Size = new System.Drawing.Size(90, 15);
            this.labelUrMoney.TabIndex = 23;
            this.labelUrMoney.Text = "Your Money:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Linen;
            this.labelTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Sienna;
            this.labelTitle.Location = new System.Drawing.Point(221, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 57);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Two Up";
            // 
            // buttonToss
            // 
            this.buttonToss.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonToss.Location = new System.Drawing.Point(485, 226);
            this.buttonToss.Name = "buttonToss";
            this.buttonToss.Size = new System.Drawing.Size(115, 29);
            this.buttonToss.TabIndex = 44;
            this.buttonToss.Text = "Toss The Coin";
            this.buttonToss.UseVisualStyleBackColor = true;
            this.buttonToss.Click += new System.EventHandler(this.buttonToss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(139, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Head or Tail?";
            // 
            // pictureBoxCoin1
            // 
            this.pictureBoxCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCoin1.Image = global::Cathrine_GameTwoUp.Properties.Resources.QuestionMark;
            this.pictureBoxCoin1.Location = new System.Drawing.Point(101, 343);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(161, 152);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin1.TabIndex = 45;
            this.pictureBoxCoin1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(219, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormGameTwoUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCoin1);
            this.Controls.Add(this.buttonToss);
            this.Controls.Add(this.labelRp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelDisplayComment);
            this.Controls.Add(this.labelDisplayMoney);
            this.Controls.Add(this.groupBoxBet);
            this.Controls.Add(this.buttonStartRestart);
            this.Controls.Add(this.labelHeadTail);
            this.Controls.Add(this.pictureBoxCoin2);
            this.Controls.Add(this.labelUrMoney);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormGameTwoUp";
            this.Text = "Two Up Game";
            this.Load += new System.EventHandler(this.FormGameTwoUp_Load);
            this.groupBoxBet.ResumeLayout(false);
            this.groupBoxBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelDisplayComment;
        private System.Windows.Forms.Label labelDisplayMoney;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.GroupBox groupBoxBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Button buttonStartRestart;
        private System.Windows.Forms.Label labelHeadTail;
        private System.Windows.Forms.PictureBox pictureBoxCoin2;
        private System.Windows.Forms.Label labelUrMoney;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonToss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCoin1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

