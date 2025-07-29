namespace WinForm4
{
    partial class Form7
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
            menuStrip1 = new MenuStrip();
            toolStripFile = new ToolStripMenuItem();
            toolStripNew = new ToolStripMenuItem();
            toolStripOpen = new ToolStripMenuItem();
            toolStripSave = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripExit = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuCal = new ToolStripMenuItem();
            toolStripMenuPi = new ToolStripMenuItem();
            lbResult = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripFile, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(638, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            toolStripFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripNew, toolStripOpen, toolStripSave, toolStripSeparator1, toolStripExit });
            toolStripFile.Name = "toolStripFile";
            toolStripFile.Size = new Size(43, 20);
            toolStripFile.Text = "파일";
            // 
            // toolStripNew
            // 
            toolStripNew.Name = "toolStripNew";
            toolStripNew.ShortcutKeys = Keys.Control | Keys.N;
            toolStripNew.Size = new Size(180, 22);
            toolStripNew.Text = "새로만들기";
            toolStripNew.Click += toolStripNew_Click;
            // 
            // toolStripOpen
            // 
            toolStripOpen.Name = "toolStripOpen";
            toolStripOpen.ShortcutKeys = Keys.Control | Keys.O;
            toolStripOpen.Size = new Size(180, 22);
            toolStripOpen.Text = "열기";
            toolStripOpen.Click += toolStripOpen_Click;
            // 
            // toolStripSave
            // 
            toolStripSave.Name = "toolStripSave";
            toolStripSave.ShortcutKeys = Keys.Control | Keys.S;
            toolStripSave.Size = new Size(180, 22);
            toolStripSave.Text = "저장";
            toolStripSave.Click += toolStripSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripExit
            // 
            toolStripExit.Name = "toolStripExit";
            toolStripExit.ShortcutKeys = Keys.Alt | Keys.F4;
            toolStripExit.Size = new Size(180, 22);
            toolStripExit.Text = "종료";
            toolStripExit.Click += toolStripExit_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuCal, toolStripMenuPi });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(67, 20);
            toolStripMenuItem1.Text = "프로그램";
            // 
            // toolStripMenuCal
            // 
            toolStripMenuCal.Name = "toolStripMenuCal";
            toolStripMenuCal.Size = new Size(110, 22);
            toolStripMenuCal.Text = "계산기";
            toolStripMenuCal.Click += toolStripMenuCal_Click;
            // 
            // toolStripMenuPi
            // 
            toolStripMenuPi.Name = "toolStripMenuPi";
            toolStripMenuPi.Size = new Size(110, 22);
            toolStripMenuPi.Text = "그림판";
            toolStripMenuPi.Click += toolStripMenuPi_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("배스킨라빈스 B", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(247, 459);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(133, 16);
            lbResult.TabIndex = 1;
            lbResult.Text = "결과를 출력합니다. ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(638, 421);
            textBox1.TabIndex = 2;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 486);
            Controls.Add(lbResult);
            Controls.Add(menuStrip1);
            Controls.Add(textBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form7";
            Text = "Form7";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripFile;
        private ToolStripMenuItem toolStripNew;
        private ToolStripMenuItem toolStripOpen;
        private ToolStripMenuItem toolStripSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripExit;
        private Label lbResult;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuCal;
        private ToolStripMenuItem toolStripMenuPi;
        private TextBox textBox1;
    }
}