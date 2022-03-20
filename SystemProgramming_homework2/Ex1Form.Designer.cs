namespace SystemProgramming_homework2
{
    partial class Ex1Form
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
            this.nTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pBarGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // nTxtBox
            // 
            this.nTxtBox.Location = new System.Drawing.Point(234, 18);
            this.nTxtBox.Name = "nTxtBox";
            this.nTxtBox.Size = new System.Drawing.Size(58, 31);
            this.nTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of progess bars";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(346, 16);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 34);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pBarGroupBox
            // 
            this.pBarGroupBox.Location = new System.Drawing.Point(12, 66);
            this.pBarGroupBox.Name = "pBarGroupBox";
            this.pBarGroupBox.Size = new System.Drawing.Size(776, 316);
            this.pBarGroupBox.TabIndex = 3;
            this.pBarGroupBox.TabStop = false;
            this.pBarGroupBox.Text = "Progress bars";
            // 
            // Ex1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.pBarGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nTxtBox);
            this.Name = "Ex1Form";
            this.Text = "Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox pBarGroupBox;
    }
}