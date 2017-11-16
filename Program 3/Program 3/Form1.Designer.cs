namespace Program_3
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.creditBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.timeAnswer = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(31, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // creditBox
            // 
            this.creditBox.Location = new System.Drawing.Point(235, 53);
            this.creditBox.Name = "creditBox";
            this.creditBox.Size = new System.Drawing.Size(100, 20);
            this.creditBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Write your last name:";
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(188, 37);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(183, 13);
            this.creditHoursLabel.TabIndex = 3;
            this.creditHoursLabel.Text = "How many credit hours do you have?";
            // 
            // timeAnswer
            // 
            this.timeAnswer.Location = new System.Drawing.Point(94, 143);
            this.timeAnswer.Name = "timeAnswer";
            this.timeAnswer.Size = new System.Drawing.Size(194, 23);
            this.timeAnswer.TabIndex = 6;
            this.timeAnswer.Text = "\r\n";
            this.timeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(121, 121);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(129, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Earliest Registration Time:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(56, 214);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 214);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(260, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeAnswer);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.creditBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox creditBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label timeAnswer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

