namespace dz6
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelTime = new Label();
            label4 = new Label();
            label3 = new Label();
            trackBarTimeActivities = new TrackBar();
            label2 = new Label();
            trackBarVer = new TrackBar();
            label1 = new Label();
            trackBarHor = new TrackBar();
            groupBox1 = new GroupBox();
            radioButtonChaos = new RadioButton();
            radioButtonDiagonal = new RadioButton();
            radioButtonHorizontal = new RadioButton();
            radioButtonVertical = new RadioButton();
            buttonStart = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBoxBox = new PictureBox();
            pictureBox1 = new PictureBox();
            timerNow = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarTimeActivities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarHor).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(trackBarTimeActivities);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBarVer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBarHor);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonStart);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 443);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 160);
            panel1.TabIndex = 0;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(632, 103);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(36, 15);
            labelTime.TabIndex = 9;
            labelTime.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 80);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 7);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Time of changes";
            // 
            // trackBarTimeActivities
            // 
            trackBarTimeActivities.Location = new Point(608, 29);
            trackBarTimeActivities.Maximum = 41;
            trackBarTimeActivities.Minimum = 1;
            trackBarTimeActivities.Name = "trackBarTimeActivities";
            trackBarTimeActivities.Size = new Size(164, 45);
            trackBarTimeActivities.TabIndex = 6;
            trackBarTimeActivities.Value = 30;
            trackBarTimeActivities.Scroll += trackBarTimeActivities_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 77);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 5;
            label2.Text = "Vertical maximum velocity";
            // 
            // trackBarVer
            // 
            trackBarVer.Location = new Point(413, 103);
            trackBarVer.Maximum = 15;
            trackBarVer.Minimum = 1;
            trackBarVer.Name = "trackBarVer";
            trackBarVer.Size = new Size(164, 45);
            trackBarVer.TabIndex = 4;
            trackBarVer.Value = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 7);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 3;
            label1.Text = "Horizontal maximum velocity";
            // 
            // trackBarHor
            // 
            trackBarHor.Location = new Point(413, 29);
            trackBarHor.Maximum = 15;
            trackBarHor.Minimum = 1;
            trackBarHor.Name = "trackBarHor";
            trackBarHor.Size = new Size(164, 45);
            trackBarHor.TabIndex = 2;
            trackBarHor.Value = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonChaos);
            groupBox1.Controls.Add(radioButtonDiagonal);
            groupBox1.Controls.Add(radioButtonHorizontal);
            groupBox1.Controls.Add(radioButtonVertical);
            groupBox1.Location = new Point(155, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Motion modes";
            // 
            // radioButtonChaos
            // 
            radioButtonChaos.AutoSize = true;
            radioButtonChaos.Location = new Point(123, 47);
            radioButtonChaos.Name = "radioButtonChaos";
            radioButtonChaos.Size = new Size(58, 19);
            radioButtonChaos.TabIndex = 3;
            radioButtonChaos.TabStop = true;
            radioButtonChaos.Text = "Chaos";
            radioButtonChaos.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagonal
            // 
            radioButtonDiagonal.AutoSize = true;
            radioButtonDiagonal.Location = new Point(6, 47);
            radioButtonDiagonal.Name = "radioButtonDiagonal";
            radioButtonDiagonal.Size = new Size(72, 19);
            radioButtonDiagonal.TabIndex = 2;
            radioButtonDiagonal.TabStop = true;
            radioButtonDiagonal.Text = "Diagonal";
            radioButtonDiagonal.UseVisualStyleBackColor = true;
            // 
            // radioButtonHorizontal
            // 
            radioButtonHorizontal.AutoSize = true;
            radioButtonHorizontal.Location = new Point(123, 22);
            radioButtonHorizontal.Name = "radioButtonHorizontal";
            radioButtonHorizontal.Size = new Size(80, 19);
            radioButtonHorizontal.TabIndex = 1;
            radioButtonHorizontal.TabStop = true;
            radioButtonHorizontal.Text = "Horizontal";
            radioButtonHorizontal.UseVisualStyleBackColor = true;
            // 
            // radioButtonVertical
            // 
            radioButtonVertical.AutoSize = true;
            radioButtonVertical.Location = new Point(6, 22);
            radioButtonVertical.Name = "radioButtonVertical";
            radioButtonVertical.Size = new Size(63, 19);
            radioButtonVertical.TabIndex = 0;
            radioButtonVertical.TabStop = true;
            radioButtonVertical.Text = "Vertical";
            radioButtonVertical.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(22, 29);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBoxBox);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 443);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 9);
            label6.Name = "label6";
            label6.Size = new Size(164, 15);
            label6.TabIndex = 11;
            label6.Text = "Horizontal maximum velocity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 46);
            label5.Name = "label5";
            label5.Size = new Size(164, 15);
            label5.TabIndex = 10;
            label5.Text = "Horizontal maximum velocity";
            // 
            // pictureBoxBox
            // 
            pictureBoxBox.Image = (Image)resources.GetObject("pictureBoxBox.Image");
            pictureBoxBox.Location = new Point(360, 132);
            pictureBoxBox.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBox.Name = "pictureBoxBox";
            pictureBoxBox.Size = new Size(189, 157);
            pictureBoxBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBox.TabIndex = 1;
            pictureBoxBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timerNow
            // 
            timerNow.Tick += timerNow_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarTimeActivities).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarHor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonStart;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton radioButtonHorizontal;
        private RadioButton radioButtonVertical;
        private PictureBox pictureBox1;
        private RadioButton radioButtonDiagonal;
        private RadioButton radioButtonChaos;
        private TrackBar trackBarHor;
        private Label label1;
        private Label label2;
        private TrackBar trackBarVer;
        private TrackBar trackBarTimeActivities;
        private Label label3;
        private Label labelTime;
        private Label label4;
        private PictureBox pictureBoxBox;
        private System.Windows.Forms.Timer timerNow;
        private Label label5;
        private Label label6;
    }
}
