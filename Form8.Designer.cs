namespace WinForm4
{
    partial class Form8
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripCopy = new ToolStripMenuItem();
            toolStripPaste = new ToolStripMenuItem();
            toolStripCut = new ToolStripMenuItem();
            lbResult = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripCopy, toolStripPaste, toolStripCut });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(165, 70);
            // 
            // toolStripCopy
            // 
            toolStripCopy.Name = "toolStripCopy";
            toolStripCopy.ShortcutKeys = Keys.Control | Keys.C;
            toolStripCopy.Size = new Size(164, 22);
            toolStripCopy.Text = "복사";
            toolStripCopy.Click += toolStripCopy_Click;
            // 
            // toolStripPaste
            // 
            toolStripPaste.Name = "toolStripPaste";
            toolStripPaste.ShortcutKeys = Keys.Control | Keys.V;
            toolStripPaste.Size = new Size(164, 22);
            toolStripPaste.Text = "붙여넣기";
            toolStripPaste.Click += toolStripPaste_Click;
            // 
            // toolStripCut
            // 
            toolStripCut.Name = "toolStripCut";
            toolStripCut.ShortcutKeys = Keys.Control | Keys.X;
            toolStripCut.Size = new Size(164, 22);
            toolStripCut.Text = "잘라내기";
            toolStripCut.Click += toolStripCut_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("배스킨라빈스 B", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(247, 198);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(128, 16);
            lbResult.TabIndex = 1;
            lbResult.Text = "결과를 출력합니다.";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lbResult);
            Name = "Form8";
            Text = "Form8";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripCopy;
        private ToolStripMenuItem toolStripPaste;
        private ToolStripMenuItem toolStripCut;
        private Label lbResult;
    }
}