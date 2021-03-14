
using System;

namespace WindowsFormsApp1
{
    partial class Lab_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rB_vinegar = new System.Windows.Forms.RadioButton();
            this.rB_columnMethod = new System.Windows.Forms.RadioButton();
            this.rB_railFence = new System.Windows.Forms.RadioButton();
            this.textBox_key = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.rB_decipher = new System.Windows.Forms.RadioButton();
            this.rB_encrypt = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem1,
            this.aboutDeveloperToolStripMenuItem});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.aboutProgramToolStripMenuItem.Text = "&Help";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem1
            // 
            this.aboutProgramToolStripMenuItem1.Name = "aboutProgramToolStripMenuItem1";
            this.aboutProgramToolStripMenuItem1.Size = new System.Drawing.Size(238, 30);
            this.aboutProgramToolStripMenuItem1.Text = "About program";
            this.aboutProgramToolStripMenuItem1.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem1_Click);
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.aboutDeveloperToolStripMenuItem.Text = "About developer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.rB_vinegar);
            this.groupBox2.Controls.Add(this.rB_columnMethod);
            this.groupBox2.Controls.Add(this.rB_railFence);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(16, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "encryption types";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rB_vinegar
            // 
            this.rB_vinegar.AutoSize = true;
            this.rB_vinegar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_vinegar.Location = new System.Drawing.Point(20, 105);
            this.rB_vinegar.Name = "rB_vinegar";
            this.rB_vinegar.Size = new System.Drawing.Size(292, 31);
            this.rB_vinegar.TabIndex = 2;
            this.rB_vinegar.TabStop = true;
            this.rB_vinegar.Text = "vinegar, прямой ключ (ru)";
            this.rB_vinegar.UseVisualStyleBackColor = true;
            this.rB_vinegar.CheckedChanged += new System.EventHandler(this.rd_vinegar_CheckedChanged);
            // 
            // rB_columnMethod
            // 
            this.rB_columnMethod.AutoSize = true;
            this.rB_columnMethod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_columnMethod.Location = new System.Drawing.Point(20, 69);
            this.rB_columnMethod.Name = "rB_columnMethod";
            this.rB_columnMethod.Size = new System.Drawing.Size(246, 31);
            this.rB_columnMethod.TabIndex = 1;
            this.rB_columnMethod.TabStop = true;
            this.rB_columnMethod.Text = "columnar method (en)";
            this.rB_columnMethod.UseVisualStyleBackColor = true;
            this.rB_columnMethod.CheckedChanged += new System.EventHandler(this.rB_columnMethod_CheckedChanged);
            // 
            // rB_railFence
            // 
            this.rB_railFence.AutoSize = true;
            this.rB_railFence.Checked = true;
            this.rB_railFence.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_railFence.Location = new System.Drawing.Point(20, 33);
            this.rB_railFence.Name = "rB_railFence";
            this.rB_railFence.Size = new System.Drawing.Size(168, 31);
            this.rB_railFence.TabIndex = 0;
            this.rB_railFence.TabStop = true;
            this.rB_railFence.Text = "rail fence (en)";
            this.rB_railFence.UseVisualStyleBackColor = true;
            this.rB_railFence.CheckedChanged += new System.EventHandler(this.rB_railFence_CheckedChanged);
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_key.Location = new System.Drawing.Point(106, 654);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(639, 34);
            this.textBox_key.TabIndex = 6;
            this.textBox_key.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(788, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.rB_decipher);
            this.groupBox_main.Controls.Add(this.rB_encrypt);
            this.groupBox_main.Controls.Add(this.groupBox2);
            this.groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_main.Location = new System.Drawing.Point(788, 74);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(377, 274);
            this.groupBox_main.TabIndex = 9;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "encryption";
            this.groupBox_main.Enter += new System.EventHandler(this.groupBox_main_Enter);
            // 
            // rB_decipher
            // 
            this.rB_decipher.AutoSize = true;
            this.rB_decipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_decipher.Location = new System.Drawing.Point(214, 47);
            this.rB_decipher.Name = "rB_decipher";
            this.rB_decipher.Size = new System.Drawing.Size(146, 36);
            this.rB_decipher.TabIndex = 7;
            this.rB_decipher.TabStop = true;
            this.rB_decipher.Text = "decipher";
            this.rB_decipher.UseVisualStyleBackColor = true;
            this.rB_decipher.CheckedChanged += new System.EventHandler(this.rB_decipher_CheckedChanged);
            // 
            // rB_encrypt
            // 
            this.rB_encrypt.AutoSize = true;
            this.rB_encrypt.Checked = true;
            this.rB_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_encrypt.Location = new System.Drawing.Point(16, 47);
            this.rB_encrypt.Name = "rB_encrypt";
            this.rB_encrypt.Size = new System.Drawing.Size(129, 36);
            this.rB_encrypt.TabIndex = 6;
            this.rB_encrypt.TabStop = true;
            this.rB_encrypt.Text = "encrypt";
            this.rB_encrypt.UseVisualStyleBackColor = true;
            this.rB_encrypt.CheckedChanged += new System.EventHandler(this.rB_encrypt_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.txt) | *.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(18, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 242);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(18, 391);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(727, 238);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.txt) | *.txt";
            // 
            // Lab_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1190, 700);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox_main);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab_1";
            this.Text = "Lab_1, Eugene Shadura, group 951007";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textBox_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rB_vinegar;
        private System.Windows.Forms.RadioButton rB_columnMethod;
        private System.Windows.Forms.RadioButton rB_railFence;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.RadioButton rB_decipher;
        private System.Windows.Forms.RadioButton rB_encrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private EventHandler radioButton3_CheckedChanged;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
    }
}

