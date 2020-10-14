namespace WindowsFormsApp1
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
            this.lBoxGames = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.opnFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxGameTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxGames
            // 
            this.lBoxGames.FormattingEnabled = true;
            this.lBoxGames.Location = new System.Drawing.Point(13, 13);
            this.lBoxGames.Name = "lBoxGames";
            this.lBoxGames.Size = new System.Drawing.Size(477, 537);
            this.lBoxGames.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Game List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opnFile
            // 
            this.opnFile.FileName = "opnFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Title:";
            // 
            // tBoxGameTitle
            // 
            this.tBoxGameTitle.Location = new System.Drawing.Point(509, 166);
            this.tBoxGameTitle.Name = "tBoxGameTitle";
            this.tBoxGameTitle.Size = new System.Drawing.Size(514, 20);
            this.tBoxGameTitle.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generate Random Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tBoxGameTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lBoxGames);
            this.Name = "Form1";
            this.Text = "Steam Game Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxGames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog opnFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxGameTitle;
        private System.Windows.Forms.Button button2;
    }
}

