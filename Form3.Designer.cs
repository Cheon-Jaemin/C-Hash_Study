namespace WinForm4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnPlay = new Button();
            btnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(27, 68);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(355, 285);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("배스킨라빈스 B", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(415, 70);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(227, 62);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "재생";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("배스킨라빈스 B", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(415, 152);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(227, 62);
            btnStop.TabIndex = 1;
            btnStop.Text = "정지";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnPlay;
        private Button btnStop;
    }
}