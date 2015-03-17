namespace PowerCalculator
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
            this.rowLabel = new System.Windows.Forms.Label();
            this.colLabel = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.ComboBox();
            this.colBox = new System.Windows.Forms.ComboBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(40, 35);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(162, 13);
            this.rowLabel.TabIndex = 0;
            this.rowLabel.Text = "How Many Rows Do You Want?";
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(40, 95);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(175, 13);
            this.colLabel.TabIndex = 1;
            this.colLabel.Text = "How Many Columns Do You Want?";
            // 
            // rowBox
            // 
            this.rowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rowBox.FormattingEnabled = true;
            this.rowBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rowBox.Location = new System.Drawing.Point(257, 32);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(121, 21);
            this.rowBox.TabIndex = 2;
            // 
            // colBox
            // 
            this.colBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colBox.FormattingEnabled = true;
            this.colBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.colBox.Location = new System.Drawing.Point(257, 95);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(121, 21);
            this.colBox.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(85, 161);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrlBtn
            // 
            this.clrlBtn.Location = new System.Drawing.Point(280, 161);
            this.clrlBtn.Name = "clrlBtn";
            this.clrlBtn.Size = new System.Drawing.Size(75, 23);
            this.clrlBtn.TabIndex = 5;
            this.clrlBtn.Text = "Clear";
            this.clrlBtn.UseVisualStyleBackColor = true;
            this.clrlBtn.Click += new System.EventHandler(this.clrlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.clrlBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.colBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.rowLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.ComboBox rowBox;
        private System.Windows.Forms.ComboBox colBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrlBtn;
    }
}

