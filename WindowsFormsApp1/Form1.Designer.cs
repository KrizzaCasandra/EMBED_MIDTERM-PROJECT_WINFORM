namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startgameLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.one_playerbtn = new System.Windows.Forms.Button();
            this.two_playerBtn = new System.Windows.Forms.Button();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.iunderstandBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.testlabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.chooselabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.player_onelabel = new System.Windows.Forms.Label();
            this.level_onelabel = new System.Windows.Forms.Label();
            this.playerOnelabel = new System.Windows.Forms.Label();
            this.LevelOnelabel = new System.Windows.Forms.Label();
            this.completedlabel = new System.Windows.Forms.Label();
            this.nextlevelBtn = new System.Windows.Forms.Button();
            this.levelone_Label2 = new System.Windows.Forms.Label();
            this.playertwo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.Lime;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(944, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 31);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 5;
            // 
            // startgameLabel
            // 
            this.startgameLabel.BackColor = System.Drawing.Color.Transparent;
            this.startgameLabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgameLabel.ForeColor = System.Drawing.Color.Lime;
            this.startgameLabel.Location = new System.Drawing.Point(218, 225);
            this.startgameLabel.Name = "startgameLabel";
            this.startgameLabel.Size = new System.Drawing.Size(722, 213);
            this.startgameLabel.TabIndex = 7;
            this.startgameLabel.Text = "MEMORY GAME \r\nCHALLENGE";
            this.startgameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startgameLabel.UseMnemonic = false;
            // 
            // one_playerbtn
            // 
            this.one_playerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.one_playerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.one_playerbtn.FlatAppearance.BorderSize = 2;
            this.one_playerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_playerbtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_playerbtn.ForeColor = System.Drawing.Color.Lime;
            this.one_playerbtn.Location = new System.Drawing.Point(402, 255);
            this.one_playerbtn.Name = "one_playerbtn";
            this.one_playerbtn.Size = new System.Drawing.Size(254, 87);
            this.one_playerbtn.TabIndex = 8;
            this.one_playerbtn.Text = "1 PLAYER";
            this.one_playerbtn.UseVisualStyleBackColor = false;
            // 
            // two_playerBtn
            // 
            this.two_playerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.two_playerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.two_playerBtn.FlatAppearance.BorderSize = 2;
            this.two_playerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_playerBtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_playerBtn.ForeColor = System.Drawing.Color.Lime;
            this.two_playerBtn.Location = new System.Drawing.Point(402, 366);
            this.two_playerBtn.Name = "two_playerBtn";
            this.two_playerBtn.Size = new System.Drawing.Size(254, 87);
            this.two_playerBtn.TabIndex = 9;
            this.two_playerBtn.Text = "2 PLAYER";
            this.two_playerBtn.UseVisualStyleBackColor = false;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.ForeColor = System.Drawing.Color.Lime;
            this.InstructionLabel.Location = new System.Drawing.Point(42, 58);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(235, 35);
            this.InstructionLabel.TabIndex = 10;
            this.InstructionLabel.Text = "INSTRUCTION";
            this.InstructionLabel.Visible = false;
            // 
            // iunderstandBtn
            // 
            this.iunderstandBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iunderstandBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.iunderstandBtn.FlatAppearance.BorderSize = 2;
            this.iunderstandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iunderstandBtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iunderstandBtn.ForeColor = System.Drawing.Color.Lime;
            this.iunderstandBtn.Location = new System.Drawing.Point(854, 571);
            this.iunderstandBtn.Name = "iunderstandBtn";
            this.iunderstandBtn.Size = new System.Drawing.Size(180, 50);
            this.iunderstandBtn.TabIndex = 12;
            this.iunderstandBtn.Text = "I UNDERSTAND";
            this.iunderstandBtn.UseVisualStyleBackColor = false;
            this.iunderstandBtn.Visible = false;
            this.iunderstandBtn.Click += new System.EventHandler(this.iunderstandBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(47, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(987, 455);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.BackColor = System.Drawing.Color.Transparent;
            this.testlabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testlabel.ForeColor = System.Drawing.Color.White;
            this.testlabel.Location = new System.Drawing.Point(253, 147);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(795, 35);
            this.testlabel.TabIndex = 18;
            this.testlabel.Text = "Test your memory, focus, and attention!";
            this.testlabel.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.startBtn.FlatAppearance.BorderSize = 2;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Lime;
            this.startBtn.Location = new System.Drawing.Point(424, 430);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(254, 87);
            this.startBtn.TabIndex = 19;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // chooselabel
            // 
            this.chooselabel.AutoSize = true;
            this.chooselabel.BackColor = System.Drawing.Color.Transparent;
            this.chooselabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooselabel.ForeColor = System.Drawing.Color.Lime;
            this.chooselabel.Location = new System.Drawing.Point(356, 130);
            this.chooselabel.Name = "chooselabel";
            this.chooselabel.Size = new System.Drawing.Size(496, 65);
            this.chooselabel.TabIndex = 20;
            this.chooselabel.Text = "CHOOSE ONLY 1";
            this.chooselabel.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(48, 96);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(986, 455);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.backBtn.FlatAppearance.BorderSize = 2;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Lime;
            this.backBtn.Location = new System.Drawing.Point(48, 571);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(180, 50);
            this.backBtn.TabIndex = 22;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            // 
            // player_onelabel
            // 
            this.player_onelabel.AutoSize = true;
            this.player_onelabel.BackColor = System.Drawing.Color.Transparent;
            this.player_onelabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_onelabel.ForeColor = System.Drawing.Color.White;
            this.player_onelabel.Location = new System.Drawing.Point(350, 127);
            this.player_onelabel.Name = "player_onelabel";
            this.player_onelabel.Size = new System.Drawing.Size(466, 98);
            this.player_onelabel.TabIndex = 23;
            this.player_onelabel.Text = "PLAYER 1";
            // 
            // level_onelabel
            // 
            this.level_onelabel.AutoSize = true;
            this.level_onelabel.BackColor = System.Drawing.Color.Transparent;
            this.level_onelabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_onelabel.ForeColor = System.Drawing.Color.Lime;
            this.level_onelabel.Location = new System.Drawing.Point(174, 280);
            this.level_onelabel.Name = "level_onelabel";
            this.level_onelabel.Size = new System.Drawing.Size(872, 137);
            this.level_onelabel.TabIndex = 24;
            this.level_onelabel.Text = "> LEVEL 1 <";
            // 
            // playerOnelabel
            // 
            this.playerOnelabel.AutoSize = true;
            this.playerOnelabel.BackColor = System.Drawing.Color.Transparent;
            this.playerOnelabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOnelabel.ForeColor = System.Drawing.Color.White;
            this.playerOnelabel.Location = new System.Drawing.Point(497, 103);
            this.playerOnelabel.Name = "playerOnelabel";
            this.playerOnelabel.Size = new System.Drawing.Size(159, 33);
            this.playerOnelabel.TabIndex = 25;
            this.playerOnelabel.Text = "PLAYER 1";
            // 
            // LevelOnelabel
            // 
            this.LevelOnelabel.AutoSize = true;
            this.LevelOnelabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelOnelabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelOnelabel.ForeColor = System.Drawing.Color.White;
            this.LevelOnelabel.Location = new System.Drawing.Point(306, 182);
            this.LevelOnelabel.Name = "LevelOnelabel";
            this.LevelOnelabel.Size = new System.Drawing.Size(625, 98);
            this.LevelOnelabel.TabIndex = 26;
            this.LevelOnelabel.Text = "> LEVEL 1 <";
            // 
            // completedlabel
            // 
            this.completedlabel.AutoSize = true;
            this.completedlabel.BackColor = System.Drawing.Color.Transparent;
            this.completedlabel.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 94.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedlabel.ForeColor = System.Drawing.Color.Lime;
            this.completedlabel.Location = new System.Drawing.Point(254, 298);
            this.completedlabel.Name = "completedlabel";
            this.completedlabel.Size = new System.Drawing.Size(745, 129);
            this.completedlabel.TabIndex = 27;
            this.completedlabel.Text = "COMPLETED!";
            // 
            // nextlevelBtn
            // 
            this.nextlevelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nextlevelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.nextlevelBtn.FlatAppearance.BorderSize = 2;
            this.nextlevelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextlevelBtn.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextlevelBtn.ForeColor = System.Drawing.Color.Lime;
            this.nextlevelBtn.Location = new System.Drawing.Point(462, 501);
            this.nextlevelBtn.Name = "nextlevelBtn";
            this.nextlevelBtn.Size = new System.Drawing.Size(180, 50);
            this.nextlevelBtn.TabIndex = 28;
            this.nextlevelBtn.Text = "NEXT LEVEL";
            this.nextlevelBtn.UseVisualStyleBackColor = false;
            this.nextlevelBtn.Visible = false;
            // 
            // levelone_Label2
            // 
            this.levelone_Label2.AccessibleName = "";
            this.levelone_Label2.AutoSize = true;
            this.levelone_Label2.BackColor = System.Drawing.Color.Transparent;
            this.levelone_Label2.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelone_Label2.ForeColor = System.Drawing.Color.Lime;
            this.levelone_Label2.Location = new System.Drawing.Point(164, 280);
            this.levelone_Label2.Name = "levelone_Label2";
            this.levelone_Label2.Size = new System.Drawing.Size(872, 137);
            this.levelone_Label2.TabIndex = 30;
            this.levelone_Label2.Text = "> LEVEL 1 <";
            // 
            // playertwo_label
            // 
            this.playertwo_label.AccessibleName = "";
            this.playertwo_label.AutoSize = true;
            this.playertwo_label.BackColor = System.Drawing.Color.Transparent;
            this.playertwo_label.Font = new System.Drawing.Font("ProggyCleanTTSZBP", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playertwo_label.ForeColor = System.Drawing.Color.White;
            this.playertwo_label.Location = new System.Drawing.Point(347, 127);
            this.playertwo_label.Name = "playertwo_label";
            this.playertwo_label.Size = new System.Drawing.Size(466, 98);
            this.playertwo_label.TabIndex = 29;
            this.playertwo_label.Text = "PLAYER 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.memory_game_bg_1920x1080;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.levelone_Label2);
            this.Controls.Add(this.playertwo_label);
            this.Controls.Add(this.nextlevelBtn);
            this.Controls.Add(this.completedlabel);
            this.Controls.Add(this.LevelOnelabel);
            this.Controls.Add(this.playerOnelabel);
            this.Controls.Add(this.level_onelabel);
            this.Controls.Add(this.player_onelabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.chooselabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.iunderstandBtn);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.two_playerBtn);
            this.Controls.Add(this.one_playerbtn);
            this.Controls.Add(this.startgameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startgameLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button one_playerbtn;
        private System.Windows.Forms.Button two_playerBtn;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button iunderstandBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label chooselabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label player_onelabel;
        private System.Windows.Forms.Label level_onelabel;
        private System.Windows.Forms.Label playerOnelabel;
        private System.Windows.Forms.Label LevelOnelabel;
        private System.Windows.Forms.Label completedlabel;
        private System.Windows.Forms.Button nextlevelBtn;
        private System.Windows.Forms.Label levelone_Label2;
        private System.Windows.Forms.Label playertwo_label;
    }
}

