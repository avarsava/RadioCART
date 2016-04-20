namespace RadioCART
{
    partial class Form1
    {
        private Line line1;
        private Line line2;
        private Line line3;
        private Line line4;
        private Line line5;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepUp = new System.Windows.Forms.RadioButton();
            this.stepDown = new System.Windows.Forms.RadioButton();
            this.unloadAll = new System.Windows.Forms.Button();
            this.line5 = new RadioCART.Line();
            this.line4 = new RadioCART.Line();
            this.line3 = new RadioCART.Line();
            this.line2 = new RadioCART.Line();
            this.line1 = new RadioCART.Line();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepUp);
            this.groupBox1.Controls.Add(this.stepDown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(623, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counter";
            // 
            // stepUp
            // 
            this.stepUp.AutoSize = true;
            this.stepUp.Location = new System.Drawing.Point(7, 45);
            this.stepUp.Name = "stepUp";
            this.stepUp.Size = new System.Drawing.Size(135, 24);
            this.stepUp.TabIndex = 1;
            this.stepUp.Text = "Time Elapsed";
            this.stepUp.UseVisualStyleBackColor = true;
            // 
            // stepDown
            // 
            this.stepDown.AutoSize = true;
            this.stepDown.Checked = true;
            this.stepDown.Location = new System.Drawing.Point(7, 20);
            this.stepDown.Name = "stepDown";
            this.stepDown.Size = new System.Drawing.Size(155, 24);
            this.stepDown.TabIndex = 0;
            this.stepDown.TabStop = true;
            this.stepDown.Text = "Time Remaining";
            this.stepDown.UseVisualStyleBackColor = true;
            // 
            // unloadAll
            // 
            this.unloadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloadAll.Location = new System.Drawing.Point(634, 235);
            this.unloadAll.Name = "unloadAll";
            this.unloadAll.Size = new System.Drawing.Size(151, 49);
            this.unloadAll.TabIndex = 6;
            this.unloadAll.Text = "Unload All";
            this.unloadAll.UseVisualStyleBackColor = true;
            this.unloadAll.Click += new System.EventHandler(this.unloadAll_Click);
            // 
            // line5
            // 
            this.line5.Location = new System.Drawing.Point(12, 235);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(605, 50);
            this.line5.TabIndex = 4;
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(12, 180);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(656, 50);
            this.line4.TabIndex = 3;
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(12, 124);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(656, 50);
            this.line3.TabIndex = 2;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(12, 68);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(656, 50);
            this.line2.TabIndex = 1;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(12, 11);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(656, 50);
            this.line1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 297);
            this.Controls.Add(this.unloadAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RadioCART 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton stepUp;
        public System.Windows.Forms.RadioButton stepDown;
        private System.Windows.Forms.Button unloadAll;





    }
}

