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
            this.label1 = new System.Windows.Forms.Label();
            this.registrationBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monsterBox = new System.Windows.Forms.GroupBox();
            this.monsterLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.energyBar = new System.Windows.Forms.ProgressBar();
            this.playerDataBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.registrationBox.SuspendLayout();
            this.monsterBox.SuspendLayout();
            this.playerDataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registrationBox
            // 
            this.registrationBox.Controls.Add(this.button1);
            this.registrationBox.Controls.Add(this.label3);
            this.registrationBox.Controls.Add(this.radioButton3);
            this.registrationBox.Controls.Add(this.radioButton2);
            this.registrationBox.Controls.Add(this.radioButton1);
            this.registrationBox.Controls.Add(this.playerNameBox);
            this.registrationBox.Controls.Add(this.label2);
            this.registrationBox.Location = new System.Drawing.Point(12, 75);
            this.registrationBox.Name = "registrationBox";
            this.registrationBox.Size = new System.Drawing.Size(398, 239);
            this.registrationBox.TabIndex = 10;
            this.registrationBox.TabStop = false;
            this.registrationBox.Text = "Створення персонажа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Створити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Виберіть ваш клас:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 191);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 30);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Розбійник";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 30);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Танк";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 119);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 30);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Варвар";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(144, 43);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(227, 34);
            this.playerNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ваш нікнейм:";
            // 
            // monsterBox
            // 
            this.monsterBox.Controls.Add(this.monsterLevel);
            this.monsterBox.Controls.Add(this.label6);
            this.monsterBox.Controls.Add(this.monsterHealthBar);
            this.monsterBox.Location = new System.Drawing.Point(486, 47);
            this.monsterBox.Name = "monsterBox";
            this.monsterBox.Size = new System.Drawing.Size(453, 129);
            this.monsterBox.TabIndex = 11;
            this.monsterBox.TabStop = false;
            this.monsterBox.Visible = false;
            // 
            // monsterLevel
            // 
            this.monsterLevel.AutoSize = true;
            this.monsterLevel.Location = new System.Drawing.Point(79, 28);
            this.monsterLevel.Name = "monsterLevel";
            this.monsterLevel.Size = new System.Drawing.Size(24, 26);
            this.monsterLevel.TabIndex = 2;
            this.monsterLevel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Рівень.";
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Location = new System.Drawing.Point(11, 71);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(436, 23);
            this.monsterHealthBar.TabIndex = 0;
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.IndianRed;
            this.healthBar.Location = new System.Drawing.Point(11, 71);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(436, 23);
            this.healthBar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Рівень.";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(79, 28);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(24, 26);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // energyBar
            // 
            this.energyBar.BackColor = System.Drawing.SystemColors.Control;
            this.energyBar.Location = new System.Drawing.Point(11, 103);
            this.energyBar.Name = "energyBar";
            this.energyBar.Size = new System.Drawing.Size(436, 23);
            this.energyBar.TabIndex = 7;
            // 
            // playerDataBox
            // 
            this.playerDataBox.Controls.Add(this.button6);
            this.playerDataBox.Controls.Add(this.energyBar);
            this.playerDataBox.Controls.Add(this.button5);
            this.playerDataBox.Controls.Add(this.button4);
            this.playerDataBox.Controls.Add(this.button3);
            this.playerDataBox.Controls.Add(this.button2);
            this.playerDataBox.Controls.Add(this.levelLabel);
            this.playerDataBox.Controls.Add(this.label4);
            this.playerDataBox.Controls.Add(this.healthBar);
            this.playerDataBox.Location = new System.Drawing.Point(12, 47);
            this.playerDataBox.Name = "playerDataBox";
            this.playerDataBox.Size = new System.Drawing.Size(453, 489);
            this.playerDataBox.TabIndex = 2;
            this.playerDataBox.TabStop = false;
            this.playerDataBox.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "DoubleWeapon";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.monsterBox);
            this.Controls.Add(this.playerDataBox);
            this.Controls.Add(this.registrationBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "Мій додаток";
            this.registrationBox.ResumeLayout(false);
            this.registrationBox.PerformLayout();
            this.monsterBox.ResumeLayout(false);
            this.monsterBox.PerformLayout();
            this.playerDataBox.ResumeLayout(false);
            this.playerDataBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox registrationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox monsterBox;
        private System.Windows.Forms.Label monsterLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar monsterHealthBar;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar energyBar;
        private System.Windows.Forms.GroupBox playerDataBox;
        private System.Windows.Forms.Button button6;
    }
}

