namespace WinForm3
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            btnStart = new Button();
            btnInit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(77, 46);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(340, 23);
            progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(333, 88);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(58, 27);
            btnStart.TabIndex = 2;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnInit
            // 
            btnInit.Location = new Point(333, 121);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(58, 27);
            btnInit.TabIndex = 2;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 192);
            Controls.Add(btnInit);
            Controls.Add(btnStart);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button btnStart;
        private Button btnInit;
        private System.Windows.Forms.Timer timer1;
    }
}