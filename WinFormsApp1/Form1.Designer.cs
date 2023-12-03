namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            tbinputScore = new TextBox();
            tbinputNAME = new TextBox();
            button1 = new Button();
            tbinputID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            tbAVER = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tbSCORE2 = new TextBox();
            tbSCORE1 = new TextBox();
            tbNameScore2 = new TextBox();
            tbNameScore1 = new TextBox();
            tbIDScore2 = new TextBox();
            tbIDScore1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gradEVG = new TextBox();
            tbGF = new TextBox();
            tbGD2 = new TextBox();
            tbGD = new TextBox();
            tbGC2 = new TextBox();
            tbGC = new TextBox();
            tbGB2 = new TextBox();
            tbGB = new TextBox();
            tbGA = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbinputScore);
            groupBox1.Controls.Add(tbinputNAME);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbinputID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 289);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 167);
            label3.Name = "label3";
            label3.Size = new Size(61, 32);
            label3.TabIndex = 6;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 113);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 5;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // tbinputScore
            // 
            tbinputScore.Location = new Point(130, 172);
            tbinputScore.Name = "tbinputScore";
            tbinputScore.Size = new Size(189, 27);
            tbinputScore.TabIndex = 4;
            // 
            // tbinputNAME
            // 
            tbinputNAME.Location = new Point(130, 116);
            tbinputNAME.Name = "tbinputNAME";
            tbinputNAME.Size = new Size(190, 27);
            tbinputNAME.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(178, 224);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSave_Click;
            // 
            // tbinputID
            // 
            tbinputID.Location = new Point(131, 54);
            tbinputID.Name = "tbinputID";
            tbinputID.Size = new Size(189, 27);
            tbinputID.TabIndex = 1;
            tbinputID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "รหัสนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbGA);
            groupBox2.Controls.Add(tbGB);
            groupBox2.Controls.Add(tbGB2);
            groupBox2.Controls.Add(tbGC);
            groupBox2.Controls.Add(tbGC2);
            groupBox2.Controls.Add(tbGD);
            groupBox2.Controls.Add(tbGD2);
            groupBox2.Controls.Add(tbGF);
            groupBox2.Controls.Add(gradEVG);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tbAVER);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbSCORE2);
            groupBox2.Controls.Add(tbSCORE1);
            groupBox2.Controls.Add(tbNameScore2);
            groupBox2.Controls.Add(tbNameScore1);
            groupBox2.Controls.Add(tbIDScore2);
            groupBox2.Controls.Add(tbIDScore1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(410, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(916, 510);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพธ์";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(633, 185);
            label10.Name = "label10";
            label10.Size = new Size(93, 32);
            label10.TabIndex = 17;
            label10.Text = "คะแนนเฉลี่ย";
            // 
            // tbAVER
            // 
            tbAVER.Location = new Point(749, 187);
            tbAVER.Name = "tbAVER";
            tbAVER.Size = new Size(125, 27);
            tbAVER.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(336, 132);
            label9.Name = "label9";
            label9.Size = new Size(97, 32);
            label9.TabIndex = 15;
            label9.Text = "คะแนนต่ำสุด";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(336, 79);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 14;
            label8.Text = "คะแนนสูงสุด";
            // 
            // tbSCORE2
            // 
            tbSCORE2.Location = new Point(749, 132);
            tbSCORE2.Name = "tbSCORE2";
            tbSCORE2.Size = new Size(125, 27);
            tbSCORE2.TabIndex = 13;
            tbSCORE2.TextChanged += tbSCORE2_TextChanged;
            // 
            // tbSCORE1
            // 
            tbSCORE1.Location = new Point(749, 79);
            tbSCORE1.Name = "tbSCORE1";
            tbSCORE1.Size = new Size(125, 27);
            tbSCORE1.TabIndex = 12;
            tbSCORE1.TextChanged += tbSCORE1_TextChanged;
            // 
            // tbNameScore2
            // 
            tbNameScore2.Location = new Point(602, 132);
            tbNameScore2.Name = "tbNameScore2";
            tbNameScore2.Size = new Size(125, 27);
            tbNameScore2.TabIndex = 11;
            tbNameScore2.TextChanged += tbNameScore2_TextChanged;
            // 
            // tbNameScore1
            // 
            tbNameScore1.Location = new Point(602, 79);
            tbNameScore1.Name = "tbNameScore1";
            tbNameScore1.Size = new Size(125, 27);
            tbNameScore1.TabIndex = 10;
            tbNameScore1.TextChanged += tbNameScore1_TextChanged;
            // 
            // tbIDScore2
            // 
            tbIDScore2.Location = new Point(458, 132);
            tbIDScore2.Name = "tbIDScore2";
            tbIDScore2.Size = new Size(125, 27);
            tbIDScore2.TabIndex = 9;
            tbIDScore2.TextChanged += tbIDScore2_TextChanged;
            // 
            // tbIDScore1
            // 
            tbIDScore1.Location = new Point(458, 79);
            tbIDScore1.Name = "tbIDScore1";
            tbIDScore1.Size = new Size(125, 27);
            tbIDScore1.TabIndex = 8;
            tbIDScore1.TextChanged += tbIDScore1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(791, 36);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 7;
            label7.Text = "คะแนน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(633, 36);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 6;
            label6.Text = "ชื่อ-นามสกุล";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 148);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 36);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 1;
            label4.Text = "รหัสนักศึกษา";
            label4.Click += label4_Click;
            // 
            // gradEVG
            // 
            gradEVG.Location = new Point(127, 456);
            gradEVG.Name = "gradEVG";
            gradEVG.Size = new Size(125, 27);
            gradEVG.TabIndex = 18;
            // 
            // tbGF
            // 
            tbGF.Location = new Point(127, 402);
            tbGF.Name = "tbGF";
            tbGF.Size = new Size(125, 27);
            tbGF.TabIndex = 19;
            // 
            // tbGD2
            // 
            tbGD2.Location = new Point(127, 354);
            tbGD2.Name = "tbGD2";
            tbGD2.Size = new Size(125, 27);
            tbGD2.TabIndex = 20;
            // 
            // tbGD
            // 
            tbGD.Location = new Point(127, 294);
            tbGD.Name = "tbGD";
            tbGD.Size = new Size(125, 27);
            tbGD.TabIndex = 21;
            // 
            // tbGC2
            // 
            tbGC2.Location = new Point(127, 242);
            tbGC2.Name = "tbGC2";
            tbGC2.Size = new Size(125, 27);
            tbGC2.TabIndex = 22;
            // 
            // tbGC
            // 
            tbGC.Location = new Point(127, 191);
            tbGC.Name = "tbGC";
            tbGC.Size = new Size(125, 27);
            tbGC.TabIndex = 23;
            // 
            // tbGB2
            // 
            tbGB2.Location = new Point(127, 144);
            tbGB2.Name = "tbGB2";
            tbGB2.Size = new Size(125, 27);
            tbGB2.TabIndex = 24;
            // 
            // tbGB
            // 
            tbGB.Location = new Point(127, 97);
            tbGB.Name = "tbGB";
            tbGB.Size = new Size(125, 27);
            tbGB.TabIndex = 25;
            // 
            // tbGA
            // 
            tbGA.Location = new Point(127, 54);
            tbGA.Name = "tbGA";
            tbGA.Size = new Size(125, 27);
            tbGA.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(45, 456);
            label11.Name = "label11";
            label11.Size = new Size(76, 32);
            label11.TabIndex = 27;
            label11.Text = "เกรดเฉลี่ย";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(74, 399);
            label12.Name = "label12";
            label12.Size = new Size(23, 32);
            label12.TabIndex = 28;
            label12.Text = "F";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(74, 351);
            label13.Name = "label13";
            label13.Size = new Size(25, 32);
            label13.TabIndex = 29;
            label13.Text = "D";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(74, 294);
            label14.Name = "label14";
            label14.Size = new Size(34, 32);
            label14.TabIndex = 30;
            label14.Text = "D+";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(74, 243);
            label15.Name = "label15";
            label15.Size = new Size(25, 32);
            label15.TabIndex = 31;
            label15.Text = "C";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(74, 191);
            label16.Name = "label16";
            label16.Size = new Size(34, 32);
            label16.TabIndex = 32;
            label16.Text = "C+";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(75, 141);
            label17.Name = "label17";
            label17.Size = new Size(24, 32);
            label17.TabIndex = 33;
            label17.Text = "B";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(75, 97);
            label18.Name = "label18";
            label18.Size = new Size(33, 32);
            label18.TabIndex = 34;
            label18.Text = "B+";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(75, 49);
            label19.Name = "label19";
            label19.Size = new Size(25, 32);
            label19.TabIndex = 35;
            label19.Text = "A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 534);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox tbinputID;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox tbinputScore;
        private TextBox tbinputNAME;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbSCORE2;
        private TextBox tbSCORE1;
        private TextBox tbNameScore2;
        private TextBox tbNameScore1;
        private TextBox tbIDScore2;
        private TextBox tbIDScore1;
        private TextBox tbAVER;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox tbGA;
        private TextBox tbGB;
        private TextBox tbGB2;
        private TextBox tbGC;
        private TextBox tbGC2;
        private TextBox tbGD;
        private TextBox tbGD2;
        private TextBox tbGF;
        private TextBox gradEVG;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}
