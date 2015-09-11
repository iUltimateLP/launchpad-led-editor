namespace Launchpad_LED_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.launchpadModels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.midi_testDevices = new System.Windows.Forms.Button();
            this.midi_OutputState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.midi_outputDevices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.midi_InputState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.midi_inputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.launchpadModels);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.midi_testDevices);
            this.groupBox1.Controls.Add(this.midi_OutputState);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.midi_outputDevices);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.midi_InputState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.midi_inputDevices);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // launchpadModels
            // 
            this.launchpadModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.launchpadModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.launchpadModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchpadModels.ForeColor = System.Drawing.Color.Gold;
            this.launchpadModels.FormattingEnabled = true;
            this.launchpadModels.Items.AddRange(new object[] {
            "Launchpad",
            "Launchpad MK2",
            "Launchpad Mini",
            "Launchpad Pro",
            "Launchpad S"});
            this.launchpadModels.Location = new System.Drawing.Point(126, 152);
            this.launchpadModels.Name = "launchpadModels";
            this.launchpadModels.Size = new System.Drawing.Size(136, 24);
            this.launchpadModels.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Launchpad Model:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(8, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 3);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // midi_testDevices
            // 
            this.midi_testDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_testDevices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.midi_testDevices.Location = new System.Drawing.Point(7, 114);
            this.midi_testDevices.Name = "midi_testDevices";
            this.midi_testDevices.Size = new System.Drawing.Size(79, 23);
            this.midi_testDevices.TabIndex = 8;
            this.midi_testDevices.Text = "Test";
            this.midi_testDevices.UseVisualStyleBackColor = true;
            this.midi_testDevices.Click += new System.EventHandler(this.midi_testDevices_Click);
            // 
            // midi_OutputState
            // 
            this.midi_OutputState.AutoSize = true;
            this.midi_OutputState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_OutputState.Location = new System.Drawing.Point(104, 90);
            this.midi_OutputState.Name = "midi_OutputState";
            this.midi_OutputState.Size = new System.Drawing.Size(81, 16);
            this.midi_OutputState.TabIndex = 7;
            this.midi_OutputState.Text = "<state here>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Status:";
            // 
            // midi_outputDevices
            // 
            this.midi_outputDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.midi_outputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midi_outputDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_outputDevices.ForeColor = System.Drawing.Color.Gold;
            this.midi_outputDevices.FormattingEnabled = true;
            this.midi_outputDevices.Location = new System.Drawing.Point(103, 64);
            this.midi_outputDevices.Name = "midi_outputDevices";
            this.midi_outputDevices.Size = new System.Drawing.Size(159, 24);
            this.midi_outputDevices.TabIndex = 5;
            this.midi_outputDevices.SelectedIndexChanged += new System.EventHandler(this.midi_outputDevices_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output Device:";
            // 
            // midi_InputState
            // 
            this.midi_InputState.AutoSize = true;
            this.midi_InputState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_InputState.Location = new System.Drawing.Point(104, 43);
            this.midi_InputState.Name = "midi_InputState";
            this.midi_InputState.Size = new System.Drawing.Size(81, 16);
            this.midi_InputState.TabIndex = 3;
            this.midi_InputState.Text = "<state here>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Status:";
            // 
            // midi_inputDevices
            // 
            this.midi_inputDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.midi_inputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midi_inputDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_inputDevices.ForeColor = System.Drawing.Color.Gold;
            this.midi_inputDevices.FormattingEnabled = true;
            this.midi_inputDevices.Location = new System.Drawing.Point(103, 14);
            this.midi_inputDevices.Name = "midi_inputDevices";
            this.midi_inputDevices.Size = new System.Drawing.Size(158, 24);
            this.midi_inputDevices.TabIndex = 1;
            this.midi_inputDevices.SelectedIndexChanged += new System.EventHandler(this.midi_inputDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Device:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(265, 277);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(596, 475);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVATION Launchpad LED Editor v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label midi_InputState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox midi_inputDevices;
        private System.Windows.Forms.Label midi_OutputState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox midi_outputDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button midi_testDevices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox launchpadModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

