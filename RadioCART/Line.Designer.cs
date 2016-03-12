namespace RadioCART
{
    partial class Line
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileName = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.ejectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(91, 17);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(90, 13);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "Please load a file.";
            // 
            // playButton
            // 
            this.playButton.ForeColor = System.Drawing.Color.Black;
            this.playButton.Location = new System.Drawing.Point(256, 7);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 40);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(312, 8);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 40);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // ejectButton
            // 
            this.ejectButton.Location = new System.Drawing.Point(377, 7);
            this.ejectButton.Name = "ejectButton";
            this.ejectButton.Size = new System.Drawing.Size(60, 25);
            this.ejectButton.TabIndex = 3;
            this.ejectButton.Text = "EJECT";
            this.ejectButton.UseVisualStyleBackColor = true;
            this.ejectButton.Click += new System.EventHandler(this.ejectButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "wav";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(377, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 15);
            this.clearButton.TabIndex = 4;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Q";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ejectButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.fileName);
            this.Name = "Line";
            this.Size = new System.Drawing.Size(500, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button ejectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
