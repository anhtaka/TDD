namespace TDD.UI
{
    partial class Form1View
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
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalucationBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(95, 75);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(183, 31);
            this.ATextBox.TabIndex = 0;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(350, 75);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(206, 31);
            this.BTextBox.TabIndex = 1;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(611, 78);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(67, 24);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "label1";
            // 
            // CalucationBotton
            // 
            this.CalucationBotton.Location = new System.Drawing.Point(205, 168);
            this.CalucationBotton.Name = "CalucationBotton";
            this.CalucationBotton.Size = new System.Drawing.Size(228, 79);
            this.CalucationBotton.TabIndex = 3;
            this.CalucationBotton.Text = "button1";
            this.CalucationBotton.UseVisualStyleBackColor = true;
            this.CalucationBotton.Click += new System.EventHandler(this.CalucationBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 364);
            this.Controls.Add(this.CalucationBotton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalucationBotton;
    }
}

