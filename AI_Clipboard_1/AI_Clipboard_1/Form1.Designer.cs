namespace AI_Clipboard_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            txtAPI = new TextBox();
            groupBox1 = new GroupBox();
            btnHelp = new Button();
            button2 = new Button();
            chkbxHide = new CheckBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(431, 16);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "ALT + 1:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "ALT + 2:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(486, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(486, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 107);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "ALT + 3:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(486, 23);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 151);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "ALT + 4:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(10, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(486, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 195);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "ALT + 5:";
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(116, 16);
            txtAPI.Name = "txtAPI";
            txtAPI.Size = new Size(252, 23);
            txtAPI.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHelp);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 272);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instructions";
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(340, 242);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 15;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 242);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chkbxHide
            // 
            chkbxHide.AutoSize = true;
            chkbxHide.Checked = true;
            chkbxHide.CheckState = CheckState.Checked;
            chkbxHide.Location = new Point(374, 20);
            chkbxHide.Name = "chkbxHide";
            chkbxHide.Size = new Size(51, 19);
            chkbxHide.TabIndex = 15;
            chkbxHide.Text = "Hide";
            chkbxHide.UseVisualStyleBackColor = true;
            chkbxHide.CheckedChanged += ChkbxHide_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(txtAPI);
            groupBox2.Controls.Add(chkbxHide);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 50);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "AI API Key";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DeepSeek" });
            comboBox1.Location = new Point(10, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 17;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 352);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(526, 22);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 374);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Clipboard hotkey";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        /*
        private void ChkbxHide_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */
        #endregion
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox txtAPI;
        private GroupBox groupBox1;
        private Button button2;
        private CheckBox chkbxHide;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox comboBox1;
        private Button btnHelp;
    }
}
