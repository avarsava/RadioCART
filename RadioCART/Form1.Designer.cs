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
            this.line5 = new RadioCART.Line();
            this.line4 = new RadioCART.Line();
            this.line3 = new RadioCART.Line();
            this.line2 = new RadioCART.Line();
            this.line1 = new RadioCART.Line();
            this.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(686, 297);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Name = "Form1";
            this.Text = "RadioCART 0.0.1";
            this.ResumeLayout(false);

        }

        #endregion





    }
}

