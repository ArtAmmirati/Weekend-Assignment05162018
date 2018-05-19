namespace _9_6_Food_Facts
{
    partial class mainForm
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
            this.banannaradioButton1 = new System.Windows.Forms.RadioButton();
            this.popcornradioButton2 = new System.Windows.Forms.RadioButton();
            this.muffinradioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.displaybutton1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // banannaradioButton1
            // 
            this.banannaradioButton1.AutoSize = true;
            this.banannaradioButton1.Location = new System.Drawing.Point(12, 36);
            this.banannaradioButton1.Name = "banannaradioButton1";
            this.banannaradioButton1.Size = new System.Drawing.Size(77, 17);
            this.banannaradioButton1.TabIndex = 0;
            this.banannaradioButton1.TabStop = true;
            this.banannaradioButton1.Text = "1 Bananna";
            this.banannaradioButton1.UseVisualStyleBackColor = true;
            // 
            // popcornradioButton2
            // 
            this.popcornradioButton2.AutoSize = true;
            this.popcornradioButton2.Location = new System.Drawing.Point(12, 71);
            this.popcornradioButton2.Name = "popcornradioButton2";
            this.popcornradioButton2.Size = new System.Drawing.Size(159, 17);
            this.popcornradioButton2.TabIndex = 1;
            this.popcornradioButton2.TabStop = true;
            this.popcornradioButton2.Text = "1 cup of air-popped popcorn";
            this.popcornradioButton2.UseVisualStyleBackColor = true;
            // 
            // muffinradioButton3
            // 
            this.muffinradioButton3.AutoSize = true;
            this.muffinradioButton3.Location = new System.Drawing.Point(12, 110);
            this.muffinradioButton3.Name = "muffinradioButton3";
            this.muffinradioButton3.Size = new System.Drawing.Size(134, 17);
            this.muffinradioButton3.TabIndex = 2;
            this.muffinradioButton3.TabStop = true;
            this.muffinradioButton3.Text = "1 large blueberry muffin";
            this.muffinradioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a Food";
            // 
            // displaybutton1
            // 
            this.displaybutton1.Location = new System.Drawing.Point(12, 150);
            this.displaybutton1.Name = "displaybutton1";
            this.displaybutton1.Size = new System.Drawing.Size(75, 63);
            this.displaybutton1.TabIndex = 4;
            this.displaybutton1.Text = "Display Food Facts";
            this.displaybutton1.UseVisualStyleBackColor = true;
            this.displaybutton1.Click += new System.EventHandler(this.displaybutton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(135, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 63);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displaybutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muffinradioButton3);
            this.Controls.Add(this.popcornradioButton2);
            this.Controls.Add(this.banannaradioButton1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton banannaradioButton1;
        private System.Windows.Forms.RadioButton popcornradioButton2;
        private System.Windows.Forms.RadioButton muffinradioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displaybutton1;
        private System.Windows.Forms.Button exitButton;
    }
}