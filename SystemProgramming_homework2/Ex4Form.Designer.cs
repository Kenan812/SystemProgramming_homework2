namespace SystemProgramming_homework2
{
    partial class Ex4Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.nbOfOccurTxtBox = new System.Windows.Forms.TextBox();
            this.wordToFindTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word to find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of occurances";
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(236, 40);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(515, 31);
            this.filePathTxtBox.TabIndex = 3;
            // 
            // nbOfOccurTxtBox
            // 
            this.nbOfOccurTxtBox.Location = new System.Drawing.Point(236, 163);
            this.nbOfOccurTxtBox.Name = "nbOfOccurTxtBox";
            this.nbOfOccurTxtBox.Size = new System.Drawing.Size(515, 31);
            this.nbOfOccurTxtBox.TabIndex = 4;
            // 
            // wordToFindTxtBox
            // 
            this.wordToFindTxtBox.Location = new System.Drawing.Point(236, 100);
            this.wordToFindTxtBox.Name = "wordToFindTxtBox";
            this.wordToFindTxtBox.Size = new System.Drawing.Size(515, 31);
            this.wordToFindTxtBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ex4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordToFindTxtBox);
            this.Controls.Add(this.nbOfOccurTxtBox);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex4Form";
            this.Text = "Ex4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.TextBox nbOfOccurTxtBox;
        private System.Windows.Forms.TextBox wordToFindTxtBox;
        private System.Windows.Forms.Button button1;
    }
}