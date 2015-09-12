namespace Launchpad_LED_Editor
{
    partial class TestingForm
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
            this.test_1 = new System.Windows.Forms.Label();
            this.test_2 = new System.Windows.Forms.Label();
            this.test_3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESTING MODE ACTIVE";
            // 
            // test_1
            // 
            this.test_1.AutoSize = true;
            this.test_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.test_1.ForeColor = System.Drawing.Color.Gold;
            this.test_1.Location = new System.Drawing.Point(13, 40);
            this.test_1.Name = "test_1";
            this.test_1.Size = new System.Drawing.Size(261, 16);
            this.test_1.TabIndex = 1;
            this.test_1.Text = "1. Press any key on your Launchpad.";
            // 
            // test_2
            // 
            this.test_2.AutoSize = true;
            this.test_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.test_2.ForeColor = System.Drawing.Color.Gold;
            this.test_2.Location = new System.Drawing.Point(13, 65);
            this.test_2.Name = "test_2";
            this.test_2.Size = new System.Drawing.Size(341, 16);
            this.test_2.TabIndex = 2;
            this.test_2.Text = "2. Check if any buttons light up. If yes, press that.";
            // 
            // test_3
            // 
            this.test_3.AutoSize = true;
            this.test_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.test_3.ForeColor = System.Drawing.Color.Gold;
            this.test_3.Location = new System.Drawing.Point(12, 90);
            this.test_3.Name = "test_3";
            this.test_3.Size = new System.Drawing.Size(136, 16);
            this.test_3.TabIndex = 3;
            this.test_3.Text = "3. Test completed.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Something isn\'t working.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(371, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test_3);
            this.Controls.Add(this.test_2);
            this.Controls.Add(this.test_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestingForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label test_1;
        private System.Windows.Forms.Label test_2;
        private System.Windows.Forms.Label test_3;
        private System.Windows.Forms.Button button1;
    }
}