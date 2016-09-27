namespace OneQuestionQuiz
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
            this.lblMusic = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdoRap = new System.Windows.Forms.RadioButton();
            this.rdoCountry = new System.Windows.Forms.RadioButton();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.rdoHipHop = new System.Windows.Forms.RadioButton();
            this.rdoClassical = new System.Windows.Forms.RadioButton();
            this.rdoJazz = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(12, 9);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(209, 13);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "What is Camisha\'s favorite genre of music?";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdoJazz);
            this.grpBox.Controls.Add(this.rdoClassical);
            this.grpBox.Controls.Add(this.rdoHipHop);
            this.grpBox.Controls.Add(this.rdoRock);
            this.grpBox.Controls.Add(this.rdoCountry);
            this.grpBox.Controls.Add(this.rdoRap);
            this.grpBox.Location = new System.Drawing.Point(12, 39);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(221, 100);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            // 
            // rdoRap
            // 
            this.rdoRap.AutoSize = true;
            this.rdoRap.Location = new System.Drawing.Point(6, 19);
            this.rdoRap.Name = "rdoRap";
            this.rdoRap.Size = new System.Drawing.Size(45, 17);
            this.rdoRap.TabIndex = 0;
            this.rdoRap.TabStop = true;
            this.rdoRap.Text = "Rap";
            this.rdoRap.UseVisualStyleBackColor = true;
            this.rdoRap.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoCountry
            // 
            this.rdoCountry.AutoSize = true;
            this.rdoCountry.Location = new System.Drawing.Point(6, 43);
            this.rdoCountry.Name = "rdoCountry";
            this.rdoCountry.Size = new System.Drawing.Size(61, 17);
            this.rdoCountry.TabIndex = 1;
            this.rdoCountry.TabStop = true;
            this.rdoCountry.Text = "Country";
            this.rdoCountry.UseVisualStyleBackColor = true;
            this.rdoCountry.CheckedChanged += new System.EventHandler(this.rdoCountry_CheckedChanged);
            // 
            // rdoRock
            // 
            this.rdoRock.AutoSize = true;
            this.rdoRock.Location = new System.Drawing.Point(6, 67);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(51, 17);
            this.rdoRock.TabIndex = 2;
            this.rdoRock.TabStop = true;
            this.rdoRock.Text = "Rock";
            this.rdoRock.UseVisualStyleBackColor = true;
            this.rdoRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // rdoHipHop
            // 
            this.rdoHipHop.AutoSize = true;
            this.rdoHipHop.Location = new System.Drawing.Point(119, 19);
            this.rdoHipHop.Name = "rdoHipHop";
            this.rdoHipHop.Size = new System.Drawing.Size(61, 17);
            this.rdoHipHop.TabIndex = 3;
            this.rdoHipHop.TabStop = true;
            this.rdoHipHop.Text = "HipHop";
            this.rdoHipHop.UseVisualStyleBackColor = true;
            this.rdoHipHop.CheckedChanged += new System.EventHandler(this.rdoHipHop_CheckedChanged);
            // 
            // rdoClassical
            // 
            this.rdoClassical.AutoSize = true;
            this.rdoClassical.Location = new System.Drawing.Point(119, 43);
            this.rdoClassical.Name = "rdoClassical";
            this.rdoClassical.Size = new System.Drawing.Size(66, 17);
            this.rdoClassical.TabIndex = 4;
            this.rdoClassical.TabStop = true;
            this.rdoClassical.Text = "Classical";
            this.rdoClassical.UseVisualStyleBackColor = true;
            this.rdoClassical.CheckedChanged += new System.EventHandler(this.rdoClassical_CheckedChanged);
            // 
            // rdoJazz
            // 
            this.rdoJazz.AutoSize = true;
            this.rdoJazz.Location = new System.Drawing.Point(119, 67);
            this.rdoJazz.Name = "rdoJazz";
            this.rdoJazz.Size = new System.Drawing.Size(46, 17);
            this.rdoJazz.TabIndex = 5;
            this.rdoJazz.TabStop = true;
            this.rdoJazz.Text = "Jazz";
            this.rdoJazz.UseVisualStyleBackColor = true;
            this.rdoJazz.CheckedChanged += new System.EventHandler(this.rdoJazz_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(18, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 205);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblMusic);
            this.Name = "Form1";
            this.Text = "What is Camisha\'s favorite genre of music?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdoRock;
        private System.Windows.Forms.RadioButton rdoCountry;
        private System.Windows.Forms.RadioButton rdoRap;
        private System.Windows.Forms.RadioButton rdoJazz;
        private System.Windows.Forms.RadioButton rdoClassical;
        private System.Windows.Forms.RadioButton rdoHipHop;
        private System.Windows.Forms.Label lblResult;
    }
}

