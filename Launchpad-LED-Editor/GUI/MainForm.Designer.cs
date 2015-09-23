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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.ledGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customtable = new System.Windows.Forms.TableLayoutPanel();
            this.colors_Edit = new System.Windows.Forms.Button();
            this.panel_currentColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_red = new System.Windows.Forms.Panel();
            this.panel_yellow = new System.Windows.Forms.Panel();
            this.panel_orange = new System.Windows.Forms.Panel();
            this.panel_blue = new System.Windows.Forms.Panel();
            this.panel_lightBlue = new System.Windows.Forms.Panel();
            this.panel_lime = new System.Windows.Forms.Panel();
            this.panel_green = new System.Windows.Forms.Panel();
            this.panel_white = new System.Windows.Forms.Panel();
            this.panel_clear = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scroll_Stop = new System.Windows.Forms.Button();
            this.scroll_Start = new System.Windows.Forms.Button();
            this.scroll_Loop = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scroll_Speed = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scroll_Text = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorBubble = new System.Windows.Forms.ToolTip(this.components);
            this.timer_UpdateCenter = new System.Windows.Forms.Timer(this.components);
            this.timer_checkColorWindow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.transparentPanel1 = new Launchpad_LED_Editor.TransparentPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ledGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            "Launchpad MK2",
            "Launchpad Mini",
            "Launchpad Pro",
            "Launchpad S"});
            this.launchpadModels.Location = new System.Drawing.Point(126, 152);
            this.launchpadModels.Name = "launchpadModels";
            this.launchpadModels.Size = new System.Drawing.Size(136, 24);
            this.launchpadModels.TabIndex = 11;
            this.launchpadModels.SelectedIndexChanged += new System.EventHandler(this.launchpadModels_SelectedIndexChanged);
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
            // ledGroup
            // 
            this.ledGroup.Controls.Add(this.transparentPanel1);
            this.ledGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ledGroup.ForeColor = System.Drawing.Color.Gold;
            this.ledGroup.Location = new System.Drawing.Point(278, -2);
            this.ledGroup.Name = "ledGroup";
            this.ledGroup.Size = new System.Drawing.Size(485, 436);
            this.ledGroup.TabIndex = 1;
            this.ledGroup.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.customtable);
            this.groupBox2.Controls.Add(this.colors_Edit);
            this.groupBox2.Controls.Add(this.panel_currentColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.panel_clear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(4, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Location = new System.Drawing.Point(6, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 3);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // customtable
            // 
            this.customtable.ColumnCount = 10;
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.customtable.Location = new System.Drawing.Point(8, 68);
            this.customtable.Name = "customtable";
            this.customtable.RowCount = 2;
            this.customtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customtable.Size = new System.Drawing.Size(249, 51);
            this.customtable.TabIndex = 15;
            // 
            // colors_Edit
            // 
            this.colors_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colors_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colors_Edit.Location = new System.Drawing.Point(217, 125);
            this.colors_Edit.Name = "colors_Edit";
            this.colors_Edit.Size = new System.Drawing.Size(45, 23);
            this.colors_Edit.TabIndex = 14;
            this.colors_Edit.Text = "Edit";
            this.colors_Edit.UseVisualStyleBackColor = true;
            this.colors_Edit.Click += new System.EventHandler(this.colors_Edit_Click);
            // 
            // panel_currentColor
            // 
            this.panel_currentColor.BackColor = System.Drawing.Color.Gray;
            this.panel_currentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_currentColor.Location = new System.Drawing.Point(97, 127);
            this.panel_currentColor.Name = "panel_currentColor";
            this.panel_currentColor.Size = new System.Drawing.Size(20, 20);
            this.panel_currentColor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current Color:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel_red, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_yellow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_orange, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_blue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_lightBlue, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_lime, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_green, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_white, 6, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Red;
            this.panel_red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_red.Location = new System.Drawing.Point(3, 3);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(19, 19);
            this.panel_red.TabIndex = 0;
            this.panel_red.Click += new System.EventHandler(this.panel_red_Click);
            // 
            // panel_yellow
            // 
            this.panel_yellow.BackColor = System.Drawing.Color.Yellow;
            this.panel_yellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_yellow.Location = new System.Drawing.Point(53, 3);
            this.panel_yellow.Name = "panel_yellow";
            this.panel_yellow.Size = new System.Drawing.Size(19, 19);
            this.panel_yellow.TabIndex = 2;
            this.panel_yellow.Click += new System.EventHandler(this.panel_yellow_Click);
            // 
            // panel_orange
            // 
            this.panel_orange.BackColor = System.Drawing.Color.Orange;
            this.panel_orange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_orange.Location = new System.Drawing.Point(78, 3);
            this.panel_orange.Name = "panel_orange";
            this.panel_orange.Size = new System.Drawing.Size(19, 19);
            this.panel_orange.TabIndex = 3;
            this.panel_orange.Click += new System.EventHandler(this.panel_orange_Click);
            // 
            // panel_blue
            // 
            this.panel_blue.BackColor = System.Drawing.Color.Blue;
            this.panel_blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_blue.Location = new System.Drawing.Point(103, 3);
            this.panel_blue.Name = "panel_blue";
            this.panel_blue.Size = new System.Drawing.Size(19, 19);
            this.panel_blue.TabIndex = 4;
            this.panel_blue.Click += new System.EventHandler(this.panel_blue_Click);
            // 
            // panel_lightBlue
            // 
            this.panel_lightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.panel_lightBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lightBlue.Location = new System.Drawing.Point(128, 3);
            this.panel_lightBlue.Name = "panel_lightBlue";
            this.panel_lightBlue.Size = new System.Drawing.Size(19, 19);
            this.panel_lightBlue.TabIndex = 5;
            this.panel_lightBlue.Click += new System.EventHandler(this.panel_lightBlue_Click);
            // 
            // panel_lime
            // 
            this.panel_lime.BackColor = System.Drawing.Color.Lime;
            this.panel_lime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lime.Location = new System.Drawing.Point(178, 3);
            this.panel_lime.Name = "panel_lime";
            this.panel_lime.Size = new System.Drawing.Size(19, 19);
            this.panel_lime.TabIndex = 7;
            this.panel_lime.Click += new System.EventHandler(this.panel_lime_Click);
            // 
            // panel_green
            // 
            this.panel_green.BackColor = System.Drawing.Color.Green;
            this.panel_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_green.Location = new System.Drawing.Point(28, 3);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(19, 19);
            this.panel_green.TabIndex = 1;
            this.panel_green.Click += new System.EventHandler(this.panel_green_Click);
            // 
            // panel_white
            // 
            this.panel_white.BackColor = System.Drawing.Color.White;
            this.panel_white.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_white.Location = new System.Drawing.Point(153, 3);
            this.panel_white.Name = "panel_white";
            this.panel_white.Size = new System.Drawing.Size(19, 19);
            this.panel_white.TabIndex = 6;
            this.panel_white.Click += new System.EventHandler(this.panel_white_Click);
            // 
            // panel_clear
            // 
            this.panel_clear.BackColor = System.Drawing.Color.Gray;
            this.panel_clear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_clear.Location = new System.Drawing.Point(239, 21);
            this.panel_clear.Name = "panel_clear";
            this.panel_clear.Size = new System.Drawing.Size(19, 19);
            this.panel_clear.TabIndex = 8;
            this.panel_clear.Click += new System.EventHandler(this.panel_clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scroll_Stop);
            this.groupBox3.Controls.Add(this.scroll_Start);
            this.groupBox3.Controls.Add(this.scroll_Loop);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.scroll_Speed);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.scroll_Text);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(4, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 138);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Scroll";
            // 
            // scroll_Stop
            // 
            this.scroll_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scroll_Stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scroll_Stop.Location = new System.Drawing.Point(113, 99);
            this.scroll_Stop.Name = "scroll_Stop";
            this.scroll_Stop.Size = new System.Drawing.Size(82, 26);
            this.scroll_Stop.TabIndex = 17;
            this.scroll_Stop.Text = "Terminate";
            this.scroll_Stop.UseVisualStyleBackColor = true;
            this.scroll_Stop.Click += new System.EventHandler(this.scroll_Stop_Click);
            // 
            // scroll_Start
            // 
            this.scroll_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scroll_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scroll_Start.Location = new System.Drawing.Point(9, 99);
            this.scroll_Start.Name = "scroll_Start";
            this.scroll_Start.Size = new System.Drawing.Size(99, 26);
            this.scroll_Start.TabIndex = 12;
            this.scroll_Start.Text = "Start Scrolling";
            this.scroll_Start.UseVisualStyleBackColor = true;
            this.scroll_Start.Click += new System.EventHandler(this.scroll_Start_Click);
            // 
            // scroll_Loop
            // 
            this.scroll_Loop.AutoSize = true;
            this.scroll_Loop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scroll_Loop.ForeColor = System.Drawing.Color.White;
            this.scroll_Loop.Location = new System.Drawing.Point(48, 80);
            this.scroll_Loop.Name = "scroll_Loop";
            this.scroll_Loop.Size = new System.Drawing.Size(15, 14);
            this.scroll_Loop.TabIndex = 16;
            this.scroll_Loop.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Loop:";
            // 
            // scroll_Speed
            // 
            this.scroll_Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scroll_Speed.LargeChange = 7;
            this.scroll_Speed.Location = new System.Drawing.Point(91, 43);
            this.scroll_Speed.Maximum = 7;
            this.scroll_Speed.Minimum = 1;
            this.scroll_Speed.Name = "scroll_Speed";
            this.scroll_Speed.Size = new System.Drawing.Size(94, 45);
            this.scroll_Speed.TabIndex = 14;
            this.scroll_Speed.Value = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Scroll Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Text:";
            // 
            // scroll_Text
            // 
            this.scroll_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scroll_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scroll_Text.ForeColor = System.Drawing.Color.Orange;
            this.scroll_Text.Location = new System.Drawing.Point(46, 21);
            this.scroll_Text.Name = "scroll_Text";
            this.scroll_Text.Size = new System.Drawing.Size(212, 22);
            this.scroll_Text.TabIndex = 0;
            this.scroll_Text.TextChanged += new System.EventHandler(this.scroll_Text_TextChanged);
            // 
            // mainToolTip
            // 
            this.mainToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainToolTip.ForeColor = System.Drawing.Color.Gold;
            // 
            // errorBubble
            // 
            this.errorBubble.IsBalloon = true;
            this.errorBubble.ShowAlways = true;
            this.errorBubble.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.errorBubble.ToolTipTitle = "Something strange.";
            // 
            // timer_UpdateCenter
            // 
            this.timer_UpdateCenter.Enabled = true;
            this.timer_UpdateCenter.Interval = 500;
            this.timer_UpdateCenter.Tick += new System.EventHandler(this.timer_UpdateCenter_Tick);
            // 
            // timer_checkColorWindow
            // 
            this.timer_checkColorWindow.Interval = 250;
            this.timer_checkColorWindow.Tick += new System.EventHandler(this.timer_checkColorWindow_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Launchpad_LED_Editor.Properties.Resources.credits;
            this.pictureBox3.Location = new System.Drawing.Point(278, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(428, 45);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Location = new System.Drawing.Point(191, 192);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(50, 50);
            this.transparentPanel1.TabIndex = 0;
            this.transparentPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.transparentPanel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(769, 488);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ledGroup);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVATION Launchpad LED Editor v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ledGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.GroupBox ledGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.Panel panel_yellow;
        private System.Windows.Forms.Panel panel_orange;
        private System.Windows.Forms.Panel panel_blue;
        private System.Windows.Forms.Panel panel_lightBlue;
        private System.Windows.Forms.Panel panel_white;
        private System.Windows.Forms.Panel panel_lime;
        private System.Windows.Forms.Panel panel_currentColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox scroll_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar scroll_Speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox scroll_Loop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Button scroll_Start;
        private System.Windows.Forms.Button scroll_Stop;
        private System.Windows.Forms.ToolTip errorBubble;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Timer timer_UpdateCenter;
        private System.Windows.Forms.Button colors_Edit;
        private System.Windows.Forms.Timer timer_checkColorWindow;
        private System.Windows.Forms.TableLayoutPanel customtable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

