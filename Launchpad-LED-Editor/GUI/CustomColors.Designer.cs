namespace Launchpad_LED_Editor
{
    partial class CustomColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomColors));
            this.colorList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addColor = new System.Windows.Forms.Button();
            this.removeColor = new System.Windows.Forms.Button();
            this.editColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorList
            // 
            this.colorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.colorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.colorList.ForeColor = System.Drawing.Color.Gold;
            this.colorList.FullRowSelect = true;
            this.colorList.Location = new System.Drawing.Point(5, 5);
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(274, 208);
            this.colorList.TabIndex = 0;
            this.colorList.UseCompatibleStateImageBehavior = false;
            this.colorList.View = System.Windows.Forms.View.Details;
            this.colorList.SelectedIndexChanged += new System.EventHandler(this.colorList_SelectedIndexChanged);
            this.colorList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.colorList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Velocity";
            // 
            // addColor
            // 
            this.addColor.Location = new System.Drawing.Point(5, 220);
            this.addColor.Name = "addColor";
            this.addColor.Size = new System.Drawing.Size(75, 23);
            this.addColor.TabIndex = 1;
            this.addColor.Text = "Add";
            this.addColor.UseVisualStyleBackColor = true;
            this.addColor.Click += new System.EventHandler(this.addColor_Click);
            // 
            // removeColor
            // 
            this.removeColor.Location = new System.Drawing.Point(106, 220);
            this.removeColor.Name = "removeColor";
            this.removeColor.Size = new System.Drawing.Size(75, 23);
            this.removeColor.TabIndex = 2;
            this.removeColor.Text = "Remove";
            this.removeColor.UseVisualStyleBackColor = true;
            this.removeColor.Click += new System.EventHandler(this.removeColor_Click);
            // 
            // editColor
            // 
            this.editColor.Location = new System.Drawing.Point(204, 220);
            this.editColor.Name = "editColor";
            this.editColor.Size = new System.Drawing.Size(75, 23);
            this.editColor.TabIndex = 3;
            this.editColor.Text = "Edit";
            this.editColor.UseVisualStyleBackColor = true;
            this.editColor.Click += new System.EventHandler(this.editColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(4, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "In the forum thread is a explanation on this!";
            // 
            // CustomColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editColor);
            this.Controls.Add(this.removeColor);
            this.Controls.Add(this.addColor);
            this.Controls.Add(this.colorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomColors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Editor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomColors_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView colorList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button addColor;
        private System.Windows.Forms.Button removeColor;
        private System.Windows.Forms.Button editColor;
        private System.Windows.Forms.Label label1;
    }
}